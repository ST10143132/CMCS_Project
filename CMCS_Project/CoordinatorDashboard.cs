using System.Windows.Forms;
using System;

namespace CMCS_Project
{
    public partial class CoordinatorDashboard : Form
    {
        public CoordinatorDashboard()
        {
            InitializeComponent();

            // Wire up the event handlers only once here
            ApproveButton.Click += ApproveButton_Click;
            RejectButton.Click += RejectButton_Click;
        }

        // Event handler for Approve button
        private void ApproveButton_Click(object sender, EventArgs e)
        {
            // Iterate over the DataGridView rows and approve the selected ones
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[0].Value);  // First column is the checkbox
                if (isSelected)
                {
                    row.Cells["ClaimStatus"].Value = "Approved";  // Update claim status
                }
            }
            MessageBox.Show("Selected claims approved!", "Approval");
        }

        // Event handler for Reject button
        private void RejectButton_Click(object sender, EventArgs e)
        {
            // Iterate over the DataGridView rows and reject the selected ones
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[0].Value);  // First column is the checkbox
                if (isSelected)
                {
                    row.Cells["ClaimStatus"].Value = "Rejected";  // Update claim status
                }
            }
            MessageBox.Show("Selected claims rejected!", "Rejection");
        }
    }
}
