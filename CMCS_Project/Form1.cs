using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CMCS_Project
{
    public partial class Form1 : Form
    {
        // Default hourly rate
        private const decimal HourlyRate = 50.00m;

        // List to store submitted claims temporarily
        private List<Claim> claimsList = new List<Claim>();

        // Counter for "Claims Made"
        private int claimsMadeCounter = 0;

        // Store the uploaded document path
        private string uploadedDocumentPath = null;

        public Form1()
        {
            InitializeComponent();
            SetDefaultValues();
            UpdateClaimsMadeCounter();
        }

        // Set default values (e.g., Hourly Rate)
        private void SetDefaultValues()
        {
            textBoxHourlyRate.Text = HourlyRate.ToString("C2"); // Display in currency format
        }

        // Event handler for "View Claims" button
        private void buttonViewClaims_Click(object sender, EventArgs e)
        {
            if (claimsList.Count == 0)
            {
                MessageBox.Show("No claims have been made yet.", "View Claims",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Build the claims report
            string claimsReport = "Submitted Claims:\n\n";
            foreach (var claim in claimsList)
            {
                claimsReport += $"ClaimID: {claim.ClaimID}\n" +
                                $"Hours Worked: {claim.HoursWorked}\n" +
                                $"Status: {claim.Status}\n\n";
            }

            // Display the claims report in a message box
            MessageBox.Show(claimsReport, "View Claims", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for "Browse" button to upload a document
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                uploadedDocumentPath = UploadDocument();
                if (uploadedDocumentPath != null)
                {
                    MessageBox.Show($"Document selected: {Path.GetFileName(uploadedDocumentPath)}",
                                    "Document Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while uploading the document: {ex.Message}",
                                "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for "Submit" button
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxHoursWorked.Text) ||
                    !decimal.TryParse(textBoxHoursWorked.Text, out decimal hoursWorked))
                {
                    MessageBox.Show("Please enter a valid number for hours worked.",
                                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(uploadedDocumentPath))
                {
                    MessageBox.Show("Please upload a supporting document before submitting.",
                                    "Upload Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newClaim = new Claim
                {
                    ClaimID = Guid.NewGuid().ToString(),
                    HoursWorked = hoursWorked,
                    Status = "Pending"
                };
                claimsList.Add(newClaim);

                claimsMadeCounter++;
                UpdateClaimsMadeCounter();

                MessageBox.Show($"Claim submitted successfully!\nHours Worked: {hoursWorked}\nDocument: {Path.GetFileName(uploadedDocumentPath)}",
                                "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxHoursWorked.Text = "";
                uploadedDocumentPath = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Submission Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Upload a document with type and size restrictions
        private string UploadDocument()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "PDF Files|*.pdf|Word Files|*.docx|Excel Files|*.xlsx",
                    Title = "Select a Supporting Document"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    FileInfo fileInfo = new FileInfo(selectedFilePath);

                    string[] allowedExtensions = { ".pdf", ".docx", ".xlsx" };
                    if (!Array.Exists(allowedExtensions, ext => ext == fileInfo.Extension.ToLower()))
                    {
                        MessageBox.Show("Invalid file type. Please upload a .pdf, .docx, or .xlsx file.",
                                        "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }

                    if (fileInfo.Length > 5 * 1024 * 1024)
                    {
                        MessageBox.Show("The selected file exceeds the size limit of 5MB.",
                                        "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }

                    return selectedFilePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while uploading the document: {ex.Message}",
                                "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void UpdateClaimsMadeCounter()
        {
            textBoxClaimsMade.Text = claimsMadeCounter.ToString();
        }

        private void btnSignOutLecturer_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Claim
    {
        public string ClaimID { get; set; }
        public decimal HoursWorked { get; set; }
        public string Status { get; set; }
    }
}
