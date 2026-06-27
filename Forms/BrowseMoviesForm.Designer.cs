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
            grid.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#171B28");
            grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = System.Drawing.ColorTranslator.FromHtml("#23283A");
            grid.RowHeadersVisible = false;
            grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#1F2433");
            grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#1F2433");
            grid.ColumnHeadersHeight = 38;
            grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#171B28");
            grid.DefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E8E8F0");
            grid.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            grid.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#2A2435");
            grid.DefaultCellStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#F4ECD8");
            grid.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);

            grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A1E2C");
            grid.RowTemplate.Height = 34;
            grid.AllowUserToResizeRows = false;
            grid.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        }

        private void StylePrimary(System.Windows.Forms.Button b)
        {
            b.BackColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A24");
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void StyleSecondary(System.Windows.Forms.Button b)
        {
            b.BackColor = System.Drawing.ColorTranslator.FromHtml("#171B28");
            b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            b.FlatAppearance.BorderSize = 1;
            b.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
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
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#10131C");
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Load += new System.EventHandler(this.BrowseMoviesForm_Load);

            this.pnlHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#10131C");
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 64);

            this.pnlAccent.BackColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            this.pnlAccent.Location = new System.Drawing.Point(0, 64);
            this.pnlAccent.Size = new System.Drawing.Size(1100, 2);

            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular);
            this.lblWelcome.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            this.lblWelcome.Location = new System.Drawing.Point(30, 12);
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;

            this.lblTagline.Text = "CINEBOOK · NOW SHOWING";
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTagline.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7C7C90");
            this.lblTagline.Location = new System.Drawing.Point(32, 42);
            this.lblTagline.AutoSize = true;
            this.lblTagline.BackColor = System.Drawing.Color.Transparent;

            this.btnLogout.Text = "Log Out";
            this.btnLogout.Location = new System.Drawing.Point(940, 16);
            this.btnLogout.Size = new System.Drawing.Size(130, 34);
            this.StyleSecondary(this.btnLogout);
            this.btnLogout.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C8C8D4");
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#444444");
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.lblMovies.Text = "NOW SHOWING";
            this.lblMovies.ForeColor = System.Drawing.ColorTranslator.FromHtml("#9A9AAC");
            this.lblMovies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMovies.Location = new System.Drawing.Point(30, 86);
            this.lblMovies.AutoSize = true;

            this.dgvMovies.Location = new System.Drawing.Point(30, 112);
            this.dgvMovies.Size = new System.Drawing.Size(640, 220);
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.MultiSelect = false;
            this.StyleGrid(this.dgvMovies);
            this.dgvMovies.SelectionChanged += new System.EventHandler(this.dgvMovies_SelectionChanged);

            this.txtDescription.Location = new System.Drawing.Point(30, 347);
            this.txtDescription.Size = new System.Drawing.Size(640, 80);
            this.txtDescription.Multiline = true;
            this.txtDescription.ReadOnly = true;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.BackColor = System.Drawing.ColorTranslator.FromHtml("#171B28");
            this.txtDescription.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B8B8C8");
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            this.lblShowtimes.Text = "SHOWTIMES";
            this.lblShowtimes.ForeColor = System.Drawing.ColorTranslator.FromHtml("#9A9AAC");
            this.lblShowtimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblShowtimes.Location = new System.Drawing.Point(690, 86);
            this.lblShowtimes.AutoSize = true;

            this.dgvShowtimes.Location = new System.Drawing.Point(690, 112);
            this.dgvShowtimes.Size = new System.Drawing.Size(380, 270);
            this.dgvShowtimes.ReadOnly = true;
            this.dgvShowtimes.AllowUserToAddRows = false;
            this.dgvShowtimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowtimes.MultiSelect = false;
            this.StyleGrid(this.dgvShowtimes);

            this.btnSelectShowtime.Text = "Select Seats →";
            this.btnSelectShowtime.Location = new System.Drawing.Point(690, 397);
            this.btnSelectShowtime.Size = new System.Drawing.Size(380, 40);
            this.StylePrimary(this.btnSelectShowtime);
            this.btnSelectShowtime.Click += new System.EventHandler(this.btnSelectShowtime_Click);

            this.btnMyBookings.Text = "My Bookings";
            this.btnMyBookings.Location = new System.Drawing.Point(30, 447);
            this.btnMyBookings.Size = new System.Drawing.Size(200, 40);
            this.StyleSecondary(this.btnMyBookings);
            this.btnMyBookings.Click += new System.EventHandler(this.btnMyBookings_Click);

            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblTagline);
            this.pnlHeader.Controls.Add(this.btnLogout);

            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAccent);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblShowtimes);
            this.Controls.Add(this.dgvShowtimes);
            this.Controls.Add(this.btnSelectShowtime);
            this.Controls.Add(this.btnMyBookings);
        }
    }
}