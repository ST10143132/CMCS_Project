using System.Windows.Forms;
using System;

namespace CMCS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the Browse button
        private void button1_Click(object sender, EventArgs e)
        {
            // Simulate document upload
            MessageBox.Show("Document uploaded successfully!");
        }

        // Event handler for the Submit Claim button
        private void button2_Click(object sender, EventArgs e)
        {
            // Simulate claim submission
            MessageBox.Show("Claim submitted successfully!", "Confirmation");
        }

        // Event handler to open the Coordinator Dashboard
        private void button3_Click(object sender, EventArgs e)
        {
            CoordinatorDashboard dashboard = new CoordinatorDashboard();
            dashboard.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
