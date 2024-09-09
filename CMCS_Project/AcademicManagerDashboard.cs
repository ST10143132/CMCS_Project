using System.Windows.Forms;
using System;

namespace CMCS_Project
{
    public partial class AcademicManagerDashboard : Form
    {
        public AcademicManagerDashboard()
        {
            InitializeComponent();
        }

        private void AcademicManagerDashboard_Load(object sender, EventArgs e)
        {
            // Simulate data for claims
            var claims = new System.Data.DataTable();
            claims.Columns.Add("Claim ID");
            claims.Columns.Add("Lecturer Name");
            claims.Columns.Add("Hours Worked");
            claims.Columns.Add("Status");

            claims.Rows.Add("001", "John Doe", "20", "Approved");
            claims.Rows.Add("002", "Jane Smith", "25", "Pending");

            // Display the total number of claims
            textBoxTotalClaims.Text = claims.Rows.Count.ToString();

            // Bind the claims data to the DataGridView
            dataGridViewAllClaims.DataSource = claims;
        }
    }
}
