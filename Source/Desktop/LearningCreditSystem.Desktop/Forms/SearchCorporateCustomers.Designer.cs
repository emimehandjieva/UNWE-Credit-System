namespace LearningCreditSystem.Desktop.Forms
{
    partial class SearchCorporateCustomers
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
            this.UICLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.TextBox();
            this.companyUIC = new System.Windows.Forms.TextBox();
            this.customerDetails = new System.Windows.Forms.TabPage();
            this.companyPhone = new System.Windows.Forms.TextBox();
            this.companyEmail = new System.Windows.Forms.TextBox();
            this.companyPhoneLabel = new System.Windows.Forms.Label();
            this.companyEmailLabel = new System.Windows.Forms.Label();
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
            this.searchButton.Location = new System.Drawing.Point(320, 388);
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
            this.searchPanel.Location = new System.Drawing.Point(99, 68);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.SelectedIndex = 0;
            this.searchPanel.Size = new System.Drawing.Size(659, 263);
            this.searchPanel.TabIndex = 2;
            // 
            // customerMainData
            // 
            this.customerMainData.Controls.Add(this.UICLabel);
            this.customerMainData.Controls.Add(this.companyNameLabel);
            this.customerMainData.Controls.Add(this.companyName);
            this.customerMainData.Controls.Add(this.companyUIC);
            this.customerMainData.Location = new System.Drawing.Point(4, 27);
            this.customerMainData.Name = "customerMainData";
            this.customerMainData.Padding = new System.Windows.Forms.Padding(3);
            this.customerMainData.Size = new System.Drawing.Size(651, 232);
            this.customerMainData.TabIndex = 0;
            this.customerMainData.Text = "Основни данни";
            this.customerMainData.UseVisualStyleBackColor = true;
            // 
            // UICLabel
            // 
            this.UICLabel.AutoSize = true;
            this.UICLabel.Location = new System.Drawing.Point(161, 46);
            this.UICLabel.Name = "UICLabel";
            this.UICLabel.Size = new System.Drawing.Size(84, 18);
            this.UICLabel.TabIndex = 5;
            this.UICLabel.Text = "БУЛСТАТ";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(162, 110);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(57, 18);
            this.companyNameLabel.TabIndex = 3;
            this.companyNameLabel.Text = "Фирма";
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(321, 102);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(161, 26);
            this.companyName.TabIndex = 1;
            // 
            // companyUIC
            // 
            this.companyUIC.Location = new System.Drawing.Point(321, 46);
            this.companyUIC.Name = "companyUIC";
            this.companyUIC.Size = new System.Drawing.Size(161, 26);
            this.companyUIC.TabIndex = 0;
            // 
            // customerDetails
            // 
            this.customerDetails.Controls.Add(this.companyPhone);
            this.customerDetails.Controls.Add(this.companyEmail);
            this.customerDetails.Controls.Add(this.companyPhoneLabel);
            this.customerDetails.Controls.Add(this.companyEmailLabel);
            this.customerDetails.Location = new System.Drawing.Point(4, 27);
            this.customerDetails.Name = "customerDetails";
            this.customerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.customerDetails.Size = new System.Drawing.Size(651, 232);
            this.customerDetails.TabIndex = 1;
            this.customerDetails.Text = "Детайли";
            this.customerDetails.UseVisualStyleBackColor = true;
            // 
            // companyPhone
            // 
            this.companyPhone.Location = new System.Drawing.Point(291, 121);
            this.companyPhone.Name = "companyPhone";
            this.companyPhone.Size = new System.Drawing.Size(148, 26);
            this.companyPhone.TabIndex = 3;
            // 
            // companyEmail
            // 
            this.companyEmail.Location = new System.Drawing.Point(291, 44);
            this.companyEmail.Name = "companyEmail";
            this.companyEmail.Size = new System.Drawing.Size(148, 26);
            this.companyEmail.TabIndex = 2;
            // 
            // companyPhoneLabel
            // 
            this.companyPhoneLabel.AutoSize = true;
            this.companyPhoneLabel.Location = new System.Drawing.Point(136, 121);
            this.companyPhoneLabel.Name = "companyPhoneLabel";
            this.companyPhoneLabel.Size = new System.Drawing.Size(73, 18);
            this.companyPhoneLabel.TabIndex = 1;
            this.companyPhoneLabel.Text = "Телефон";
            // 
            // companyEmailLabel
            // 
            this.companyEmailLabel.AutoSize = true;
            this.companyEmailLabel.Location = new System.Drawing.Point(136, 44);
            this.companyEmailLabel.Name = "companyEmailLabel";
            this.companyEmailLabel.Size = new System.Drawing.Size(48, 18);
            this.companyEmailLabel.TabIndex = 0;
            this.companyEmailLabel.Text = "Email";
            // 
            // SearchCorporateCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningCreditSystem.Desktop.Properties.Resources.BusinessBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 502);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPanel);
            this.DoubleBuffered = true;
            this.Name = "SearchCorporateCustomers";
            this.Text = "SearchCorporateCustomers";
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
        private System.Windows.Forms.Label UICLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.TextBox companyUIC;
        private System.Windows.Forms.TabPage customerDetails;
        private System.Windows.Forms.TextBox companyPhone;
        private System.Windows.Forms.TextBox companyEmail;
        private System.Windows.Forms.Label companyPhoneLabel;
        private System.Windows.Forms.Label companyEmailLabel;
    }
}