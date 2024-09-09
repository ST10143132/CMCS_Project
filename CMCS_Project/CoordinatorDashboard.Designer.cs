using System.Windows.Forms;

namespace CMCS_Project
{
    partial class CoordinatorDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip();
            this.titleLabel = new System.Windows.Forms.Label();  // Add title label
            this.SuspendLayout();

            // Title Label (Coordinator Dashboard)
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);  // Large font for the title
            this.titleLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.titleLabel.Location = new System.Drawing.Point(180, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(240, 40);
            this.titleLabel.Text = "Coordinator Dashboard";  // Title text

            // GroupBox to organize elements
            this.groupBox1.Location = new System.Drawing.Point(20, 70);  // Moved down to make space for the title
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 300);
            this.groupBox1.Text = "Review Submitted Claims";
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;

            // DataGridView for claims
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Add Checkbox Column to DataGridView
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Width = 50;
            this.dataGridView1.Columns.Add(checkBoxColumn);

            // Add other columns to DataGridView
            this.dataGridView1.Columns.Add("LecturerName", "Lecturer Name");
            this.dataGridView1.Columns.Add("HoursWorked", "Hours Worked");
            this.dataGridView1.Columns.Add("ClaimAmount", "Claim Amount");
            this.dataGridView1.Columns.Add("ClaimStatus", "Claim Status");
            this.dataGridView1.Location = new System.Drawing.Point(30, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;  // Alternating row color for readability

            // Sample row for testing
            this.dataGridView1.Rows.Add(false, "John Doe", "10", "$200", "Pending");
            this.dataGridView1.Rows.Add(false, "Jane Smith", "8", "$160", "Pending");

            // Approve Button
            this.ApproveButton.Location = new System.Drawing.Point(150, 220);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(100, 40);
            this.ApproveButton.TabIndex = 1;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.BackColor = System.Drawing.Color.ForestGreen;
            this.ApproveButton.ForeColor = System.Drawing.Color.White;
            this.ApproveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);

            // Reject Button
            this.RejectButton.Location = new System.Drawing.Point(300, 220);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(100, 40);
            this.RejectButton.TabIndex = 2;
            this.RejectButton.Text = "Reject";
            this.RejectButton.BackColor = System.Drawing.Color.Firebrick;
            this.RejectButton.ForeColor = System.Drawing.Color.White;
            this.RejectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);

            // Add controls to form
            this.Controls.Add(this.titleLabel);  // Add the title label to the form
            this.Controls.Add(this.groupBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.ApproveButton);
            this.groupBox1.Controls.Add(this.RejectButton);

            // CoordinatorDashboard Layout
            this.ClientSize = new System.Drawing.Size(600, 400);  // Increased size for title and layout
            this.Name = "CoordinatorDashboard";
            this.BackColor = System.Drawing.Color.Azure;
            this.Text = "Coordinator Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();  // Ensure layout updates after adding the title
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label titleLabel;  // Added title label for the page
    }
}
