namespace CineBook.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lnkBackToLogin;

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lnkBackToLogin = new System.Windows.Forms.LinkLabel();

            this.Text = "CineBook — Register";
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D0D14");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.pnlCard.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1B26");
            this.pnlCard.Size = new System.Drawing.Size(420, 480);
            this.pnlCard.Location = new System.Drawing.Point(240, 70);

            this.lblTitle.Text = "Create Account";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(90, 25);

            // Full Name (top = 80)
            this.lblFullName.Text = "Full Name";
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(40, 80);
            this.lblFullName.AutoSize = true;
            this.txtFullName.Location = new System.Drawing.Point(40, 105);
            this.txtFullName.Size = new System.Drawing.Size(340, 28);

            // Email (top = 145)
            this.lblEmail.Text = "Email";
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(40, 145);
            this.lblEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(40, 170);
            this.txtEmail.Size = new System.Drawing.Size(340, 28);

            // Phone (top = 210)
            this.lblPhone.Text = "Phone (optional)";
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(40, 210);
            this.lblPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(40, 235);
            this.txtPhone.Size = new System.Drawing.Size(340, 28);

            // Password (top = 275)
            this.lblPassword.Text = "Password";
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(40, 275);
            this.lblPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(40, 300);
            this.txtPassword.Size = new System.Drawing.Size(340, 28);
            this.txtPassword.UseSystemPasswordChar = true;

            // Confirm Password (top = 340)
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(40, 340);
            this.lblConfirmPassword.AutoSize = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(40, 365);
            this.txtConfirmPassword.Size = new System.Drawing.Size(340, 28);
            this.txtConfirmPassword.UseSystemPasswordChar = true;

            // Register button (top = 405, +10 = 415)
            this.btnRegister.Text = "Create Account";
            this.btnRegister.Location = new System.Drawing.Point(40, 415);
            this.btnRegister.Size = new System.Drawing.Size(340, 40);
            this.btnRegister.BackColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // Back to login link (top = 405, +65 = 470)
            this.lnkBackToLogin.Text = "Already have an account? Log in";
            this.lnkBackToLogin.LinkColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.lnkBackToLogin.Location = new System.Drawing.Point(95, 470);
            this.lnkBackToLogin.AutoSize = true;
            this.lnkBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBackToLogin_Click);

            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblFullName);
            this.pnlCard.Controls.Add(this.txtFullName);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblPhone);
            this.pnlCard.Controls.Add(this.txtPhone);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.lblConfirmPassword);
            this.pnlCard.Controls.Add(this.txtConfirmPassword);
            this.pnlCard.Controls.Add(this.btnRegister);
            this.pnlCard.Controls.Add(this.lnkBackToLogin);

            this.Controls.Add(this.pnlCard);
        }
    }
}