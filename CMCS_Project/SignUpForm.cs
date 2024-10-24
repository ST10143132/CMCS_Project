using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CMCS_Project
{
    public partial class SignUpForm : Form
    {
        public static List<User> registeredLecturers = new List<User>();

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUser = new User
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                HourlyPay = 50.0m,
                UserType = "Lecturer"
            };

            registeredLecturers.Add(newUser);
            MessageBox.Show("Account created successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect to Login form
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal HourlyPay { get; set; }
        public string UserType { get; set; }
    }
}
