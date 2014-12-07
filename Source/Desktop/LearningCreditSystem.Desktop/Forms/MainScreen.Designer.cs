namespace LearningCreditSystem.Desktop.Forms
{
    partial class MainScreen
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
            this.searchParameters = new System.Windows.Forms.TabControl();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.customersDatagridView = new System.Windows.Forms.DataGridView();
            this.customersSearchParameters = new System.Windows.Forms.RichTextBox();
            this.registerCorpoarateCustomers = new System.Windows.Forms.Button();
            this.registerIndividualCustomersButton = new System.Windows.Forms.Button();
            this.creditProductsTab = new System.Windows.Forms.TabPage();
            this.newCreditProductButton = new System.Windows.Forms.Button();
            this.creditProductsRegisterButton = new System.Windows.Forms.Button();
            this.creditProductSearchParameters = new System.Windows.Forms.RichTextBox();
            this.creditProductsDatagridView = new System.Windows.Forms.DataGridView();
            this.contractsTab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addNewCreditButton = new System.Windows.Forms.Button();
            this.creditRegisterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CreditNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.exitTab = new System.Windows.Forms.TabPage();
            this.searchParameters.SuspendLayout();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDatagridView)).BeginInit();
            this.creditProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditProductsDatagridView)).BeginInit();
            this.contractsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchParameters
            // 
            this.searchParameters.Controls.Add(this.customersTab);
            this.searchParameters.Controls.Add(this.creditProductsTab);
            this.searchParameters.Controls.Add(this.contractsTab);
            this.searchParameters.Controls.Add(this.exitTab);
            this.searchParameters.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchParameters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchParameters.Location = new System.Drawing.Point(128, 68);
            this.searchParameters.Name = "searchParameters";
            this.searchParameters.SelectedIndex = 0;
            this.searchParameters.Size = new System.Drawing.Size(898, 534);
            this.searchParameters.TabIndex = 1;
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.customersDatagridView);
            this.customersTab.Controls.Add(this.customersSearchParameters);
            this.customersTab.Controls.Add(this.registerCorpoarateCustomers);
            this.customersTab.Controls.Add(this.registerIndividualCustomersButton);
            this.customersTab.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersTab.Location = new System.Drawing.Point(4, 27);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(10);
            this.customersTab.Size = new System.Drawing.Size(890, 503);
            this.customersTab.TabIndex = 0;
            this.customersTab.Text = "Клиенти";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // customersDatagridView
            // 
            this.customersDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDatagridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customersDatagridView.Location = new System.Drawing.Point(13, 281);
            this.customersDatagridView.Name = "customersDatagridView";
            this.customersDatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDatagridView.Size = new System.Drawing.Size(864, 150);
            this.customersDatagridView.TabIndex = 4;
            this.customersDatagridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDatagridView_CellMouseDoubleClick);
            // 
            // customersSearchParameters
            // 
            this.customersSearchParameters.Enabled = false;
            this.customersSearchParameters.Location = new System.Drawing.Point(254, 134);
            this.customersSearchParameters.Name = "customersSearchParameters";
            this.customersSearchParameters.Size = new System.Drawing.Size(424, 96);
            this.customersSearchParameters.TabIndex = 3;
            this.customersSearchParameters.Text = "                                   Няма данни за търсене";
            // 
            // registerCorpoarateCustomers
            // 
            this.registerCorpoarateCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerCorpoarateCustomers.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerCorpoarateCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerCorpoarateCustomers.Location = new System.Drawing.Point(591, 45);
            this.registerCorpoarateCustomers.Name = "registerCorpoarateCustomers";
            this.registerCorpoarateCustomers.Size = new System.Drawing.Size(164, 55);
            this.registerCorpoarateCustomers.TabIndex = 1;
            this.registerCorpoarateCustomers.Text = "Регистър ЮЛ";
            this.registerCorpoarateCustomers.UseVisualStyleBackColor = true;
            this.registerCorpoarateCustomers.Click += new System.EventHandler(this.registerCorporateCustomers_Click);
            // 
            // registerIndividualCustomersButton
            // 
            this.registerIndividualCustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerIndividualCustomersButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerIndividualCustomersButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerIndividualCustomersButton.Location = new System.Drawing.Point(168, 45);
            this.registerIndividualCustomersButton.Name = "registerIndividualCustomersButton";
            this.registerIndividualCustomersButton.Size = new System.Drawing.Size(167, 55);
            this.registerIndividualCustomersButton.TabIndex = 0;
            this.registerIndividualCustomersButton.Text = "Регистър ФЛ";
            this.registerIndividualCustomersButton.UseVisualStyleBackColor = true;
            this.registerIndividualCustomersButton.Click += new System.EventHandler(this.registerIndividualCustomers_Click);
            // 
            // creditProductsTab
            // 
            this.creditProductsTab.Controls.Add(this.newCreditProductButton);
            this.creditProductsTab.Controls.Add(this.creditProductsRegisterButton);
            this.creditProductsTab.Controls.Add(this.creditProductSearchParameters);
            this.creditProductsTab.Controls.Add(this.creditProductsDatagridView);
            this.creditProductsTab.Location = new System.Drawing.Point(4, 27);
            this.creditProductsTab.Name = "creditProductsTab";
            this.creditProductsTab.Padding = new System.Windows.Forms.Padding(3);
            this.creditProductsTab.Size = new System.Drawing.Size(890, 503);
            this.creditProductsTab.TabIndex = 1;
            this.creditProductsTab.Text = "Кредитни продукти";
            this.creditProductsTab.UseVisualStyleBackColor = true;
            // 
            // newCreditProductButton
            // 
            this.newCreditProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCreditProductButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newCreditProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newCreditProductButton.Location = new System.Drawing.Point(524, 42);
            this.newCreditProductButton.Name = "newCreditProductButton";
            this.newCreditProductButton.Size = new System.Drawing.Size(167, 55);
            this.newCreditProductButton.TabIndex = 5;
            this.newCreditProductButton.Text = "Нов продукт";
            this.newCreditProductButton.UseVisualStyleBackColor = true;
            this.newCreditProductButton.Click += new System.EventHandler(this.newCreditProductButton_Click);
            // 
            // creditProductsRegisterButton
            // 
            this.creditProductsRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditProductsRegisterButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditProductsRegisterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creditProductsRegisterButton.Location = new System.Drawing.Point(129, 42);
            this.creditProductsRegisterButton.Name = "creditProductsRegisterButton";
            this.creditProductsRegisterButton.Size = new System.Drawing.Size(167, 55);
            this.creditProductsRegisterButton.TabIndex = 4;
            this.creditProductsRegisterButton.Text = "Регистър продукти";
            this.creditProductsRegisterButton.UseVisualStyleBackColor = true;
            this.creditProductsRegisterButton.Click += new System.EventHandler(this.creditProductsRegisterButton_Click);
            // 
            // creditProductSearchParameters
            // 
            this.creditProductSearchParameters.Location = new System.Drawing.Point(169, 139);
            this.creditProductSearchParameters.Name = "creditProductSearchParameters";
            this.creditProductSearchParameters.Size = new System.Drawing.Size(476, 137);
            this.creditProductSearchParameters.TabIndex = 3;
            this.creditProductSearchParameters.Text = "                                       Няма данни от търсене";
            // 
            // creditProductsDatagridView
            // 
            this.creditProductsDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.creditProductsDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditProductsDatagridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.creditProductsDatagridView.Location = new System.Drawing.Point(18, 299);
            this.creditProductsDatagridView.Name = "creditProductsDatagridView";
            this.creditProductsDatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.creditProductsDatagridView.Size = new System.Drawing.Size(846, 176);
            this.creditProductsDatagridView.TabIndex = 0;
            // 
            // contractsTab
            // 
            this.contractsTab.Controls.Add(this.richTextBox1);
            this.contractsTab.Controls.Add(this.addNewCreditButton);
            this.contractsTab.Controls.Add(this.creditRegisterButton);
            this.contractsTab.Controls.Add(this.dataGridView1);
            this.contractsTab.Location = new System.Drawing.Point(4, 27);
            this.contractsTab.Name = "contractsTab";
            this.contractsTab.Padding = new System.Windows.Forms.Padding(3);
            this.contractsTab.Size = new System.Drawing.Size(890, 503);
            this.contractsTab.TabIndex = 2;
            this.contractsTab.Text = "Договори";
            this.contractsTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(235, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(432, 123);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "                                    Няма данни за търсене";
            // 
            // addNewCreditButton
            // 
            this.addNewCreditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewCreditButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewCreditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewCreditButton.Location = new System.Drawing.Point(500, 40);
            this.addNewCreditButton.Name = "addNewCreditButton";
            this.addNewCreditButton.Size = new System.Drawing.Size(167, 55);
            this.addNewCreditButton.TabIndex = 2;
            this.addNewCreditButton.Text = "Добави нов договор";
            this.addNewCreditButton.UseVisualStyleBackColor = true;
            this.addNewCreditButton.Click += new System.EventHandler(this.addNewCreditButton_Click);
            // 
            // creditRegisterButton
            // 
            this.creditRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditRegisterButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditRegisterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creditRegisterButton.Location = new System.Drawing.Point(150, 40);
            this.creditRegisterButton.Name = "creditRegisterButton";
            this.creditRegisterButton.Size = new System.Drawing.Size(167, 55);
            this.creditRegisterButton.TabIndex = 1;
            this.creditRegisterButton.Text = "Регистър договори";
            this.creditRegisterButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreditNumber,
            this.CreditDate,
            this.CreditPeriod,
            this.CreditStart,
            this.CreditEnd,
            this.Details});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(41, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // CreditNumber
            // 
            this.CreditNumber.HeaderText = "Номер на договор";
            this.CreditNumber.Name = "CreditNumber";
            // 
            // CreditDate
            // 
            this.CreditDate.HeaderText = "Дата на сключване";
            this.CreditDate.Name = "CreditDate";
            // 
            // CreditPeriod
            // 
            this.CreditPeriod.HeaderText = "Срок на договора";
            this.CreditPeriod.Name = "CreditPeriod";
            // 
            // CreditStart
            // 
            this.CreditStart.HeaderText = "Начало на договора";
            this.CreditStart.Name = "CreditStart";
            // 
            // CreditEnd
            // 
            this.CreditEnd.HeaderText = "Край на договора";
            this.CreditEnd.Name = "CreditEnd";
            // 
            // Details
            // 
            this.Details.HeaderText = "Детайли";
            this.Details.Name = "Details";
            this.Details.Text = "Виж";
            // 
            // exitTab
            // 
            this.exitTab.Location = new System.Drawing.Point(4, 27);
            this.exitTab.Name = "exitTab";
            this.exitTab.Padding = new System.Windows.Forms.Padding(3);
            this.exitTab.Size = new System.Drawing.Size(890, 503);
            this.exitTab.TabIndex = 3;
            this.exitTab.Text = "Изход";
            this.exitTab.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningCreditSystem.Desktop.Properties.Resources.BusinessBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 677);
            this.Controls.Add(this.searchParameters);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.searchParameters.ResumeLayout(false);
            this.customersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDatagridView)).EndInit();
            this.creditProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creditProductsDatagridView)).EndInit();
            this.contractsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl searchParameters;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.Button registerCorpoarateCustomers;
        private System.Windows.Forms.Button registerIndividualCustomersButton;
        private System.Windows.Forms.TabPage creditProductsTab;
        private System.Windows.Forms.TabPage contractsTab;
        private System.Windows.Forms.TabPage exitTab;
        private System.Windows.Forms.RichTextBox customersSearchParameters;
        private System.Windows.Forms.DataGridView creditProductsDatagridView;
        private System.Windows.Forms.RichTextBox creditProductSearchParameters;
        private System.Windows.Forms.Button newCreditProductButton;
        private System.Windows.Forms.Button creditProductsRegisterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView customersDatagridView;
        private System.Windows.Forms.Button addNewCreditButton;
        private System.Windows.Forms.Button creditRegisterButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditEnd;
        private System.Windows.Forms.DataGridViewButtonColumn Details;

    }
}