
namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passwordEntryPanel = new System.Windows.Forms.Panel();
            this.passwordEntryButton = new System.Windows.Forms.Button();
            this.passwordScreenImage = new System.Windows.Forms.PictureBox();
            this.passwordEntryLabel = new System.Windows.Forms.Label();
            this.passwordEntryTextBox = new System.Windows.Forms.TextBox();
            this.investmentPanel = new System.Windows.Forms.Panel();
            this.investorDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.referenceNumberLabel = new System.Windows.Forms.Label();
            this.referenceIDDescriptionLabel = new System.Windows.Forms.Label();
            this.investmentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.finalBalance10YearLabel = new System.Windows.Forms.Label();
            this.finalBalance5YearLabel = new System.Windows.Forms.Label();
            this.finalBalance3YearLabel = new System.Windows.Forms.Label();
            this.finalBalance1YearLabel = new System.Windows.Forms.Label();
            this.finalBalanceLabel = new System.Windows.Forms.Label();
            this.interestRate10YearLabel = new System.Windows.Forms.Label();
            this.interestRate5YearLabel = new System.Windows.Forms.Label();
            this.interestRate3YearLabel = new System.Windows.Forms.Label();
            this.interestRate1YearLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.selectInvestmentTermLabel = new System.Windows.Forms.Label();
            this.tenYearsRadioButton = new System.Windows.Forms.RadioButton();
            this.fiveYearsRadioButton = new System.Windows.Forms.RadioButton();
            this.threeYearsRadioButton = new System.Windows.Forms.RadioButton();
            this.oneYearRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.investmentAmountTextBox = new System.Windows.Forms.TextBox();
            this.euroSymbolLabel = new System.Windows.Forms.Label();
            this.investmentAmountLabel = new System.Windows.Forms.Label();
            this.confirmationGroupBox = new System.Windows.Forms.GroupBox();
            this.investmentConfirmationLabel = new System.Windows.Forms.Label();
            this.interestRateConfirmationLabel = new System.Windows.Forms.Label();
            this.termDurationConfirmationLabel = new System.Windows.Forms.Label();
            this.fullNameConfirmationLabel = new System.Windows.Forms.Label();
            this.emailAddressConfirmationLabel = new System.Windows.Forms.Label();
            this.telephoneConfirmationLabel = new System.Windows.Forms.Label();
            this.dateConfirmationLabel = new System.Windows.Forms.Label();
            this.referenceIDConfirmationLabel = new System.Windows.Forms.Label();
            this.dateValueLabel = new System.Windows.Forms.Label();
            this.referenceIDValueLabel = new System.Windows.Forms.Label();
            this.telephoneValueLabel = new System.Windows.Forms.Label();
            this.emailAddressValueLabel = new System.Windows.Forms.Label();
            this.fullNameValueLabel = new System.Windows.Forms.Label();
            this.termDurationValueLabel = new System.Windows.Forms.Label();
            this.interestRateValueLabel = new System.Windows.Forms.Label();
            this.investmentValueLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.passwordEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordScreenImage)).BeginInit();
            this.investmentPanel.SuspendLayout();
            this.investorDetailsGroupBox.SuspendLayout();
            this.investmentDetailsGroupBox.SuspendLayout();
            this.confirmationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordEntryPanel
            // 
            this.passwordEntryPanel.Controls.Add(this.passwordEntryButton);
            this.passwordEntryPanel.Controls.Add(this.passwordScreenImage);
            this.passwordEntryPanel.Controls.Add(this.passwordEntryLabel);
            this.passwordEntryPanel.Controls.Add(this.passwordEntryTextBox);
            this.passwordEntryPanel.Location = new System.Drawing.Point(0, 0);
            this.passwordEntryPanel.Name = "passwordEntryPanel";
            this.passwordEntryPanel.Size = new System.Drawing.Size(1575, 1454);
            this.passwordEntryPanel.TabIndex = 0;
            this.passwordEntryPanel.Visible = false;
            // 
            // passwordEntryButton
            // 
            this.passwordEntryButton.Location = new System.Drawing.Point(713, 857);
            this.passwordEntryButton.Name = "passwordEntryButton";
            this.passwordEntryButton.Size = new System.Drawing.Size(150, 46);
            this.passwordEntryButton.TabIndex = 3;
            this.passwordEntryButton.Text = "&Proceed";
            this.passwordEntryButton.UseVisualStyleBackColor = true;
            this.passwordEntryButton.Click += new System.EventHandler(this.passwordEntryButton_Click);
            // 
            // passwordScreenImage
            // 
            this.passwordScreenImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordScreenImage.BackgroundImage")));
            this.passwordScreenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passwordScreenImage.Location = new System.Drawing.Point(413, 100);
            this.passwordScreenImage.Name = "passwordScreenImage";
            this.passwordScreenImage.Size = new System.Drawing.Size(750, 500);
            this.passwordScreenImage.TabIndex = 2;
            this.passwordScreenImage.TabStop = false;
            // 
            // passwordEntryLabel
            // 
            this.passwordEntryLabel.Location = new System.Drawing.Point(588, 721);
            this.passwordEntryLabel.Name = "passwordEntryLabel";
            this.passwordEntryLabel.Size = new System.Drawing.Size(400, 40);
            this.passwordEntryLabel.TabIndex = 1;
            this.passwordEntryLabel.Text = "Enter Password:";
            // 
            // passwordEntryTextBox
            // 
            this.passwordEntryTextBox.Location = new System.Drawing.Point(588, 765);
            this.passwordEntryTextBox.Name = "passwordEntryTextBox";
            this.passwordEntryTextBox.PasswordChar = '*';
            this.passwordEntryTextBox.Size = new System.Drawing.Size(400, 39);
            this.passwordEntryTextBox.TabIndex = 0;
            this.passwordEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordEntryTextBox_KeyDown);
            // 
            // investmentPanel
            // 
            this.investmentPanel.Controls.Add(this.confirmationGroupBox);
            this.investmentPanel.Controls.Add(this.investorDetailsGroupBox);
            this.investmentPanel.Controls.Add(this.investmentDetailsGroupBox);
            this.investmentPanel.Controls.Add(this.displayButton);
            this.investmentPanel.Controls.Add(this.investmentAmountTextBox);
            this.investmentPanel.Controls.Add(this.euroSymbolLabel);
            this.investmentPanel.Controls.Add(this.investmentAmountLabel);
            this.investmentPanel.Location = new System.Drawing.Point(0, 0);
            this.investmentPanel.Name = "investmentPanel";
            this.investmentPanel.Size = new System.Drawing.Size(1575, 1426);
            this.investmentPanel.TabIndex = 4;
            // 
            // investorDetailsGroupBox
            // 
            this.investorDetailsGroupBox.Controls.Add(this.submitButton);
            this.investorDetailsGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.investorDetailsGroupBox.Controls.Add(this.emailTextBox);
            this.investorDetailsGroupBox.Controls.Add(this.fullNameTextBox);
            this.investorDetailsGroupBox.Controls.Add(this.phoneNumberLabel);
            this.investorDetailsGroupBox.Controls.Add(this.emailLabel);
            this.investorDetailsGroupBox.Controls.Add(this.fullNameLabel);
            this.investorDetailsGroupBox.Controls.Add(this.referenceNumberLabel);
            this.investorDetailsGroupBox.Controls.Add(this.referenceIDDescriptionLabel);
            this.investorDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.investorDetailsGroupBox.Location = new System.Drawing.Point(49, 525);
            this.investorDetailsGroupBox.Name = "investorDetailsGroupBox";
            this.investorDetailsGroupBox.Size = new System.Drawing.Size(853, 342);
            this.investorDetailsGroupBox.TabIndex = 5;
            this.investorDetailsGroupBox.TabStop = false;
            this.investorDetailsGroupBox.Text = "3. Enter Investor Details";
            this.investorDetailsGroupBox.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(373, 266);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(150, 46);
            this.submitButton.TabIndex = 22;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(198, 205);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(616, 39);
            this.phoneNumberTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTextBox.Location = new System.Drawing.Point(198, 155);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(616, 39);
            this.emailTextBox.TabIndex = 20;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameTextBox.Location = new System.Drawing.Point(198, 105);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(616, 39);
            this.fullNameTextBox.TabIndex = 19;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLabel.Location = new System.Drawing.Point(32, 208);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(166, 32);
            this.phoneNumberLabel.TabIndex = 18;
            this.phoneNumberLabel.Text = "Telephone no:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(32, 158);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(164, 32);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Email address:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.Location = new System.Drawing.Point(32, 108);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(124, 32);
            this.fullNameLabel.TabIndex = 16;
            this.fullNameLabel.Text = "Full name:";
            // 
            // referenceNumberLabel
            // 
            this.referenceNumberLabel.AutoSize = true;
            this.referenceNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.referenceNumberLabel.Location = new System.Drawing.Point(198, 58);
            this.referenceNumberLabel.Name = "referenceNumberLabel";
            this.referenceNumberLabel.Size = new System.Drawing.Size(24, 32);
            this.referenceNumberLabel.TabIndex = 7;
            this.referenceNumberLabel.Text = "-";
            // 
            // referenceIDDescriptionLabel
            // 
            this.referenceIDDescriptionLabel.AutoSize = true;
            this.referenceIDDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.referenceIDDescriptionLabel.Location = new System.Drawing.Point(32, 58);
            this.referenceIDDescriptionLabel.Name = "referenceIDDescriptionLabel";
            this.referenceIDDescriptionLabel.Size = new System.Drawing.Size(155, 32);
            this.referenceIDDescriptionLabel.TabIndex = 6;
            this.referenceIDDescriptionLabel.Text = "Reference ID:";
            // 
            // investmentDetailsGroupBox
            // 
            this.investmentDetailsGroupBox.Controls.Add(this.proceedButton);
            this.investmentDetailsGroupBox.Controls.Add(this.finalBalance10YearLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.finalBalance5YearLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.finalBalance3YearLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.finalBalance1YearLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.finalBalanceLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.interestRate10YearLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.interestRate5YearLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.interestRate3YearLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.interestRate1YearLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.interestRateLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.selectInvestmentTermLabel);
            this.investmentDetailsGroupBox.Controls.Add(this.tenYearsRadioButton);
            this.investmentDetailsGroupBox.Controls.Add(this.fiveYearsRadioButton);
            this.investmentDetailsGroupBox.Controls.Add(this.threeYearsRadioButton);
            this.investmentDetailsGroupBox.Controls.Add(this.oneYearRadioButton);
            this.investmentDetailsGroupBox.Location = new System.Drawing.Point(49, 111);
            this.investmentDetailsGroupBox.Name = "investmentDetailsGroupBox";
            this.investmentDetailsGroupBox.Size = new System.Drawing.Size(853, 408);
            this.investmentDetailsGroupBox.TabIndex = 4;
            this.investmentDetailsGroupBox.TabStop = false;
            this.investmentDetailsGroupBox.Text = "Details on return on investment";
            this.investmentDetailsGroupBox.Visible = false;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(364, 338);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(150, 46);
            this.proceedButton.TabIndex = 15;
            this.proceedButton.Text = "&Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Visible = false;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // finalBalance10YearLabel
            // 
            this.finalBalance10YearLabel.AutoSize = true;
            this.finalBalance10YearLabel.Location = new System.Drawing.Point(528, 279);
            this.finalBalance10YearLabel.Name = "finalBalance10YearLabel";
            this.finalBalance10YearLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalance10YearLabel.TabIndex = 14;
            this.finalBalance10YearLabel.Text = "Final Balance";
            // 
            // finalBalance5YearLabel
            // 
            this.finalBalance5YearLabel.AutoSize = true;
            this.finalBalance5YearLabel.Location = new System.Drawing.Point(528, 232);
            this.finalBalance5YearLabel.Name = "finalBalance5YearLabel";
            this.finalBalance5YearLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalance5YearLabel.TabIndex = 13;
            this.finalBalance5YearLabel.Text = "Final Balance";
            // 
            // finalBalance3YearLabel
            // 
            this.finalBalance3YearLabel.AutoSize = true;
            this.finalBalance3YearLabel.Location = new System.Drawing.Point(528, 185);
            this.finalBalance3YearLabel.Name = "finalBalance3YearLabel";
            this.finalBalance3YearLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalance3YearLabel.TabIndex = 12;
            this.finalBalance3YearLabel.Text = "Final Balance";
            // 
            // finalBalance1YearLabel
            // 
            this.finalBalance1YearLabel.AutoSize = true;
            this.finalBalance1YearLabel.Location = new System.Drawing.Point(528, 142);
            this.finalBalance1YearLabel.Name = "finalBalance1YearLabel";
            this.finalBalance1YearLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalance1YearLabel.TabIndex = 11;
            this.finalBalance1YearLabel.Text = "Final Balance";
            // 
            // finalBalanceLabel
            // 
            this.finalBalanceLabel.AutoSize = true;
            this.finalBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.finalBalanceLabel.Location = new System.Drawing.Point(528, 90);
            this.finalBalanceLabel.Name = "finalBalanceLabel";
            this.finalBalanceLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalanceLabel.TabIndex = 10;
            this.finalBalanceLabel.Text = "Final Balance";
            // 
            // interestRate10YearLabel
            // 
            this.interestRate10YearLabel.AutoSize = true;
            this.interestRate10YearLabel.Location = new System.Drawing.Point(198, 279);
            this.interestRate10YearLabel.Name = "interestRate10YearLabel";
            this.interestRate10YearLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRate10YearLabel.TabIndex = 9;
            this.interestRate10YearLabel.Text = "Interest Rate";
            // 
            // interestRate5YearLabel
            // 
            this.interestRate5YearLabel.AutoSize = true;
            this.interestRate5YearLabel.Location = new System.Drawing.Point(198, 232);
            this.interestRate5YearLabel.Name = "interestRate5YearLabel";
            this.interestRate5YearLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRate5YearLabel.TabIndex = 8;
            this.interestRate5YearLabel.Text = "Interest Rate";
            // 
            // interestRate3YearLabel
            // 
            this.interestRate3YearLabel.AutoSize = true;
            this.interestRate3YearLabel.Location = new System.Drawing.Point(198, 185);
            this.interestRate3YearLabel.Name = "interestRate3YearLabel";
            this.interestRate3YearLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRate3YearLabel.TabIndex = 7;
            this.interestRate3YearLabel.Text = "Interest Rate";
            // 
            // interestRate1YearLabel
            // 
            this.interestRate1YearLabel.AutoSize = true;
            this.interestRate1YearLabel.Location = new System.Drawing.Point(198, 142);
            this.interestRate1YearLabel.Name = "interestRate1YearLabel";
            this.interestRate1YearLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRate1YearLabel.TabIndex = 6;
            this.interestRate1YearLabel.Text = "Interest Rate";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.interestRateLabel.Location = new System.Drawing.Point(198, 90);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRateLabel.TabIndex = 5;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // selectInvestmentTermLabel
            // 
            this.selectInvestmentTermLabel.AutoSize = true;
            this.selectInvestmentTermLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectInvestmentTermLabel.Location = new System.Drawing.Point(11, 46);
            this.selectInvestmentTermLabel.Name = "selectInvestmentTermLabel";
            this.selectInvestmentTermLabel.Size = new System.Drawing.Size(304, 32);
            this.selectInvestmentTermLabel.TabIndex = 4;
            this.selectInvestmentTermLabel.Text = "2. Select investment term";
            // 
            // tenYearsRadioButton
            // 
            this.tenYearsRadioButton.AutoSize = true;
            this.tenYearsRadioButton.Location = new System.Drawing.Point(35, 275);
            this.tenYearsRadioButton.Name = "tenYearsRadioButton";
            this.tenYearsRadioButton.Size = new System.Drawing.Size(132, 36);
            this.tenYearsRadioButton.TabIndex = 3;
            this.tenYearsRadioButton.TabStop = true;
            this.tenYearsRadioButton.Text = "10 Years";
            this.tenYearsRadioButton.UseVisualStyleBackColor = true;
            this.tenYearsRadioButton.CheckedChanged += new System.EventHandler(this.tenYearsRadioButton_CheckedChanged);
            // 
            // fiveYearsRadioButton
            // 
            this.fiveYearsRadioButton.AutoSize = true;
            this.fiveYearsRadioButton.Location = new System.Drawing.Point(35, 230);
            this.fiveYearsRadioButton.Name = "fiveYearsRadioButton";
            this.fiveYearsRadioButton.Size = new System.Drawing.Size(119, 36);
            this.fiveYearsRadioButton.TabIndex = 2;
            this.fiveYearsRadioButton.TabStop = true;
            this.fiveYearsRadioButton.Text = "5 Years";
            this.fiveYearsRadioButton.UseVisualStyleBackColor = true;
            this.fiveYearsRadioButton.CheckedChanged += new System.EventHandler(this.fiveYearsRadioButton_CheckedChanged);
            // 
            // threeYearsRadioButton
            // 
            this.threeYearsRadioButton.AutoSize = true;
            this.threeYearsRadioButton.Location = new System.Drawing.Point(35, 185);
            this.threeYearsRadioButton.Name = "threeYearsRadioButton";
            this.threeYearsRadioButton.Size = new System.Drawing.Size(119, 36);
            this.threeYearsRadioButton.TabIndex = 1;
            this.threeYearsRadioButton.TabStop = true;
            this.threeYearsRadioButton.Text = "3 Years";
            this.threeYearsRadioButton.UseVisualStyleBackColor = true;
            this.threeYearsRadioButton.CheckedChanged += new System.EventHandler(this.threeYearsRadioButton_CheckedChanged);
            // 
            // oneYearRadioButton
            // 
            this.oneYearRadioButton.AutoSize = true;
            this.oneYearRadioButton.Location = new System.Drawing.Point(35, 140);
            this.oneYearRadioButton.Name = "oneYearRadioButton";
            this.oneYearRadioButton.Size = new System.Drawing.Size(109, 36);
            this.oneYearRadioButton.TabIndex = 0;
            this.oneYearRadioButton.TabStop = true;
            this.oneYearRadioButton.Text = "1 Year";
            this.oneYearRadioButton.UseVisualStyleBackColor = true;
            this.oneYearRadioButton.CheckedChanged += new System.EventHandler(this.oneYearRadioButton_CheckedChanged);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(752, 37);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(150, 46);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "&Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // investmentAmountTextBox
            // 
            this.investmentAmountTextBox.Location = new System.Drawing.Point(475, 44);
            this.investmentAmountTextBox.MaxLength = 14;
            this.investmentAmountTextBox.Name = "investmentAmountTextBox";
            this.investmentAmountTextBox.Size = new System.Drawing.Size(255, 39);
            this.investmentAmountTextBox.TabIndex = 2;
            this.investmentAmountTextBox.TextChanged += new System.EventHandler(this.investmentAmountTextBox_TextChanged);
            this.investmentAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.investmentAmountTextBox_KeyPress);
            // 
            // euroSymbolLabel
            // 
            this.euroSymbolLabel.AutoSize = true;
            this.euroSymbolLabel.Location = new System.Drawing.Point(442, 44);
            this.euroSymbolLabel.Name = "euroSymbolLabel";
            this.euroSymbolLabel.Size = new System.Drawing.Size(27, 32);
            this.euroSymbolLabel.TabIndex = 1;
            this.euroSymbolLabel.Text = "€";
            this.euroSymbolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // investmentAmountLabel
            // 
            this.investmentAmountLabel.AutoSize = true;
            this.investmentAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.investmentAmountLabel.Location = new System.Drawing.Point(49, 47);
            this.investmentAmountLabel.Name = "investmentAmountLabel";
            this.investmentAmountLabel.Size = new System.Drawing.Size(339, 32);
            this.investmentAmountLabel.TabIndex = 0;
            this.investmentAmountLabel.Text = "1. Enter investment amount:";
            // 
            // confirmationGroupBox
            // 
            this.confirmationGroupBox.Controls.Add(this.confirmButton);
            this.confirmationGroupBox.Controls.Add(this.dateValueLabel);
            this.confirmationGroupBox.Controls.Add(this.referenceIDValueLabel);
            this.confirmationGroupBox.Controls.Add(this.telephoneValueLabel);
            this.confirmationGroupBox.Controls.Add(this.emailAddressValueLabel);
            this.confirmationGroupBox.Controls.Add(this.fullNameValueLabel);
            this.confirmationGroupBox.Controls.Add(this.termDurationValueLabel);
            this.confirmationGroupBox.Controls.Add(this.interestRateValueLabel);
            this.confirmationGroupBox.Controls.Add(this.investmentValueLabel);
            this.confirmationGroupBox.Controls.Add(this.dateConfirmationLabel);
            this.confirmationGroupBox.Controls.Add(this.referenceIDConfirmationLabel);
            this.confirmationGroupBox.Controls.Add(this.telephoneConfirmationLabel);
            this.confirmationGroupBox.Controls.Add(this.emailAddressConfirmationLabel);
            this.confirmationGroupBox.Controls.Add(this.fullNameConfirmationLabel);
            this.confirmationGroupBox.Controls.Add(this.termDurationConfirmationLabel);
            this.confirmationGroupBox.Controls.Add(this.interestRateConfirmationLabel);
            this.confirmationGroupBox.Controls.Add(this.investmentConfirmationLabel);
            this.confirmationGroupBox.Location = new System.Drawing.Point(49, 873);
            this.confirmationGroupBox.Name = "confirmationGroupBox";
            this.confirmationGroupBox.Size = new System.Drawing.Size(853, 508);
            this.confirmationGroupBox.TabIndex = 6;
            this.confirmationGroupBox.TabStop = false;
            this.confirmationGroupBox.Text = "4. Confirm investment";
            // 
            // investmentConfirmationLabel
            // 
            this.investmentConfirmationLabel.AutoSize = true;
            this.investmentConfirmationLabel.Location = new System.Drawing.Point(35, 65);
            this.investmentConfirmationLabel.Name = "investmentConfirmationLabel";
            this.investmentConfirmationLabel.Size = new System.Drawing.Size(202, 32);
            this.investmentConfirmationLabel.TabIndex = 0;
            this.investmentConfirmationLabel.Text = "Invested Amount:";
            // 
            // interestRateConfirmationLabel
            // 
            this.interestRateConfirmationLabel.AutoSize = true;
            this.interestRateConfirmationLabel.Location = new System.Drawing.Point(35, 110);
            this.interestRateConfirmationLabel.Name = "interestRateConfirmationLabel";
            this.interestRateConfirmationLabel.Size = new System.Drawing.Size(153, 32);
            this.interestRateConfirmationLabel.TabIndex = 1;
            this.interestRateConfirmationLabel.Text = "Interest Rate:";
            // 
            // termDurationConfirmationLabel
            // 
            this.termDurationConfirmationLabel.AutoSize = true;
            this.termDurationConfirmationLabel.Location = new System.Drawing.Point(35, 155);
            this.termDurationConfirmationLabel.Name = "termDurationConfirmationLabel";
            this.termDurationConfirmationLabel.Size = new System.Drawing.Size(172, 32);
            this.termDurationConfirmationLabel.TabIndex = 2;
            this.termDurationConfirmationLabel.Text = "Term Duration:";
            // 
            // fullNameConfirmationLabel
            // 
            this.fullNameConfirmationLabel.AutoSize = true;
            this.fullNameConfirmationLabel.Location = new System.Drawing.Point(35, 200);
            this.fullNameConfirmationLabel.Name = "fullNameConfirmationLabel";
            this.fullNameConfirmationLabel.Size = new System.Drawing.Size(124, 32);
            this.fullNameConfirmationLabel.TabIndex = 3;
            this.fullNameConfirmationLabel.Text = "Full name:";
            // 
            // emailAddressConfirmationLabel
            // 
            this.emailAddressConfirmationLabel.AutoSize = true;
            this.emailAddressConfirmationLabel.Location = new System.Drawing.Point(35, 245);
            this.emailAddressConfirmationLabel.Name = "emailAddressConfirmationLabel";
            this.emailAddressConfirmationLabel.Size = new System.Drawing.Size(164, 32);
            this.emailAddressConfirmationLabel.TabIndex = 4;
            this.emailAddressConfirmationLabel.Text = "Email address:";
            // 
            // telephoneConfirmationLabel
            // 
            this.telephoneConfirmationLabel.AutoSize = true;
            this.telephoneConfirmationLabel.Location = new System.Drawing.Point(35, 290);
            this.telephoneConfirmationLabel.Name = "telephoneConfirmationLabel";
            this.telephoneConfirmationLabel.Size = new System.Drawing.Size(166, 32);
            this.telephoneConfirmationLabel.TabIndex = 5;
            this.telephoneConfirmationLabel.Text = "Telephone no:";
            // 
            // dateConfirmationLabel
            // 
            this.dateConfirmationLabel.AutoSize = true;
            this.dateConfirmationLabel.Location = new System.Drawing.Point(35, 380);
            this.dateConfirmationLabel.Name = "dateConfirmationLabel";
            this.dateConfirmationLabel.Size = new System.Drawing.Size(69, 32);
            this.dateConfirmationLabel.TabIndex = 7;
            this.dateConfirmationLabel.Text = "Date:";
            // 
            // referenceIDConfirmationLabel
            // 
            this.referenceIDConfirmationLabel.AutoSize = true;
            this.referenceIDConfirmationLabel.Location = new System.Drawing.Point(35, 335);
            this.referenceIDConfirmationLabel.Name = "referenceIDConfirmationLabel";
            this.referenceIDConfirmationLabel.Size = new System.Drawing.Size(155, 32);
            this.referenceIDConfirmationLabel.TabIndex = 6;
            this.referenceIDConfirmationLabel.Text = "Reference ID:";
            // 
            // dateValueLabel
            // 
            this.dateValueLabel.AutoSize = true;
            this.dateValueLabel.Location = new System.Drawing.Point(243, 380);
            this.dateValueLabel.Name = "dateValueLabel";
            this.dateValueLabel.Size = new System.Drawing.Size(69, 32);
            this.dateValueLabel.TabIndex = 15;
            this.dateValueLabel.Text = "Date:";
            // 
            // referenceIDValueLabel
            // 
            this.referenceIDValueLabel.AutoSize = true;
            this.referenceIDValueLabel.Location = new System.Drawing.Point(243, 335);
            this.referenceIDValueLabel.Name = "referenceIDValueLabel";
            this.referenceIDValueLabel.Size = new System.Drawing.Size(155, 32);
            this.referenceIDValueLabel.TabIndex = 14;
            this.referenceIDValueLabel.Text = "Reference ID:";
            // 
            // telephoneValueLabel
            // 
            this.telephoneValueLabel.AutoSize = true;
            this.telephoneValueLabel.Location = new System.Drawing.Point(243, 290);
            this.telephoneValueLabel.Name = "telephoneValueLabel";
            this.telephoneValueLabel.Size = new System.Drawing.Size(166, 32);
            this.telephoneValueLabel.TabIndex = 13;
            this.telephoneValueLabel.Text = "Telephone no:";
            // 
            // emailAddressValueLabel
            // 
            this.emailAddressValueLabel.AutoSize = true;
            this.emailAddressValueLabel.Location = new System.Drawing.Point(243, 245);
            this.emailAddressValueLabel.Name = "emailAddressValueLabel";
            this.emailAddressValueLabel.Size = new System.Drawing.Size(164, 32);
            this.emailAddressValueLabel.TabIndex = 12;
            this.emailAddressValueLabel.Text = "Email address:";
            // 
            // fullNameValueLabel
            // 
            this.fullNameValueLabel.AutoSize = true;
            this.fullNameValueLabel.Location = new System.Drawing.Point(243, 200);
            this.fullNameValueLabel.Name = "fullNameValueLabel";
            this.fullNameValueLabel.Size = new System.Drawing.Size(124, 32);
            this.fullNameValueLabel.TabIndex = 11;
            this.fullNameValueLabel.Text = "Full name:";
            // 
            // termDurationValueLabel
            // 
            this.termDurationValueLabel.AutoSize = true;
            this.termDurationValueLabel.Location = new System.Drawing.Point(243, 155);
            this.termDurationValueLabel.Name = "termDurationValueLabel";
            this.termDurationValueLabel.Size = new System.Drawing.Size(172, 32);
            this.termDurationValueLabel.TabIndex = 10;
            this.termDurationValueLabel.Text = "Term Duration:";
            // 
            // interestRateValueLabel
            // 
            this.interestRateValueLabel.AutoSize = true;
            this.interestRateValueLabel.Location = new System.Drawing.Point(243, 110);
            this.interestRateValueLabel.Name = "interestRateValueLabel";
            this.interestRateValueLabel.Size = new System.Drawing.Size(153, 32);
            this.interestRateValueLabel.TabIndex = 9;
            this.interestRateValueLabel.Text = "Interest Rate:";
            // 
            // investmentValueLabel
            // 
            this.investmentValueLabel.AutoSize = true;
            this.investmentValueLabel.Location = new System.Drawing.Point(243, 65);
            this.investmentValueLabel.Name = "investmentValueLabel";
            this.investmentValueLabel.Size = new System.Drawing.Size(202, 32);
            this.investmentValueLabel.TabIndex = 8;
            this.investmentValueLabel.Text = "Invested Amount:";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(373, 432);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(150, 46);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "&Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1422);
            this.Controls.Add(this.investmentPanel);
            this.Controls.Add(this.passwordEntryPanel);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "s";
            this.passwordEntryPanel.ResumeLayout(false);
            this.passwordEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordScreenImage)).EndInit();
            this.investmentPanel.ResumeLayout(false);
            this.investmentPanel.PerformLayout();
            this.investorDetailsGroupBox.ResumeLayout(false);
            this.investorDetailsGroupBox.PerformLayout();
            this.investmentDetailsGroupBox.ResumeLayout(false);
            this.investmentDetailsGroupBox.PerformLayout();
            this.confirmationGroupBox.ResumeLayout(false);
            this.confirmationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel passwordEntryPanel;
        private System.Windows.Forms.Label passwordEntryLabel;
        private System.Windows.Forms.TextBox passwordEntryTextBox;
        private System.Windows.Forms.PictureBox passwordScreenImage;
        private System.Windows.Forms.Button passwordEntryButton;
        private System.Windows.Forms.Panel investmentPanel;
        private System.Windows.Forms.TextBox investmentAmountTextBox;
        private System.Windows.Forms.Label euroSymbolLabel;
        private System.Windows.Forms.Label investmentAmountLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.GroupBox investmentDetailsGroupBox;
        private System.Windows.Forms.RadioButton tenYearsRadioButton;
        private System.Windows.Forms.RadioButton fiveYearsRadioButton;
        private System.Windows.Forms.RadioButton threeYearsRadioButton;
        private System.Windows.Forms.RadioButton oneYearRadioButton;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label selectInvestmentTermLabel;
        private System.Windows.Forms.Label interestRate10YearLabel;
        private System.Windows.Forms.Label interestRate5YearLabel;
        private System.Windows.Forms.Label interestRate3YearLabel;
        private System.Windows.Forms.Label interestRate1YearLabel;
        private System.Windows.Forms.Label finalBalanceLabel;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label finalBalance10YearLabel;
        private System.Windows.Forms.Label finalBalance5YearLabel;
        private System.Windows.Forms.Label finalBalance3YearLabel;
        private System.Windows.Forms.Label finalBalance1YearLabel;
        private System.Windows.Forms.GroupBox investorDetailsGroupBox;
        private System.Windows.Forms.Label referenceNumberLabel;
        private System.Windows.Forms.Label referenceIDDescriptionLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox confirmationGroupBox;
        private System.Windows.Forms.Label investmentConfirmationLabel;
        private System.Windows.Forms.Label termDurationConfirmationLabel;
        private System.Windows.Forms.Label interestRateConfirmationLabel;
        private System.Windows.Forms.Label fullNameConfirmationLabel;
        private System.Windows.Forms.Label emailAddressConfirmationLabel;
        private System.Windows.Forms.Label telephoneConfirmationLabel;
        private System.Windows.Forms.Label dateConfirmationLabel;
        private System.Windows.Forms.Label referenceIDConfirmationLabel;
        private System.Windows.Forms.Label dateValueLabel;
        private System.Windows.Forms.Label referenceIDValueLabel;
        private System.Windows.Forms.Label telephoneValueLabel;
        private System.Windows.Forms.Label emailAddressValueLabel;
        private System.Windows.Forms.Label fullNameValueLabel;
        private System.Windows.Forms.Label termDurationValueLabel;
        private System.Windows.Forms.Label interestRateValueLabel;
        private System.Windows.Forms.Label investmentValueLabel;
        private System.Windows.Forms.Button confirmButton;
    }
}

