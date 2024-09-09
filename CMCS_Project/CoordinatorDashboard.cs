using System.Windows.Forms;
using System;

namespace CMCS_Project
{
    public partial class CoordinatorDashboard : Form
    {
        public CoordinatorDashboard()
        {
            InitializeComponent();
        }

        private void CoordinatorDashboard_Load(object sender, EventArgs e)
        {
            // Simulate data for claims
            var claims = new System.Data.DataTable();
            claims.Columns.Add("Claim ID");
            claims.Columns.Add("Lecturer Name");
            claims.Columns.Add("Hours Worked");
            claims.Columns.Add("Status");

            claims.Rows.Add("001", "John Doe", "20", "Pending");
            claims.Rows.Add("002", "Jane Smith", "25", "Pending");

            // Display the total number of claims
            textBoxTotalClaims.Text = claims.Rows.Count.ToString();

            // Bind the claims data to the DataGridView
            dataGridViewClaims.DataSource = claims;
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            // Approve logic
            MessageBox.Show("Claim approved!");
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            // Reject logic
            MessageBox.Show("Claim rejected.");
        }
    }
}
