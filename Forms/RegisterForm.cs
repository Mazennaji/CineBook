using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CineBook.Helpers;

namespace CineBook.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in name, email, and password.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Mismatch",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper.ExecuteNonQuery(
                    @"INSERT INTO Users (FullName, Email, Phone, Password, Role)
                      VALUES (@FullName, @Email, @Phone, @Password, 'User')",
                    new SqlParameter("@FullName", name),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Password", password));

                MessageBox.Show("Account created! You can now log in.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("An account with that email already exists.", "Duplicate Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}