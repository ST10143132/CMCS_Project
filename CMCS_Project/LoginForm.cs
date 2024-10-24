using System;
using System.Linq;
using System.Windows.Forms;

namespace CMCS_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Login button click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Validate input fields are not empty
                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Please enter a valid username.", "Login Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter a password.", "Login Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for Manager login
                if (username == "manager1" && password == "manager123")
                {
                    AcademicManagerDashboard managerDashboard = new AcademicManagerDashboard();
                    managerDashboard.Show();
                    this.Hide(); // Hide the Login form
                    return;
                }

                // Check for Coordinator login
                if (username == "coordinator1" && password == "coordinator123")
                {
                    CoordinatorDashboard coordinatorDashboard = new CoordinatorDashboard();
                    coordinatorDashboard.Show();
                    this.Hide(); // Hide the Login form
                    return;
                }

                // Check for Lecturer login from the registered lecturers list
                var lecturer = SignUpForm.registeredLecturers
                                .FirstOrDefault(user => user.Username == username && user.Password == password);

                if (lecturer != null)
                {
                    Form1 lecturerDashboard = new Form1();
                    lecturerDashboard.Show();
                    this.Hide(); // Hide the Login form
                    return;
                }

                // If no matching credentials are found
                lblErrorMessage.Text = "Invalid Login. Please try again.";
                lblErrorMessage.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Login Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sign Up label click event
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            // Open the SignUpForm when the user clicks "Sign Up"
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide(); // Hide the Login form
        }
    }
}
