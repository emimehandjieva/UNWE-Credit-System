namespace LearningCreditSystem.Desktop.Forms
{
    partial class CreditDetails
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
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.searchParameters = new System.Windows.Forms.RichTextBox();
            this.individualCustomersList = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registerEntityCustomers = new System.Windows.Forms.Button();
            this.registerIndividualCustomers = new System.Windows.Forms.Button();
            this.creditProductsTab = new System.Windows.Forms.TabPage();
            this.newCreditProductButton = new System.Windows.Forms.Button();
            this.creditProductsRegisterButton = new System.Windows.Forms.Button();
            this.searchResults = new System.Windows.Forms.RichTextBox();
            this.creditProductsDatagridView = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CreditNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTab = new System.Windows.Forms.TabPage();
            this.tabContainer.SuspendLayout();
            this.customersTab.SuspendLayout();
            this.creditProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditProductsDatagridView)).BeginInit();
            this.contractsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.customersTab);
            this.tabContainer.Controls.Add(this.creditProductsTab);
            this.tabContainer.Controls.Add(this.contractsTab);
            this.tabContainer.Controls.Add(this.exitTab);
            this.tabContainer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabContainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabContainer.Location = new System.Drawing.Point(90, 61);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(795, 484);
            this.tabContainer.TabIndex = 2;
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.searchParameters);
            this.customersTab.Controls.Add(this.individualCustomersList);
            this.customersTab.Controls.Add(this.registerEntityCustomers);
            this.customersTab.Controls.Add(this.registerIndividualCustomers);
            this.customersTab.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersTab.Location = new System.Drawing.Point(4, 27);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(10);
            this.customersTab.Size = new System.Drawing.Size(787, 453);
            this.customersTab.TabIndex = 0;
            this.customersTab.Text = "Клиенти";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // searchParameters
            // 
            this.searchParameters.Enabled = false;
            this.searchParameters.Location = new System.Drawing.Point(254, 134);
            this.searchParameters.Name = "searchParameters";
            this.searchParameters.Size = new System.Drawing.Size(424, 96);
            this.searchParameters.TabIndex = 3;
            this.searchParameters.Text = "                                   Няма данни за търсене";
            // 
            // individualCustomersList
            // 
            this.individualCustomersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName,
            this.PIN,
            this.phone,
            this.Email});
            this.individualCustomersList.FullRowSelect = true;
            this.individualCustomersList.GridLines = true;
            this.individualCustomersList.LabelEdit = true;
            this.individualCustomersList.Location = new System.Drawing.Point(41, 267);
            this.individualCustomersList.Name = "individualCustomersList";
            this.individualCustomersList.Size = new System.Drawing.Size(821, 211);
            this.individualCustomersList.TabIndex = 2;
            this.individualCustomersList.UseCompatibleStateImageBehavior = false;
            this.individualCustomersList.View = System.Windows.Forms.View.Details;
            // 
            // firstName
            // 
            this.firstName.Text = "Име";
            this.firstName.Width = 138;
            // 
            // lastName
            // 
            this.lastName.Text = "Фамилия";
            this.lastName.Width = 144;
            // 
            // PIN
            // 
            this.PIN.Text = "ЕГН";
            // 
            // phone
            // 
            this.phone.Text = "Телефон";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            // 
            // registerEntityCustomers
            // 
            this.registerEntityCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerEntityCustomers.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerEntityCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerEntityCustomers.Location = new System.Drawing.Point(591, 45);
            this.registerEntityCustomers.Name = "registerEntityCustomers";
            this.registerEntityCustomers.Size = new System.Drawing.Size(164, 55);
            this.registerEntityCustomers.TabIndex = 1;
            this.registerEntityCustomers.Text = "Регистър ЮЛ";
            this.registerEntityCustomers.UseVisualStyleBackColor = true;
            // 
            // registerIndividualCustomers
            // 
            this.registerIndividualCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerIndividualCustomers.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerIndividualCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerIndividualCustomers.Location = new System.Drawing.Point(168, 45);
            this.registerIndividualCustomers.Name = "registerIndividualCustomers";
            this.registerIndividualCustomers.Size = new System.Drawing.Size(167, 55);
            this.registerIndividualCustomers.TabIndex = 0;
            this.registerIndividualCustomers.Text = "Регистър ФЛ";
            this.registerIndividualCustomers.UseVisualStyleBackColor = true;
            // 
            // creditProductsTab
            // 
            this.creditProductsTab.Controls.Add(this.newCreditProductButton);
            this.creditProductsTab.Controls.Add(this.creditProductsRegisterButton);
            this.creditProductsTab.Controls.Add(this.searchResults);
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
            this.newCreditProductButton.Text = "Регистър продукти";
            this.newCreditProductButton.UseVisualStyleBackColor = true;
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
            // 
            // searchResults
            // 
            this.searchResults.Location = new System.Drawing.Point(169, 139);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(476, 137);
            this.searchResults.TabIndex = 3;
            this.searchResults.Text = "                                       Няма данни от търсене";
            // 
            // creditProductsDatagridView
            // 
            this.creditProductsDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.creditProductsDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditProductsDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Product,
            this.Status,
            this.MinInterest,
            this.MaxInterest,
            this.MinPeriod,
            this.MaxPeriod});
            this.creditProductsDatagridView.Enabled = false;
            this.creditProductsDatagridView.Location = new System.Drawing.Point(18, 299);
            this.creditProductsDatagridView.Name = "creditProductsDatagridView";
            this.creditProductsDatagridView.Size = new System.Drawing.Size(846, 176);
            this.creditProductsDatagridView.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код на продукт";
            this.Code.Name = "Code";
            // 
            // Product
            // 
            this.Product.HeaderText = "Име на продукт";
            this.Product.Name = "Product";
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // MinInterest
            // 
            this.MinInterest.HeaderText = "Минимална лихен процент";
            this.MinInterest.Name = "MinInterest";
            // 
            // MaxInterest
            // 
            this.MaxInterest.HeaderText = "Максимален лихвен процент";
            this.MaxInterest.Name = "MaxInterest";
            // 
            // MinPeriod
            // 
            this.MinPeriod.HeaderText = "Минимален период";
            this.MinPeriod.Name = "MinPeriod";
            // 
            // MaxPeriod
            // 
            this.MaxPeriod.HeaderText = "Максимален период";
            this.MaxPeriod.Name = "MaxPeriod";
            // 
            // contractsTab
            // 
            this.contractsTab.Controls.Add(this.dataGridView1);
            this.contractsTab.Location = new System.Drawing.Point(4, 27);
            this.contractsTab.Name = "contractsTab";
            this.contractsTab.Padding = new System.Windows.Forms.Padding(3);
            this.contractsTab.Size = new System.Drawing.Size(890, 503);
            this.contractsTab.TabIndex = 2;
            this.contractsTab.Text = "Договори";
            this.contractsTab.UseVisualStyleBackColor = true;
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
            this.CreditEnd});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(34, 221);
            this.dataGridView1.Name = "dataGridView1";
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
            // CreditDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningCreditSystem.Desktop.Properties.Resources.BusinessBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 618);
            this.Controls.Add(this.tabContainer);
            this.DoubleBuffered = true;
            this.Name = "CreditDetails";
            this.Text = "CreditDetails";
            this.tabContainer.ResumeLayout(false);
            this.customersTab.ResumeLayout(false);
            this.creditProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creditProductsDatagridView)).EndInit();
            this.contractsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.RichTextBox searchParameters;
        private System.Windows.Forms.ListView individualCustomersList;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader PIN;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button registerEntityCustomers;
        private System.Windows.Forms.Button registerIndividualCustomers;
        private System.Windows.Forms.TabPage creditProductsTab;
        private System.Windows.Forms.Button newCreditProductButton;
        private System.Windows.Forms.Button creditProductsRegisterButton;
        private System.Windows.Forms.RichTextBox searchResults;
        private System.Windows.Forms.DataGridView creditProductsDatagridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPeriod;
        private System.Windows.Forms.TabPage contractsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditEnd;
        private System.Windows.Forms.TabPage exitTab;
    }
}