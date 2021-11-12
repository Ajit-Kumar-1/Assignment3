using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        
        // Default form height
        const int MIN_HEIGHT = 508;

        // Fully expanded form height
        const int MAX_HEIGHT = 1518;        
        
        // Correct password
        const string PASSWORD_VALUE = "ShowMeTheMoney#";

        // Limit for number of failed attempts to enter password
        const int PASSWORD_FAILED_ATTEMPTS_LIMIT = 4;

        // File name where transaction data is stored
        const string DATA_FILE_NAME = "Invest4UTransactions.txt";

        // Format for displaying date
        const string DATE_FORMAT = "dd/MM/yyyy";

        // Messages displayed on entering the wrong password
        const string WRONG_PASSWORD_MESSAGE_PART_1 = "Wrong Password. You have ";
        const string WRONG_PASSWORD_MESSAGE_PART_2 = " more attempt(s).";

        // Message displayed on being locked out of the application
        const string TOO_MANY_FAILED_ATTEMPTS_MESSAGE = "Too many failed attempts";
        const string LOCKED_OUT_MESSAGE = "Locked out";

        // Heading for the message box for errors
        const string ERROR_MESSAGE = "Error";

        // Message displayed when name is not entered
        const string ENTER_NAME_MESSAGE = "Please enter your full name";

        // Message displayed when email is not entered
        const string ENTER_EMAIL_MESSAGE = "Please enter your email address";

        // Message displayed when phone number is not entered
        const string ENTER_PHONE_MESSAGE = "Please enter your phone number";

        // Message displayed when an invalid email address is entered
        const string ENTER_VALID_EMAIL_MESSAGE = "Please enter a valid email address";

        // Message displayed when an invalid phone number is entered
        const string ENTER_VALID_PHONE_MESSAGE = "Please enter a valid phone number";

        // Message displayed when an invalid value is entered for investment
        const string ENTER_VALID_AMOUNT = "Please enter a numeric value for investment amount";

        // Message displayed when a negative investment amount is entered
        const string ENTER_NON_NEGATIVE_AMOUNT = "Please enter a non-negative amount for investment";

        // Heading for the message box displayed when requesting final confirmation
        const string CONFIRM_INVESTMENT_MESSAGE = "Confirm Investment";

        // Message displayed when requesting final confirmation
        const string ARE_YOU_SURE_MESSAGE = "Would you like to confirm this investment?";

        // Message displayed confirming transaction
        const string TRANSACTION_CONFIRMED_MESSAGE = "Transaction confirmed!";

        // Heading for alert messages
        const string ALERT_MESSAGE = "Alert";

        // Message prompting the user to enter a value to search for
        const string ENTER_SEARCH_TERM_MESSAGE = "Enter a term to search";

        // Literal value for displaying years of investment term duration
        const string YEAR_SUFFIX = " Year(s)";

        // Specify the characters used to make up the random string
        const string characterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        // Tooltip message for the "Display" button
        const string DISPLAY_TOOLTIP = "Display term duration options, and interest rates and final balances for each term duration";

        // Tooltip message for the "Summary" button
        const string SUMMARY_TOOLTIP = "Show a summary of all transactions saved on file";

        // Tooltip message for the "Clear" button
        const string CLEAR_TOOLTIP = "Clear the form and set values to default";

        // Tooltip message for the "Exit" button
        const string EXIT_TOOLTIP = "Quit application";

        // Tooltip message for the "Search" button
        const string SEARCH_TOOLTIP = "Search file for transactions matching the provided term";

        // Tooltip message for the "By transaction ID" radio button
        const string BY_ID_TOOLTIP = "Search for a transaction by providing its transaction ID";

        // Tooltip message for the "By email" radio button
        const string BY_EMAIL_TOOLTIP = "Search for transactions by providing the email address registered with them";

        // Tooltip message for the "By date" radio button
        const string BY_DATE_TOOLTIP = "Search for transactions by providing the date of their occurrence";

        // Tooltip message for the "Proceed" button
        const string PROCEED_TOOLTIP = "Proceed to fill in the investor's name, email and phone number";

        // Tooltip message for the "Submit" button
        const string SUBMIT_TOOLTIP = "Submit given details for a pre-confirmation summary";

        // Tooltip message for the "Confirm" button
        const string CONFIRM_TOOLTIP = "Seek final confirmation";

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
        int termDuration = 0;

        // Variables to keep track of investor details
        string transactionID = "";
        string name = "";
        string email = "";
        string phone = "";

        public Form1()
        {
            InitializeComponent();

            // Set a tooltip for the "Display" button
            toolTip.SetToolTip(displayButton, DISPLAY_TOOLTIP);

            // Set a tooltip for the "Summary" button
            toolTip.SetToolTip(summaryButton, SUMMARY_TOOLTIP);

            // Set a tooltip for the "Clear" button
            toolTip.SetToolTip(clearButton, CLEAR_TOOLTIP);

            // Set a tooltip for the "Exit" button
            toolTip.SetToolTip(exitButton, EXIT_TOOLTIP);

            // Set a tooltip for the "Search" button
            toolTip.SetToolTip(searchButton, SEARCH_TOOLTIP);

            // Set a tooltip for the "Proceed" button
            toolTip.SetToolTip(proceedButton, PROCEED_TOOLTIP);

            // Set a tooltip for the "Submit" button
            toolTip.SetToolTip(submitButton, SUBMIT_TOOLTIP);

            // Set a tootip for the "Confirm" button
            toolTip.SetToolTip(confirmButton, CONFIRM_TOOLTIP);

            // Set a tooltip for the "By Transaction ID" radio button
            toolTip.SetToolTip(searchIDRadioButton, BY_ID_TOOLTIP);

            // Set a tooltip for the "By email" radio button
            toolTip.SetToolTip(searchEmailRadioButton, BY_EMAIL_TOOLTIP);

            // Set a tooltip for the "By date" radio button
            toolTip.SetToolTip(searchDateRadioButton, BY_DATE_TOOLTIP);

        }

        // Function for checking the entered password and acting according to its validity
        private void checkPassword()
        {
            // Obtain entered password
            String enteredPassword = passwordEntryTextBox.Text;

            // Check if entered password is correct
            if (enteredPassword == PASSWORD_VALUE)
            {
                // If so, proceed to the next screen
                passwordEntryPanel.Hide();
                investmentPanel.Show();

            }
            else
            {
                // Update counter for number of failed password entry attempts
                passwordAttemptsCounter++;
                // Check if we are within the limit for failed password attempts
                if (passwordAttemptsCounter < PASSWORD_FAILED_ATTEMPTS_LIMIT)
                {
                    // Display message indicating that a wrong password is entered
                    string mainMessage = WRONG_PASSWORD_MESSAGE_PART_1 +
                        (PASSWORD_FAILED_ATTEMPTS_LIMIT - passwordAttemptsCounter) +
                        WRONG_PASSWORD_MESSAGE_PART_2;
                    DialogResult result = MessageBox.Show(mainMessage, ERROR_MESSAGE, 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                        // Return focus to the password text field
                        passwordEntryTextBox.Focus();
                }
                else
                {
                    // Display message indicating that too many failed attempts have occured
                    DialogResult result =
                    MessageBox.Show(TOO_MANY_FAILED_ATTEMPTS_MESSAGE,
                    LOCKED_OUT_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Then exit the application
                    if (result == DialogResult.OK)
                        Application.Exit();
                }
            }
        }

        // Event handler called on pressing the "Proceed" button on the first screen
        private void passwordEntryButton_Click(object sender, EventArgs e)
        {
            // Run password check
            checkPassword();
        }

        // Event handler called whenever a key is pressed while the text box has focus
        private void passwordEntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // If so, perform the password check
                checkPassword();
            }
        }

        // Method to display interest rates and final balance for given investment amount
        private void displayRates()
        {
            
            try
            {
                // Obtain entered investment amount
                investment = Math.Round(decimal.Parse(investmentAmountTextBox.Text), 2);

                // Check if the value entered is negative
                if(investment < 0)
                {
                    // Display message requesting entry of a non-negative investment amount
                    DialogResult result = MessageBox.Show(ENTER_NON_NEGATIVE_AMOUNT,
                        ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Return focus to the investment amount text field
                    if (result == DialogResult.OK)
                        // Pass on focus to the investment amount input field
                        investmentAmountTextBox.Focus();
                    return;
                }
            }
            catch
            {
                // Display message requesting entry of a valid investment amount
                DialogResult result = MessageBox.Show(ENTER_VALID_AMOUNT,
                    ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Return focus to the investment amount text field
                if (result == DialogResult.OK)
                    // Pass on focus to the investment amount input field
                    investmentAmountTextBox.Focus();
                return;
            }

            // Check if the investment amount qualifies for the higher interest rate
            if (investment >= BAND_2_CUTOFF)
            {
                // If so, apply the higher interest rate for each term duration
                interestRateFor1Years = BAND_2_TERM_1_YEARS;
                interestRateFor3Years = BAND_2_TERM_3_YEARS;
                interestRateFor5Years = BAND_2_TERM_5_YEARS;
                interestRateFor10Years = BAND_2_TERM_10_YEARS;
            }
            else
            {
                // Otherwise, apply the lower interest rate for each term duration
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

            // Expand form
            this.Height = MAX_HEIGHT;

            // Display interest rates and final balance
            investmentDetailsGroupBox.Enabled = true;
            investmentDetailsGroupBox.Show();

            // Pass on focus
            term10YearsRadioButton.Focus();
        }

        // Method to compute balance after compound interest
        private decimal computeBalance(decimal investment, int term, decimal interest) => 
            investment * ((decimal)Math.Pow((1 + Decimal.ToDouble(interest)), (term * 12)));

        // Method to generate applicable bonus amount
        private decimal generateBonus(decimal investment, int term) =>
            (investment > BONUS_CUTOFF && term >= BONUS_MINIMUM_TERM_DURATION) ? BONUS_AMOUNT : 0;

        // Event handler called on pressing the "Display" button 
        private void displayButton_Click(object sender, EventArgs e)
        {
            // Display interest rates and final balance values for the given investment amount
            displayRates();
        }

        // Method to generate a random string
        private string randomString()
        {
            // Initialize the random string
            var randomizedString = "";

            var random = new Random();

            // Loop 8 times
            for (int i = 0; i < 8; i++)
                // Add a random character each time
                randomizedString += characterSet[random.Next(8)];

            return randomizedString;
        }

        // Method to generate a unique random string
        private void generateTransactionID()
        {
            // Generate a random candidate string for the Transaction ID
            string candidate = randomString();
            try
            {
                // Open file
                StreamReader inputFile = File.OpenText(DATA_FILE_NAME);

                do
                {
                    // Obtain the first transacation ID from file, if any
                    string currentID = inputFile.ReadLine();

                    // Check if it's the same as the one just generated
                    if (currentID == candidate)
                    {
                        generateTransactionID();
                        return;
                    }
                    else
                        // Pass over the rest of the current transaction's details
                        for (int index = 0; index < 7; index++)
                            inputFile.ReadLine();
                }
                while (inputFile.ReadLine() != null);

                // Close file
                inputFile.Close();
            }
            catch { }

            // Save the candidate string as the transaction ID
            transactionID = candidate;
        }

        // Method to be called when toggling radio buttons
        private void toggleRadioButton()
        {
            // Unhide the proceed button
            proceedButton.Show();

            // Grey out the investor details section depending on whether the term duration was changed
            toggleInvestorDetailsVisibility();
        }

        // Event handlers called on toggling radio buttons
        private void oneYearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toggleRadioButton();
        }

        private void threeYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toggleRadioButton();
        }

        private void fiveYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toggleRadioButton();
        }

        private void tenYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toggleRadioButton();
        }

        // Method for proceeding from term selection to investor information
        private void proceedToInvestorInformation()
        {
            // Variable to keep track of the selected term duration
            int checkedIndex = 0;

            // Set term duration based on selected radio button
            checkedIndex = term1YearsRadioButton.Checked ? 0 :
                term3YearsRadioButton.Checked ? 1 :
                term5YearsRadioButton.Checked ? 2 :
                term10YearsRadioButton.Checked ? 3 : 0;

            // Set interest rate and final balance based on selected term duration
            switch (checkedIndex)
            {
                case 0:
                    termDuration = TERM_1_YEARS;
                    interestRate = interestRateFor1Years;
                    finalBalance = finalBalanceFor1Years;
                    break;
                case 1:
                    termDuration = TERM_3_YEARS;
                    interestRate = interestRateFor3Years;
                    finalBalance = finalBalanceFor3Years;
                    break;
                case 2:
                    termDuration = TERM_5_YEARS;
                    interestRate = interestRateFor5Years;
                    finalBalance = finalBalanceFor5Years;
                    break;
                case 3:
                    termDuration = TERM_10_YEARS;
                    interestRate = interestRateFor10Years;
                    finalBalance = finalBalanceFor10Years;
                    break;
            }

            // Check if a transaction ID has not been generated
            if (transactionID == "")
            {
                // If so, generate a transaction ID
                generateTransactionID();
            }

            // Display transaction ID
            transactionIDDisplayLabel.Text = transactionID;

            // Display date
            investmentDateValueLabel.Text = DateTime.Today.ToString(DATE_FORMAT);

            // Expand form
            this.Height = MAX_HEIGHT;

            // Display fields for investor details
            investorDetailsGroupBox.Show();
            investorDetailsGroupBox.Enabled = true;

            // Check if name is not entered
            if (fullNameTextBox.Text == "")
                // Pass on focus to the name input field
                fullNameTextBox.Focus();
            // Check if email is not entered
            else if (emailTextBox.Text == "")
                // Pass on focus to the email input field
                emailTextBox.Focus();
            // Check if phone number is not entered
            else if (phoneNumberTextBox.Text == "")
                // Pass on focus to the phone number input field
                phoneNumberTextBox.Focus();
            // Everything seems filled in
            else
                // Pass on focus to the submit button
                submitButton.Focus();

        }

        // Event handler called on pressing the "Proceed" button
        private void proceedButton_Click(object sender, EventArgs e)
        {
            // Show fields for entering client details
            proceedToInvestorInformation();
        }

        // Method to Submit information for confirmation
        private void submitInformation()
        {
            // Check if no name was entered
            if (fullNameTextBox.Text.Trim() == "")
            {
                // Display message requesting the user to enter one
                DialogResult result = MessageBox.Show(ENTER_NAME_MESSAGE,
                    ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (result == DialogResult.OK)
                    // Pass on focus to the name input field
                    fullNameTextBox.Focus();
                return;
            }

            // Check if no email address was entered
            if (emailTextBox.Text.Trim() == "")
            {
                // Display message requesting the user to enter one
                DialogResult result = MessageBox.Show(ENTER_EMAIL_MESSAGE,
                    ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                    // Pass on focus to the email input field
                    emailTextBox.Focus();
                return;
            }

            // Check if email entered was invalid
            if (!new EmailAddressAttribute().IsValid(emailTextBox.Text))
            {
                // Display message requesting the user to enter a valid email address
                DialogResult result = MessageBox.Show(ENTER_VALID_EMAIL_MESSAGE,
                ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                    // Pass on focus to the email input field
                    emailTextBox.Focus();
                return;
            }

            // Check if no phone number was entered
            if (phoneNumberTextBox.Text.Trim() == "")
            {
                // Display message requesting the user to enter one
                DialogResult result = MessageBox.Show(ENTER_PHONE_MESSAGE,
                    ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                    // Pass on focus to the phone number input field
                    phoneNumberTextBox.Focus();
                return;
            }

            // Check if invalid phone number was entered
            if (!new PhoneAttribute().IsValid(phoneNumberTextBox.Text))
            {
                // Display message requesting the user to enter a valid phone number
                DialogResult result = MessageBox.Show(ENTER_VALID_PHONE_MESSAGE,
                ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                    // Pass on focus to the phone number input field
                    phoneNumberTextBox.Focus();
                return;
            }

            // Obtain investor name
            name = fullNameTextBox.Text.Trim();

            // Obtain investor email
            email = emailTextBox.Text.Trim();

            // Obtain investor phone number
            phone = phoneNumberTextBox.Text.Trim();

            // Display the investment amount
            investmentValueLabel.Text = investment.ToString("C");

            // Display the final amount
            finalBalanceValueLabel.Text = finalBalance.ToString("C");

            // Display the interest amount
            interestValueLabel.Text = (finalBalance - investment).ToString("C");

            // Display the term duration
            termDurationValueLabel.Text = termDuration + YEAR_SUFFIX;

            // Display the client name
            fullNameValueLabel.Text = name;

            // Display the client email
            emailAddressValueLabel.Text = email;

            // Display the client phone number
            telephoneValueLabel.Text = phone;

            // Display the transaction ID
            transactionIDValueLabel.Text = transactionID;

            // Display the date
            dateValueLabel.Text = DateTime.Today.ToString(DATE_FORMAT);

            // Display the investment details for confirmation
            confirmationGroupBox.Show();

            // Pass on focus
            confirmButton.Focus();

        }

        // Event handler called on pressing the "Submit" button
        private void submitButton_Click(object sender, EventArgs e)
        {
            submitInformation();
        }

        // Method to check if the term duration is unchanged
        private void toggleInvestorDetailsVisibility()
        {
            // Check if the term duration selected is the same as that before pressing "Proceed"
            if (termDuration == TERM_1_YEARS && finalBalance == finalBalanceFor1Years && term1YearsRadioButton.Checked ||
                termDuration == TERM_3_YEARS && finalBalance == finalBalanceFor3Years && term3YearsRadioButton.Checked ||
                termDuration == TERM_5_YEARS && finalBalance == finalBalanceFor5Years && term5YearsRadioButton.Checked ||
                termDuration == TERM_10_YEARS && finalBalance == finalBalanceFor10Years && term10YearsRadioButton.Checked)
                // If so, show the investor details
                investorDetailsGroupBox.Enabled = true;
            else 
                // Otherwise, grey out the investor details
                investorDetailsGroupBox.Enabled = false;
        }

        // Event handler called on editing investment amount text box
        private void investmentAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if the investment amount is the same as that was saved
                if (investment == decimal.Parse(investmentAmountTextBox.Text) &&
                    investment != 0)
                {
                    // If so, show the investment details
                    investmentDetailsGroupBox.Enabled = true;

                    // Set the visibility of the investor details section based on the term duration selection
                    toggleInvestorDetailsVisibility();                   
                }
                else
                {
                    // Otherwise, hide the investment and the investor details
                    investmentDetailsGroupBox.Enabled = false;
                    investorDetailsGroupBox.Enabled = false;
                }
            }
            catch { }
        }

        // Event handler called on pressing a key when focused on the Investment amount text box
        private void investmentAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the enter key is pressed
            if (e.KeyChar == (char)13)
            {
                // If so, display the interest rates and final balance
                displayRates();
            }
        }

        // Method to clear fields and labels
        private void clearFields()
        {
            // Hide sections that were hidden initially
            confirmationGroupBox.Hide();
            investorDetailsGroupBox.Hide();
            investmentDetailsGroupBox.Hide();

            // Clear displayed values
            fullNameValueLabel.Text = "";
            emailAddressValueLabel.Text = "";
            interestValueLabel.Text = "";
            telephoneValueLabel.Text = "";
            finalBalanceValueLabel.Text = "";
            termDurationValueLabel.Text = "";
            transactionIDValueLabel.Text = "";
            investmentValueLabel.Text = "";
            dateValueLabel.Text = "";
            investmentDateValueLabel.Text = "";
            fullNameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            investmentAmountTextBox.Text = "";
            term1YearsRadioButton.Checked = false;
            term3YearsRadioButton.Checked = false;
            term5YearsRadioButton.Checked = false;
            term10YearsRadioButton.Checked = false;
            averageInvestmentValueLabel.Text = "";
            averageTermValueLabel.Text = "";
            totalInterestValueLabel.Text = "";
            totalInvestmentValueLabel.Text = "";

            // Clear session data
            transactionID = "";
            name = "";
            email = "";
            phone = "";
            investment = 0.00M;
            interestRate = 0;
            termDuration = 0;
            interestRateFor1Years = BAND_1_TERM_1_YEARS;
            interestRateFor3Years = BAND_1_TERM_3_YEARS;
            interestRateFor5Years = BAND_1_TERM_5_YEARS;
            interestRateFor10Years = BAND_1_TERM_10_YEARS;
            finalBalanceFor1Years = 0.00M;
            finalBalanceFor3Years = 0.00M;
            finalBalanceFor5Years = 0.00M;
            finalBalanceFor10Years = 0.00M;
            interestRate = BAND_1_TERM_1_YEARS;
            finalBalance = 0.00M;

            // Pass on focus to the input field for entering investment amount
            investmentAmountTextBox.Focus();
        }

        // Event handler called on pressing the "Confirm" button
        private void confirmButton_Click(object sender, EventArgs e)
        {
            // Display message prompting the user to confirm the transaction
            DialogResult result = MessageBox.Show(ARE_YOU_SURE_MESSAGE,
                CONFIRM_INVESTMENT_MESSAGE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            try
            {
                // Obtain the file where data is stored
                StreamWriter outputFile = File.AppendText(DATA_FILE_NAME);

                // Write details of investment to file
                outputFile.WriteLine(transactionID);
                outputFile.WriteLine(DateTime.Today.ToString(DATE_FORMAT));
                outputFile.WriteLine(email);
                outputFile.WriteLine(name);
                outputFile.WriteLine(phone);
                outputFile.WriteLine(investment.ToString("0.00"));
                outputFile.WriteLine(termDuration);
                outputFile.WriteLine((finalBalance - investment).ToString("0.00"));
                outputFile.WriteLine(" ");

                // Close file
                outputFile.Close();

                // Display message indicating that the transaction has been confirmed
                MessageBox.Show(TRANSACTION_CONFIRMED_MESSAGE, ALERT_MESSAGE, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear text fields and labels
                clearFields();

            }
            catch (Exception ex)
            {
                // Display message explaining the exception that occured
                MessageBox.Show(ex.Message, ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handlers called on pressing keys when focused on a radio button
        private void oneYearRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                // Display fields for entering client details
                proceedToInvestorInformation();
        }
        private void threeYearsRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                // Display fields for entering client details
                proceedToInvestorInformation();
        }
        private void fiveYearsRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                // Display fields for entering client details
                proceedToInvestorInformation();
        }
        private void tenYearsRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                // Display fields for entering client details
                proceedToInvestorInformation();
        }

        // Event handlers called on pressing keys while focused on text fields in the Investor information group box
        private void fullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                // Submit investment details to be confirmed
                submitInformation();
        }
        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                // Submit investment details to be confirmed
                submitInformation();
        }
        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                // Submit investment details to be confirmed
                submitInformation();
        }

        // Event handler called on pressing the "Exit" button
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Quit application
            Application.Exit();
        }

        // Event handler called on pressing the "Clear" button
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Set views to default
            clearFields();

            // Hide the summary section as per default
            summaryPanel.Hide();

            // Hide the search results section as per default
            searchResultsPanel.Hide();

            // Restore form height to default
            this.Height = MIN_HEIGHT;
        }
        
        // Event handler called on pressing the "Summary" button
        private void summaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variable for total investment amount
                decimal totalInvestment = 0.00M;

                // Initialize variable for total interest amount
                decimal totalInterest = 0.00M;

                // Initialize variable for average investment amount
                decimal averageInvestment = 0.00M;

                // Initialze variable for average term duration
                decimal averageTermDuration = 0.0M;

                // Initialize variable for counting the number of transactions
                int transactionCount = 0;

                // Initialize variable for totalling the term duration, for computing its average
                decimal totalTermDuration = 0.0M;

                // Open file
                StreamReader inputFile = File.OpenText(DATA_FILE_NAME);

                // Empty list of IDs displayed in Summary section
                summaryListBox.Items.Clear();

                // Read saved data
                do
                {                    
                    // Obtain the transaction ID of the first record
                    string currentID = inputFile.ReadLine();

                    // Check if there is no record
                    if (currentID == null)
                        break;

                    // Increment number of transactions
                    transactionCount++;

                    // Add transaction ID to the list of IDs displayed
                    summaryListBox.Items.Add(currentID);

                    // Skip through lines with information we don't need now
                    for (int index = 0; index < 4; index++)
                        inputFile.ReadLine();

                    // Add investment amount to total
                    totalInvestment += decimal.Parse(inputFile.ReadLine());

                    // Add term duration to total
                    totalTermDuration += decimal.Parse(inputFile.ReadLine());

                    // Add interest amount to total
                    totalInterest += decimal.Parse(inputFile.ReadLine());
                }
                while (inputFile.ReadLine() != null);

                // Close file
                inputFile.Close();

                // Calculating average investment amount
                averageInvestment = totalInvestment / transactionCount;

                // Calculating average term duration
                averageTermDuration = totalTermDuration / transactionCount;

                // Expand form
                this.Height = MAX_HEIGHT;

                // Display average term duration
                averageTermValueLabel.Text = averageTermDuration.ToString("0.0") + YEAR_SUFFIX;

                // Display average investment amount
                averageInvestmentValueLabel.Text = averageInvestment.ToString("C");

                // Display total investment amount
                totalInvestmentValueLabel.Text = totalInvestment.ToString("C");

                // Display total interest amount
                totalInterestValueLabel.Text = totalInterest.ToString("C");

                // Display summary section
                summaryPanel.Show();

                // Hide overlapping search results panel
                searchResultsPanel.Hide();

            }
            catch (Exception ex)
            {
                // Display message explaining the exception that occured
                MessageBox.Show(ex.Message, ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        // Method for searching
        private void runSearch()
        {
            // Display the search results section
            searchResultsPanel.Show();

            // Hide the overlapping Summary section
            summaryPanel.Hide();

            // Expand the form
            this.Height = MAX_HEIGHT;

            // Empty display listbox
            searchResultsListBox.Items.Clear();

            // Obtain the entered search term
            string searchTerm = searchPaneTextBox.Text.Trim();

            // If the search term is empty,
            if (searchTerm == "")
            {
                // Inform the user to enter one
                DialogResult result = MessageBox.Show(ENTER_SEARCH_TERM_MESSAGE, ALERT_MESSAGE,
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                    // Pass focus to the search input field
                    searchPaneTextBox.Focus();
                return;
            }

            try
            {
                // Open file
                StreamReader inputFile = File.OpenText(DATA_FILE_NAME);

                // Check if the search is by transaction ID
                if (searchIDRadioButton.Checked)
                {

                    do
                    {
                        // Obtain the transaction ID from file, if any
                        string savedID = inputFile.ReadLine();

                        // Check if the saved ID is the one we are looking for
                        if (savedID == searchTerm)
                        {
                            // Display transaction ID
                            searchResultsListBox.Items.Add(savedID);

                            // Display the rest of that transaction's details
                            for (int index = 0; index < 7; index++)
                                searchResultsListBox.Items.Add(inputFile.ReadLine());
                            break;
                        }
                        else
                        {
                            // Since not a match, skip over the current transaction
                            for (int index = 0; index < 7; index++)
                                inputFile.ReadLine();

                        }

                    }
                    while (inputFile.ReadLine() != null);

                    // If no results found, indicate accordingly
                    searchResultsListBox.Items.Add("No results found");
                }
                // Check if search is by email
                else if (searchEmailRadioButton.Checked)
                {
                    do
                    {
                        // Obtain transaction ID
                        string savedID = inputFile.ReadLine();

                        // Obtain transaction date
                        string savedDate = inputFile.ReadLine();

                        // Obtain email registered with the transaction
                        string savedEmail = inputFile.ReadLine();

                        // Check if the saved ID is the one we are looking for
                        if (savedEmail == searchTerm)
                        {
                            // If so, display details pertaining to the current transaction

                            // Display transaction ID
                            searchResultsListBox.Items.Add(savedID);

                            // Display transaction date
                            searchResultsListBox.Items.Add(savedDate);

                            // Display email registered with the transaction
                            searchResultsListBox.Items.Add(savedEmail);

                            // Display the rest of that transaction's details
                            for (int index = 0; index < 5; index++)
                                searchResultsListBox.Items.Add(inputFile.ReadLine());
                        }
                        else
                        {
                            // Since not a match, skip over the current transaction
                            for (int index = 0; index < 5; index++)
                                inputFile.ReadLine();

                        }

                    }
                    while (inputFile.ReadLine() != null);

                    // If no results found, indicate accordingly
                    if(searchResultsListBox.Items.Count == 0)
                        searchResultsListBox.Items.Add("No results found");
                }
                // Check if search is by date
                else if (searchDateRadioButton.Checked)
                {
                    do
                    {
                        // Obtain transaction ID
                        string savedID = inputFile.ReadLine();

                        // Obtain transaction date
                        string savedDate = inputFile.ReadLine();

                        // Check if the saved ID is the one we are looking for
                        if (savedDate == searchTerm)
                        {
                            // If so, display details pertaining to the current transaction

                            // Display transaction ID
                            searchResultsListBox.Items.Add(savedID);

                            // Display transaction date
                            searchResultsListBox.Items.Add(savedDate);

                            // Display the rest of that transaction's details
                            for (int index = 0; index < 6; index++)
                                searchResultsListBox.Items.Add(inputFile.ReadLine());
                        }
                        else
                        {
                            // Since not a match, skip over the current transaction
                            for (int index = 0; index < 6; index++)
                                inputFile.ReadLine();

                        }

                    }
                    while (inputFile.ReadLine() != null);

                    // If no results found, indicate accordingly
                    if (searchResultsListBox.Items.Count == 0)
                        searchResultsListBox.Items.Add("No results found");
                }

                // Close file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display a message explaining the exception that occured
                MessageBox.Show(ex.Message, ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Event handler called on pressing the "Search" button
        private void searchButton_Click(object sender, EventArgs e)
        {
            runSearch();
        }

        // Event handler called on pressing a key when focused on the text box in search pane
        private void searchPaneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is the Enter key
            if (e.KeyChar == (char)13)
                // If so, run the search
                runSearch();
        }

    }

}
