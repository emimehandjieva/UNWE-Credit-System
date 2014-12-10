namespace LearningCreditSystem.Desktop.Forms
{
    partial class AddNewCreditToIndividualCustomer
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
            this.newCreditDataContainer = new System.Windows.Forms.TabControl();
            this.customerTab = new System.Windows.Forms.TabPage();
            this.creditTab = new System.Windows.Forms.TabPage();
            this.fulfillCustomerDataButton = new System.Windows.Forms.Button();
            this.fulfillCreditDataButton = new System.Windows.Forms.Button();
            this.addNewCreditButton = new System.Windows.Forms.Button();
            this.newIndividualCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.customerPhone = new System.Windows.Forms.TextBox();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.PINLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.customerPIN = new System.Windows.Forms.TextBox();
            this.customerLastName = new System.Windows.Forms.TextBox();
            this.customerFirstName = new System.Windows.Forms.TextBox();
            this.searchExistingCustomerButton = new System.Windows.Forms.Button();
            this.newCreditDataContainer.SuspendLayout();
            this.customerTab.SuspendLayout();
            this.newIndividualCustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newCreditDataContainer
            // 
            this.newCreditDataContainer.Controls.Add(this.customerTab);
            this.newCreditDataContainer.Controls.Add(this.creditTab);
            this.newCreditDataContainer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newCreditDataContainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newCreditDataContainer.Location = new System.Drawing.Point(110, 64);
            this.newCreditDataContainer.Name = "newCreditDataContainer";
            this.newCreditDataContainer.SelectedIndex = 0;
            this.newCreditDataContainer.Size = new System.Drawing.Size(869, 460);
            this.newCreditDataContainer.TabIndex = 2;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.searchExistingCustomerButton);
            this.customerTab.Controls.Add(this.newIndividualCustomerGroupBox);
            this.customerTab.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerTab.Location = new System.Drawing.Point(4, 27);
            this.customerTab.Name = "customerTab";
            this.customerTab.Padding = new System.Windows.Forms.Padding(10);
            this.customerTab.Size = new System.Drawing.Size(861, 429);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "Клиент";
            this.customerTab.UseVisualStyleBackColor = true;
            // 
            // creditTab
            // 
            this.creditTab.Location = new System.Drawing.Point(4, 27);
            this.creditTab.Name = "creditTab";
            this.creditTab.Padding = new System.Windows.Forms.Padding(3);
            this.creditTab.Size = new System.Drawing.Size(861, 429);
            this.creditTab.TabIndex = 1;
            this.creditTab.Text = "Договор";
            this.creditTab.UseVisualStyleBackColor = true;
            // 
            // fulfillCustomerDataButton
            // 
            this.fulfillCustomerDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fulfillCustomerDataButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fulfillCustomerDataButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fulfillCustomerDataButton.Location = new System.Drawing.Point(150, 551);
            this.fulfillCustomerDataButton.Name = "fulfillCustomerDataButton";
            this.fulfillCustomerDataButton.Size = new System.Drawing.Size(167, 55);
            this.fulfillCustomerDataButton.TabIndex = 3;
            this.fulfillCustomerDataButton.Text = "Клиент";
            this.fulfillCustomerDataButton.UseVisualStyleBackColor = true;
            this.fulfillCustomerDataButton.Click += new System.EventHandler(this.fulfillCustomerDataButton_Click);
            // 
            // fulfillCreditDataButton
            // 
            this.fulfillCreditDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fulfillCreditDataButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fulfillCreditDataButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fulfillCreditDataButton.Location = new System.Drawing.Point(442, 551);
            this.fulfillCreditDataButton.Name = "fulfillCreditDataButton";
            this.fulfillCreditDataButton.Size = new System.Drawing.Size(167, 55);
            this.fulfillCreditDataButton.TabIndex = 4;
            this.fulfillCreditDataButton.Text = "Договор";
            this.fulfillCreditDataButton.UseVisualStyleBackColor = true;
            this.fulfillCreditDataButton.Click += new System.EventHandler(this.fulfillCreditDataButton_Click);
            // 
            // addNewCreditButton
            // 
            this.addNewCreditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewCreditButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewCreditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewCreditButton.Location = new System.Drawing.Point(691, 551);
            this.addNewCreditButton.Name = "addNewCreditButton";
            this.addNewCreditButton.Size = new System.Drawing.Size(167, 55);
            this.addNewCreditButton.TabIndex = 5;
            this.addNewCreditButton.Text = "Запис";
            this.addNewCreditButton.UseVisualStyleBackColor = true;
            // 
            // newIndividualCustomerGroupBox
            // 
            this.newIndividualCustomerGroupBox.Controls.Add(this.customerPhone);
            this.newIndividualCustomerGroupBox.Controls.Add(this.customerEmail);
            this.newIndividualCustomerGroupBox.Controls.Add(this.phoneLabel);
            this.newIndividualCustomerGroupBox.Controls.Add(this.emailLabel);
            this.newIndividualCustomerGroupBox.Controls.Add(this.PINLabel);
            this.newIndividualCustomerGroupBox.Controls.Add(this.lastNameLabel);
            this.newIndividualCustomerGroupBox.Controls.Add(this.firstNameLabel);
            this.newIndividualCustomerGroupBox.Controls.Add(this.customerPIN);
            this.newIndividualCustomerGroupBox.Controls.Add(this.customerLastName);
            this.newIndividualCustomerGroupBox.Controls.Add(this.customerFirstName);
            this.newIndividualCustomerGroupBox.Location = new System.Drawing.Point(26, 13);
            this.newIndividualCustomerGroupBox.Name = "newIndividualCustomerGroupBox";
            this.newIndividualCustomerGroupBox.Size = new System.Drawing.Size(442, 403);
            this.newIndividualCustomerGroupBox.TabIndex = 16;
            this.newIndividualCustomerGroupBox.TabStop = false;
            this.newIndividualCustomerGroupBox.Text = "Нов клиент";
            // 
            // customerPhone
            // 
            this.customerPhone.Location = new System.Drawing.Point(223, 315);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(157, 26);
            this.customerPhone.TabIndex = 25;
            // 
            // customerEmail
            // 
            this.customerEmail.Location = new System.Drawing.Point(223, 238);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(157, 26);
            this.customerEmail.TabIndex = 24;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(60, 315);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(73, 18);
            this.phoneLabel.TabIndex = 23;
            this.phoneLabel.Text = "Телефон";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(60, 238);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 18);
            this.emailLabel.TabIndex = 22;
            this.emailLabel.Text = "Email";
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.Location = new System.Drawing.Point(59, 47);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(39, 18);
            this.PINLabel.TabIndex = 21;
            this.PINLabel.Text = "ЕГН";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(59, 171);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(75, 18);
            this.lastNameLabel.TabIndex = 20;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(60, 111);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(38, 18);
            this.firstNameLabel.TabIndex = 19;
            this.firstNameLabel.Text = "Име";
            // 
            // customerPIN
            // 
            this.customerPIN.Location = new System.Drawing.Point(219, 163);
            this.customerPIN.Name = "customerPIN";
            this.customerPIN.Size = new System.Drawing.Size(161, 26);
            this.customerPIN.TabIndex = 18;
            // 
            // customerLastName
            // 
            this.customerLastName.Location = new System.Drawing.Point(219, 103);
            this.customerLastName.Name = "customerLastName";
            this.customerLastName.Size = new System.Drawing.Size(161, 26);
            this.customerLastName.TabIndex = 17;
            // 
            // customerFirstName
            // 
            this.customerFirstName.Location = new System.Drawing.Point(219, 47);
            this.customerFirstName.Name = "customerFirstName";
            this.customerFirstName.Size = new System.Drawing.Size(161, 26);
            this.customerFirstName.TabIndex = 16;
            // 
            // searchExistingCustomerButton
            // 
            this.searchExistingCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchExistingCustomerButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchExistingCustomerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchExistingCustomerButton.Location = new System.Drawing.Point(561, 166);
            this.searchExistingCustomerButton.Name = "searchExistingCustomerButton";
            this.searchExistingCustomerButton.Size = new System.Drawing.Size(240, 67);
            this.searchExistingCustomerButton.TabIndex = 7;
            this.searchExistingCustomerButton.Text = "Избери съществуващ";
            this.searchExistingCustomerButton.UseVisualStyleBackColor = true;
            this.searchExistingCustomerButton.Click += new System.EventHandler(this.searchExistingCustomerButton_Click);
            // 
            // AddNewCreditToIndividualCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningCreditSystem.Desktop.Properties.Resources.BusinessBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 675);
            this.Controls.Add(this.addNewCreditButton);
            this.Controls.Add(this.fulfillCreditDataButton);
            this.Controls.Add(this.fulfillCustomerDataButton);
            this.Controls.Add(this.newCreditDataContainer);
            this.DoubleBuffered = true;
            this.Name = "AddNewCreditToIndividualCustomer";
            this.Text = "AddNewCredit";
            this.newCreditDataContainer.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.newIndividualCustomerGroupBox.ResumeLayout(false);
            this.newIndividualCustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl newCreditDataContainer;
        private System.Windows.Forms.TabPage customerTab;
        private System.Windows.Forms.TabPage creditTab;
        private System.Windows.Forms.Button fulfillCustomerDataButton;
        private System.Windows.Forms.Button fulfillCreditDataButton;
        private System.Windows.Forms.Button addNewCreditButton;
        private System.Windows.Forms.Button searchExistingCustomerButton;
        private System.Windows.Forms.GroupBox newIndividualCustomerGroupBox;
        private System.Windows.Forms.TextBox customerPhone;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox customerPIN;
        private System.Windows.Forms.TextBox customerLastName;
        private System.Windows.Forms.TextBox customerFirstName;
    }
}