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
            // Add sample data to DataGridView
            dataGridView1.Rows.Add(false, "John Doe", "10", "$200", "Pending");
            dataGridView1.Rows.Add(false, "Jane Smith", "8", "$160", "Pending");
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected claims approved.");
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected claims rejected.");
        }
    }
}
