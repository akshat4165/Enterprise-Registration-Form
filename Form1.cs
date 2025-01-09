using System;
using System.Windows.Forms;

namespace ERPRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtDOB.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtDepartment.Text) ||
                string.IsNullOrWhiteSpace(txtRole.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeID.Text) ||
                string.IsNullOrWhiteSpace(txtJoiningDate.Text) ||
                string.IsNullOrWhiteSpace(txtAccountNumber.Text) ||
                string.IsNullOrWhiteSpace(txtIFSC.Text) ||
                string.IsNullOrWhiteSpace(txtPAN.Text) ||
                string.IsNullOrWhiteSpace(txtAadhaar.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtSecurityQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtEmergencyContact.Text) ||
                string.IsNullOrWhiteSpace(txtHobbies.Text) ||
                string.IsNullOrWhiteSpace(txtBloodGroup.Text) ||
                cmbMaritalStatus.SelectedIndex == -1) // Ensure Marital Status is selected
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Email Validation
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Phone number validation
            if (txtPhone.Text.Length != 10 || !long.TryParse(txtPhone.Text, out _))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // PAN number validation (length should be 10)
            if (txtPAN.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid PAN number (10 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aadhaar number validation (length should be 12)
            if (txtAadhaar.Text.Length != 12 || !long.TryParse(txtAadhaar.Text, out _))
            {
                MessageBox.Show("Please enter a valid Aadhaar number (12 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display the entered information
            string message = $"Name: {txtName.Text}\n" +
                             $"Email: {txtEmail.Text}\n" +
                             $"Phone: {txtPhone.Text}\n" +
                             $"DOB: {txtDOB.Text}\n" +
                             $"Address: {txtAddress.Text}\n" +
                             $"Department: {txtDepartment.Text}\n" +
                             $"Role: {txtRole.Text}\n" +
                             $"Employee ID: {txtEmployeeID.Text}\n" +
                             $"Joining Date: {txtJoiningDate.Text}\n" +
                             $"Bank Account No: {txtAccountNumber.Text}\n" +
                             $"IFSC: {txtIFSC.Text}\n" +
                             $"PAN: {txtPAN.Text}\n" +
                             $"Aadhaar: {txtAadhaar.Text}\n" +
                             $"Username: {txtUsername.Text}\n" +
                             $"Password: {txtPassword.Text}\n" +
                             $"Security Question: {txtSecurityQuestion.Text}\n" +
                             $"Emergency Contact: {txtEmergencyContact.Text}\n" +
                             $"Hobbies: {txtHobbies.Text}\n" +
                             $"Blood Group: {txtBloodGroup.Text}\n" +
                             $"Marital Status: {cmbMaritalStatus.SelectedItem}";

            MessageBox.Show(message, "Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void lblJoiningDate_Click(object sender, EventArgs e)
        {

        }

        private void lblBloodGroup_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblAccountNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void lblIFSC_Click(object sender, EventArgs e)
        {

        }

        private void lblPAN_Click(object sender, EventArgs e)
        {

        }

        private void lblAadhaar_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblSecurityQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblEmergencyContact_Click(object sender, EventArgs e)
        {

        }

        private void lblHobbies_Click(object sender, EventArgs e)
        {

        }

        private void lblMaritalStatus_Click(object sender, EventArgs e)
        {

        }
    }
}