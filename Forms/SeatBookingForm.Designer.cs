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

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Panel pnlScreenGlow;
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

        private void StylePrimary(System.Windows.Forms.Button b)
        {
            b.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9184A");
            b.ForeColor = System.Drawing.Color.White;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = System.Windows.Forms.ControlPaint.Light(b.BackColor, 0.2f);
            b.FlatAppearance.MouseDownBackColor = System.Windows.Forms.ControlPaint.Dark(b.BackColor, 0.1f);
            b.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void StyleOutline(System.Windows.Forms.Button b, string color)
        {
            b.BackColor = System.Drawing.ColorTranslator.FromHtml("#15151F");
            b.ForeColor = System.Drawing.ColorTranslator.FromHtml(color);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml(color);
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.MouseOverBackColor = System.Windows.Forms.ControlPaint.Light(System.Drawing.ColorTranslator.FromHtml("#15151F"), 0.3f);
            b.Font = new System.Drawing.Font("Segoe UI", 10F);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblTagline = new Label();
            pnlAccent = new Panel();
            lblPrice = new Label();
            lblScreen = new Label();
            pnlScreenGlow = new Panel();
            pnlSeats = new Panel();
            lblLegendAvailable = new Label();
            lblLegendBooked = new Label();
            lblLegendSelected = new Label();
            pnlSwatchAvailable = new Panel();
            pnlSwatchBooked = new Panel();
            pnlSwatchSelected = new Panel();
            lblSelectedSeat = new Label();
            btnConfirmBooking = new Button();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(10, 10, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblTagline);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(960, 68);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(226, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Select Your Seat";
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagline.ForeColor = Color.FromArgb(201, 24, 74);
            lblTagline.Location = new Point(32, 46);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(297, 19);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "C I N E B O O K   ·   S E A T   S E L E C T I O N";
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(201, 24, 74);
            pnlAccent.Location = new Point(0, 68);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(960, 2);
            pnlAccent.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.ForeColor = Color.FromArgb(184, 184, 200);
            lblPrice.Location = new Point(30, 84);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 23);
            lblPrice.TabIndex = 2;
            // 
            // lblScreen
            // 
            lblScreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblScreen.ForeColor = Color.FromArgb(138, 138, 153);
            lblScreen.Location = new Point(180, 108);
            lblScreen.Name = "lblScreen";
            lblScreen.Size = new Size(600, 20);
            lblScreen.TabIndex = 3;
            lblScreen.Text = "S C R E E N";
            lblScreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlScreenGlow
            // 
            pnlScreenGlow.BackColor = Color.FromArgb(58, 58, 74);
            pnlScreenGlow.Location = new Point(180, 132);
            pnlScreenGlow.Name = "pnlScreenGlow";
            pnlScreenGlow.Size = new Size(600, 6);
            pnlScreenGlow.TabIndex = 4;
            // 
            // pnlSeats
            // 
            pnlSeats.AutoScroll = true;
            pnlSeats.BackColor = Color.FromArgb(21, 21, 31);
            pnlSeats.Location = new Point(180, 156);
            pnlSeats.Name = "pnlSeats";
            pnlSeats.Size = new Size(600, 320);
            pnlSeats.TabIndex = 5;
            // 
            // lblLegendAvailable
            // 
            lblLegendAvailable.AutoSize = true;
            lblLegendAvailable.ForeColor = Color.White;
            lblLegendAvailable.Location = new Point(210, 496);
            lblLegendAvailable.Name = "lblLegendAvailable";
            lblLegendAvailable.Size = new Size(71, 20);
            lblLegendAvailable.TabIndex = 7;
            lblLegendAvailable.Text = "Available";
            // 
            // lblLegendBooked
            // 
            lblLegendBooked.AutoSize = true;
            lblLegendBooked.ForeColor = Color.White;
            lblLegendBooked.Location = new Point(350, 496);
            lblLegendBooked.Name = "lblLegendBooked";
            lblLegendBooked.Size = new Size(60, 20);
            lblLegendBooked.TabIndex = 9;
            lblLegendBooked.Text = "Booked";
            // 
            // lblLegendSelected
            // 
            lblLegendSelected.AutoSize = true;
            lblLegendSelected.ForeColor = Color.White;
            lblLegendSelected.Location = new Point(480, 496);
            lblLegendSelected.Name = "lblLegendSelected";
            lblLegendSelected.Size = new Size(66, 20);
            lblLegendSelected.TabIndex = 11;
            lblLegendSelected.Text = "Selected";
            // 
            // pnlSwatchAvailable
            // 
            pnlSwatchAvailable.BackColor = Color.FromArgb(42, 42, 56);
            pnlSwatchAvailable.Location = new Point(180, 496);
            pnlSwatchAvailable.Name = "pnlSwatchAvailable";
            pnlSwatchAvailable.Size = new Size(20, 20);
            pnlSwatchAvailable.TabIndex = 6;
            // 
            // pnlSwatchBooked
            // 
            pnlSwatchBooked.BackColor = Color.FromArgb(226, 75, 74);
            pnlSwatchBooked.Location = new Point(320, 496);
            pnlSwatchBooked.Name = "pnlSwatchBooked";
            pnlSwatchBooked.Size = new Size(20, 20);
            pnlSwatchBooked.TabIndex = 8;
            // 
            // pnlSwatchSelected
            // 
            pnlSwatchSelected.BackColor = Color.FromArgb(93, 202, 165);
            pnlSwatchSelected.Location = new Point(450, 496);
            pnlSwatchSelected.Name = "pnlSwatchSelected";
            pnlSwatchSelected.Size = new Size(20, 20);
            pnlSwatchSelected.TabIndex = 10;
            // 
            // lblSelectedSeat
            // 
            lblSelectedSeat.AutoSize = true;
            lblSelectedSeat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSelectedSeat.ForeColor = Color.White;
            lblSelectedSeat.Location = new Point(180, 556);
            lblSelectedSeat.Name = "lblSelectedSeat";
            lblSelectedSeat.Size = new Size(185, 25);
            lblSelectedSeat.TabIndex = 12;
            lblSelectedSeat.Text = "Selected Seat: none";
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.Location = new Point(180, 606);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(600, 46);
            btnConfirmBooking.TabIndex = 13;
            btnConfirmBooking.Text = "Confirm Booking";
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(180, 662);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(600, 42);
            btnBack.TabIndex = 14;
            btnBack.Text = "← Back to Movies";
            btnBack.Click += btnBack_Click;
            // 
            // SeatBookingForm
            // 
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(960, 800);
            Controls.Add(pnlHeader);
            Controls.Add(pnlAccent);
            Controls.Add(lblPrice);
            Controls.Add(lblScreen);
            Controls.Add(pnlScreenGlow);
            Controls.Add(pnlSeats);
            Controls.Add(pnlSwatchAvailable);
            Controls.Add(lblLegendAvailable);
            Controls.Add(pnlSwatchBooked);
            Controls.Add(lblLegendBooked);
            Controls.Add(pnlSwatchSelected);
            Controls.Add(lblLegendSelected);
            Controls.Add(lblSelectedSeat);
            Controls.Add(btnConfirmBooking);
            Controls.Add(btnBack);
            Font = new Font("Segoe UI", 9F);
            Name = "SeatBookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineBook — Select Seats";
            Load += SeatBookingForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}