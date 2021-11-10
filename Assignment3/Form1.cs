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
        const decimal BAND_1_TERM_1_YEARS = 0.005000M;
        const decimal BAND_1_TERM_3_YEARS = 0.006250M;
        const decimal BAND_1_TERM_5_YEARS = 0.007125M;
        const decimal BAND_1_TERM_10_YEARS = 0.011250M;
        const decimal BAND_2_TERM_1_YEARS = 0.006000M;
        const decimal BAND_2_TERM_3_YEARS = 0.007250M;
        const decimal BAND_2_TERM_5_YEARS = 0.008125M;
        const decimal BAND_2_TERM_10_YEARS = 0.012500M;

        // Cut-off for higher investment rate
        int BAND_2_CUTOFF = 100000;

        // Term durations
        const int TERM_1_YEARS = 1;
        const int TERM_3_YEARS = 3;
        const int TERM_5_YEARS = 5;
        const int TERM_10_YEARS = 10;

        // Literal values - bonus
        const decimal BONUS_CUTOFF = 1000000.00M;
        const int BONUS_MINIMUM_TERM_DURATION = 5;
        const decimal BONUS_AMOUNT = 25000.00M;

        // Variable to keep track of number of failed attempts to enter password
        int passwordAttemptsCounter = 0;

        // Variables to keep track of investment details
        decimal investment = 0.00M;
        decimal finalBalance = 0.00M;
        decimal finalBalanceFor1Years = 0.00M;
        decimal finalBalanceFor3Years = 0.00M;
        decimal finalBalanceFor5Years = 0.00M;
        decimal finalBalanceFor10Years = 0.00M;
        decimal interestRate = BAND_1_TERM_10_YEARS;
        decimal interestRateFor1Years = BAND_1_TERM_1_YEARS;
        decimal interestRateFor3Years = BAND_1_TERM_3_YEARS;
        decimal interestRateFor5Years = BAND_1_TERM_5_YEARS;
        decimal interestRateFor10Years = BAND_1_TERM_10_YEARS;
        int termDuration = TERM_1_YEARS;

        // Variables to keep track of investor details
        string reference = "12345678";
        string name = "";
        string email = "";
        string phone = "";

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
                    MessageBox.Show(TOO_MANY_FAILED_ATTEMPTS_MESSAGE, 
                    LOCKED_OUT_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Method to compute balance after compound interest
        decimal computeBalance(decimal investment, int term, decimal interest) => 
            investment * ((decimal)Math.Pow((1 + Decimal.ToDouble(interest)), (term * 12)));

        // Method to generate applicable bonus amount
        decimal generateBonus(decimal investment, int term) =>
            (investment > BONUS_CUTOFF && term >= BONUS_MINIMUM_TERM_DURATION) ? BONUS_AMOUNT : 0;

        // Method called on pressing the "Display" button 
        private void displayButton_Click(object sender, EventArgs e)
        {
            // Obtain entered investment amount
            investment = int.Parse(investmentAmountTextBox.Text);

            // Show interest rates and final balance
            investmentDetailsGroupBox.Show();

            // Check if the investment amount qualifies for the higher interest rate
            if (investment >= BAND_2_CUTOFF)
            {
                // If so, apply the higher interest rate
                interestRateFor1Years = BAND_2_TERM_1_YEARS;
                interestRateFor3Years = BAND_2_TERM_3_YEARS;
                interestRateFor5Years = BAND_2_TERM_5_YEARS;
                interestRateFor10Years = BAND_2_TERM_10_YEARS;
            }
            else
            {
                // Otherwise, apply the lower interest rate
                interestRateFor1Years = BAND_1_TERM_1_YEARS;
                interestRateFor3Years = BAND_1_TERM_3_YEARS;
                interestRateFor5Years = BAND_1_TERM_5_YEARS;
                interestRateFor10Years = BAND_1_TERM_10_YEARS;
            }

            // Calculate final balance for each term duration
            finalBalanceFor1Years = computeBalance(investment, TERM_1_YEARS, interestRateFor1Years);
            finalBalanceFor1Years += generateBonus(investment, TERM_1_YEARS);
            finalBalanceFor3Years = computeBalance(investment, TERM_3_YEARS, interestRateFor3Years);
            finalBalanceFor1Years += generateBonus(investment, TERM_3_YEARS);
            finalBalanceFor5Years = computeBalance(investment, TERM_5_YEARS, interestRateFor5Years);
            finalBalanceFor1Years += generateBonus(investment, TERM_5_YEARS);
            finalBalanceFor10Years = computeBalance(investment, TERM_10_YEARS, interestRateFor10Years);
            finalBalanceFor1Years += generateBonus(investment, TERM_10_YEARS);

            // Display final balance for each term duration
            finalBalance1YearLabel.Text = finalBalanceFor1Years.ToString("C");
            finalBalance3YearLabel.Text = finalBalanceFor3Years.ToString("C");
            finalBalance5YearLabel.Text = finalBalanceFor5Years.ToString("C");
            finalBalance10YearLabel.Text = finalBalanceFor10Years.ToString("C");

            // Display interest rates for each term duration
            interestRate1YearLabel.Text = interestRateFor1Years + "%";
            interestRate3YearLabel.Text = interestRateFor3Years + "%";
            interestRate5YearLabel.Text = interestRateFor5Years + "%";
            interestRate10YearLabel.Text = interestRateFor10Years + "%";

        }

        // Methods called on toggling radio buttons
        private void oneYearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            proceedButton.Show();
        }

        private void threeYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            proceedButton.Show();
        }

        private void fiveYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            proceedButton.Show();
        }

        private void tenYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            proceedButton.Show();
        }

        // Method called on pressing the "Proceed" button
        private void proceedButton_Click(object sender, EventArgs e)
        {
            // Variable to keep track of the selected term duration
            int checkedIndex = 0;

            // Set term duration based on selected radio button
            checkedIndex = oneYearRadioButton.Checked ? 0 :
                threeYearsRadioButton.Checked ? 1 :
                fiveYearsRadioButton.Checked ? 2 :
                tenYearsRadioButton.Checked ? 3 : 0;

            // Set interest rate and final balance based on selected term duration
            switch (checkedIndex)
            {
                case 0:
                    interestRate = interestRateFor1Years;
                    finalBalance = finalBalanceFor1Years;
                    break;
                case 1:
                    interestRate = interestRateFor3Years;
                    finalBalance = finalBalanceFor3Years;
                    break;
                case 2:
                    interestRate = interestRateFor5Years;
                    finalBalance = finalBalanceFor5Years;
                    break;
                case 3:
                    interestRate = interestRateFor10Years;
                    finalBalance = finalBalanceFor10Years;
                    break;
            }

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

        }

    }

}
