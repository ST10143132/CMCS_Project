using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CMCS_Project
{
    public partial class AcademicManagerDashboard : Form
    {
        public AcademicManagerDashboard()
        {
            InitializeComponent();
        }

        // Class to represent a claim record
        public class ClaimRecord
        {
            public string ClaimID { get; set; }
            public string LecturerName { get; set; }
            public int HoursWorked { get; set; }
            public string Status { get; set; }
        }

        private void AcademicManagerDashboard_Load(object sender, EventArgs e)
        {
            // Step 1: Create a list of ClaimRecord objects to simulate data
            var claims = new List<ClaimRecord>
            {
                new ClaimRecord { ClaimID = "001", LecturerName = "John Doe", HoursWorked = 20, Status = "Approved" },
                new ClaimRecord { ClaimID = "002", LecturerName = "Jane Smith", HoursWorked = 25, Status = "Pending" }
            };

            // Step 2: Set the DataSource of the DataGridView to the list
            dataGridViewAllClaims.DataSource = claims;

            // Step 3: Set total claims count
            textBoxTotalClaims.Text = claims.Count.ToString();
        }
    }
}
