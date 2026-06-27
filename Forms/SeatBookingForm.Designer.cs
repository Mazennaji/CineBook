namespace CineBook.Forms
{
    partial class SeatBookingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.Label lblLegendAvailable;
        private System.Windows.Forms.Label lblLegendBooked;
        private System.Windows.Forms.Label lblLegendSelected;
        private System.Windows.Forms.Panel pnlSwatchAvailable;
        private System.Windows.Forms.Panel pnlSwatchBooked;
        private System.Windows.Forms.Panel pnlSwatchSelected;
        private System.Windows.Forms.Label lblSelectedSeat;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnBack;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblScreen = new System.Windows.Forms.Label();
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.lblLegendAvailable = new System.Windows.Forms.Label();
            this.lblLegendBooked = new System.Windows.Forms.Label();
            this.lblLegendSelected = new System.Windows.Forms.Label();
            this.pnlSwatchAvailable = new System.Windows.Forms.Panel();
            this.pnlSwatchBooked = new System.Windows.Forms.Panel();
            this.pnlSwatchSelected = new System.Windows.Forms.Panel();
            this.lblSelectedSeat = new System.Windows.Forms.Label();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.Text = "CineBook — Select Seats";
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D0D14");
            this.Load += new System.EventHandler(this.SeatBookingForm_Load);

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.AutoSize = true;

            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(30, 55);
            this.lblPrice.AutoSize = true;

            this.lblScreen.Text = "🎬  S C R E E N";
            this.lblScreen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblScreen.ForeColor = System.Drawing.ColorTranslator.FromHtml("#888888");
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScreen.Location = new System.Drawing.Point(150, 95);
            this.lblScreen.Size = new System.Drawing.Size(550, 30);

            this.pnlSeats.Location = new System.Drawing.Point(150, 140);
            this.pnlSeats.Size = new System.Drawing.Size(560, 320);
            this.pnlSeats.AutoScroll = true;

            int legendTop = 480;

            this.pnlSwatchAvailable.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E2E3E");
            this.pnlSwatchAvailable.Size = new System.Drawing.Size(20, 20);
            this.pnlSwatchAvailable.Location = new System.Drawing.Point(150, legendTop);

            this.lblLegendAvailable.Text = "Available";
            this.lblLegendAvailable.ForeColor = System.Drawing.Color.White;
            this.lblLegendAvailable.Location = new System.Drawing.Point(180, legendTop + 2);
            this.lblLegendAvailable.AutoSize = true;

            this.pnlSwatchBooked.BackColor = System.Drawing.Color.IndianRed;
            this.pnlSwatchBooked.Size = new System.Drawing.Size(20, 20);
            this.pnlSwatchBooked.Location = new System.Drawing.Point(290, legendTop);

            this.lblLegendBooked.Text = "Booked";
            this.lblLegendBooked.ForeColor = System.Drawing.Color.White;
            this.lblLegendBooked.Location = new System.Drawing.Point(320, legendTop + 2);
            this.lblLegendBooked.AutoSize = true;

            this.pnlSwatchSelected.BackColor = System.Drawing.ColorTranslator.FromHtml("#4CAF50");
            this.pnlSwatchSelected.Size = new System.Drawing.Size(20, 20);
            this.pnlSwatchSelected.Location = new System.Drawing.Point(420, legendTop);

            this.lblLegendSelected.Text = "Selected";
            this.lblLegendSelected.ForeColor = System.Drawing.Color.White;
            this.lblLegendSelected.Location = new System.Drawing.Point(450, legendTop + 2);
            this.lblLegendSelected.AutoSize = true;

            this.lblSelectedSeat.Text = "Selected Seat: none";
            this.lblSelectedSeat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSelectedSeat.ForeColor = System.Drawing.Color.White;
            this.lblSelectedSeat.Location = new System.Drawing.Point(150, 540);
            this.lblSelectedSeat.AutoSize = true;

            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.Location = new System.Drawing.Point(150, 590);
            this.btnConfirmBooking.Size = new System.Drawing.Size(560, 45);
            this.btnConfirmBooking.BackColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.btnConfirmBooking.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBooking.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);

            this.btnBack.Text = "← Back to Movies";
            this.btnBack.Location = new System.Drawing.Point(150, 650);
            this.btnBack.Size = new System.Drawing.Size(560, 38);
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.pnlSeats);
            this.Controls.Add(this.pnlSwatchAvailable);
            this.Controls.Add(this.lblLegendAvailable);
            this.Controls.Add(this.pnlSwatchBooked);
            this.Controls.Add(this.lblLegendBooked);
            this.Controls.Add(this.pnlSwatchSelected);
            this.Controls.Add(this.lblLegendSelected);
            this.Controls.Add(this.lblSelectedSeat);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.btnBack);
        }
    }
}