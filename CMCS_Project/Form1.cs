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

        // Event handler for "View Claims" button
        private void buttonViewClaims_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viewing Claims...");
        }

        // Event handler for "Browse" button
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Browse for documents...");
        }

        // Event handler for "Submit" button
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Claim submitted!");
        }
    }
}
