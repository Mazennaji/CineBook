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

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblShowtimes;
        private System.Windows.Forms.DataGridView dgvShowtimes;
        private System.Windows.Forms.Button btnSelectShowtime;
        private System.Windows.Forms.Button btnMyBookings;
        private System.Windows.Forms.Button btnLogout;

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

        private void StylePrimary(System.Windows.Forms.Button b)
        {
            b.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9184A");
            b.ForeColor = System.Drawing.Color.White;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = System.Windows.Forms.ControlPaint.Light(b.BackColor, 0.2f);
            b.FlatAppearance.MouseDownBackColor = System.Windows.Forms.ControlPaint.Dark(b.BackColor, 0.1f);
            b.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void StyleSecondary(System.Windows.Forms.Button b)
        {
            b.BackColor = System.Drawing.ColorTranslator.FromHtml("#15151F");
            b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9184A");
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#C9184A");
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.MouseOverBackColor = System.Windows.Forms.ControlPaint.Light(System.Drawing.ColorTranslator.FromHtml("#15151F"), 0.3f);
            b.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblWelcome = new Label();
            lblTagline = new Label();
            btnLogout = new Button();
            pnlAccent = new Panel();
            lblMovies = new Label();
            dgvMovies = new DataGridView();
            txtDescription = new TextBox();
            lblShowtimes = new Label();
            dgvShowtimes = new DataGridView();
            btnSelectShowtime = new Button();
            btnMyBookings = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowtimes).BeginInit();
            SuspendLayout();

            pnlHeader.BackColor = Color.FromArgb(10, 10, 15);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblTagline);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1100, 68);
            pnlHeader.TabIndex = 0;

            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(30, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 40);
            lblWelcome.TabIndex = 0;

            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagline.ForeColor = Color.FromArgb(201, 24, 74);
            lblTagline.Location = new Point(32, 46);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(285, 19);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "C I N E B O O K   ·   N O W   S H O W I N G";

            StyleSecondary(btnLogout);
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 56);
            btnLogout.ForeColor = Color.FromArgb(200, 200, 212);
            btnLogout.Location = new Point(940, 18);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(130, 34);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log Out";
            btnLogout.Click += btnLogout_Click;

            pnlAccent.BackColor = Color.FromArgb(201, 24, 74);
            pnlAccent.Location = new Point(0, 68);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(1100, 2);
            pnlAccent.TabIndex = 1;

            lblMovies.AutoSize = true;
            lblMovies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMovies.ForeColor = Color.FromArgb(138, 138, 153);
            lblMovies.Location = new Point(30, 90);
            lblMovies.Name = "lblMovies";
            lblMovies.Size = new Size(124, 20);
            lblMovies.TabIndex = 2;
            lblMovies.Text = "NOW SHOWING";

            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.ColumnHeadersHeight = 29;
            dgvMovies.Location = new Point(30, 116);
            dgvMovies.MultiSelect = false;
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.Size = new Size(640, 220);
            dgvMovies.TabIndex = 3;
            StyleGrid(dgvMovies);
            dgvMovies.SelectionChanged += dgvMovies_SelectionChanged;

            txtDescription.BackColor = Color.FromArgb(21, 21, 31);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.ForeColor = Color.FromArgb(184, 184, 200);
            txtDescription.Location = new Point(30, 351);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(640, 80);
            txtDescription.TabIndex = 4;

            lblShowtimes.AutoSize = true;
            lblShowtimes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShowtimes.ForeColor = Color.FromArgb(138, 138, 153);
            lblShowtimes.Location = new Point(690, 90);
            lblShowtimes.Name = "lblShowtimes";
            lblShowtimes.Size = new Size(98, 20);
            lblShowtimes.TabIndex = 5;
            lblShowtimes.Text = "SHOWTIMES";

            dgvShowtimes.AllowUserToAddRows = false;
            dgvShowtimes.ColumnHeadersHeight = 29;
            dgvShowtimes.Location = new Point(690, 116);
            dgvShowtimes.MultiSelect = false;
            dgvShowtimes.Name = "dgvShowtimes";
            dgvShowtimes.ReadOnly = true;
            dgvShowtimes.RowHeadersWidth = 51;
            dgvShowtimes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShowtimes.Size = new Size(380, 270);
            dgvShowtimes.TabIndex = 6;
            StyleGrid(dgvShowtimes);

            btnSelectShowtime.Location = new Point(690, 401);
            btnSelectShowtime.Name = "btnSelectShowtime";
            btnSelectShowtime.Size = new Size(380, 40);
            btnSelectShowtime.TabIndex = 7;
            btnSelectShowtime.Text = "Select Seats →";
            StylePrimary(btnSelectShowtime);
            btnSelectShowtime.Click += btnSelectShowtime_Click;

            btnMyBookings.Location = new Point(30, 451);
            btnMyBookings.Name = "btnMyBookings";
            btnMyBookings.Size = new Size(200, 40);
            btnMyBookings.TabIndex = 8;
            btnMyBookings.Text = "My Bookings";
            StyleSecondary(btnMyBookings);
            btnMyBookings.Click += btnMyBookings_Click;

            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(1100, 720);
            Controls.Add(pnlHeader);
            Controls.Add(pnlAccent);
            Controls.Add(lblMovies);
            Controls.Add(dgvMovies);
            Controls.Add(txtDescription);
            Controls.Add(lblShowtimes);
            Controls.Add(dgvShowtimes);
            Controls.Add(btnSelectShowtime);
            Controls.Add(btnMyBookings);
            Font = new Font("Segoe UI", 9F);
            Name = "BrowseMoviesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineBook — Browse Movies";
            Load += BrowseMoviesForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowtimes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}