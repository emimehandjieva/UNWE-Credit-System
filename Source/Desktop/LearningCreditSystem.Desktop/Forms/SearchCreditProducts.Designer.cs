namespace LearningCreditSystem.Desktop.Forms
{
    partial class SearchCreditProducts
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
            this.productStatus = new System.Windows.Forms.ComboBox();
            this.productStatusLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productCode = new System.Windows.Forms.TextBox();
            this.customerDetails = new System.Windows.Forms.TabPage();
            this.minimumSum = new System.Windows.Forms.TextBox();
            this.minimumSumLabel = new System.Windows.Forms.Label();
            this.maximumSumLabel = new System.Windows.Forms.Label();
            this.maximumTerm = new System.Windows.Forms.TextBox();
            this.minimumTerm = new System.Windows.Forms.TextBox();
            this.maximumSum = new System.Windows.Forms.TextBox();
            this.maximumTermLabel = new System.Windows.Forms.Label();
            this.maximumInterestRate = new System.Windows.Forms.TextBox();
            this.minimumTermLabel = new System.Windows.Forms.Label();
            this.maximumIntRateerestLabel = new System.Windows.Forms.Label();
            this.minimumInterestRate = new System.Windows.Forms.TextBox();
            this.minimumInterestRateLabel = new System.Windows.Forms.Label();
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
            this.searchButton.Location = new System.Drawing.Point(329, 381);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(227, 57);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Търси";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.customerMainData);
            this.searchPanel.Controls.Add(this.customerDetails);
            this.searchPanel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchPanel.Location = new System.Drawing.Point(107, 52);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.SelectedIndex = 0;
            this.searchPanel.Size = new System.Drawing.Size(659, 314);
            this.searchPanel.TabIndex = 4;
            // 
            // customerMainData
            // 
            this.customerMainData.Controls.Add(this.productStatus);
            this.customerMainData.Controls.Add(this.productStatusLabel);
            this.customerMainData.Controls.Add(this.productCodeLabel);
            this.customerMainData.Controls.Add(this.productNameLabel);
            this.customerMainData.Controls.Add(this.productName);
            this.customerMainData.Controls.Add(this.productCode);
            this.customerMainData.Location = new System.Drawing.Point(4, 27);
            this.customerMainData.Name = "customerMainData";
            this.customerMainData.Padding = new System.Windows.Forms.Padding(3);
            this.customerMainData.Size = new System.Drawing.Size(651, 283);
            this.customerMainData.TabIndex = 0;
            this.customerMainData.Text = "Основни данни";
            this.customerMainData.UseVisualStyleBackColor = true;
            // 
            // productStatus
            // 
            this.productStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productStatus.FormattingEnabled = true;
            this.productStatus.Items.AddRange(new object[] {
            "Активен",
            "Неактивен"});
            this.productStatus.Location = new System.Drawing.Point(321, 150);
            this.productStatus.Name = "productStatus";
            this.productStatus.Size = new System.Drawing.Size(161, 26);
            this.productStatus.TabIndex = 7;
            // 
            // productStatusLabel
            // 
            this.productStatusLabel.AutoSize = true;
            this.productStatusLabel.Location = new System.Drawing.Point(140, 154);
            this.productStatusLabel.Name = "productStatusLabel";
            this.productStatusLabel.Size = new System.Drawing.Size(58, 18);
            this.productStatusLabel.TabIndex = 6;
            this.productStatusLabel.Text = "Статус";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(140, 32);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(36, 18);
            this.productCodeLabel.TabIndex = 5;
            this.productCodeLabel.Text = "Код";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(140, 87);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(114, 18);
            this.productNameLabel.TabIndex = 3;
            this.productNameLabel.Text = "Наименование";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(321, 84);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(161, 26);
            this.productName.TabIndex = 1;
            // 
            // productCode
            // 
            this.productCode.Location = new System.Drawing.Point(321, 32);
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(161, 26);
            this.productCode.TabIndex = 0;
            // 
            // customerDetails
            // 
            this.customerDetails.Controls.Add(this.minimumSum);
            this.customerDetails.Controls.Add(this.minimumSumLabel);
            this.customerDetails.Controls.Add(this.maximumSumLabel);
            this.customerDetails.Controls.Add(this.maximumTerm);
            this.customerDetails.Controls.Add(this.minimumTerm);
            this.customerDetails.Controls.Add(this.maximumSum);
            this.customerDetails.Controls.Add(this.maximumTermLabel);
            this.customerDetails.Controls.Add(this.maximumInterestRate);
            this.customerDetails.Controls.Add(this.minimumTermLabel);
            this.customerDetails.Controls.Add(this.maximumIntRateerestLabel);
            this.customerDetails.Controls.Add(this.minimumInterestRate);
            this.customerDetails.Controls.Add(this.minimumInterestRateLabel);
            this.customerDetails.Location = new System.Drawing.Point(4, 27);
            this.customerDetails.Name = "customerDetails";
            this.customerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.customerDetails.Size = new System.Drawing.Size(651, 283);
            this.customerDetails.TabIndex = 1;
            this.customerDetails.Text = "Детайли";
            this.customerDetails.UseVisualStyleBackColor = true;
            // 
            // minimumSum
            // 
            this.minimumSum.Location = new System.Drawing.Point(429, 193);
            this.minimumSum.Name = "minimumSum";
            this.minimumSum.Size = new System.Drawing.Size(86, 26);
            this.minimumSum.TabIndex = 12;
            // 
            // minimumSumLabel
            // 
            this.minimumSumLabel.AutoSize = true;
            this.minimumSumLabel.Location = new System.Drawing.Point(169, 196);
            this.minimumSumLabel.Name = "minimumSumLabel";
            this.minimumSumLabel.Size = new System.Drawing.Size(202, 18);
            this.minimumSumLabel.TabIndex = 11;
            this.minimumSumLabel.Text = "Минимална изискана сума";
            // 
            // maximumSumLabel
            // 
            this.maximumSumLabel.AutoSize = true;
            this.maximumSumLabel.Location = new System.Drawing.Point(169, 237);
            this.maximumSumLabel.Name = "maximumSumLabel";
            this.maximumSumLabel.Size = new System.Drawing.Size(208, 18);
            this.maximumSumLabel.TabIndex = 10;
            this.maximumSumLabel.Text = "Максимална изискана сума";
            // 
            // maximumTerm
            // 
            this.maximumTerm.Location = new System.Drawing.Point(429, 139);
            this.maximumTerm.Name = "maximumTerm";
            this.maximumTerm.Size = new System.Drawing.Size(86, 26);
            this.maximumTerm.TabIndex = 9;
            // 
            // minimumTerm
            // 
            this.minimumTerm.Location = new System.Drawing.Point(429, 101);
            this.minimumTerm.Name = "minimumTerm";
            this.minimumTerm.Size = new System.Drawing.Size(86, 26);
            this.minimumTerm.TabIndex = 8;
            // 
            // maximumSum
            // 
            this.maximumSum.Location = new System.Drawing.Point(429, 234);
            this.maximumSum.Name = "maximumSum";
            this.maximumSum.Size = new System.Drawing.Size(86, 26);
            this.maximumSum.TabIndex = 3;
            // 
            // maximumTermLabel
            // 
            this.maximumTermLabel.AutoSize = true;
            this.maximumTermLabel.Location = new System.Drawing.Point(169, 142);
            this.maximumTermLabel.Name = "maximumTermLabel";
            this.maximumTermLabel.Size = new System.Drawing.Size(169, 18);
            this.maximumTermLabel.TabIndex = 7;
            this.maximumTermLabel.Text = "Максимална срочност";
            // 
            // maximumInterestRate
            // 
            this.maximumInterestRate.Location = new System.Drawing.Point(429, 57);
            this.maximumInterestRate.Name = "maximumInterestRate";
            this.maximumInterestRate.Size = new System.Drawing.Size(86, 26);
            this.maximumInterestRate.TabIndex = 6;
            // 
            // minimumTermLabel
            // 
            this.minimumTermLabel.AutoSize = true;
            this.minimumTermLabel.Location = new System.Drawing.Point(169, 104);
            this.minimumTermLabel.Name = "minimumTermLabel";
            this.minimumTermLabel.Size = new System.Drawing.Size(163, 18);
            this.minimumTermLabel.TabIndex = 5;
            this.minimumTermLabel.Text = "Минимална срочност";
            // 
            // maximumIntRateerestLabel
            // 
            this.maximumIntRateerestLabel.AutoSize = true;
            this.maximumIntRateerestLabel.Location = new System.Drawing.Point(169, 65);
            this.maximumIntRateerestLabel.Name = "maximumIntRateerestLabel";
            this.maximumIntRateerestLabel.Size = new System.Drawing.Size(220, 18);
            this.maximumIntRateerestLabel.TabIndex = 4;
            this.maximumIntRateerestLabel.Text = "Максимален лихвен процент";
            // 
            // minimumInterestRate
            // 
            this.minimumInterestRate.Location = new System.Drawing.Point(429, 14);
            this.minimumInterestRate.Name = "minimumInterestRate";
            this.minimumInterestRate.Size = new System.Drawing.Size(86, 26);
            this.minimumInterestRate.TabIndex = 2;
            // 
            // minimumInterestRateLabel
            // 
            this.minimumInterestRateLabel.AutoSize = true;
            this.minimumInterestRateLabel.Location = new System.Drawing.Point(169, 22);
            this.minimumInterestRateLabel.Name = "minimumInterestRateLabel";
            this.minimumInterestRateLabel.Size = new System.Drawing.Size(214, 18);
            this.minimumInterestRateLabel.TabIndex = 0;
            this.minimumInterestRateLabel.Text = "Минимален лихвен процент";
            // 
            // SearchCreditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningCreditSystem.Desktop.Properties.Resources.BusinessBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 480);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPanel);
            this.DoubleBuffered = true;
            this.Name = "SearchCreditProducts";
            this.Text = "SearchCreditProducts";
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
        private System.Windows.Forms.ComboBox productStatus;
        private System.Windows.Forms.Label productStatusLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productCode;
        private System.Windows.Forms.TabPage customerDetails;
        private System.Windows.Forms.TextBox maximumSum;
        private System.Windows.Forms.TextBox minimumInterestRate;
        private System.Windows.Forms.Label minimumInterestRateLabel;
        private System.Windows.Forms.TextBox minimumTerm;
        private System.Windows.Forms.Label maximumTermLabel;
        private System.Windows.Forms.TextBox maximumInterestRate;
        private System.Windows.Forms.Label minimumTermLabel;
        private System.Windows.Forms.Label maximumIntRateerestLabel;
        private System.Windows.Forms.TextBox maximumTerm;
        private System.Windows.Forms.TextBox minimumSum;
        private System.Windows.Forms.Label minimumSumLabel;
        private System.Windows.Forms.Label maximumSumLabel;
    }
}