﻿using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MyInv
{
    public partial class frmLogin : Form
    {/*
        private SHA256Managed hashAlgorithm= new SHA256Managed();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmSignUp().ShowDialog();
            try
            {
                this.userTableAdapter.Fill(this.hiveDropDataSet.User);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txt_Leave(object sender, EventArgs e)
        {
            isValidEmail();
        }
        public bool isValidEmail()
        {
            if (userTableAdapter.FindByEmail(txtEmail.Text).HasValue)
            {
                lblEmailNotFound.Visible = false;
                return true;
            }
            else lblEmailNotFound.Visible = true;

            return false;
        }
        public bool isValidPassword() 
        {
            if (isValidEmail())
            {
                DataRow userRow = hiveDropDataSet.User.Select($"Email = '{txtEmail.Text}'")[0];


                // Get the user's entered password from the login form
                string enteredPassword = txtPassword.Text;

                // Retrieve the stored hashed password and salt from the database
                string storedHashedPasswordString = userRow[3].ToString(); //GetStoredHashedPasswordFromDatabase();
                string storedSaltString = userRow[6].ToString();//GetStoredSaltFromDatabase()

                // Combine the stored salt and entered password
                string saltedEnteredPassword = storedSaltString + enteredPassword;

                // Compute the hash of the salted entered password
                byte[] hashedEnteredPassword = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(saltedEnteredPassword));

                // Convert the hashed entered password to a string for comparison
                string hashedEnteredPasswordString = Convert.ToBase64String(hashedEnteredPassword);

                // Compare the stored hashed password and the hashed entered password
                if (hashedEnteredPasswordString != storedHashedPasswordString)
                {   // Passwords don't match, user authentication failed
                    // Display an error message or take appropriate action
                    lblWrongPassword.Visible = true;
                    return false;
                }
                else
                {
                    // Passwords match, user is authenticated
                    // Proceed with the login process
                    lblWrongPassword.Visible = false;
                    return true;
                }

            } return false;
            
        } 
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isValidPassword())
            {
                MainDark frm = new MainDark();
                frm.UserEmail = txtEmail.Text;
                frm.Show();
                this.Hide();
            }
        }
        private void frmLogin_Closing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.Fill(this.hiveDropDataSet.User);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/
    }
}
