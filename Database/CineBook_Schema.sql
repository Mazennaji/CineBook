-- =========================================================
-- CineBook Database Schema
-- Movie Ticket Booking System
-- CSCI370 Visual Programming Project
-- =========================================================

CREATE DATABASE CineBook;
GO

USE CineBook;
GO

-- =========================================================
-- TABLE: Users
-- Single table for both regular users and admins (Role flag)
-- =========================================================
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Phone NVARCHAR(20),
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL DEFAULT 'User', -- 'User' or 'Admin'
    CreatedAt DATETIME DEFAULT GETDATE(),
    CONSTRAINT CHK_Role CHECK (Role IN ('User', 'Admin'))
);
GO

-- =========================================================
-- TABLE: Movies
-- =========================================================
CREATE TABLE Movies (
    MovieID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(150) NOT NULL,
    Genre NVARCHAR(50),
    DurationMinutes INT NOT NULL,
    Rating NVARCHAR(10), -- e.g. PG-13, R
    Description NVARCHAR(500),
    PosterPath NVARCHAR(255), -- local file path or URL to poster image
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- =========================================================
-- TABLE: Showtimes
-- =========================================================
CREATE TABLE Showtimes (
    ShowtimeID INT IDENTITY(1,1) PRIMARY KEY,
    MovieID INT NOT NULL,
    ShowDate DATE NOT NULL,
    ShowTime TIME NOT NULL,
    Hall NVARCHAR(50) NOT NULL,
    TotalSeats INT NOT NULL DEFAULT 50,
    TicketPrice DECIMAL(10,2) NOT NULL DEFAULT 10.00,
    CONSTRAINT FK_Showtimes_Movie FOREIGN KEY (MovieID)
        REFERENCES Movies(MovieID) ON DELETE CASCADE,
    CONSTRAINT UQ_Showtime UNIQUE (MovieID, ShowDate, ShowTime, Hall)
);
GO

-- =========================================================
-- TABLE: Seats
-- One row per seat per showtime — tracks exact seat occupancy
-- =========================================================
CREATE TABLE Seats (
    SeatID INT IDENTITY(1,1) PRIMARY KEY,
    ShowtimeID INT NOT NULL,
    SeatNumber NVARCHAR(10) NOT NULL, -- e.g. 'A1', 'B5'
    IsBooked BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Seats_Showtime FOREIGN KEY (ShowtimeID)
        REFERENCES Showtimes(ShowtimeID) ON DELETE CASCADE,
    CONSTRAINT UQ_Seat_Per_Showtime UNIQUE (ShowtimeID, SeatNumber)
);
GO

-- =========================================================
-- TABLE: Bookings
-- =========================================================
CREATE TABLE Bookings (
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    ShowtimeID INT NOT NULL,
    SeatID INT NOT NULL,
    BookingDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) NOT NULL DEFAULT 'Confirmed', -- Confirmed / Cancelled
    TotalPrice DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_Bookings_User FOREIGN KEY (UserID)
        REFERENCES Users(UserID) ON DELETE CASCADE,
    CONSTRAINT FK_Bookings_Showtime FOREIGN KEY (ShowtimeID)
        REFERENCES Showtimes(ShowtimeID) ON DELETE CASCADE,
    CONSTRAINT FK_Bookings_Seat FOREIGN KEY (SeatID)
        REFERENCES Seats(SeatID),
    CONSTRAINT CHK_BookingStatus CHECK (Status IN ('Confirmed', 'Cancelled'))
);
GO

-- =========================================================
-- TRIGGER: Auto-generate seats when a showtime is created
-- Generates seats A1..E10 (50 seats) by default, or scales to TotalSeats
-- =========================================================
CREATE TRIGGER trg_GenerateSeats
ON Showtimes
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ShowtimeID INT, @TotalSeats INT;
    SELECT @ShowtimeID = ShowtimeID, @TotalSeats = TotalSeats FROM inserted;

    DECLARE @Rows INT = CEILING(@TotalSeats / 10.0);
    DECLARE @r INT = 0;

    WHILE @r < @Rows
    BEGIN
        DECLARE @RowLetter CHAR(1) = CHAR(65 + @r);
        DECLARE @c INT = 1;
        WHILE @c <= 10 AND ((@r * 10) + @c) <= @TotalSeats
        BEGIN
            INSERT INTO Seats (ShowtimeID, SeatNumber, IsBooked)
            VALUES (@ShowtimeID, @RowLetter + CAST(@c AS NVARCHAR(2)), 0);
            SET @c += 1;
        END
        SET @r += 1;
    END
END;
GO

-- =========================================================
-- SEED DATA
-- =========================================================

INSERT INTO Users (FullName, Email, Phone, Password, Role) VALUES
('System Admin', 'admin@cinebook.com', NULL, 'admin123', 'Admin'),
('Mazen Naji', 'mazen@cinebook.com', '76112233', 'user123', 'User'),
('Sara Younes', 'sara@cinebook.com', '71223344', 'user123', 'User');
GO

INSERT INTO Movies (Title, Genre, DurationMinutes, Rating, Description, PosterPath) VALUES
('Quantum Horizon', 'Sci-Fi', 132, 'PG-13', 'A team of astronauts discovers a rift in spacetime that threatens Earth.', NULL),
('The Last Sunset', 'Drama', 118, 'PG-13', 'A family confronts old wounds during one final summer together.', NULL),
('Midnight Heist', 'Action', 109, 'R', 'A crew of thieves plans the impossible: robbing a bank during a blackout.', NULL);
GO

-- Showtimes (inserting these fires the trigger and auto-creates seats)
INSERT INTO Showtimes (MovieID, ShowDate, ShowTime, Hall, TotalSeats, TicketPrice) VALUES
(1, '2026-07-01', '18:00', 'Hall 1', 30, 12.00),
(1, '2026-07-01', '21:00', 'Hall 1', 30, 12.00),
(2, '2026-07-02', '19:30', 'Hall 2', 40, 10.00),
(3, '2026-07-03', '20:00', 'Hall 3', 20, 14.00);
GO

-- =========================================================
-- USEFUL VIEW: Full booking details (joins Users/Showtimes/Movies/Seats)
-- =========================================================
CREATE VIEW vw_BookingDetails AS
SELECT
    b.BookingID,
    u.FullName AS UserName,
    m.Title AS MovieTitle,
    s.ShowDate,
    s.ShowTime,
    s.Hall,
    se.SeatNumber,
    b.TotalPrice,
    b.Status,
    b.BookingDate
FROM Bookings b
JOIN Users u ON b.UserID = u.UserID
JOIN Showtimes s ON b.ShowtimeID = s.ShowtimeID
JOIN Movies m ON s.MovieID = m.MovieID
JOIN Seats se ON b.SeatID = se.SeatID;
GO