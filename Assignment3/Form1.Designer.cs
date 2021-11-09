
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.investmentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.passwordEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordScreenImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.investmentDetailsGroupBox.SuspendLayout();
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
            this.passwordEntryPanel.Size = new System.Drawing.Size(1575, 1131);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.investmentDetailsGroupBox);
            this.panel1.Controls.Add(this.displayButton);
            this.panel1.Controls.Add(this.investmentAmountTextBox);
            this.panel1.Controls.Add(this.euroSymbolLabel);
            this.panel1.Controls.Add(this.investmentAmountLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1575, 1128);
            this.panel1.TabIndex = 4;
            // 
            // investmentDetailsGroupBox
            // 
            this.investmentDetailsGroupBox.Controls.Add(this.button1);
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
            this.investmentDetailsGroupBox.Location = new System.Drawing.Point(92, 154);
            this.investmentDetailsGroupBox.Name = "investmentDetailsGroupBox";
            this.investmentDetailsGroupBox.Size = new System.Drawing.Size(1386, 564);
            this.investmentDetailsGroupBox.TabIndex = 4;
            this.investmentDetailsGroupBox.TabStop = false;
            this.investmentDetailsGroupBox.Text = "Details on return on investment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Proceed";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // finalBalance10YearLabel
            // 
            this.finalBalance10YearLabel.AutoSize = true;
            this.finalBalance10YearLabel.Location = new System.Drawing.Point(961, 365);
            this.finalBalance10YearLabel.Name = "finalBalance10YearLabel";
            this.finalBalance10YearLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalance10YearLabel.TabIndex = 14;
            this.finalBalance10YearLabel.Text = "Final Balance";
            // 
            // finalBalance5YearLabel
            // 
            this.finalBalance5YearLabel.AutoSize = true;
            this.finalBalance5YearLabel.Location = new System.Drawing.Point(961, 305);
            this.finalBalance5YearLabel.Name = "finalBalance5YearLabel";
            this.finalBalance5YearLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalance5YearLabel.TabIndex = 13;
            this.finalBalance5YearLabel.Text = "Final Balance";
            // 
            // finalBalance3YearLabel
            // 
            this.finalBalance3YearLabel.AutoSize = true;
            this.finalBalance3YearLabel.Location = new System.Drawing.Point(961, 245);
            this.finalBalance3YearLabel.Name = "finalBalance3YearLabel";
            this.finalBalance3YearLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalance3YearLabel.TabIndex = 12;
            this.finalBalance3YearLabel.Text = "Final Balance";
            // 
            // finalBalance1YearLabel
            // 
            this.finalBalance1YearLabel.AutoSize = true;
            this.finalBalance1YearLabel.Location = new System.Drawing.Point(961, 185);
            this.finalBalance1YearLabel.Name = "finalBalance1YearLabel";
            this.finalBalance1YearLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalance1YearLabel.TabIndex = 11;
            this.finalBalance1YearLabel.Text = "Final Balance";
            // 
            // finalBalanceLabel
            // 
            this.finalBalanceLabel.AutoSize = true;
            this.finalBalanceLabel.Location = new System.Drawing.Point(961, 112);
            this.finalBalanceLabel.Name = "finalBalanceLabel";
            this.finalBalanceLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalanceLabel.TabIndex = 10;
            this.finalBalanceLabel.Text = "Final Balance";
            // 
            // interestRate10YearLabel
            // 
            this.interestRate10YearLabel.AutoSize = true;
            this.interestRate10YearLabel.Location = new System.Drawing.Point(398, 365);
            this.interestRate10YearLabel.Name = "interestRate10YearLabel";
            this.interestRate10YearLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRate10YearLabel.TabIndex = 9;
            this.interestRate10YearLabel.Text = "Interest Rate";
            // 
            // interestRate5YearLabel
            // 
            this.interestRate5YearLabel.AutoSize = true;
            this.interestRate5YearLabel.Location = new System.Drawing.Point(398, 305);
            this.interestRate5YearLabel.Name = "interestRate5YearLabel";
            this.interestRate5YearLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRate5YearLabel.TabIndex = 8;
            this.interestRate5YearLabel.Text = "Interest Rate";
            // 
            // interestRate3YearLabel
            // 
            this.interestRate3YearLabel.AutoSize = true;
            this.interestRate3YearLabel.Location = new System.Drawing.Point(398, 245);
            this.interestRate3YearLabel.Name = "interestRate3YearLabel";
            this.interestRate3YearLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRate3YearLabel.TabIndex = 7;
            this.interestRate3YearLabel.Text = "Interest Rate";
            // 
            // interestRate1YearLabel
            // 
            this.interestRate1YearLabel.AutoSize = true;
            this.interestRate1YearLabel.Location = new System.Drawing.Point(398, 185);
            this.interestRate1YearLabel.Name = "interestRate1YearLabel";
            this.interestRate1YearLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRate1YearLabel.TabIndex = 6;
            this.interestRate1YearLabel.Text = "Interest Rate";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(398, 112);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(148, 32);
            this.interestRateLabel.TabIndex = 5;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // selectInvestmentTermLabel
            // 
            this.selectInvestmentTermLabel.AutoSize = true;
            this.selectInvestmentTermLabel.Location = new System.Drawing.Point(63, 56);
            this.selectInvestmentTermLabel.Name = "selectInvestmentTermLabel";
            this.selectInvestmentTermLabel.Size = new System.Drawing.Size(261, 32);
            this.selectInvestmentTermLabel.TabIndex = 4;
            this.selectInvestmentTermLabel.Text = "Select investment term";
            // 
            // tenYearsRadioButton
            // 
            this.tenYearsRadioButton.AutoSize = true;
            this.tenYearsRadioButton.Location = new System.Drawing.Point(63, 363);
            this.tenYearsRadioButton.Name = "tenYearsRadioButton";
            this.tenYearsRadioButton.Size = new System.Drawing.Size(132, 36);
            this.tenYearsRadioButton.TabIndex = 3;
            this.tenYearsRadioButton.TabStop = true;
            this.tenYearsRadioButton.Text = "10 Years";
            this.tenYearsRadioButton.UseVisualStyleBackColor = true;
            // 
            // fiveYearsRadioButton
            // 
            this.fiveYearsRadioButton.AutoSize = true;
            this.fiveYearsRadioButton.Location = new System.Drawing.Point(63, 303);
            this.fiveYearsRadioButton.Name = "fiveYearsRadioButton";
            this.fiveYearsRadioButton.Size = new System.Drawing.Size(119, 36);
            this.fiveYearsRadioButton.TabIndex = 2;
            this.fiveYearsRadioButton.TabStop = true;
            this.fiveYearsRadioButton.Text = "5 Years";
            this.fiveYearsRadioButton.UseVisualStyleBackColor = true;
            // 
            // threeYearsRadioButton
            // 
            this.threeYearsRadioButton.AutoSize = true;
            this.threeYearsRadioButton.Location = new System.Drawing.Point(63, 243);
            this.threeYearsRadioButton.Name = "threeYearsRadioButton";
            this.threeYearsRadioButton.Size = new System.Drawing.Size(119, 36);
            this.threeYearsRadioButton.TabIndex = 1;
            this.threeYearsRadioButton.TabStop = true;
            this.threeYearsRadioButton.Text = "3 Years";
            this.threeYearsRadioButton.UseVisualStyleBackColor = true;
            // 
            // oneYearRadioButton
            // 
            this.oneYearRadioButton.AutoSize = true;
            this.oneYearRadioButton.Location = new System.Drawing.Point(63, 183);
            this.oneYearRadioButton.Name = "oneYearRadioButton";
            this.oneYearRadioButton.Size = new System.Drawing.Size(109, 36);
            this.oneYearRadioButton.TabIndex = 0;
            this.oneYearRadioButton.TabStop = true;
            this.oneYearRadioButton.Text = "1 Year";
            this.oneYearRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(938, 63);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(150, 46);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "&Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // investmentAmountTextBox
            // 
            this.investmentAmountTextBox.Location = new System.Drawing.Point(621, 67);
            this.investmentAmountTextBox.MaxLength = 10;
            this.investmentAmountTextBox.Name = "investmentAmountTextBox";
            this.investmentAmountTextBox.Size = new System.Drawing.Size(200, 39);
            this.investmentAmountTextBox.TabIndex = 2;
            // 
            // euroSymbolLabel
            // 
            this.euroSymbolLabel.AutoSize = true;
            this.euroSymbolLabel.Location = new System.Drawing.Point(588, 67);
            this.euroSymbolLabel.Name = "euroSymbolLabel";
            this.euroSymbolLabel.Size = new System.Drawing.Size(27, 32);
            this.euroSymbolLabel.TabIndex = 1;
            this.euroSymbolLabel.Text = "€";
            // 
            // investmentAmountLabel
            // 
            this.investmentAmountLabel.AutoSize = true;
            this.investmentAmountLabel.Location = new System.Drawing.Point(92, 67);
            this.investmentAmountLabel.Name = "investmentAmountLabel";
            this.investmentAmountLabel.Size = new System.Drawing.Size(402, 32);
            this.investmentAmountLabel.TabIndex = 0;
            this.investmentAmountLabel.Text = "How much would you like to invest?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordEntryPanel);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.passwordEntryPanel.ResumeLayout(false);
            this.passwordEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordScreenImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.investmentDetailsGroupBox.ResumeLayout(false);
            this.investmentDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel passwordEntryPanel;
        private System.Windows.Forms.Label passwordEntryLabel;
        private System.Windows.Forms.TextBox passwordEntryTextBox;
        private System.Windows.Forms.PictureBox passwordScreenImage;
        private System.Windows.Forms.Button passwordEntryButton;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label finalBalance10YearLabel;
        private System.Windows.Forms.Label finalBalance5YearLabel;
        private System.Windows.Forms.Label finalBalance3YearLabel;
        private System.Windows.Forms.Label finalBalance1YearLabel;
    }
}

