using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CineBook.Helpers;

namespace CineBook.Forms
{
    public partial class BrowseMoviesForm : Form
    {
        private readonly int _userId;
        private readonly string _userName;

        public BrowseMoviesForm(int userId, string userName)
        {
            InitializeComponent();
            _userId = userId;
            _userName = userName;
            lblWelcome.Text = $"Welcome, {_userName}";
        }

        private void BrowseMoviesForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            string query = @"
                SELECT MovieID, Title, Genre, DurationMinutes, Rating, Description
                FROM Movies
                ORDER BY Title";

            dgvMovies.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void LoadShowtimes(int movieId)
        {
            string query = @"
                SELECT s.ShowtimeID, s.ShowDate, s.ShowTime, s.Hall, s.TicketPrice,
                       s.TotalSeats - (SELECT COUNT(*) FROM Seats se WHERE se.ShowtimeID = s.ShowtimeID AND se.IsBooked = 1) AS SeatsAvailable
                FROM Showtimes s
                WHERE s.MovieID = @MovieID AND s.ShowDate >= CAST(GETDATE() AS DATE)
                ORDER BY s.ShowDate, s.ShowTime";

            DataTable showtimes = DatabaseHelper.ExecuteQuery(query,
                new SqlParameter("@MovieID", movieId));

            dgvShowtimes.DataSource = showtimes;
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count > 0)
            {
                int movieId = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["MovieID"].Value);
                LoadShowtimes(movieId);
                txtDescription.Text = dgvMovies.SelectedRows[0].Cells["Description"].Value?.ToString();
            }
        }

        private void btnSelectShowtime_Click(object sender, EventArgs e)
        {
            if (dgvShowtimes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a showtime first.", "Missing Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int showtimeId = Convert.ToInt32(dgvShowtimes.SelectedRows[0].Cells["ShowtimeID"].Value);
            string movieTitle = dgvMovies.SelectedRows[0].Cells["Title"].Value.ToString();
            decimal price = Convert.ToDecimal(dgvShowtimes.SelectedRows[0].Cells["TicketPrice"].Value);

            SeatBookingForm seatForm = new SeatBookingForm(_userId, _userName, showtimeId, movieTitle, price);
            seatForm.Show();
            this.Hide();
        }

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            MyBookingsForm bookings = new MyBookingsForm(_userId, _userName);
            bookings.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}