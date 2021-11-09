
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
            this.passwordEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordScreenImage)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.passwordEntryPanel);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.passwordEntryPanel.ResumeLayout(false);
            this.passwordEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordScreenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel passwordEntryPanel;
        private System.Windows.Forms.Label passwordEntryLabel;
        private System.Windows.Forms.TextBox passwordEntryTextBox;
        private System.Windows.Forms.PictureBox passwordScreenImage;
        private System.Windows.Forms.Button passwordEntryButton;
    }
}

