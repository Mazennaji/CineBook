using System;

namespace CineBook.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int DurationMinutes { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public string PosterPath { get; set; }
    }

    public class Showtime
    {
        public int ShowtimeID { get; set; }
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public DateTime ShowDate { get; set; }
        public TimeSpan ShowTime { get; set; }
        public string Hall { get; set; }
        public int TotalSeats { get; set; }
        public decimal TicketPrice { get; set; }
    }

    public class Seat
    {
        public int SeatID { get; set; }
        public int ShowtimeID { get; set; }
        public string SeatNumber { get; set; }
        public bool IsBooked { get; set; }
    }

    public class Booking
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int ShowtimeID { get; set; }
        public int SeatID { get; set; }
        public string MovieTitle { get; set; }
        public DateTime ShowDate { get; set; }
        public TimeSpan ShowTime { get; set; }
        public string Hall { get; set; }
        public string SeatNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public DateTime BookingDate { get; set; }
    }
}