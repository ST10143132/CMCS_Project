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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTotalClaims = new System.Windows.Forms.Label();
            this.textBoxTotalClaims = new System.Windows.Forms.TextBox();
            this.dataGridViewClaims = new System.Windows.Forms.DataGridView();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClaims)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(98, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(257, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Coordinator Dashboard";
            // 
            // labelTotalClaims
            // 
            this.labelTotalClaims.AutoSize = true;
            this.labelTotalClaims.Location = new System.Drawing.Point(26, 69);
            this.labelTotalClaims.Name = "labelTotalClaims";
            this.labelTotalClaims.Size = new System.Drawing.Size(67, 13);
            this.labelTotalClaims.TabIndex = 1;
            this.labelTotalClaims.Text = "Total Claims:";
            // 
            // textBoxTotalClaims
            // 
            this.textBoxTotalClaims.Location = new System.Drawing.Point(103, 67);
            this.textBoxTotalClaims.Name = "textBoxTotalClaims";
            this.textBoxTotalClaims.ReadOnly = true;
            this.textBoxTotalClaims.Size = new System.Drawing.Size(86, 20);
            this.textBoxTotalClaims.TabIndex = 2;
            // 
            // dataGridViewClaims
            // 
            this.dataGridViewClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClaims.Location = new System.Drawing.Point(26, 104);
            this.dataGridViewClaims.Name = "dataGridViewClaims";
            this.dataGridViewClaims.Size = new System.Drawing.Size(386, 217);
            this.dataGridViewClaims.TabIndex = 3;
            // 
            // buttonApprove
            // 
            this.buttonApprove.Location = new System.Drawing.Point(103, 347);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(86, 35);
            this.buttonApprove.TabIndex = 4;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = true;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.Location = new System.Drawing.Point(223, 347);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(86, 35);
            this.buttonReject.TabIndex = 5;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // CoordinatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 433);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTotalClaims);
            this.Controls.Add(this.textBoxTotalClaims);
            this.Controls.Add(this.dataGridViewClaims);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.buttonReject);
            this.Name = "CoordinatorDashboard";
            this.Text = "Coordinator Dashboard";
            this.Load += new System.EventHandler(this.CoordinatorDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClaims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTotalClaims;
        private System.Windows.Forms.TextBox textBoxTotalClaims;
        private System.Windows.Forms.DataGridView dataGridViewClaims;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.Button buttonReject;
    }
}
