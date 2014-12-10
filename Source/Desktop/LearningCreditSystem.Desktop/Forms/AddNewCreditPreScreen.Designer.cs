namespace LearningCreditSystem.Desktop.Forms
{
    partial class AddNewCreditPreScreen
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
            this.addCreditToIndividualCustomer = new System.Windows.Forms.Button();
            this.addCreditToCorporateCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCreditToIndividualCustomer
            // 
            this.addCreditToIndividualCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCreditToIndividualCustomer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCreditToIndividualCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCreditToIndividualCustomer.Location = new System.Drawing.Point(70, 149);
            this.addCreditToIndividualCustomer.Name = "addCreditToIndividualCustomer";
            this.addCreditToIndividualCustomer.Size = new System.Drawing.Size(251, 82);
            this.addCreditToIndividualCustomer.TabIndex = 6;
            this.addCreditToIndividualCustomer.Text = "Физическо лице";
            this.addCreditToIndividualCustomer.UseVisualStyleBackColor = true;
            this.addCreditToIndividualCustomer.Click += new System.EventHandler(this.addCreditToIndividualCustomer_Click);
            // 
            // addCreditToCorporateCustomer
            // 
            this.addCreditToCorporateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCreditToCorporateCustomer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCreditToCorporateCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCreditToCorporateCustomer.Location = new System.Drawing.Point(360, 149);
            this.addCreditToCorporateCustomer.Name = "addCreditToCorporateCustomer";
            this.addCreditToCorporateCustomer.Size = new System.Drawing.Size(251, 82);
            this.addCreditToCorporateCustomer.TabIndex = 7;
            this.addCreditToCorporateCustomer.Text = "Юридическо лице";
            this.addCreditToCorporateCustomer.UseVisualStyleBackColor = true;
            this.addCreditToCorporateCustomer.Click += new System.EventHandler(this.addCreditToCorporateCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Изберете тип клиент";
            // 
            // AddNewCreditPreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningCreditSystem.Desktop.Properties.Resources.BusinessBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCreditToCorporateCustomer);
            this.Controls.Add(this.addCreditToIndividualCustomer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewCreditPreScreen";
            this.Text = "AddNewCreditPreScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCreditToIndividualCustomer;
        private System.Windows.Forms.Button addCreditToCorporateCustomer;
        private System.Windows.Forms.Label label1;
    }
}