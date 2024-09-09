namespace CMCS_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxClaimsMade = new System.Windows.Forms.TextBox();
            this.buttonViewClaims = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxSubmitClaim = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxSubmitClaim.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(106, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer Claim Submit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Claims Made:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hourly Rate:";
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Location = new System.Drawing.Point(137, 41);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(86, 20);
            this.textBoxHoursWorked.TabIndex = 1;
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Location = new System.Drawing.Point(300, 75);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(86, 20);
            this.textBoxHourlyRate.TabIndex = 4;
            // 
            // textBoxClaimsMade
            // 
            this.textBoxClaimsMade.Location = new System.Drawing.Point(111, 75);
            this.textBoxClaimsMade.Name = "textBoxClaimsMade";
            this.textBoxClaimsMade.Size = new System.Drawing.Size(86, 20);
            this.textBoxClaimsMade.TabIndex = 2;
            // 
            // buttonViewClaims
            // 
            this.buttonViewClaims.Location = new System.Drawing.Point(69, 113);
            this.buttonViewClaims.Name = "buttonViewClaims";
            this.buttonViewClaims.Size = new System.Drawing.Size(86, 35);
            this.buttonViewClaims.TabIndex = 5;
            this.buttonViewClaims.Text = "View Claims";
            this.buttonViewClaims.UseVisualStyleBackColor = true;
            this.buttonViewClaims.Click += new System.EventHandler(this.buttonViewClaims_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(137, 104);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(86, 26);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(137, 139);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(86, 26);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupBoxSubmitClaim
            // 
            this.groupBoxSubmitClaim.Controls.Add(this.label4);
            this.groupBoxSubmitClaim.Controls.Add(this.textBoxHoursWorked);
            this.groupBoxSubmitClaim.Controls.Add(this.label5);
            this.groupBoxSubmitClaim.Controls.Add(this.buttonBrowse);
            this.groupBoxSubmitClaim.Controls.Add(this.buttonSubmit);
            this.groupBoxSubmitClaim.Location = new System.Drawing.Point(34, 173);
            this.groupBoxSubmitClaim.Name = "groupBoxSubmitClaim";
            this.groupBoxSubmitClaim.Size = new System.Drawing.Size(360, 173);
            this.groupBoxSubmitClaim.TabIndex = 6;
            this.groupBoxSubmitClaim.TabStop = false;
            this.groupBoxSubmitClaim.Text = "Submit Claim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hours Worked:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Upload Supporting Documents:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClaimsMade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.buttonViewClaims);
            this.Controls.Add(this.groupBoxSubmitClaim);
            this.Name = "Form1";
            this.Text = "Lecturer Claim Submission";
            this.groupBoxSubmitClaim.ResumeLayout(false);
            this.groupBoxSubmitClaim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClaimsMade;
        private System.Windows.Forms.TextBox textBoxHourlyRate;
        private System.Windows.Forms.Button buttonViewClaims;
        private System.Windows.Forms.GroupBox groupBoxSubmitClaim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHoursWorked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonSubmit;
    }
}
