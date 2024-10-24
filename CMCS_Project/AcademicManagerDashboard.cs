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
            // Simulate loading data into DataGridView
            dataGridView1.Rows.Add(false, "John Doe", "10", "$200", "Pending");
            dataGridView1.Rows.Add(false, "Jane Smith", "8", "$160", "Pending");

            // Set total claims
            textBoxTotalClaims.Text = "2";
            textBoxAccepted.Text = "0";
            textBoxRejected.Text = "0";
            textBoxPending.Text = "2";
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Approved claims.");
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rejected claims.");
        }
    }
}
