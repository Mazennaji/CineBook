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
            pnlCard = new Panel();
            pnlAccent = new Panel();
            lblLogo = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblEmail = new Label();
            pnlEmail = new Panel();
            txtEmail = new TextBox();
            lblPassword = new Label();
            pnlPassword = new Panel();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            pnlCard.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlPassword.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(23, 27, 40);
            pnlCard.Controls.Add(pnlAccent);
            pnlCard.Controls.Add(lblLogo);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(pnlEmail);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(pnlPassword);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(lnkRegister);
            pnlCard.Location = new Point(240, 70);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(420, 440);
            pnlCard.TabIndex = 0;
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(212, 175, 110);
            pnlAccent.Location = new Point(0, 0);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(420, 3);
            pnlAccent.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI Emoji", 26F);
            lblLogo.ForeColor = Color.FromArgb(212, 175, 110);
            lblLogo.Location = new Point(173, 22);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(85, 58);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "🎬";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F);
            lblTitle.ForeColor = Color.FromArgb(244, 236, 216);
            lblTitle.Location = new Point(121, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 54);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "CineBook";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 8F);
            lblSubtitle.ForeColor = Color.FromArgb(124, 124, 144);
            lblSubtitle.Location = new Point(149, 134);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(140, 19);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "CINEMA EXPERIENCE";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(154, 154, 172);
            lblEmail.Location = new Point(40, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "EMAIL";
            // 
            // pnlEmail
            // 
            pnlEmail.BackColor = Color.FromArgb(31, 36, 51);
            pnlEmail.Controls.Add(txtEmail);
            pnlEmail.Location = new Point(40, 182);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Padding = new Padding(12, 8, 12, 8);
            pnlEmail.Size = new Size(340, 40);
            pnlEmail.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(31, 36, 51);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.FromArgb(232, 232, 240);
            txtEmail.Location = new Point(12, 8);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 25);
            txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(154, 154, 172);
            lblPassword.Location = new Point(40, 235);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 19);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "PASSWORD";
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(31, 36, 51);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Location = new Point(40, 257);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Padding = new Padding(12, 8, 12, 8);
            pnlPassword.Size = new Size(340, 40);
            pnlPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(31, 36, 51);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(232, 232, 240);
            txtPassword.Location = new Point(12, 8);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(316, 25);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(212, 175, 110);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(26, 26, 36);
            btnLogin.Location = new Point(40, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(340, 44);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(244, 236, 216);
            lnkRegister.AutoSize = true;
            lnkRegister.BackColor = Color.Transparent;
            lnkRegister.Font = new Font("Segoe UI", 9F);
            lnkRegister.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkRegister.LinkColor = Color.FromArgb(212, 175, 110);
            lnkRegister.Location = new Point(95, 390);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(254, 20);
            lnkRegister.TabIndex = 9;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Don't have an account? Register here";
            lnkRegister.LinkClicked += lnkRegister_Click;
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(16, 19, 28);
            ClientSize = new Size(900, 580);
            Controls.Add(pnlCard);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineBook — Login";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ResumeLayout(false);
        }
    }
}