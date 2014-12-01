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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PINLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.customerLastName = new System.Windows.Forms.TextBox();
            this.customerFirstName = new System.Windows.Forms.TextBox();
            this.customerDetails = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.minimalInterestRateLabel = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.customerMainData.Controls.Add(this.comboBox1);
            this.customerMainData.Controls.Add(this.label1);
            this.customerMainData.Controls.Add(this.PINLabel);
            this.customerMainData.Controls.Add(this.productCodeLabel);
            this.customerMainData.Controls.Add(this.customerLastName);
            this.customerMainData.Controls.Add(this.customerFirstName);
            this.customerMainData.Location = new System.Drawing.Point(4, 27);
            this.customerMainData.Name = "customerMainData";
            this.customerMainData.Padding = new System.Windows.Forms.Padding(3);
            this.customerMainData.Size = new System.Drawing.Size(651, 232);
            this.customerMainData.TabIndex = 0;
            this.customerMainData.Text = "Основни данни";
            this.customerMainData.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Активен",
            "Неактивен"});
            this.comboBox1.Location = new System.Drawing.Point(321, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 26);
            this.comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Статус";
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.Location = new System.Drawing.Point(140, 32);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(36, 18);
            this.PINLabel.TabIndex = 5;
            this.PINLabel.Text = "Код";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(140, 87);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(114, 18);
            this.productCodeLabel.TabIndex = 3;
            this.productCodeLabel.Text = "Наименование";
            // 
            // customerLastName
            // 
            this.customerLastName.Location = new System.Drawing.Point(321, 84);
            this.customerLastName.Name = "customerLastName";
            this.customerLastName.Size = new System.Drawing.Size(161, 26);
            this.customerLastName.TabIndex = 1;
            // 
            // customerFirstName
            // 
            this.customerFirstName.Location = new System.Drawing.Point(321, 32);
            this.customerFirstName.Name = "customerFirstName";
            this.customerFirstName.Size = new System.Drawing.Size(161, 26);
            this.customerFirstName.TabIndex = 0;
            // 
            // customerDetails
            // 
            this.customerDetails.Controls.Add(this.textBox4);
            this.customerDetails.Controls.Add(this.label6);
            this.customerDetails.Controls.Add(this.label5);
            this.customerDetails.Controls.Add(this.textBox3);
            this.customerDetails.Controls.Add(this.textBox2);
            this.customerDetails.Controls.Add(this.phoneInput);
            this.customerDetails.Controls.Add(this.label4);
            this.customerDetails.Controls.Add(this.textBox1);
            this.customerDetails.Controls.Add(this.label3);
            this.customerDetails.Controls.Add(this.label2);
            this.customerDetails.Controls.Add(this.emailInput);
            this.customerDetails.Controls.Add(this.minimalInterestRateLabel);
            this.customerDetails.Location = new System.Drawing.Point(4, 27);
            this.customerDetails.Name = "customerDetails";
            this.customerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.customerDetails.Size = new System.Drawing.Size(651, 283);
            this.customerDetails.TabIndex = 1;
            this.customerDetails.Text = "Детайли";
            this.customerDetails.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(429, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 26);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Максимална срочност";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Минимална срочност";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Максимален лихвен процент";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(429, 14);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(86, 26);
            this.emailInput.TabIndex = 2;
            // 
            // minimalInterestRateLabel
            // 
            this.minimalInterestRateLabel.AutoSize = true;
            this.minimalInterestRateLabel.Location = new System.Drawing.Point(169, 22);
            this.minimalInterestRateLabel.Name = "minimalInterestRateLabel";
            this.minimalInterestRateLabel.Size = new System.Drawing.Size(214, 18);
            this.minimalInterestRateLabel.TabIndex = 0;
            this.minimalInterestRateLabel.Text = "Минимален лихвен процент";
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(429, 185);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(86, 26);
            this.phoneInput.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(429, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 26);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Максимална изискана сума";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Минимална изискана сума";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(429, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 26);
            this.textBox4.TabIndex = 12;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.TextBox customerLastName;
        private System.Windows.Forms.TextBox customerFirstName;
        private System.Windows.Forms.TabPage customerDetails;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label minimalInterestRateLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}