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

        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TabPage tabShowtimes;

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

        private void StyleGrid(System.Windows.Forms.DataGridView grid)
        {
            grid.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#15151F");
            grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A2A38");
            grid.RowHeadersVisible = false;
            grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1B26");
            grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9184A");
            grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#1B1B26");
            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#15151F");
            grid.DefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E8E8F0");
            grid.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            grid.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#2A1620");
            grid.DefaultCellStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#F4ECD8");
            grid.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);

            grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#191922");
            grid.RowTemplate.Height = 36;
            grid.AllowUserToResizeRows = false;
            grid.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        }

        private void StyleInput(System.Windows.Forms.TextBox t)
        {
            t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            t.BackColor = System.Drawing.ColorTranslator.FromHtml("#1F1F2B");
            t.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E8E8F0");
            t.Font = new System.Drawing.Font("Segoe UI", 10F);
        }

        private void StyleLabel(System.Windows.Forms.Label l)
        {
            l.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8A8A99");
            l.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            l.BackColor = System.Drawing.Color.Transparent;
        }

        private void StyleButton(System.Windows.Forms.Button b, string back, string fore)
        {
            b.BackColor = System.Drawing.ColorTranslator.FromHtml(back);
            b.ForeColor = System.Drawing.ColorTranslator.FromHtml(fore);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.ControlPaint.Light(b.BackColor, 0.2f);
            b.FlatAppearance.MouseDownBackColor = System.Drawing.ControlPaint.Dark(b.BackColor, 0.1f);
            b.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void StyleOutline(System.Windows.Forms.Button b, string color)
        {
            b.BackColor = System.Drawing.ColorTranslator.FromHtml("#15151F");
            b.ForeColor = System.Drawing.ColorTranslator.FromHtml(color);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml(color);
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.ControlPaint.Light(System.Drawing.ColorTranslator.FromHtml("#15151F"), 0.3f);
            b.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void tabControl_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            System.Windows.Forms.TabControl tc = (System.Windows.Forms.TabControl)sender;
            System.Windows.Forms.TabPage page = tc.TabPages[e.Index];
            System.Drawing.Rectangle rect = tc.GetTabRect(e.Index);
            bool selected = (e.Index == tc.SelectedIndex);

            System.Drawing.Color back = selected
                ? System.Drawing.ColorTranslator.FromHtml("#15151F")
                : System.Drawing.ColorTranslator.FromHtml("#0A0A0F");
            System.Drawing.Color fore = selected
                ? System.Drawing.ColorTranslator.FromHtml("#C9184A")
                : System.Drawing.ColorTranslator.FromHtml("#8A8A9C");

            using (System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(back))
                e.Graphics.FillRectangle(b, rect);

            if (selected)
            {
                using (System.Drawing.SolidBrush accent = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#C9184A")))
                    e.Graphics.FillRectangle(accent, rect.Left, rect.Bottom - 2, rect.Width, 2);
            }

            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, page.Text,
                new System.Drawing.Font("Segoe UI", 10F, selected ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular),
                rect, fore,
                System.Windows.Forms.TextFormatFlags.HorizontalCenter | System.Windows.Forms.TextFormatFlags.VerticalCenter);
        }

        private void InitializeComponent()
        {
            pnlAccent = new Panel();
            lblTitle = new Label();
            lblTagline = new Label();
            btnLogout = new Button();
            tabControl = new TabControl();
            tabMovies = new TabPage();
            lblMovieTitle = new Label();
            txtMovieTitle = new TextBox();
            lblGenre = new Label();
            txtGenre = new TextBox();
            lblDuration = new Label();
            txtDuration = new TextBox();
            lblRating = new Label();
            txtRating = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAddMovie = new Button();
            btnUpdateMovie = new Button();
            btnDeleteMovie = new Button();
            btnClearMovie = new Button();
            dgvMovies = new DataGridView();
            tabShowtimes = new TabPage();
            lblShowtimeMovie = new Label();
            cmbShowtimeMovie = new ComboBox();
            lblShowDate = new Label();
            dtpShowDate = new DateTimePicker();
            lblShowTime = new Label();
            dtpShowTime = new DateTimePicker();
            lblHall = new Label();
            txtHall = new TextBox();
            lblTotalSeats = new Label();
            txtTotalSeats = new TextBox();
            lblTicketPrice = new Label();
            txtTicketPrice = new TextBox();
            btnAddShowtime = new Button();
            btnDeleteShowtime = new Button();
            dgvShowtimes = new DataGridView();
            tabControl.SuspendLayout();
            tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            tabShowtimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowtimes).BeginInit();
            SuspendLayout();
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(201, 24, 74);
            pnlAccent.Location = new Point(0, 70);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(1100, 2);
            pnlAccent.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(183, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Panel";
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagline.ForeColor = Color.FromArgb(201, 24, 74);
            lblTagline.Location = new Point(32, 48);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(272, 19);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "C I N E B O O K   ·   M A N A G E M E N T";
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 56);
            btnLogout.Location = new Point(940, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(130, 35);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log Out";
            btnLogout.Click += btnLogout_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMovies);
            tabControl.Controls.Add(tabShowtimes);
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.ItemSize = new Size(130, 36);
            tabControl.Location = new Point(30, 82);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1040, 656);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 4;
            tabControl.DrawItem += tabControl_DrawItem;
            // 
            // tabMovies
            // 
            tabMovies.BackColor = Color.FromArgb(21, 21, 31);
            tabMovies.Controls.Add(lblMovieTitle);
            tabMovies.Controls.Add(txtMovieTitle);
            tabMovies.Controls.Add(lblGenre);
            tabMovies.Controls.Add(txtGenre);
            tabMovies.Controls.Add(lblDuration);
            tabMovies.Controls.Add(txtDuration);
            tabMovies.Controls.Add(lblRating);
            tabMovies.Controls.Add(txtRating);
            tabMovies.Controls.Add(lblDescription);
            tabMovies.Controls.Add(txtDescription);
            tabMovies.Controls.Add(btnAddMovie);
            tabMovies.Controls.Add(btnUpdateMovie);
            tabMovies.Controls.Add(btnDeleteMovie);
            tabMovies.Controls.Add(btnClearMovie);
            tabMovies.Controls.Add(dgvMovies);
            tabMovies.Location = new Point(4, 40);
            tabMovies.Name = "tabMovies";
            tabMovies.Size = new Size(1032, 612);
            tabMovies.TabIndex = 0;
            tabMovies.Text = "Movies";
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Location = new Point(20, 20);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(44, 20);
            lblMovieTitle.TabIndex = 0;
            lblMovieTitle.Text = "TITLE";
            // 
            // txtMovieTitle
            // 
            txtMovieTitle.Location = new Point(20, 42);
            txtMovieTitle.Name = "txtMovieTitle";
            txtMovieTitle.Size = new Size(250, 27);
            txtMovieTitle.TabIndex = 1;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(290, 20);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(55, 20);
            lblGenre.TabIndex = 2;
            lblGenre.Text = "GENRE";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(290, 42);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(150, 27);
            txtGenre.TabIndex = 3;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(460, 20);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(124, 20);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "DURATION (MIN)";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(460, 42);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(110, 27);
            txtDuration.TabIndex = 5;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(590, 20);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(60, 20);
            lblRating.TabIndex = 6;
            lblRating.Text = "RATING";
            // 
            // txtRating
            // 
            txtRating.Location = new Point(590, 42);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(100, 27);
            txtRating.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 90);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "DESCRIPTION";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 112);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(670, 60);
            txtDescription.TabIndex = 9;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(720, 42);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(100, 32);
            btnAddMovie.TabIndex = 10;
            btnAddMovie.Text = "Add";
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.Location = new Point(830, 42);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(100, 32);
            btnUpdateMovie.TabIndex = 11;
            btnUpdateMovie.Text = "Update";
            btnUpdateMovie.Click += btnUpdateMovie_Click;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Location = new Point(720, 90);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(130, 32);
            btnDeleteMovie.TabIndex = 12;
            btnDeleteMovie.Text = "Delete Selected";
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // btnClearMovie
            // 
            btnClearMovie.Location = new Point(860, 90);
            btnClearMovie.Name = "btnClearMovie";
            btnClearMovie.Size = new Size(110, 32);
            btnClearMovie.TabIndex = 13;
            btnClearMovie.Text = "Clear Form";
            btnClearMovie.Click += btnClearMovie_Click;
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.ColumnHeadersHeight = 29;
            dgvMovies.Location = new Point(20, 185);
            dgvMovies.MultiSelect = false;
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.Size = new Size(1000, 440);
            dgvMovies.TabIndex = 14;
            dgvMovies.SelectionChanged += dgvMovies_SelectionChanged;
            // 
            // tabShowtimes
            // 
            tabShowtimes.BackColor = Color.FromArgb(21, 21, 31);
            tabShowtimes.Controls.Add(lblShowtimeMovie);
            tabShowtimes.Controls.Add(cmbShowtimeMovie);
            tabShowtimes.Controls.Add(lblShowDate);
            tabShowtimes.Controls.Add(dtpShowDate);
            tabShowtimes.Controls.Add(lblShowTime);
            tabShowtimes.Controls.Add(dtpShowTime);
            tabShowtimes.Controls.Add(lblHall);
            tabShowtimes.Controls.Add(txtHall);
            tabShowtimes.Controls.Add(lblTotalSeats);
            tabShowtimes.Controls.Add(txtTotalSeats);
            tabShowtimes.Controls.Add(lblTicketPrice);
            tabShowtimes.Controls.Add(txtTicketPrice);
            tabShowtimes.Controls.Add(btnAddShowtime);
            tabShowtimes.Controls.Add(btnDeleteShowtime);
            tabShowtimes.Controls.Add(dgvShowtimes);
            tabShowtimes.Location = new Point(4, 40);
            tabShowtimes.Name = "tabShowtimes";
            tabShowtimes.Size = new Size(1032, 612);
            tabShowtimes.TabIndex = 1;
            tabShowtimes.Text = "Showtimes";
            // 
            // lblShowtimeMovie
            // 
            lblShowtimeMovie.AutoSize = true;
            lblShowtimeMovie.Location = new Point(20, 20);
            lblShowtimeMovie.Name = "lblShowtimeMovie";
            lblShowtimeMovie.Size = new Size(54, 20);
            lblShowtimeMovie.TabIndex = 0;
            lblShowtimeMovie.Text = "MOVIE";
            // 
            // cmbShowtimeMovie
            // 
            cmbShowtimeMovie.BackColor = Color.FromArgb(31, 31, 43);
            cmbShowtimeMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShowtimeMovie.FlatStyle = FlatStyle.Flat;
            cmbShowtimeMovie.Font = new Font("Segoe UI", 10F);
            cmbShowtimeMovie.ForeColor = Color.FromArgb(232, 232, 240);
            cmbShowtimeMovie.Location = new Point(20, 42);
            cmbShowtimeMovie.Name = "cmbShowtimeMovie";
            cmbShowtimeMovie.Size = new Size(220, 31);
            cmbShowtimeMovie.TabIndex = 1;
            // 
            // lblShowDate
            // 
            lblShowDate.AutoSize = true;
            lblShowDate.Location = new Point(260, 20);
            lblShowDate.Name = "lblShowDate";
            lblShowDate.Size = new Size(45, 20);
            lblShowDate.TabIndex = 2;
            lblShowDate.Text = "DATE";
            // 
            // dtpShowDate
            // 
            dtpShowDate.CalendarForeColor = Color.FromArgb(232, 232, 240);
            dtpShowDate.CalendarMonthBackground = Color.FromArgb(31, 31, 43);
            dtpShowDate.Format = DateTimePickerFormat.Short;
            dtpShowDate.Location = new Point(260, 42);
            dtpShowDate.Name = "dtpShowDate";
            dtpShowDate.Size = new Size(140, 27);
            dtpShowDate.TabIndex = 3;
            // 
            // lblShowTime
            // 
            lblShowTime.AutoSize = true;
            lblShowTime.Location = new Point(420, 20);
            lblShowTime.Name = "lblShowTime";
            lblShowTime.Size = new Size(42, 20);
            lblShowTime.TabIndex = 4;
            lblShowTime.Text = "TIME";
            // 
            // dtpShowTime
            // 
            dtpShowTime.Format = DateTimePickerFormat.Time;
            dtpShowTime.Location = new Point(420, 42);
            dtpShowTime.Name = "dtpShowTime";
            dtpShowTime.ShowUpDown = true;
            dtpShowTime.Size = new Size(110, 27);
            dtpShowTime.TabIndex = 5;
            // 
            // lblHall
            // 
            lblHall.AutoSize = true;
            lblHall.Location = new Point(550, 20);
            lblHall.Name = "lblHall";
            lblHall.Size = new Size(44, 20);
            lblHall.TabIndex = 6;
            lblHall.Text = "HALL";
            // 
            // txtHall
            // 
            txtHall.Location = new Point(550, 42);
            txtHall.Name = "txtHall";
            txtHall.Size = new Size(110, 27);
            txtHall.TabIndex = 7;
            // 
            // lblTotalSeats
            // 
            lblTotalSeats.AutoSize = true;
            lblTotalSeats.Location = new Point(680, 20);
            lblTotalSeats.Name = "lblTotalSeats";
            lblTotalSeats.Size = new Size(95, 20);
            lblTotalSeats.TabIndex = 8;
            lblTotalSeats.Text = "TOTAL SEATS";
            // 
            // txtTotalSeats
            // 
            txtTotalSeats.Location = new Point(680, 42);
            txtTotalSeats.Name = "txtTotalSeats";
            txtTotalSeats.Size = new Size(90, 27);
            txtTotalSeats.TabIndex = 9;
            // 
            // lblTicketPrice
            // 
            lblTicketPrice.AutoSize = true;
            lblTicketPrice.Location = new Point(790, 20);
            lblTicketPrice.Name = "lblTicketPrice";
            lblTicketPrice.Size = new Size(69, 20);
            lblTicketPrice.TabIndex = 10;
            lblTicketPrice.Text = "PRICE ($)";
            // 
            // txtTicketPrice
            // 
            txtTicketPrice.Location = new Point(790, 42);
            txtTicketPrice.Name = "txtTicketPrice";
            txtTicketPrice.Size = new Size(90, 27);
            txtTicketPrice.TabIndex = 11;
            // 
            // btnAddShowtime
            // 
            btnAddShowtime.Location = new Point(20, 90);
            btnAddShowtime.Name = "btnAddShowtime";
            btnAddShowtime.Size = new Size(160, 32);
            btnAddShowtime.TabIndex = 12;
            btnAddShowtime.Text = "Add Showtime";
            btnAddShowtime.Click += btnAddShowtime_Click;
            // 
            // btnDeleteShowtime
            // 
            btnDeleteShowtime.Location = new Point(190, 90);
            btnDeleteShowtime.Name = "btnDeleteShowtime";
            btnDeleteShowtime.Size = new Size(190, 32);
            btnDeleteShowtime.TabIndex = 13;
            btnDeleteShowtime.Text = "Delete Selected Showtime";
            btnDeleteShowtime.Click += btnDeleteShowtime_Click;
            // 
            // dgvShowtimes
            // 
            dgvShowtimes.AllowUserToAddRows = false;
            dgvShowtimes.ColumnHeadersHeight = 29;
            dgvShowtimes.Location = new Point(20, 140);
            dgvShowtimes.MultiSelect = false;
            dgvShowtimes.Name = "dgvShowtimes";
            dgvShowtimes.ReadOnly = true;
            dgvShowtimes.RowHeadersWidth = 51;
            dgvShowtimes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShowtimes.Size = new Size(1000, 470);
            dgvShowtimes.TabIndex = 14;
            // 
            // AdminDashboardForm
            // 
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(1100, 760);
            Controls.Add(lblTitle);
            Controls.Add(lblTagline);
            Controls.Add(btnLogout);
            Controls.Add(pnlAccent);
            Controls.Add(tabControl);
            Font = new Font("Segoe UI", 9F);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineBook — Admin Dashboard";
            Load += AdminDashboardForm_Load;
            tabControl.ResumeLayout(false);
            tabMovies.ResumeLayout(false);
            tabMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            tabShowtimes.ResumeLayout(false);
            tabShowtimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowtimes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}