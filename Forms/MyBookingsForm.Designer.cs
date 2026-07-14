namespace CineBook.Forms
{
    partial class MyBookingsForm
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
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;

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

        private void StyleOutline(System.Windows.Forms.Button b, string color)
        {
            b.BackColor = System.Drawing.ColorTranslator.FromHtml("#15151F");
            b.ForeColor = System.Drawing.ColorTranslator.FromHtml(color);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml(color);
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.MouseOverBackColor = System.Windows.Forms.ControlPaint.Light(System.Drawing.ColorTranslator.FromHtml("#15151F"), 0.3f);
            b.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblTagline = new Label();
            pnlAccent = new Panel();
            dgvBookings = new DataGridView();
            btnCancel = new Button();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(10, 10, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblTagline);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1040, 68);
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
            lblTitle.Size = new Size(189, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Bookings";
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagline.ForeColor = Color.FromArgb(201, 24, 74);
            lblTagline.Location = new Point(32, 46);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(321, 19);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "C I N E B O O K   ·   B O O K I N G   H I S T O R Y";
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(201, 24, 74);
            pnlAccent.Location = new Point(0, 68);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(1040, 2);
            pnlAccent.TabIndex = 1;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.ColumnHeadersHeight = 29;
            dgvBookings.Location = new Point(30, 94);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(980, 430);
            dgvBookings.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(30, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(280, 42);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel Selected Booking";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(730, 540);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 42);
            btnBack.TabIndex = 4;
            btnBack.Text = "← Back to Movies";
            btnBack.Click += btnBack_Click;
            // 
            // MyBookingsForm
            // 
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(1040, 680);
            Controls.Add(pnlHeader);
            Controls.Add(pnlAccent);
            Controls.Add(dgvBookings);
            Controls.Add(btnCancel);
            Controls.Add(btnBack);
            Font = new Font("Segoe UI", 9F);
            Name = "MyBookingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineBook — My Bookings";
            Load += MyBookingsForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }
    }
}