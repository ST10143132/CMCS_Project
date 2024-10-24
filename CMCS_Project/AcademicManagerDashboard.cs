﻿using System;
using System.Windows.Forms;

namespace CMCS_Project
{
    public partial class AcademicManagerDashboard : Form
    {
        public AcademicManagerDashboard()
        {
            InitializeComponent();
        }

        // Load sample data into the DataGridView on form load
        private void AcademicManagerDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // Simulate loading claims into DataGridView
                dataGridView1.Rows.Add(false, "John Doe", "10", "$200", "Pending");
                dataGridView1.Rows.Add(false, "Jane Smith", "8", "$160", "Pending");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Approve button click event
        private void buttonApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateClaimStatus("Approved"))
                {
                    MessageBox.Show("Selected claims approved.", "Approval",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No claims selected for approval.", "No Selection",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Reject button click event
        private void buttonReject_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateClaimStatus("Rejected"))
                {
                    MessageBox.Show("Selected claims rejected.", "Rejection",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No claims selected for rejection.", "No Selection",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to update claim status
        private bool UpdateClaimStatus(string newStatus)
        {
            bool claimSelected = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value))
                {
                    row.Cells["dataGridViewTextBoxColumn4"].Value = newStatus;
                    claimSelected = true;
                }
            }

            return claimSelected;
        }

        // Sign out button click event
        private void btnSignOutManager_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();  // Close the Manager Dashboard
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
