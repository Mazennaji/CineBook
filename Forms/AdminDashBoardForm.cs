using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CineBook.Helpers;

namespace CineBook.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
            LoadMoviesIntoShowtimeCombo();
            LoadShowtimes();
        }

        // ---------------- MOVIES ----------------

        private void LoadMovies()
        {
            string query = "SELECT MovieID, Title, Genre, DurationMinutes, Rating, Description FROM Movies ORDER BY Title";
            dgvMovies.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0) return;

            var row = dgvMovies.SelectedRows[0];
            txtMovieTitle.Text = row.Cells["Title"].Value.ToString();
            txtGenre.Text = row.Cells["Genre"].Value?.ToString();
            txtDuration.Text = row.Cells["DurationMinutes"].Value.ToString();
            txtRating.Text = row.Cells["Rating"].Value?.ToString();
            txtDescription.Text = row.Cells["Description"].Value?.ToString();
        }

        private void ClearMovieForm()
        {
            txtMovieTitle.Clear();
            txtGenre.Clear();
            txtDuration.Clear();
            txtRating.Clear();
            txtDescription.Clear();
            dgvMovies.ClearSelection();
        }

        private bool ValidateMovieForm()
        {
            if (string.IsNullOrWhiteSpace(txtMovieTitle.Text) || string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                MessageBox.Show("Title and Duration are required.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtDuration.Text.Trim(), out _))
            {
                MessageBox.Show("Duration must be a number (minutes).", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (!ValidateMovieForm()) return;

            DatabaseHelper.ExecuteNonQuery(
                @"INSERT INTO Movies (Title, Genre, DurationMinutes, Rating, Description)
                  VALUES (@Title, @Genre, @Duration, @Rating, @Description)",
                new SqlParameter("@Title", txtMovieTitle.Text.Trim()),
                new SqlParameter("@Genre", txtGenre.Text.Trim()),
                new SqlParameter("@Duration", int.Parse(txtDuration.Text.Trim())),
                new SqlParameter("@Rating", txtRating.Text.Trim()),
                new SqlParameter("@Description", txtDescription.Text.Trim()));

            MessageBox.Show("Movie added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMovies();
            LoadMoviesIntoShowtimeCombo();
            ClearMovieForm();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a movie to update.", "Missing Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateMovieForm()) return;

            int movieId = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["MovieID"].Value);

            DatabaseHelper.ExecuteNonQuery(
                @"UPDATE Movies SET Title = @Title, Genre = @Genre, DurationMinutes = @Duration,
                  Rating = @Rating, Description = @Description WHERE MovieID = @MovieID",
                new SqlParameter("@Title", txtMovieTitle.Text.Trim()),
                new SqlParameter("@Genre", txtGenre.Text.Trim()),
                new SqlParameter("@Duration", int.Parse(txtDuration.Text.Trim())),
                new SqlParameter("@Rating", txtRating.Text.Trim()),
                new SqlParameter("@Description", txtDescription.Text.Trim()),
                new SqlParameter("@MovieID", movieId));

            MessageBox.Show("Movie updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMovies();
            LoadMoviesIntoShowtimeCombo();
            ClearMovieForm();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a movie to delete.", "Missing Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int movieId = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["MovieID"].Value);
            string title = dgvMovies.SelectedRows[0].Cells["Title"].Value.ToString();

            var confirm = MessageBox.Show(
                $"Delete '{title}'? This will also remove its showtimes, seats, and bookings.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteNonQuery("DELETE FROM Movies WHERE MovieID = @ID",
                    new SqlParameter("@ID", movieId));

                LoadMovies();
                LoadMoviesIntoShowtimeCombo();
                LoadShowtimes();
                ClearMovieForm();
            }
        }

        private void btnClearMovie_Click(object sender, EventArgs e)
        {
            ClearMovieForm();
        }

        // ---------------- SHOWTIMES ----------------

        private void LoadMoviesIntoShowtimeCombo()
        {
            DataTable movies = DatabaseHelper.ExecuteQuery("SELECT MovieID, Title FROM Movies ORDER BY Title");
            cmbShowtimeMovie.DataSource = movies;
            cmbShowtimeMovie.DisplayMember = "Title";
            cmbShowtimeMovie.ValueMember = "MovieID";
        }

        private void LoadShowtimes()
        {
            string query = @"
                SELECT s.ShowtimeID, m.Title AS MovieTitle, s.ShowDate, s.ShowTime, s.Hall, s.TotalSeats, s.TicketPrice
                FROM Showtimes s
                JOIN Movies m ON s.MovieID = m.MovieID
                ORDER BY s.ShowDate, s.ShowTime";

            dgvShowtimes.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnAddShowtime_Click(object sender, EventArgs e)
        {
            if (cmbShowtimeMovie.SelectedValue == null)
            {
                MessageBox.Show("Select a movie first.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHall.Text) ||
                !int.TryParse(txtTotalSeats.Text.Trim(), out int totalSeats) ||
                !decimal.TryParse(txtTicketPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Please fill Hall, Total Seats (number), and Price (number) correctly.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper.ExecuteNonQuery(
                    @"INSERT INTO Showtimes (MovieID, ShowDate, ShowTime, Hall, TotalSeats, TicketPrice)
                      VALUES (@MovieID, @ShowDate, @ShowTime, @Hall, @TotalSeats, @Price)",
                    new SqlParameter("@MovieID", cmbShowtimeMovie.SelectedValue),
                    new SqlParameter("@ShowDate", dtpShowDate.Value.Date),
                    new SqlParameter("@ShowTime", dtpShowTime.Value.TimeOfDay),
                    new SqlParameter("@Hall", txtHall.Text.Trim()),
                    new SqlParameter("@TotalSeats", totalSeats),
                    new SqlParameter("@Price", price));

                MessageBox.Show("Showtime added (seats auto-generated).", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadShowtimes();
                txtHall.Clear();
                txtTotalSeats.Clear();
                txtTicketPrice.Clear();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("That showtime already exists for this movie/date/time/hall.", "Duplicate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add showtime: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteShowtime_Click(object sender, EventArgs e)
        {
            if (dgvShowtimes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a showtime to delete.", "Missing Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int showtimeId = Convert.ToInt32(dgvShowtimes.SelectedRows[0].Cells["ShowtimeID"].Value);

            var confirm = MessageBox.Show(
                "Delete this showtime? This will also remove its seats and bookings.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteNonQuery("DELETE FROM Showtimes WHERE ShowtimeID = @ID",
                    new SqlParameter("@ID", showtimeId));

                LoadShowtimes();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}