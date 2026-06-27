using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CineBook.Helpers;

namespace CineBook.Forms
{
    public partial class MyBookingsForm : Form
    {
        private readonly int _userId;
        private readonly string _userName;

        public MyBookingsForm(int userId, string userName)
        {
            InitializeComponent();
            _userId = userId;
            _userName = userName;
            lblTitle.Text = $"{_userName}'s Bookings";
        }

        private void MyBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            string query = @"
                SELECT BookingID, MovieTitle, ShowDate, ShowTime, Hall, SeatNumber, TotalPrice, Status, BookingDate
                FROM vw_BookingDetails
                WHERE UserName = @UserName
                ORDER BY BookingDate DESC";

            DataTable bookings = DatabaseHelper.ExecuteQuery(query,
                new SqlParameter("@UserName", _userName));

            dgvBookings.DataSource = bookings;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a booking to cancel.", "Missing Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = dgvBookings.SelectedRows[0].Cells["Status"].Value.ToString();
            if (status == "Cancelled")
            {
                MessageBox.Show("This booking is already cancelled.", "Already Cancelled",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int bookingId = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);

            var confirm = MessageBox.Show("Cancel this booking? Your seat will be released.", "Confirm Cancellation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Bookings SET Status = 'Cancelled' WHERE BookingID = @ID",
                new SqlParameter("@ID", bookingId));

            DatabaseHelper.ExecuteNonQuery(
                @"UPDATE Seats SET IsBooked = 0
                  WHERE SeatID = (SELECT SeatID FROM Bookings WHERE BookingID = @ID)",
                new SqlParameter("@ID", bookingId));

            MessageBox.Show("Booking cancelled. Your seat has been released.", "Done",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadBookings();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BrowseMoviesForm browse = new BrowseMoviesForm(_userId, _userName);
            browse.Show();
            this.Close();
        }
    }
}