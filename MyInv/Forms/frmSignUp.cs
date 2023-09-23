using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MyInv
{
    public partial class frmSignUp : Form
    {/*
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            if (sender == txtEmail)
                isValidEmail();
            else if (sender == txtRepassword)
                isValidPassword();
            else isValidUsername();
        }
        public bool isValidEmail()
        {
            try
            {
                MailAddress ma = new MailAddress(txtEmail.Text);
                lblEmailErr.Visible = false;
            }
            catch
            {
                lblEmailErr.Visible = true;
                return false;
            }
            if (userTableAdapter.FindByEmail(txtEmail.Text).HasValue)
            {
                lblEmailAlreadyRegistered.Visible = true;
                return false;
            }
            else lblEmailAlreadyRegistered.Visible = false;

            return true;
        }
        public bool isValidUsername()
        {
            if (userTableAdapter.FindByUsername(txtUsername.Text).HasValue)
            {
                lblUsernameAlreadyRegistered.Visible = true;
                return false;
            }
            else lblUsernameAlreadyRegistered.Visible = false;

            return true;
        }
        public bool isValidPassword()
        {
            if (txtPassword.Text.Equals(txtRepassword.Text))
            {
                lblPasswordMismatch.Visible = false;
                return true;
            }
            lblPasswordMismatch.Visible = true;
            return false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (isValidEmail() && isValidPassword()&&isValidUsername())
            {
                byte[] salt = new byte[16];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(salt);
                }

                // Convert the salt to a string for storage in the database
                string saltString = Convert.ToBase64String(salt);

                // Get the user's password from the signup form
                string password = txtPassword.Text;

                // Combine the salt and password
                string saltedPassword = saltString + password;

                // Create a new instance of the hashing algorithm (e.g., bcrypt)
                var hashAlgorithm = new SHA256Managed();

                // Compute the hash of the salted password
                byte[] hashedPassword = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));

                // Convert the hashed password to a string for storage in the database
                string hashedPasswordString = Convert.ToBase64String(hashedPassword);

                // Store the hashedPasswordString and saltString in the database
                // along with other user details
                DataRow newUserRow = hiveDropDataSet.Tables["User"].NewRow();
                newUserRow["Email"] = txtEmail.Text;
                newUserRow["Username"] = txtUsername.Text;
                newUserRow["DateOfBirth"] = birthDate.Value;
                newUserRow["Password"] = hashedPasswordString;
                newUserRow["Salt"] = saltString;

                // Add the new row to the dataset
                hiveDropDataSet.Tables["User"].Rows.Add(newUserRow);

                // Commit the changes and add the new user
                bsUsers.EndEdit();
                try
                {
                    this.userTableAdapter.Update(this.hiveDropDataSet.User);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Hide();

            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.Fill(this.hiveDropDataSet.User);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }*/
    }
}
