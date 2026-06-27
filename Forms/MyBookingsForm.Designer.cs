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

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.Text = "CineBook — My Bookings";
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D0D14");
            this.Load += new System.EventHandler(this.MyBookingsForm_Load);

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.AutoSize = true;

            this.dgvBookings.Location = new System.Drawing.Point(30, 70);
            this.dgvBookings.Size = new System.Drawing.Size(940, 440);
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.MultiSelect = false;

            this.btnCancel.Text = "Cancel Selected Booking";
            this.btnCancel.Location = new System.Drawing.Point(30, 530);
            this.btnCancel.Size = new System.Drawing.Size(260, 38);
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.btnBack.Text = "← Back to Movies";
            this.btnBack.Location = new System.Drawing.Point(710, 530);
            this.btnBack.Size = new System.Drawing.Size(260, 38);
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBack);
        }
    }
}