using System.Windows.Forms;

namespace CMCS_Project
{
    partial class AcademicManagerDashboard
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose method to clean up resources
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTotalClaims = new System.Windows.Forms.Label();
            this.textBoxTotalClaims = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.labelTotalAccepted = new System.Windows.Forms.Label();
            this.textBoxAccepted = new System.Windows.Forms.TextBox();
            this.labelTotalPending = new System.Windows.Forms.Label();
            this.textBoxPending = new System.Windows.Forms.TextBox();
            this.labelTotalRejected = new System.Windows.Forms.Label();
            this.textBoxRejected = new System.Windows.Forms.TextBox();
            this.btnSignOutManager = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(182, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(332, 30);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Academic Manager Dashboard";
            // 
            // labelTotalClaims
            // 
            this.labelTotalClaims.AutoSize = true;
            this.labelTotalClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTotalClaims.Location = new System.Drawing.Point(283, 56);
            this.labelTotalClaims.Name = "labelTotalClaims";
            this.labelTotalClaims.Size = new System.Drawing.Size(99, 20);
            this.labelTotalClaims.TabIndex = 7;
            this.labelTotalClaims.Text = "Total Claims:";
            // 
            // textBoxTotalClaims
            // 
            this.textBoxTotalClaims.Location = new System.Drawing.Point(306, 79);
            this.textBoxTotalClaims.Name = "textBoxTotalClaims";
            this.textBoxTotalClaims.ReadOnly = true;
            this.textBoxTotalClaims.Size = new System.Drawing.Size(57, 20);
            this.textBoxTotalClaims.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(73, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 93);
            this.dataGridView1.TabIndex = 9;
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.HeaderText = "Select";
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Lecturer Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Hours Worked";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Claim Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Claim Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // buttonApprove
            // 
            this.buttonApprove.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonApprove.ForeColor = System.Drawing.Color.White;
            this.buttonApprove.Location = new System.Drawing.Point(201, 309);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(120, 40);
            this.buttonApprove.TabIndex = 10;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = true;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // labelTotalAccepted
            // 
            this.labelTotalAccepted.AutoSize = true;
            this.labelTotalAccepted.ForeColor = System.Drawing.Color.Green;
            this.labelTotalAccepted.Location = new System.Drawing.Point(120, 121);
            this.labelTotalAccepted.Name = "labelTotalAccepted";
            this.labelTotalAccepted.Size = new System.Drawing.Size(53, 13);
            this.labelTotalAccepted.TabIndex = 5;
            this.labelTotalAccepted.Text = "Accepted";
            // 
            // textBoxAccepted
            // 
            this.textBoxAccepted.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAccepted.Location = new System.Drawing.Point(179, 118);
            this.textBoxAccepted.Name = "textBoxAccepted";
            this.textBoxAccepted.Size = new System.Drawing.Size(50, 20);
            this.textBoxAccepted.TabIndex = 3;
            // 
            // labelTotalPending
            // 
            this.labelTotalPending.AutoSize = true;
            this.labelTotalPending.Location = new System.Drawing.Point(399, 120);
            this.labelTotalPending.Name = "labelTotalPending";
            this.labelTotalPending.Size = new System.Drawing.Size(46, 13);
            this.labelTotalPending.TabIndex = 1;
            this.labelTotalPending.Text = "Pending";
            // 
            // textBoxPending
            // 
            this.textBoxPending.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPending.Location = new System.Drawing.Point(452, 118);
            this.textBoxPending.Name = "textBoxPending";
            this.textBoxPending.Size = new System.Drawing.Size(61, 20);
            this.textBoxPending.TabIndex = 0;
            // 
            // labelTotalRejected
            // 
            this.labelTotalRejected.AutoSize = true;
            this.labelTotalRejected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTotalRejected.Location = new System.Drawing.Point(258, 121);
            this.labelTotalRejected.Name = "labelTotalRejected";
            this.labelTotalRejected.Size = new System.Drawing.Size(50, 13);
            this.labelTotalRejected.TabIndex = 4;
            this.labelTotalRejected.Text = "Rejected";
            // 
            // textBoxRejected
            // 
            this.textBoxRejected.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRejected.Location = new System.Drawing.Point(314, 118);
            this.textBoxRejected.Name = "textBoxRejected";
            this.textBoxRejected.Size = new System.Drawing.Size(49, 20);
            this.textBoxRejected.TabIndex = 2;
            // 
            // btnSignOutManager
            // 
            this.btnSignOutManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignOutManager.Location = new System.Drawing.Point(262, 381);
            this.btnSignOutManager.Name = "btnSignOutManager";
            this.btnSignOutManager.Size = new System.Drawing.Size(120, 40);
            this.btnSignOutManager.TabIndex = 0;
            this.btnSignOutManager.Text = "Sign Out";
            this.btnSignOutManager.UseVisualStyleBackColor = true;
            this.btnSignOutManager.Click += new System.EventHandler(this.btnSignOutManager_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.Firebrick;
            this.buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReject.ForeColor = System.Drawing.Color.White;
            this.buttonReject.Location = new System.Drawing.Point(361, 309);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(120, 40);
            this.buttonReject.TabIndex = 10;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // AcademicManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 433);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.btnSignOutManager);
            this.Controls.Add(this.textBoxPending);
            this.Controls.Add(this.labelTotalPending);
            this.Controls.Add(this.textBoxRejected);
            this.Controls.Add(this.textBoxAccepted);
            this.Controls.Add(this.labelTotalRejected);
            this.Controls.Add(this.labelTotalAccepted);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTotalClaims);
            this.Controls.Add(this.textBoxTotalClaims);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonApprove);
            this.Name = "AcademicManagerDashboard";
            this.Text = "Academic Manager Dashboard";
            this.Load += new System.EventHandler(this.AcademicManagerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTotalClaims;
        private System.Windows.Forms.TextBox textBoxTotalClaims;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonApprove;
        private DataGridViewCheckBoxColumn checkBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label labelTotalAccepted;
        private TextBox textBoxAccepted;
        private Label labelTotalPending;
        private TextBox textBoxPending;
        private Label labelTotalRejected;
        private TextBox textBoxRejected;
        private Button btnSignOutManager;
        private Button buttonReject;
    }
}
