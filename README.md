<div align="center">

<img src="https://api.iconify.design/mdi/movie-open-star.svg?color=%23E94560" width="72" height="72" alt="CineBook logo" />

# CineBook

**A premium movie ticket booking experience, built end-to-end in C# and SQL Server.**

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![SQL Server](https://img.shields.io/badge/SQL_Server-Database-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/en-us/sql-server)
[![License](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)](#license)

[![Stars](https://img.shields.io/github/stars/Mazennaji/CineBook?style=for-the-badge&color=E94560)](https://github.com/Mazennaji/CineBook/stargazers)
[![Issues](https://img.shields.io/github/issues/Mazennaji/CineBook?style=for-the-badge&color=E94560)](https://github.com/Mazennaji/CineBook/issues)
[![Last Commit](https://img.shields.io/github/last-commit/Mazennaji/CineBook?style=for-the-badge&color=E94560)](https://github.com/Mazennaji/CineBook/commits/main)

</div>

<br/>

<div align="center">
  <img src="https://api.iconify.design/mdi/ticket-confirmation-outline.svg?color=%23E94560" width="40" />
  &nbsp;&nbsp;&nbsp;
  <img src="https://api.iconify.design/mdi/seat-outline.svg?color=%23E94560" width="40" />
  &nbsp;&nbsp;&nbsp;
  <img src="https://api.iconify.design/mdi/filmstrip.svg?color=%23E94560" width="40" />
  &nbsp;&nbsp;&nbsp;
  <img src="https://api.iconify.design/mdi/shield-account-outline.svg?color=%23E94560" width="40" />
</div>

<br/>

## ✨ Overview

**CineBook** is a desktop movie ticket booking system built as a Visual Programming (CSCI370) project. It goes beyond CRUD basics with a genuinely interactive seat map, role-based dashboards, and database-level integrity guarantees — no two users can ever book the same seat.

| | |
|---|---|
| 🎬 **Browse** | Filter movies by genre, see live seat availability per showtime |
| 🪑 **Book** | Click-to-select visual seat map — not a dropdown |
| ❌ **Cancel** | Instant seat release back into the pool |
| 🛠️ **Admin** | Full control over the movie catalog and showtime schedule |

<br/>

## 🖥️ Tech Stack

<div align="center">

| Layer | Technology |
|:---:|:---:|
| **UI** | <img src="https://api.iconify.design/simple-icons/csharp.svg?color=%23239120" width="18" valign="middle"/> C# WinForms |
| **Runtime** | <img src="https://api.iconify.design/simple-icons/dotnet.svg?color=%23512BD4" width="18" valign="middle"/> .NET 8 |
| **Database** | <img src="https://api.iconify.design/simple-icons/microsoftsqlserver.svg?color=%23CC2927" width="18" valign="middle"/> SQL Server (ADO.NET) |
| **IDE** | <img src="https://api.iconify.design/simple-icons/visualstudio.svg?color=%235C2D91" width="18" valign="middle"/> Visual Studio |

</div>

<br/>

## 🏗️ Architecture

```
CineBook/
├── Database/
│   └── CineBook_Schema.sql       → tables, trigger, seed data, view
├── Forms/
│   ├── LoginForm                 → authentication entry point
│   ├── RegisterForm              → self-service signup
│   ├── BrowseMoviesForm          → catalog + showtime browser
│   ├── SeatBookingForm           → interactive seat map
│   ├── MyBookingsForm            → booking history + cancellation
│   └── AdminDashboardForm        → movie & showtime management
├── Helpers/
│   └── DatabaseHelper.cs         → parameterized ADO.NET access layer
├── Models/
│   └── Models.cs                 → User, Movie, Showtime, Seat, Booking
└── Program.cs
```

**Database schema** — 5 tables, 1 trigger, 1 view:

```mermaid
erDiagram
    USERS ||--o{ BOOKINGS : places
    MOVIES ||--o{ SHOWTIMES : has
    SHOWTIMES ||--o{ SEATS : contains
    SHOWTIMES ||--o{ BOOKINGS : scheduled_for
    SEATS ||--o| BOOKINGS : reserved_by

    USERS {
        int UserID PK
        string FullName
        string Email
        string Role
    }
    MOVIES {
        int MovieID PK
        string Title
        string Genre
        int DurationMinutes
        string Rating
    }
    SHOWTIMES {
        int ShowtimeID PK
        int MovieID FK
        date ShowDate
        time ShowTime
        string Hall
        decimal TicketPrice
    }
    SEATS {
        int SeatID PK
        int ShowtimeID FK
        string SeatNumber
        bool IsBooked
    }
    BOOKINGS {
        int BookingID PK
        int UserID FK
        int ShowtimeID FK
        int SeatID FK
        string Status
        decimal TotalPrice
    }
```

<br/>

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2022+ with the **.NET desktop development** workload
- SQL Server (Express edition is fine) + SQL Server Management Studio

### 1 — Set up the database
Open `Database/CineBook_Schema.sql` in SSMS and run it. This creates the `CineBook` database, all tables, the seat-generation trigger, and seed data.

### 2 — Point the app at your SQL Server instance
In `Helpers/DatabaseHelper.cs`, confirm the connection string matches your instance name:
```csharp
Data Source=.\SQLEXPRESS;Initial Catalog=CineBook;Integrated Security=True;
```

### 3 — Run it
Open `CineBook.csproj` in Visual Studio, let NuGet restore `System.Data.SqlClient`, then hit **F5**.

<br/>

## 🔑 Demo Accounts

| Role | Email | Password |
|:---:|:---|:---:|
| 🛡️ Admin | `admin@cinebook.com` | `admin123` |
| 🎟️ User | `mazen@cinebook.com` | `user123` |
| 🎟️ User | `sara@cinebook.com` | `user123` |

<br/>

## 🎯 How Seat Locking Works

Each showtime gets its **own seat map** generated automatically by a SQL trigger the moment an admin creates it — no manual seat entry, ever.

```
Admin adds Showtime  →  trg_GenerateSeats fires  →  Seats A1...E10 created
User books Seat A4   →  IsBooked = 1 + Booking row inserted
User cancels         →  IsBooked = 0 → seat returns to the pool instantly
```

A `UNIQUE (ShowtimeID, SeatNumber)` constraint makes double-booking structurally impossible — not just a UI rule, enforced by the database itself.

<br/>

## 🗺️ Roadmap

- [ ] Poster images on the Browse Movies screen (`PosterPath` column already exists)
- [ ] Password hashing via `BCrypt.Net`
- [ ] Admin analytics view (top-grossing movies, busiest showtimes)

<br/>

## 📄 License

This project was built for academic purposes (CSCI370 — Visual Programming). Feel free to fork and build on it.

<br/>

<div align="center">

Built with <img src="https://api.iconify.design/mdi/heart.svg?color=%23E94560" width="14" valign="middle"/> by **Mazen Naji**

<img src="https://api.iconify.design/simple-icons/github.svg?color=%23FFFFFF" width="16" valign="middle"/> [github.com/Mazennaji](https://github.com/Mazennaji)

</div>
