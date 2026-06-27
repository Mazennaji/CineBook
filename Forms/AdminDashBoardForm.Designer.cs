namespace CineBook.Forms
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TabPage tabShowtimes;

        // Movies tab controls
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnClearMovie;
        private System.Windows.Forms.DataGridView dgvMovies;

        // Showtimes tab controls
        private System.Windows.Forms.Label lblShowtimeMovie;
        private System.Windows.Forms.ComboBox cmbShowtimeMovie;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.DateTimePicker dtpShowDate;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.DateTimePicker dtpShowTime;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.TextBox txtHall;
        private System.Windows.Forms.Label lblTotalSeats;
        private System.Windows.Forms.TextBox txtTotalSeats;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.Button btnAddShowtime;
        private System.Windows.Forms.Button btnDeleteShowtime;
        private System.Windows.Forms.DataGridView dgvShowtimes;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.tabShowtimes = new System.Windows.Forms.TabPage();

            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnClearMovie = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();

            this.lblShowtimeMovie = new System.Windows.Forms.Label();
            this.cmbShowtimeMovie = new System.Windows.Forms.ComboBox();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.dtpShowDate = new System.Windows.Forms.DateTimePicker();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.dtpShowTime = new System.Windows.Forms.DateTimePicker();
            this.lblHall = new System.Windows.Forms.Label();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.lblTotalSeats = new System.Windows.Forms.Label();
            this.txtTotalSeats = new System.Windows.Forms.TextBox();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.btnAddShowtime = new System.Windows.Forms.Button();
            this.btnDeleteShowtime = new System.Windows.Forms.Button();
            this.dgvShowtimes = new System.Windows.Forms.DataGridView();

            // ---------- Form ----------
            this.Text = "CineBook — Admin Dashboard";
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D0D14");
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);

            this.lblTitle.Text = "Admin Panel";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.AutoSize = true;

            this.btnLogout.Text = "Log Out";
            this.btnLogout.Location = new System.Drawing.Point(940, 20);
            this.btnLogout.Size = new System.Drawing.Size(130, 35);
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.tabControl.Location = new System.Drawing.Point(30, 70);
            this.tabControl.Size = new System.Drawing.Size(1040, 660);
            this.tabControl.Controls.Add(this.tabMovies);
            this.tabControl.Controls.Add(this.tabShowtimes);

            this.tabMovies.Text = "Movies";
            this.tabMovies.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D0D14");

            this.tabShowtimes.Text = "Showtimes";
            this.tabShowtimes.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D0D14");

            // ================= MOVIES TAB =================
            // Row 1 (top = 20): Title, Genre, Duration, Rating
            this.lblMovieTitle.Text = "Title";
            this.lblMovieTitle.ForeColor = System.Drawing.Color.White;
            this.lblMovieTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMovieTitle.AutoSize = true;
            this.txtMovieTitle.Location = new System.Drawing.Point(20, 42);
            this.txtMovieTitle.Size = new System.Drawing.Size(250, 28);

            this.lblGenre.Text = "Genre";
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(290, 20);
            this.lblGenre.AutoSize = true;
            this.txtGenre.Location = new System.Drawing.Point(290, 42);
            this.txtGenre.Size = new System.Drawing.Size(150, 28);

            this.lblDuration.Text = "Duration (min)";
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(460, 20);
            this.lblDuration.AutoSize = true;
            this.txtDuration.Location = new System.Drawing.Point(460, 42);
            this.txtDuration.Size = new System.Drawing.Size(110, 28);

            this.lblRating.Text = "Rating";
            this.lblRating.ForeColor = System.Drawing.Color.White;
            this.lblRating.Location = new System.Drawing.Point(590, 20);
            this.lblRating.AutoSize = true;
            this.txtRating.Location = new System.Drawing.Point(590, 42);
            this.txtRating.Size = new System.Drawing.Size(100, 28);

            // Row 2 (top2 = 90): Description (multiline, taller)
            this.lblDescription.Text = "Description";
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(20, 90);
            this.lblDescription.AutoSize = true;
            this.txtDescription.Location = new System.Drawing.Point(20, 112);
            this.txtDescription.Size = new System.Drawing.Size(670, 60);
            this.txtDescription.Multiline = true;

            // Action buttons — placed below row 1 inputs (clear of the textboxes), top = 90
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.Location = new System.Drawing.Point(720, 42);
            this.btnAddMovie.Size = new System.Drawing.Size(100, 32);
            this.btnAddMovie.BackColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.btnAddMovie.ForeColor = System.Drawing.Color.White;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);

            this.btnUpdateMovie.Text = "Update";
            this.btnUpdateMovie.Location = new System.Drawing.Point(830, 42);
            this.btnUpdateMovie.Size = new System.Drawing.Size(100, 32);
            this.btnUpdateMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateMovie.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);

            this.btnDeleteMovie.Text = "Delete Selected";
            this.btnDeleteMovie.Location = new System.Drawing.Point(720, 90);
            this.btnDeleteMovie.Size = new System.Drawing.Size(130, 32);
            this.btnDeleteMovie.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);

            this.btnClearMovie.Text = "Clear Form";
            this.btnClearMovie.Location = new System.Drawing.Point(860, 90);
            this.btnClearMovie.Size = new System.Drawing.Size(110, 32);
            this.btnClearMovie.BackColor = System.Drawing.Color.Gray;
            this.btnClearMovie.ForeColor = System.Drawing.Color.White;
            this.btnClearMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMovie.Click += new System.EventHandler(this.btnClearMovie_Click);

            // Grid (top3 = 185) — well clear of the description box which ends at 112+60=172
            this.dgvMovies.Location = new System.Drawing.Point(20, 185);
            this.dgvMovies.Size = new System.Drawing.Size(1000, 440);
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.SelectionChanged += new System.EventHandler(this.dgvMovies_SelectionChanged);

            this.tabMovies.Controls.Add(this.lblMovieTitle);
            this.tabMovies.Controls.Add(this.txtMovieTitle);
            this.tabMovies.Controls.Add(this.lblGenre);
            this.tabMovies.Controls.Add(this.txtGenre);
            this.tabMovies.Controls.Add(this.lblDuration);
            this.tabMovies.Controls.Add(this.txtDuration);
            this.tabMovies.Controls.Add(this.lblRating);
            this.tabMovies.Controls.Add(this.txtRating);
            this.tabMovies.Controls.Add(this.lblDescription);
            this.tabMovies.Controls.Add(this.txtDescription);
            this.tabMovies.Controls.Add(this.btnAddMovie);
            this.tabMovies.Controls.Add(this.btnUpdateMovie);
            this.tabMovies.Controls.Add(this.btnDeleteMovie);
            this.tabMovies.Controls.Add(this.btnClearMovie);
            this.tabMovies.Controls.Add(this.dgvMovies);

            // ================= SHOWTIMES TAB =================
            // Row 1 (sTop = 20): Movie, Date, Time, Hall, Total Seats, Price
            this.lblShowtimeMovie.Text = "Movie";
            this.lblShowtimeMovie.ForeColor = System.Drawing.Color.White;
            this.lblShowtimeMovie.Location = new System.Drawing.Point(20, 20);
            this.lblShowtimeMovie.AutoSize = true;
            this.cmbShowtimeMovie.Location = new System.Drawing.Point(20, 42);
            this.cmbShowtimeMovie.Size = new System.Drawing.Size(220, 28);
            this.cmbShowtimeMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblShowDate.Text = "Date";
            this.lblShowDate.ForeColor = System.Drawing.Color.White;
            this.lblShowDate.Location = new System.Drawing.Point(260, 20);
            this.lblShowDate.AutoSize = true;
            this.dtpShowDate.Location = new System.Drawing.Point(260, 42);
            this.dtpShowDate.Size = new System.Drawing.Size(140, 28);
            this.dtpShowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblShowTime.Text = "Time";
            this.lblShowTime.ForeColor = System.Drawing.Color.White;
            this.lblShowTime.Location = new System.Drawing.Point(420, 20);
            this.lblShowTime.AutoSize = true;
            this.dtpShowTime.Location = new System.Drawing.Point(420, 42);
            this.dtpShowTime.Size = new System.Drawing.Size(110, 28);
            this.dtpShowTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShowTime.ShowUpDown = true;

            this.lblHall.Text = "Hall";
            this.lblHall.ForeColor = System.Drawing.Color.White;
            this.lblHall.Location = new System.Drawing.Point(550, 20);
            this.lblHall.AutoSize = true;
            this.txtHall.Location = new System.Drawing.Point(550, 42);
            this.txtHall.Size = new System.Drawing.Size(110, 28);

            this.lblTotalSeats.Text = "Total Seats";
            this.lblTotalSeats.ForeColor = System.Drawing.Color.White;
            this.lblTotalSeats.Location = new System.Drawing.Point(680, 20);
            this.lblTotalSeats.AutoSize = true;
            this.txtTotalSeats.Location = new System.Drawing.Point(680, 42);
            this.txtTotalSeats.Size = new System.Drawing.Size(90, 28);

            this.lblTicketPrice.Text = "Price ($)";
            this.lblTicketPrice.ForeColor = System.Drawing.Color.White;
            this.lblTicketPrice.Location = new System.Drawing.Point(790, 20);
            this.lblTicketPrice.AutoSize = true;
            this.txtTicketPrice.Location = new System.Drawing.Point(790, 42);
            this.txtTicketPrice.Size = new System.Drawing.Size(90, 28);

            // Row 2 (sTop2 = 90) — clear of row 1 inputs which end at 42+28=70
            this.btnAddShowtime.Text = "Add Showtime";
            this.btnAddShowtime.Location = new System.Drawing.Point(20, 90);
            this.btnAddShowtime.Size = new System.Drawing.Size(160, 32);
            this.btnAddShowtime.BackColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.btnAddShowtime.ForeColor = System.Drawing.Color.White;
            this.btnAddShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShowtime.Click += new System.EventHandler(this.btnAddShowtime_Click);

            this.btnDeleteShowtime.Text = "Delete Selected Showtime";
            this.btnDeleteShowtime.Location = new System.Drawing.Point(190, 90);
            this.btnDeleteShowtime.Size = new System.Drawing.Size(190, 32);
            this.btnDeleteShowtime.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteShowtime.ForeColor = System.Drawing.Color.White;
            this.btnDeleteShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShowtime.Click += new System.EventHandler(this.btnDeleteShowtime_Click);

            // Grid (sTop3 = 140) — clear of row 2 buttons which end at 90+32=122
            this.dgvShowtimes.Location = new System.Drawing.Point(20, 140);
            this.dgvShowtimes.Size = new System.Drawing.Size(1000, 470);
            this.dgvShowtimes.ReadOnly = true;
            this.dgvShowtimes.AllowUserToAddRows = false;
            this.dgvShowtimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowtimes.MultiSelect = false;

            this.tabShowtimes.Controls.Add(this.lblShowtimeMovie);
            this.tabShowtimes.Controls.Add(this.cmbShowtimeMovie);
            this.tabShowtimes.Controls.Add(this.lblShowDate);
            this.tabShowtimes.Controls.Add(this.dtpShowDate);
            this.tabShowtimes.Controls.Add(this.lblShowTime);
            this.tabShowtimes.Controls.Add(this.dtpShowTime);
            this.tabShowtimes.Controls.Add(this.lblHall);
            this.tabShowtimes.Controls.Add(this.txtHall);
            this.tabShowtimes.Controls.Add(this.lblTotalSeats);
            this.tabShowtimes.Controls.Add(this.txtTotalSeats);
            this.tabShowtimes.Controls.Add(this.lblTicketPrice);
            this.tabShowtimes.Controls.Add(this.txtTicketPrice);
            this.tabShowtimes.Controls.Add(this.btnAddShowtime);
            this.tabShowtimes.Controls.Add(this.btnDeleteShowtime);
            this.tabShowtimes.Controls.Add(this.dgvShowtimes);

            // ---------- Add to form ----------
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl);
        }
    }
}