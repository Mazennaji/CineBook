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
        private System.Windows.Forms.Panel pnlTopAccent;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel pnlUnderlineFullName;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlUnderlineEmail;

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel pnlUnderlinePhone;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlUnderlinePassword;

        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Panel pnlUnderlineConfirmPassword;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lnkBackToLogin;

        private void InitializeComponent()
        {
            pnlCard = new Panel();
            pnlTopAccent = new Panel();
            lblBrand = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            pnlUnderlineFullName = new Panel();
            lblEmail = new Label();
            txtEmail = new TextBox();
            pnlUnderlineEmail = new Panel();
            lblPhone = new Label();
            txtPhone = new TextBox();
            pnlUnderlinePhone = new Panel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            pnlUnderlinePassword = new Panel();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            pnlUnderlineConfirmPassword = new Panel();
            btnRegister = new Button();
            lnkBackToLogin = new LinkLabel();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(21, 21, 31);
            pnlCard.Controls.Add(pnlTopAccent);
            pnlCard.Controls.Add(lblBrand);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblFullName);
            pnlCard.Controls.Add(txtFullName);
            pnlCard.Controls.Add(pnlUnderlineFullName);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(pnlUnderlineEmail);
            pnlCard.Controls.Add(lblPhone);
            pnlCard.Controls.Add(txtPhone);
            pnlCard.Controls.Add(pnlUnderlinePhone);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(pnlUnderlinePassword);
            pnlCard.Controls.Add(lblConfirmPassword);
            pnlCard.Controls.Add(txtConfirmPassword);
            pnlCard.Controls.Add(pnlUnderlineConfirmPassword);
            pnlCard.Controls.Add(btnRegister);
            pnlCard.Controls.Add(lnkBackToLogin);
            pnlCard.Location = new Point(250, 40);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(460, 600);
            pnlCard.TabIndex = 0;
            // 
            // pnlTopAccent
            // 
            pnlTopAccent.BackColor = Color.FromArgb(201, 24, 74);
            pnlTopAccent.Location = new Point(0, 0);
            pnlTopAccent.Name = "pnlTopAccent";
            pnlTopAccent.Size = new Size(460, 4);
            pnlTopAccent.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(201, 24, 74);
            lblBrand.Location = new Point(48, 34);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(113, 20);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "C I N E B O O K";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(46, 58);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(292, 52);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Create Account";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(138, 138, 153);
            lblSubtitle.Location = new Point(48, 110);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(364, 20);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Join us and start booking unforgettable movie nights";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(138, 138, 153);
            lblFullName.Location = new Point(48, 148);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(85, 19);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "FULL NAME";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(21, 21, 31);
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.ForeColor = Color.White;
            txtFullName.Location = new Point(48, 170);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(364, 25);
            txtFullName.TabIndex = 5;
            // 
            // pnlUnderlineFullName
            // 
            pnlUnderlineFullName.BackColor = Color.FromArgb(42, 42, 56);
            pnlUnderlineFullName.Location = new Point(48, 198);
            pnlUnderlineFullName.Name = "pnlUnderlineFullName";
            pnlUnderlineFullName.Size = new Size(364, 2);
            pnlUnderlineFullName.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(138, 138, 153);
            lblEmail.Location = new Point(48, 218);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(116, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "EMAIL ADDRESS";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(21, 21, 31);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(48, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(364, 25);
            txtEmail.TabIndex = 8;
            // 
            // pnlUnderlineEmail
            // 
            pnlUnderlineEmail.BackColor = Color.FromArgb(42, 42, 56);
            pnlUnderlineEmail.Location = new Point(48, 268);
            pnlUnderlineEmail.Name = "pnlUnderlineEmail";
            pnlUnderlineEmail.Size = new Size(364, 2);
            pnlUnderlineEmail.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(138, 138, 153);
            lblPhone.Location = new Point(48, 288);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(143, 19);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "PHONE (OPTIONAL)";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(21, 21, 31);
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(48, 310);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(364, 25);
            txtPhone.TabIndex = 11;
            // 
            // pnlUnderlinePhone
            // 
            pnlUnderlinePhone.BackColor = Color.FromArgb(42, 42, 56);
            pnlUnderlinePhone.Location = new Point(48, 338);
            pnlUnderlinePhone.Name = "pnlUnderlinePhone";
            pnlUnderlinePhone.Size = new Size(364, 2);
            pnlUnderlinePhone.TabIndex = 12;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(138, 138, 153);
            lblPassword.Location = new Point(48, 358);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 19);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(21, 21, 31);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(48, 380);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(364, 25);
            txtPassword.TabIndex = 14;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pnlUnderlinePassword
            // 
            pnlUnderlinePassword.BackColor = Color.FromArgb(42, 42, 56);
            pnlUnderlinePassword.Location = new Point(48, 408);
            pnlUnderlinePassword.Name = "pnlUnderlinePassword";
            pnlUnderlinePassword.Size = new Size(364, 2);
            pnlUnderlinePassword.TabIndex = 15;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(138, 138, 153);
            lblConfirmPassword.Location = new Point(48, 428);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(155, 19);
            lblConfirmPassword.TabIndex = 16;
            lblConfirmPassword.Text = "CONFIRM PASSWORD";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(21, 21, 31);
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(48, 450);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(364, 25);
            txtConfirmPassword.TabIndex = 17;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // pnlUnderlineConfirmPassword
            // 
            pnlUnderlineConfirmPassword.BackColor = Color.FromArgb(42, 42, 56);
            pnlUnderlineConfirmPassword.Location = new Point(48, 478);
            pnlUnderlineConfirmPassword.Name = "pnlUnderlineConfirmPassword";
            pnlUnderlineConfirmPassword.Size = new Size(364, 2);
            pnlUnderlineConfirmPassword.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(201, 24, 74);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(168, 18, 64);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 27, 87);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(48, 510);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(364, 46);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lnkBackToLogin
            // 
            lnkBackToLogin.ActiveLinkColor = Color.FromArgb(224, 27, 87);
            lnkBackToLogin.AutoSize = true;
            lnkBackToLogin.Font = new Font("Segoe UI", 9.5F);
            lnkBackToLogin.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkBackToLogin.LinkColor = Color.FromArgb(201, 24, 74);
            lnkBackToLogin.Location = new Point(122, 566);
            lnkBackToLogin.Name = "lnkBackToLogin";
            lnkBackToLogin.Size = new Size(237, 21);
            lnkBackToLogin.TabIndex = 20;
            lnkBackToLogin.TabStop = true;
            lnkBackToLogin.Text = "Already have an account?  Log in";
            lnkBackToLogin.VisitedLinkColor = Color.FromArgb(201, 24, 74);
            lnkBackToLogin.LinkClicked += lnkBackToLogin_Click;
            // 
            // RegisterForm
            // 
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(960, 680);
            Controls.Add(pnlCard);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineBook — Register";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }
    }
}