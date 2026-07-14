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
            pnlCard.BackColor = Color.FromArgb(21, 21, 31);
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
            pnlCard.Location = new Point(250, 40);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(460, 520);
            pnlCard.TabIndex = 0;
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(201, 24, 74);
            pnlAccent.Location = new Point(0, 0);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(460, 4);
            pnlAccent.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI Emoji", 30F);
            lblLogo.ForeColor = Color.FromArgb(201, 24, 74);
            lblLogo.Location = new Point(190, 34);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(98, 67);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "🎬";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(134, 104);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 60);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "CineBook";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSubtitle.ForeColor = Color.FromArgb(138, 138, 153);
            lblSubtitle.Location = new Point(126, 164);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(223, 20);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "C I N E M A   E X P E R I E N C E";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(138, 138, 153);
            lblEmail.Location = new Point(48, 208);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(116, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "EMAIL ADDRESS";
            // 
            // pnlEmail
            // 
            pnlEmail.BackColor = Color.FromArgb(31, 31, 43);
            pnlEmail.Controls.Add(txtEmail);
            pnlEmail.Location = new Point(48, 230);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Padding = new Padding(14, 9, 14, 9);
            pnlEmail.Size = new Size(364, 44);
            pnlEmail.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(31, 31, 43);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(14, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(336, 25);
            txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(138, 138, 153);
            lblPassword.Location = new Point(48, 288);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 19);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "PASSWORD";
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(31, 31, 43);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Location = new Point(48, 310);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Padding = new Padding(14, 9, 14, 9);
            pnlPassword.Size = new Size(364, 44);
            pnlPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(31, 31, 43);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(14, 9);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(336, 25);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(201, 24, 74);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(168, 18, 64);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 27, 87);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(48, 386);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(364, 46);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(224, 27, 87);
            lnkRegister.AutoSize = true;
            lnkRegister.BackColor = Color.Transparent;
            lnkRegister.Font = new Font("Segoe UI", 9.5F);
            lnkRegister.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkRegister.LinkColor = Color.FromArgb(201, 24, 74);
            lnkRegister.Location = new Point(103, 452);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(271, 21);
            lnkRegister.TabIndex = 9;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Don't have an account?  Register here";
            lnkRegister.LinkClicked += lnkRegister_Click;
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(960, 600);
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