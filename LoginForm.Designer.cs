namespace CineBook.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();

            this.Text = "CineBook — Login";
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D0D14");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.pnlCard.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1B26");
            this.pnlCard.Size = new System.Drawing.Size(420, 400);
            this.pnlCard.Location = new System.Drawing.Point(240, 80);

            this.lblTitle.Text = "CineBook";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(125, 30);

            this.lblEmail.Text = "Email";
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(40, 110);
            this.lblEmail.AutoSize = true;

            this.txtEmail.Location = new System.Drawing.Point(40, 135);
            this.txtEmail.Size = new System.Drawing.Size(340, 28);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);

            this.lblPassword.Text = "Password";
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(40, 180);
            this.lblPassword.AutoSize = true;

            this.txtPassword.Location = new System.Drawing.Point(40, 205);
            this.txtPassword.Size = new System.Drawing.Size(340, 28);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.UseSystemPasswordChar = true;

            this.btnLogin.Text = "Log In";
            this.btnLogin.Location = new System.Drawing.Point(40, 260);
            this.btnLogin.Size = new System.Drawing.Size(340, 40);
            this.btnLogin.BackColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.lnkRegister.Text = "Don't have an account? Register here";
            this.lnkRegister.LinkColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.lnkRegister.Location = new System.Drawing.Point(95, 320);
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_Click);

            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.lnkRegister);

            this.Controls.Add(this.pnlCard);
        }
    }
}