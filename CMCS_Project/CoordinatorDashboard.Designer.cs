using System.Windows.Forms;

namespace CMCS_Project
{
    partial class CoordinatorDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.buttonReject = new System.Windows.Forms.Button();
            this.labelTotalAccepted = new System.Windows.Forms.Label();
            this.labelTotalRejected = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelTotalPending = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(182, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(257, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Coordinator Dashboard";
            // 
            // labelTotalClaims
            // 
            this.labelTotalClaims.AutoSize = true;
            this.labelTotalClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalClaims.Location = new System.Drawing.Point(251, 56);
            this.labelTotalClaims.Name = "labelTotalClaims";
            this.labelTotalClaims.Size = new System.Drawing.Size(99, 20);
            this.labelTotalClaims.TabIndex = 1;
            this.labelTotalClaims.Text = "Total Claims:";
            // 
            // textBoxTotalClaims
            // 
            this.textBoxTotalClaims.Location = new System.Drawing.Point(265, 79);
            this.textBoxTotalClaims.Name = "textBoxTotalClaims";
            this.textBoxTotalClaims.ReadOnly = true;
            this.textBoxTotalClaims.Size = new System.Drawing.Size(57, 20);
            this.textBoxTotalClaims.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridView1.Location = new System.Drawing.Point(73, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.buttonApprove.ForeColor = System.Drawing.Color.White;
            this.buttonApprove.Location = new System.Drawing.Point(169, 314);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(100, 40);
            this.buttonApprove.TabIndex = 1;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = true;
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.Firebrick;
            this.buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReject.ForeColor = System.Drawing.Color.White;
            this.buttonReject.Location = new System.Drawing.Point(339, 314);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(100, 40);
            this.buttonReject.TabIndex = 2;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // labelTotalAccepted
            // 
            this.labelTotalAccepted.AutoSize = true;
            this.labelTotalAccepted.ForeColor = System.Drawing.Color.Green;
            this.labelTotalAccepted.Location = new System.Drawing.Point(120, 121);
            this.labelTotalAccepted.Name = "labelTotalAccepted";
            this.labelTotalAccepted.Size = new System.Drawing.Size(53, 13);
            this.labelTotalAccepted.TabIndex = 3;
            this.labelTotalAccepted.Text = "Accepted";
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(179, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(314, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 6;
            // 
            // labelTotalPending
            // 
            this.labelTotalPending.AutoSize = true;
            this.labelTotalPending.Location = new System.Drawing.Point(399, 120);
            this.labelTotalPending.Name = "labelTotalPending";
            this.labelTotalPending.Size = new System.Drawing.Size(46, 13);
            this.labelTotalPending.TabIndex = 7;
            this.labelTotalPending.Text = "Pending";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(452, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 8;
            // 
            // CoordinatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 433);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelTotalPending);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTotalRejected);
            this.Controls.Add(this.labelTotalAccepted);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTotalClaims);
            this.Controls.Add(this.textBoxTotalClaims);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.buttonReject);
            this.Name = "CoordinatorDashboard";
            this.Text = "Coordinator Dashboard";
            this.Load += new System.EventHandler(this.CoordinatorDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTotalClaims;
        private System.Windows.Forms.TextBox textBoxTotalClaims;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.Button buttonReject;
        private DataGridViewCheckBoxColumn checkBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label labelTotalAccepted;
        private Label labelTotalRejected;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelTotalPending;
        private TextBox textBox3;
    }
}
