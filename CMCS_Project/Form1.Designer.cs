namespace CMCS_Project
{
    partial class Form1
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

        #region Windows Form Designer generated code

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
            this.btnSignOutLecturer = new System.Windows.Forms.Button();
            this.groupBoxSubmitClaim.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer Claim Submit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(57, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Claims Made:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(250, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hourly Rate:";
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Location = new System.Drawing.Point(120, 32);
            this.textBoxHoursWorked.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(91, 29);
            this.textBoxHoursWorked.TabIndex = 1;
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxHourlyRate.Location = new System.Drawing.Point(338, 65);
            this.textBoxHourlyRate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.ReadOnly = true;
            this.textBoxHourlyRate.Size = new System.Drawing.Size(91, 29);
            this.textBoxHourlyRate.TabIndex = 4;
            // 
            // textBoxClaimsMade
            // 
            this.textBoxClaimsMade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClaimsMade.Location = new System.Drawing.Point(150, 65);
            this.textBoxClaimsMade.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxClaimsMade.Name = "textBoxClaimsMade";
            this.textBoxClaimsMade.ReadOnly = true;
            this.textBoxClaimsMade.Size = new System.Drawing.Size(91, 29);
            this.textBoxClaimsMade.TabIndex = 2;
            // 
            // buttonViewClaims
            // 
            this.buttonViewClaims.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonViewClaims.Location = new System.Drawing.Point(172, 106);
            this.buttonViewClaims.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewClaims.Name = "buttonViewClaims";
            this.buttonViewClaims.Size = new System.Drawing.Size(112, 32);
            this.buttonViewClaims.TabIndex = 5;
            this.buttonViewClaims.Text = "View Claims";
            this.buttonViewClaims.UseVisualStyleBackColor = true;
            this.buttonViewClaims.Click += new System.EventHandler(this.buttonViewClaims_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(120, 65);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(90, 28);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.Location = new System.Drawing.Point(120, 106);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(90, 32);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupBoxSubmitClaim
            // 
            this.groupBoxSubmitClaim.Controls.Add(this.label4);
            this.groupBoxSubmitClaim.Controls.Add(this.textBoxHoursWorked);
            this.groupBoxSubmitClaim.Controls.Add(this.buttonBrowse);
            this.groupBoxSubmitClaim.Controls.Add(this.buttonSubmit);
            this.groupBoxSubmitClaim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBoxSubmitClaim.Location = new System.Drawing.Point(75, 154);
            this.groupBoxSubmitClaim.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSubmitClaim.Name = "groupBoxSubmitClaim";
            this.groupBoxSubmitClaim.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSubmitClaim.Size = new System.Drawing.Size(300, 146);
            this.groupBoxSubmitClaim.TabIndex = 6;
            this.groupBoxSubmitClaim.TabStop = false;
            this.groupBoxSubmitClaim.Text = "Submit Claim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hours Worked:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 2;
            // 
            // btnSignOutLecturer
            // 
            this.btnSignOutLecturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignOutLecturer.Location = new System.Drawing.Point(172, 309);
            this.btnSignOutLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOutLecturer.Name = "btnSignOutLecturer";
            this.btnSignOutLecturer.Size = new System.Drawing.Size(112, 32);
            this.btnSignOutLecturer.TabIndex = 7;
            this.btnSignOutLecturer.Text = "Sign Out";
            this.btnSignOutLecturer.UseVisualStyleBackColor = true;
            this.btnSignOutLecturer.Click += new System.EventHandler(this.btnSignOutLecturer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClaimsMade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.buttonViewClaims);
            this.Controls.Add(this.groupBoxSubmitClaim);
            this.Controls.Add(this.btnSignOutLecturer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer Claim Submission";
            this.groupBoxSubmitClaim.ResumeLayout(false);
            this.groupBoxSubmitClaim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnSignOutLecturer;
    }
}
