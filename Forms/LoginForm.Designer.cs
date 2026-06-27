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
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();

            this.Text = "CineBook — Login";
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#10131C");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.pnlCard.BackColor = System.Drawing.ColorTranslator.FromHtml("#171B28");
            this.pnlCard.Size = new System.Drawing.Size(420, 440);
            this.pnlCard.Location = new System.Drawing.Point(240, 70);

            this.pnlAccent.BackColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            this.pnlAccent.Size = new System.Drawing.Size(420, 3);
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);

            this.lblLogo.Text = "🎬";
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lblLogo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Location = new System.Drawing.Point(185, 28);

            this.lblTitle.Text = "CineBook";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Regular);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4ECD8");
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(140, 80);

            this.lblSubtitle.Text = "CINEMA EXPERIENCE";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7C7C90");
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Location = new System.Drawing.Point(150, 125);

            this.lblEmail.Text = "EMAIL";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#9A9AAC");
            this.lblEmail.Location = new System.Drawing.Point(40, 160);
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;

            this.pnlEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#1F2433");
            this.pnlEmail.Location = new System.Drawing.Point(40, 182);
            this.pnlEmail.Size = new System.Drawing.Size(340, 40);
            this.pnlEmail.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);

            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#1F2433");
            this.txtEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E8E8F0");
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblPassword.Text = "PASSWORD";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#9A9AAC");
            this.lblPassword.Location = new System.Drawing.Point(40, 235);
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;

            this.pnlPassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#1F2433");
            this.pnlPassword.Location = new System.Drawing.Point(40, 257);
            this.pnlPassword.Size = new System.Drawing.Size(340, 40);
            this.pnlPassword.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);

            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#1F2433");
            this.txtPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E8E8F0");
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnLogin.Text = "LOG IN";
            this.btnLogin.Location = new System.Drawing.Point(40, 322);
            this.btnLogin.Size = new System.Drawing.Size(340, 44);
            this.btnLogin.BackColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            this.btnLogin.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A24");
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.lnkRegister.Text = "Don't have an account? Register here";
            this.lnkRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkRegister.LinkColor = System.Drawing.ColorTranslator.FromHtml("#D4AF6E");
            this.lnkRegister.ActiveLinkColor = System.Drawing.ColorTranslator.FromHtml("#F4ECD8");
            this.lnkRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRegister.Location = new System.Drawing.Point(95, 390);
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.BackColor = System.Drawing.Color.Transparent;
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_Click);

            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlPassword.Controls.Add(this.txtPassword);

            this.pnlCard.Controls.Add(this.pnlAccent);
            this.pnlCard.Controls.Add(this.lblLogo);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.pnlEmail);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.pnlPassword);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.lnkRegister);

            this.Controls.Add(this.pnlCard);
        }
    }
}