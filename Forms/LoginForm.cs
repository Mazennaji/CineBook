using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CineBook.Helpers;

namespace CineBook.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
            DataTable result = DatabaseHelper.ExecuteQuery(query,
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password));

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Invalid email or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = Convert.ToInt32(result.Rows[0]["UserID"]);
            string name = result.Rows[0]["FullName"].ToString();
            string role = result.Rows[0]["Role"].ToString();

            if (role == "Admin")
            {
                AdminDashboardForm admin = new AdminDashboardForm();
                admin.Show();
            }
            else
            {
                BrowseMoviesForm browse = new BrowseMoviesForm(userId, name);
                browse.Show();
            }

            this.Hide();
        }

        private void lnkRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
    }
}