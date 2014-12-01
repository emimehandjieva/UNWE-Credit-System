namespace LearningCreditSystem.Desktop.Forms
{
    partial class SearchIndividualCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.TabControl();
            this.customerMainData = new System.Windows.Forms.TabPage();
            this.PINLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.customerPIN = new System.Windows.Forms.TextBox();
            this.customerLastName = new System.Windows.Forms.TextBox();
            this.customerFirstName = new System.Windows.Forms.TextBox();
            this.customerDetails = new System.Windows.Forms.TabPage();
            this.customerPhone = new System.Windows.Forms.TextBox();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            this.customerMainData.SuspendLayout();
            this.customerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(323, 414);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(227, 57);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Търси";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.customerMainData);
            this.searchPanel.Controls.Add(this.customerDetails);
            this.searchPanel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchPanel.Location = new System.Drawing.Point(85, 64);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.SelectedIndex = 0;
            this.searchPanel.Size = new System.Drawing.Size(702, 301);
            this.searchPanel.TabIndex = 2;
            // 
            // customerMainData
            // 
            this.customerMainData.Controls.Add(this.PINLabel);
            this.customerMainData.Controls.Add(this.lastNameLabel);
            this.customerMainData.Controls.Add(this.firstNameLabel);
            this.customerMainData.Controls.Add(this.customerPIN);
            this.customerMainData.Controls.Add(this.customerLastName);
            this.customerMainData.Controls.Add(this.customerFirstName);
            this.customerMainData.Location = new System.Drawing.Point(4, 27);
            this.customerMainData.Name = "customerMainData";
            this.customerMainData.Padding = new System.Windows.Forms.Padding(3);
            this.customerMainData.Size = new System.Drawing.Size(694, 270);
            this.customerMainData.TabIndex = 0;
            this.customerMainData.Text = "Основни данни";
            this.customerMainData.UseVisualStyleBackColor = true;
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.Location = new System.Drawing.Point(161, 46);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(39, 18);
            this.PINLabel.TabIndex = 5;
            this.PINLabel.Text = "ЕГН";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(161, 170);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(75, 18);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(162, 110);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(38, 18);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "Име";
            // 
            // customerPIN
            // 
            this.customerPIN.Location = new System.Drawing.Point(321, 162);
            this.customerPIN.Name = "customerPIN";
            this.customerPIN.Size = new System.Drawing.Size(161, 26);
            this.customerPIN.TabIndex = 2;
            // 
            // customerLastName
            // 
            this.customerLastName.Location = new System.Drawing.Point(321, 102);
            this.customerLastName.Name = "customerLastName";
            this.customerLastName.Size = new System.Drawing.Size(161, 26);
            this.customerLastName.TabIndex = 1;
            // 
            // customerFirstName
            // 
            this.customerFirstName.Location = new System.Drawing.Point(321, 46);
            this.customerFirstName.Name = "customerFirstName";
            this.customerFirstName.Size = new System.Drawing.Size(161, 26);
            this.customerFirstName.TabIndex = 0;
            // 
            // customerDetails
            // 
            this.customerDetails.Controls.Add(this.customerPhone);
            this.customerDetails.Controls.Add(this.customerEmail);
            this.customerDetails.Controls.Add(this.phoneLabel);
            this.customerDetails.Controls.Add(this.emailLabel);
            this.customerDetails.Location = new System.Drawing.Point(4, 27);
            this.customerDetails.Name = "customerDetails";
            this.customerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.customerDetails.Size = new System.Drawing.Size(694, 270);
            this.customerDetails.TabIndex = 1;
            this.customerDetails.Text = "Детайли";
            this.customerDetails.UseVisualStyleBackColor = true;
            // 
            // customerPhone
            // 
            this.customerPhone.Location = new System.Drawing.Point(291, 121);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(148, 26);
            this.customerPhone.TabIndex = 3;
            // 
            // customerEmail
            // 
            this.customerEmail.Location = new System.Drawing.Point(291, 44);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(148, 26);
            this.customerEmail.TabIndex = 2;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(136, 121);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(73, 18);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Телефон";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(136, 44);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 18);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // SearchIndividualCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningCreditSystem.Desktop.Properties.Resources.BusinessBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 538);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPanel);
            this.DoubleBuffered = true;
            this.Name = "SearchIndividualCustomers";
            this.Text = "SearchIndividualCustomers";
            this.searchPanel.ResumeLayout(false);
            this.customerMainData.ResumeLayout(false);
            this.customerMainData.PerformLayout();
            this.customerDetails.ResumeLayout(false);
            this.customerDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabControl searchPanel;
        private System.Windows.Forms.TabPage customerMainData;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox customerPIN;
        private System.Windows.Forms.TextBox customerLastName;
        private System.Windows.Forms.TextBox customerFirstName;
        private System.Windows.Forms.TabPage customerDetails;
        private System.Windows.Forms.TextBox customerPhone;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;


    }
}