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
        // Correct password
        const string PASSWORD_VALUE = "ShowMeTheMoney";

        // Limit for number of failed attempts to enter password
        const int PASSWORD_FAILED_ATTEMPTS_LIMIT = 4;

        // Error messages for wrong password
        const string WRONG_PASSWORD_MESSAGE = "Wrong Password";
        const string TOO_MANY_FAILED_ATTEMPTS_MESSAGE = "Too many failed attempts";
        const string LOCKED_OUT_MESSAGE = "Locked out";

        // Interest rates
        const double BAND_1_TERM_1_YEARS = 0.005000D;
        const double BAND_1_TERM_3_YEARS = 0.006250D;
        const double BAND_1_TERM_5_YEARS = 0.007125D;
        const double BAND_1_TERM_10_YEARS = 0.011250D;
        const double BAND_2_TERM_1_YEARS = 0.006000D;
        const double BAND_2_TERM_3_YEARS = 0.007250D;
        const double BAND_2_TERM_5_YEARS = 0.008125D;
        const double BAND_2_TERM_10_YEARS = 0.012500D;

        // Cut-off for higher investment rate
        int BAND_2_CUTOFF = 100000;

        // Term durations
        const int TERM_1_YEARS = 1;
        const int TERM_3_YEARS = 3;
        const int TERM_5_YEARS = 5;
        const int TERM_10_YEARS = 10;

        // Cutoff for bonus
        const decimal BONUS_CUTOFF = 1000000.00M;
        const int BONUS_MINIMUM_TERM_DURATION = 5;

        // Variable to keep track of number of failed attempts to enter password
        int passwordAttemptsCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Function for checking the entered password and acting according to its validity
        void checkPassword()
        {
            // Obtain entered password
            String enteredPassword = passwordEntryTextBox.Text;

            // Check if entered password is correct
            if (enteredPassword == PASSWORD_VALUE)
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

        // Method called on pressing the "Proceed" button on the first screen
        private void passwordEntryButton_Click(object sender, EventArgs e)
        {
            // Run password check
            checkPassword();
        }

        // Method called whenever a key is pressed while the text box has focus
        private void passwordEntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // If so, perform the password check
                checkPassword();
            }
        }

        // Method to compute final balance
        double computeBalance(double investment, int term, double interest) => 
            investment * Math.Pow((1 + interest), (term * 12));

        // Method called on pressing the "Display" button 
        private void displayButton_Click(object sender, EventArgs e)
        {
            // Obtain entered investment amount
            double investment = int.Parse(investmentAmountTextBox.Text);
            // Check if the investment amount qualifies for the higher interest rate
            // Accordingly, display interest rates, calculate and display final balance
            if (investment >= BAND_2_CUTOFF)
            {
                interestRate1YearLabel.Text = BAND_2_TERM_1_YEARS + "%";
                interestRate3YearLabel.Text = BAND_2_TERM_3_YEARS + "%";
                interestRate5YearLabel.Text = BAND_2_TERM_5_YEARS + "%";
                interestRate10YearLabel.Text = BAND_2_TERM_10_YEARS + "%";
                finalBalance1YearLabel.Text = computeBalance(investment, TERM_1_YEARS, BAND_2_TERM_1_YEARS).ToString("C");
                finalBalance3YearLabel.Text = computeBalance(investment, TERM_3_YEARS, BAND_2_TERM_3_YEARS).ToString("C");
                finalBalance5YearLabel.Text = computeBalance(investment, TERM_5_YEARS, BAND_2_TERM_5_YEARS).ToString("C");
                finalBalance10YearLabel.Text = computeBalance(investment, TERM_10_YEARS, BAND_2_TERM_10_YEARS).ToString("C");
            }
            else
            {
                interestRate1YearLabel.Text = BAND_1_TERM_1_YEARS + "%";
                interestRate3YearLabel.Text = BAND_1_TERM_3_YEARS + "%";
                interestRate5YearLabel.Text = BAND_1_TERM_5_YEARS + "%";
                interestRate10YearLabel.Text = BAND_1_TERM_10_YEARS + "%";
                finalBalance1YearLabel.Text = computeBalance(investment, TERM_1_YEARS, BAND_1_TERM_1_YEARS).ToString("C");
                finalBalance3YearLabel.Text = computeBalance(investment, TERM_3_YEARS, BAND_1_TERM_3_YEARS).ToString("C");
                finalBalance5YearLabel.Text = computeBalance(investment, TERM_5_YEARS, BAND_1_TERM_5_YEARS).ToString("C");
                finalBalance10YearLabel.Text = computeBalance(investment, TERM_10_YEARS, BAND_1_TERM_10_YEARS).ToString("C");
            }

        }
    }

}
