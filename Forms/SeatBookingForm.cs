using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CineBook.Helpers;

namespace CineBook.Forms
{
    public partial class SeatBookingForm : Form
    {
        private readonly int _userId;
        private readonly string _userName;
        private readonly int _showtimeId;
        private readonly string _movieTitle;
        private readonly decimal _ticketPrice;
        private int? _selectedSeatId = null;
        private string _selectedSeatNumber = null;

        public SeatBookingForm(int userId, string userName, int showtimeId, string movieTitle, decimal ticketPrice)
        {
            InitializeComponent();
            _userId = userId;
            _userName = userName;
            _showtimeId = showtimeId;
            _movieTitle = movieTitle;
            _ticketPrice = ticketPrice;

            lblTitle.Text = $"{_movieTitle}";
            lblPrice.Text = $"Ticket Price: ${_ticketPrice:0.00}";
        }

        private void SeatBookingForm_Load(object sender, EventArgs e)
        {
            BuildSeatMap();
        }

        private void BuildSeatMap()
        {
            pnlSeats.Controls.Clear();

            string query = @"
                SELECT SeatID, SeatNumber, IsBooked
                FROM Seats
                WHERE ShowtimeID = @ShowtimeID
                ORDER BY SeatNumber";

            DataTable seats = DatabaseHelper.ExecuteQuery(query,
                new SqlParameter("@ShowtimeID", _showtimeId));

            int col = 0, row = 0;
            int seatsPerRow = 10;
            int btnSize = 45;
            int spacing = 8;

            foreach (DataRow seatRow in seats.Rows)
            {
                int seatId = Convert.ToInt32(seatRow["SeatID"]);
                string seatNumber = seatRow["SeatNumber"].ToString();
                bool isBooked = Convert.ToBoolean(seatRow["IsBooked"]);

                Button seatBtn = new Button
                {
                    Text = seatNumber,
                    Tag = seatId,
                    Size = new Size(btnSize, btnSize),
                    Location = new Point(col * (btnSize + spacing), row * (btnSize + spacing)),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                    BackColor = isBooked ? Color.IndianRed : ColorTranslator.FromHtml("#2E2E3E"),
                    ForeColor = Color.White,
                    Enabled = !isBooked
                };

                seatBtn.Click += SeatBtn_Click;
                pnlSeats.Controls.Add(seatBtn);

                col++;
                if (col >= seatsPerRow)
                {
                    col = 0;
                    row++;
                }
            }
        }

        private void SeatBtn_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            foreach (Control ctrl in pnlSeats.Controls)
            {
                if (ctrl is Button btn && btn.Enabled)
                    btn.BackColor = ColorTranslator.FromHtml("#2E2E3E");
            }

            clicked.BackColor = ColorTranslator.FromHtml("#4CAF50");
            _selectedSeatId = (int)clicked.Tag;
            _selectedSeatNumber = clicked.Text;

            lblSelectedSeat.Text = $"Selected Seat: {_selectedSeatNumber}";
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if (_selectedSeatId == null)
            {
                MessageBox.Show("Please select a seat first.", "Missing Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Confirm booking seat {_selectedSeatNumber} for {_movieTitle} at ${_ticketPrice:0.00}?",
                "Confirm Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                DatabaseHelper.ExecuteNonQuery(
                    @"INSERT INTO Bookings (UserID, ShowtimeID, SeatID, Status, TotalPrice)
                      VALUES (@UserID, @ShowtimeID, @SeatID, 'Confirmed', @TotalPrice)",
                    new SqlParameter("@UserID", _userId),
                    new SqlParameter("@ShowtimeID", _showtimeId),
                    new SqlParameter("@SeatID", _selectedSeatId),
                    new SqlParameter("@TotalPrice", _ticketPrice));

                DatabaseHelper.ExecuteNonQuery(
                    "UPDATE Seats SET IsBooked = 1 WHERE SeatID = @SeatID",
                    new SqlParameter("@SeatID", _selectedSeatId));

                MessageBox.Show("Booking confirmed! Enjoy the movie.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _selectedSeatId = null;
                _selectedSeatNumber = null;
                lblSelectedSeat.Text = "Selected Seat: none";
                BuildSeatMap();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("That seat was just booked by someone else. Please pick another.", "Seat Taken",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BuildSeatMap();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Booking failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BrowseMoviesForm browse = new BrowseMoviesForm(_userId, _userName);
            browse.Show();
            this.Close();
        }
    }
}