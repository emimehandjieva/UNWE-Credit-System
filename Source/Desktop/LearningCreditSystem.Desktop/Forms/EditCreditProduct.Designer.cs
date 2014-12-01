namespace LearningCreditSystem.Desktop.Forms
{
    partial class EditCreditProduct
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
            this.currentCustomer = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currentCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // currentCustomer
            // 
            this.currentCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.currentCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentCustomer.Location = new System.Drawing.Point(89, 25);
            this.currentCustomer.Name = "currentCustomer";
            this.currentCustomer.Size = new System.Drawing.Size(685, 117);
            this.currentCustomer.TabIndex = 7;
            // 
            // editButton
            // 
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButton.Location = new System.Drawing.Point(821, 55);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(135, 54);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Редактирай";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // EditCreditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningCreditSystem.Desktop.Properties.Resources.BusinessBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 171);
            this.Controls.Add(this.currentCustomer);
            this.Controls.Add(this.editButton);
            this.DoubleBuffered = true;
            this.Name = "EditCreditProduct";
            this.Text = "EditCreditProduct";
            ((System.ComponentModel.ISupportInitialize)(this.currentCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView currentCustomer;
        private System.Windows.Forms.Button editButton;
    }
}