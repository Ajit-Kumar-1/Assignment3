using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        // Literal value - correct password
        const string PASSWORD_VALUE = "ShowMeTheMoney";

        // Literal value - limit for number of failed attempts to enter password
        const int PASSWORD_FAILED_ATTEMPTS_LIMIT = 4;

        // Literal values - wrong password
        const string WRONG_PASSWORD_MESSAGE = "Wrong Password";
        const string TOO_MANY_FAILED_ATTEMPTS_MESSAGE = "Too many failed attempts";
        const string LOCKED_OUT_MESSAGE = "Locked out";

        // Variable to keep track of number of failed attempts to enter password
        int passwordAttemptsCounter = 0;

        // Function to check is password is correct
        Boolean isPasswordCorrect(String enteredPassword) => enteredPassword == PASSWORD_VALUE;

        public Form1()
        {
            InitializeComponent();
        }

        // Method triggered on clicking the "Proceed" button on the first screen
        private void passwordEntryButton_Click(object sender, EventArgs e)
        {
            // Obtain entered password
            String enteredPassword = passwordEntryTextBox.Text;

            // Check if entered password is correct
            if (isPasswordCorrect(enteredPassword))
            {
                // If so, proceed to the next screen
                passwordEntryPanel.Hide();
            }
            else
            {
                // Update counter for number of failed password entry attempts
                passwordAttemptsCounter++;
                // Check if we are within the limit for failed password attempts
                if (passwordAttemptsCounter < PASSWORD_FAILED_ATTEMPTS_LIMIT)
                    // Show message indicating that a wrong password is entered
                    MessageBox.Show(WRONG_PASSWORD_MESSAGE);
                else
                {
                    // Show message indicating that too many failed attempts have occured
                    DialogResult result =
                    MessageBox.Show(TOO_MANY_FAILED_ATTEMPTS_MESSAGE, LOCKED_OUT_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Then exit the application
                    if (result == DialogResult.OK)
                        Application.Exit();
                }

            }
        }

        private void passwordEntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordEntryButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

    }

}
