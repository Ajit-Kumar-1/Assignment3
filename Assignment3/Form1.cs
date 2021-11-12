﻿using System;
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

        // Form dimensions
        const int MIN_HEIGHT = 500;
        const int MAX_HEIGHT = 1518;        
        
        // Correct password
        const string PASSWORD_VALUE = "ShowMeTheMoney#";

        // Limit for number of failed attempts to enter password
        const int PASSWORD_FAILED_ATTEMPTS_LIMIT = 4;

        // File name where transaction data is stored
        const string DATA_FILE_NAME = "Invest4UTransactions.txt";

        // Format for displaying date
        const string DATE_FORMAT = "dd/MM/yyyy";

        // Messages
        const string WRONG_PASSWORD_MESSAGE_PART_1 = "Wrong Password. You have ";
        const string WRONG_PASSWORD_MESSAGE_PART_2 = " more attempt(s).";
        const string TOO_MANY_FAILED_ATTEMPTS_MESSAGE = "Too many failed attempts";
        const string LOCKED_OUT_MESSAGE = "Locked out";
        const string ERROR_MESSAGE = "Error";
        const string ENTER_NAME_MESSAGE = "Please enter your full name";
        const string ENTER_EMAIL_MESSAGE = "Please enter your email address";
        const string ENTER_PHONE_MESSAGE = "Please enter your phone number";
        const string ENTER_VALID_EMAIL_MESSAGE = "Please enter a valid email address";
        const string ENTER_VALID_PHONE_MESSAGE = "Please enter a valid phone number";
        const string ENTER_VALID_AMOUNT = "Please enter a numeric value for investment amount";
        const string CONFIRM_INVESTMENT_MESSAGE = "Confirm Investment";
        const string ARE_YOU_SURE_MESSAGE = "Would you like to confirm this investment?";
        const string TRANSACTION_CONFIRMED_MESSAGE = "Transaction confirmed!";
        const string ALERT_MESSAGE = "Alert";
        const string ENTER_SEARCH_TERM_MESSAGE = "Enter a term to search";
        const string ID_NOT_FOUND = "No transaction found for given ID";

        // Literal value for displaying years of investment term duration
        const string YEAR_SUFFIX = " Year(s)";

        // Specify the characters used to make up the random string
        const string characterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

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
                    // Show message indicating that a wrong password is entered
                    string mainMessage = WRONG_PASSWORD_MESSAGE_PART_1 +
                        (PASSWORD_FAILED_ATTEMPTS_LIMIT - passwordAttemptsCounter) +
                        WRONG_PASSWORD_MESSAGE_PART_2;
                    DialogResult result = MessageBox.Show(mainMessage, ERROR_MESSAGE, 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                        passwordEntryTextBox.Focus();
                }
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

        // Method to show interest rates and final balance for given investment amount
        private void displayRates()
        {
            // Obtain entered investment amount
            try
            {
                investment = decimal.Parse(investmentAmountTextBox.Text);
            }
            catch
            {
                // Show message requesting entry of a valid investment amount
                DialogResult result = MessageBox.Show(ENTER_VALID_AMOUNT,
                    ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                    investmentAmountTextBox.Focus();
                return;
            }

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

            // Expand form
            this.Height = MAX_HEIGHT;

            // Show interest rates and final balance
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
            displayRates();
        }

        // Method to generate a random string
        private string randomString()
        {
            // StreamReader inputFile = File.OpenText("Invest4UTransactions.txt");

            // Initialize the random string
            var randomizedString = "";
            var random = new Random();

            // Loop 8 times
            for (int i = 0; i < 8; i++)
                // Add a random character each time
                randomizedString += characterSet[random.Next(8)];

            return randomizedString;
        }

        // Event handlers called on toggling radio buttons
        private void oneYearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            proceedButton.Show();
            toggleInvestorDetailsVisibility();
        }

        private void threeYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            proceedButton.Show();
            toggleInvestorDetailsVisibility();
        }

        private void fiveYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            proceedButton.Show();
            toggleInvestorDetailsVisibility();
        }

        private void tenYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            proceedButton.Show();
            toggleInvestorDetailsVisibility();
        }

        // Method for proceeding from term selection to investor information
        private void proceedToInvestorInformation()
        {
            // Variable to keep track of the selected term duration
            int checkedIndex = 0;

            // Set term duration based on selected radio button
            checkedIndex = term10YearsRadioButton.Checked ? 0 :
                term3YearsRadioButton.Checked ? 1 :
                term5YearsRadioButton.Checked ? 2 :
                term1YearsRadioButton.Checked ? 3 : 0;

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

            // Check if a transaction ID hasa not been generated
            if (transactionID == "")
            {
                // If so, generate and assign a random string for the transaction ID
                transactionID = randomString();
                transactionIDDisplayLabel.Text = transactionID;
            }

            // Show date
            investmentDateValueLabel.Text = DateTime.Today.ToString(DATE_FORMAT);

            // Expand form
            this.Height = MAX_HEIGHT;

            // Show fields for investor details
            investorDetailsGroupBox.Show();
            investorDetailsGroupBox.Enabled = true;

            // Pass on focus
            if (fullNameTextBox.Text == "")
                fullNameTextBox.Focus();
            else if (emailTextBox.Text == "")
                emailTextBox.Focus();
            else if (phoneNumberTextBox.Text == "")
                phoneNumberTextBox.Focus();
            else
                submitButton.Focus();

        }

        // Event handler called on pressing the "Proceed" button
        private void proceedButton_Click(object sender, EventArgs e)
        {
            proceedToInvestorInformation();
        }

        // Method to Submit information for confirmation
        private void submitInformation()
        {
            // Check if no name was entered
            if (fullNameTextBox.Text.Trim() == "")
            {
                // Show message requesting the user to enter one
                DialogResult result = MessageBox.Show(ENTER_NAME_MESSAGE,
                    ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                    fullNameTextBox.Focus();
                return;
            }

            // Check if no email address was entered
            if (emailTextBox.Text.Trim() == "")
            {
                // Show message requesting the user to enter one
                DialogResult result = MessageBox.Show(ENTER_EMAIL_MESSAGE,
                    ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                    emailTextBox.Focus();
                return;
            }

            // Check if email entered was invalid
            if (!new EmailAddressAttribute().IsValid(emailTextBox.Text))
            {
                // Show message requesting the user to enter a valid email address
                DialogResult result = MessageBox.Show(ENTER_VALID_EMAIL_MESSAGE,
                ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                    emailTextBox.Focus();
                return;
            }

            // Obtain entered information
            name = fullNameTextBox.Text.Trim();
            email = emailTextBox.Text.Trim();
            phone = phoneNumberTextBox.Text.Trim();

            // Fill investment details
            investmentValueLabel.Text = investment.ToString("C");
            finalBalanceValueLabel.Text = finalBalance.ToString("C");
            interestValueLabel.Text = (finalBalance - investment).ToString("C");
            termDurationValueLabel.Text = termDuration + (termDuration == 1 ? "" : "s");
            fullNameValueLabel.Text = name;
            emailAddressValueLabel.Text = email;
            telephoneValueLabel.Text = phone;
            transactionIDValueLabel.Text = transactionID;
            dateValueLabel.Text = DateTime.Today.ToString(DATE_FORMAT);

            // Show the investment details for confirmation
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
            if (termDuration == TERM_1_YEARS && term10YearsRadioButton.Checked ||
                termDuration == TERM_3_YEARS && term3YearsRadioButton.Checked ||
                termDuration == TERM_5_YEARS && term5YearsRadioButton.Checked ||
                termDuration == TERM_10_YEARS && term1YearsRadioButton.Checked)
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
            confirmationGroupBox.Hide();
            investorDetailsGroupBox.Hide();
            investmentDetailsGroupBox.Hide();
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
            term10YearsRadioButton.Checked = false;
            term3YearsRadioButton.Checked = false;
            term5YearsRadioButton.Checked = false;
            term1YearsRadioButton.Checked = false;
            investmentAmountTextBox.Focus();
        }

        // Event handler called on pressing the "Confirm" button
        private void confirmButton_Click(object sender, EventArgs e)
        {
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

                MessageBox.Show(TRANSACTION_CONFIRMED_MESSAGE, ALERT_MESSAGE, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear text fields and labels
                clearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handlers called on pressing keys when focused on a radio button
        private void oneYearRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                proceedToInvestorInformation();
        }
        private void threeYearsRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                proceedToInvestorInformation();
        }
        private void fiveYearsRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                proceedToInvestorInformation();
        }
        private void tenYearsRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                proceedToInvestorInformation();
        }

        // Event handlers called on pressing keys while focused on text fields in the Investor information group box
        private void fullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                submitInformation();
        }
        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                submitInformation();
        }
        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if enter key is pressed
            if (e.KeyChar == (char)13)
                submitInformation();
        }

        // Event handler called on pressing the "Exit" button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler called on pressing the "Clear" button
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();
            summaryPanel.Hide();
            this.Height = MIN_HEIGHT;
        }
        
        // Event handler called on pressing the "Summary" button
        private void summaryButton_Click(object sender, EventArgs e)
        {
            try
            {

                // Initializing variables
                decimal totalInvestment = 0.00M;
                decimal totalInterest = 0.00M;
                decimal averageInvestment = 0.00M;
                decimal averageTermDuration = 0.0M;
                int transactionCount = 0;
                decimal totalTermDuration = 0.0M;

                // Open file
                StreamReader inputFile = File.OpenText(DATA_FILE_NAME);

                // Empty list of IDs shown in Summary section
                summaryListBox.Items.Clear();

                // Read saved data
                do
                {                    
                    // Obtain the transaction ID of the first record
                    string currentID = inputFile.ReadLine();

                    // Check if there is no record
                    if (currentID == null)
                        break;

                    transactionCount++;

                    // Add transaction ID to the list of IDs shown
                    summaryListBox.Items.Add(currentID);

                    // Skip through lines with information we don't need now
                    for (int index = 0; index < 4; index++)
                        inputFile.ReadLine();

                    totalInvestment += decimal.Parse(inputFile.ReadLine());
                    totalTermDuration += decimal.Parse(inputFile.ReadLine());
                    totalInterest += decimal.Parse(inputFile.ReadLine());
                }
                while (inputFile.ReadLine() != null);

                // Close file
                inputFile.Close();

                // Calculating averages
                averageInvestment = totalInvestment / transactionCount;
                averageTermDuration = totalTermDuration / transactionCount;

                // Expand form
                this.Height = MAX_HEIGHT;

                // Display information
                averageTermValueLabel.Text = averageTermDuration.ToString("0.0") + YEAR_SUFFIX;
                averageInvestmentValueLabel.Text = averageInvestment.ToString("C");
                totalInvestmentValueLabel.Text = totalInvestment.ToString("C");
                totalInterestValueLabel.Text = totalInterest.ToString("C");

                // Show summary section
                summaryPanel.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        // Method for searching
        private void runSearch()
        {
            // Show the search results section
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
                    searchPaneTextBox.Focus();
                return;
            }

            try
            {
                // Open file
                StreamReader inputFile = File.OpenText(DATA_FILE_NAME);

                if (searchIDRadioButton.Checked)
                {

                    do
                    {
                        string savedID = inputFile.ReadLine();

                        // Check if the saved ID is the one we are looking for
                        if (savedID == searchTerm)
                        {
                            // If so, print details in form

                            // Show ID
                            searchResultsListBox.Items.Add(savedID);

                            // Show the rest of that transaction's details
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

                // Close file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Check if the search is by transaction ID

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
