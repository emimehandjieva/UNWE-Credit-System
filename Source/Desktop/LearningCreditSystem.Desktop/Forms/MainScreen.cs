namespace LearningCreditSystem.Desktop.Forms
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using LearningCreditSystem.Desktop.Common;
    using LearningCreditSystem.Desktop.Forms.Common;

    public partial class MainScreen : BaseForm
    {
        private static string[] individualCustomersColumnNames = {"ЕГН", "Име", "Фамилия", "Имейл", "Телефон"};
        private static string[] corporateCustomersColumnNames = {"БУЛСТАТ", "Фирма", "Имейл", "Телефон"};
        private static string[] creditProductColumnNames = 
            { "Код на продукт", "Име на продукт", "Статус", "Минимален лихвен процент", 
                "Максимален лихвен процент", "Минимална срочност", "Максимална срочност", "Минимална сума", "Максимална сума" };

        public MainScreen()
        {
            InitializeComponent();

            // All tabs
            customersTab.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);
            creditProductsTab.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);
            contractsTab.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);

            // Customers tab
            registerCorpoarateCustomers.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            registerCorpoarateCustomers.ForeColor = Color.Black;
            registerIndividualCustomersButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            registerIndividualCustomersButton.ForeColor = Color.Black;
            addCreditButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            addCreditButton.ForeColor = Color.Black;

            // Credit products tab
            creditProductsRegisterButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            creditProductsRegisterButton.ForeColor = Color.Black;
            newCreditProductButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            newCreditProductButton.ForeColor = Color.Black;

            // Credits tab
            creditRegisterButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            creditRegisterButton.ForeColor = Color.Black;
            addNewCreditButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            addNewCreditButton.ForeColor = Color.Black;

        }

        public static string SearchParameteres { get; set; }

        public static string[] CurrentColumnNames { get; set; }

        public static List<string[]> DataToBeDisplayed { get; set; }

        private void FillSearchParametersField(RichTextBox searchParametersField)
        {
            searchParametersField.Text = SearchParameteres;
        }

        private void SetColumnNames(DataGridView dataGridView)
        {
            ClearDatagridView(dataGridView);

            int columnsCount = CurrentColumnNames.Length;
            dataGridView.ColumnCount = columnsCount;

            for (int column = 0; column < columnsCount; column++)
            {
                dataGridView.Columns[column].Name = CurrentColumnNames[column];
            }
        }

        private void DisplayData(DataGridView dataGridView)
        {
            foreach (var row in DataToBeDisplayed)
            {
                dataGridView.Rows.Add(row);
            }
        }

        private void ClearDatagridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }

        private void registerIndividualCustomers_Click(object sender, System.EventArgs e)
        {
            var searchForm = new SearchIndividualCustomers();
            searchForm.ShowDialog();
            FillSearchParametersField(customersSearchParameters);
            CurrentColumnNames = individualCustomersColumnNames;
            SetColumnNames(customersDatagridView);
            DisplayData(customersDatagridView);
        }

        private void registerCorporateCustomers_Click(object sender, System.EventArgs e)
        {
            var searchForm = new SearchCorporateCustomers();
            searchForm.ShowDialog();
            FillSearchParametersField(customersSearchParameters);
            CurrentColumnNames = corporateCustomersColumnNames;
            SetColumnNames(customersDatagridView);
            DisplayData(customersDatagridView);
        }

        private void creditProductsRegisterButton_Click(object sender, System.EventArgs e)
        {
            var searchForm = new SearchCreditProducts();
            searchForm.ShowDialog();
            FillSearchParametersField(creditProductSearchParameters);
            CurrentColumnNames = creditProductColumnNames;
            SetColumnNames(creditProductsDatagridView);
            DisplayData(creditProductsDatagridView);
        }

        private void newCreditProductButton_Click(object sender, System.EventArgs e)
        {
            var newCreditProductForm = new AddNewCreditProduct();
            newCreditProductForm.ShowDialog();
        }

        private void customerDatagridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentRowSelected = customersDatagridView.CurrentRow;
            List<string> customerDataList = new List<string>();
            foreach (DataGridViewTextBoxCell cell in currentRowSelected.Cells)
            {
                customerDataList.Add(cell.Value.ToString());
            }
            string[] customerData = customerDataList.ToArray();
            var editForm = new EditCustomerсInformation(CurrentColumnNames, customerData);
            editForm.ShowDialog();
        }

        private void addNewCreditButton_Click(object sender, System.EventArgs e)
        {
            var newCreditForm = new AddNewCredit();
            newCreditForm.Show();
        }

        private void addCreditButton_Click(object sender, System.EventArgs e)
        {
            bool hasCustomers = customersDatagridView.Rows.Count > 0;
            bool hasSelectedCustomer = customersDatagridView.SelectedRows.Count > 0;
            if (!hasCustomers)
            {
                base.ShowMessage("No customers", "Please search for customers before add new credit");
            }
            else if (!hasSelectedCustomer)
            {
                base.ShowMessage("No customers", "Please select a customer before add new credit");
            }
            else
            {
                AddNewCredit newCreditForm = new AddNewCredit();
                newCreditForm.ShowDialog();
            }
        }

        private void credits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            base.ShowMessage("", "Clicked");
        }
    }
}
