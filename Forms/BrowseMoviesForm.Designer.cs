namespace CineBook.Forms
{
    partial class BrowseMoviesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblShowtimes;
        private System.Windows.Forms.DataGridView dgvShowtimes;
        private System.Windows.Forms.Button btnSelectShowtime;
        private System.Windows.Forms.Button btnMyBookings;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblShowtimes = new System.Windows.Forms.Label();
            this.dgvShowtimes = new System.Windows.Forms.DataGridView();
            this.btnSelectShowtime = new System.Windows.Forms.Button();
            this.btnMyBookings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.Text = "CineBook — Browse Movies";
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D0D14");
            this.Load += new System.EventHandler(this.BrowseMoviesForm_Load);

            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.AutoSize = true;

            this.lblMovies.Text = "Now Showing:";
            this.lblMovies.ForeColor = System.Drawing.Color.White;
            this.lblMovies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMovies.Location = new System.Drawing.Point(30, 70);
            this.lblMovies.AutoSize = true;

            this.dgvMovies.Location = new System.Drawing.Point(30, 100);
            this.dgvMovies.Size = new System.Drawing.Size(640, 220);
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.SelectionChanged += new System.EventHandler(this.dgvMovies_SelectionChanged);

            this.txtDescription.Location = new System.Drawing.Point(30, 335);
            this.txtDescription.Size = new System.Drawing.Size(640, 80);
            this.txtDescription.Multiline = true;
            this.txtDescription.ReadOnly = true;
            this.txtDescription.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1B26");
            this.txtDescription.ForeColor = System.Drawing.Color.White;

            this.lblShowtimes.Text = "Showtimes:";
            this.lblShowtimes.ForeColor = System.Drawing.Color.White;
            this.lblShowtimes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblShowtimes.Location = new System.Drawing.Point(690, 70);
            this.lblShowtimes.AutoSize = true;

            this.dgvShowtimes.Location = new System.Drawing.Point(690, 100);
            this.dgvShowtimes.Size = new System.Drawing.Size(380, 270);
            this.dgvShowtimes.ReadOnly = true;
            this.dgvShowtimes.AllowUserToAddRows = false;
            this.dgvShowtimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowtimes.MultiSelect = false;

            this.btnSelectShowtime.Text = "Select Seats →";
            this.btnSelectShowtime.Location = new System.Drawing.Point(690, 385);
            this.btnSelectShowtime.Size = new System.Drawing.Size(380, 38);
            this.btnSelectShowtime.BackColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.btnSelectShowtime.ForeColor = System.Drawing.Color.White;
            this.btnSelectShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectShowtime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectShowtime.Click += new System.EventHandler(this.btnSelectShowtime_Click);

            this.btnMyBookings.Text = "My Bookings";
            this.btnMyBookings.Location = new System.Drawing.Point(30, 440);
            this.btnMyBookings.Size = new System.Drawing.Size(200, 38);
            this.btnMyBookings.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMyBookings.ForeColor = System.Drawing.Color.White;
            this.btnMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBookings.Click += new System.EventHandler(this.btnMyBookings_Click);

            this.btnLogout.Text = "Log Out";
            this.btnLogout.Location = new System.Drawing.Point(940, 20);
            this.btnLogout.Size = new System.Drawing.Size(130, 35);
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblShowtimes);
            this.Controls.Add(this.dgvShowtimes);
            this.Controls.Add(this.btnSelectShowtime);
            this.Controls.Add(this.btnMyBookings);
            this.Controls.Add(this.btnLogout);
        }
    }
}