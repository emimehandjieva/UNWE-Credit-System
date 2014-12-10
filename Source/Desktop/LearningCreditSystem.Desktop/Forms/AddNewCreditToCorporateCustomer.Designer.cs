namespace LearningCreditSystem.Desktop.Forms
{
    partial class AddNewCreditToCorporateCustomer
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
            this.newCreditDataContainer.SuspendLayout();
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
            // AddNewCredit
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
            this.Name = "AddNewCredit";
            this.Text = "AddNewCredit";
            this.newCreditDataContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl newCreditDataContainer;
        private System.Windows.Forms.TabPage customerTab;
        private System.Windows.Forms.TabPage creditTab;
        private System.Windows.Forms.Button fulfillCustomerDataButton;
        private System.Windows.Forms.Button fulfillCreditDataButton;
        private System.Windows.Forms.Button addNewCreditButton;
    }
}