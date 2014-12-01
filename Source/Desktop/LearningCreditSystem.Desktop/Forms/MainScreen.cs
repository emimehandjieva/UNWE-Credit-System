namespace LearningCreditSystem.Desktop.Forms
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using LearningCreditSystem.Desktop.Common;

    public partial class MainScreen : Form
    {
        private static string[] individualCustomersColumnNames = {"ЕГН", "Име", "Фамилия", "Имейл", "Телефон"};
        private static string[] corporateCustomersColumnNames = {"БУЛСТАТ", "Фирма", "Имейл", "Телефон"};

        public MainScreen()
        {
            InitializeComponent();
            tabContainer.SelectedTab = creditProductsTab; // Useful works - use it later

            // All tabs
            customersTab.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);
            creditProductsTab.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);
            contractsTab.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);

            registerCorpoarateCustomers.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            registerCorpoarateCustomers.ForeColor = Color.Black;
            registerIndividualCustomersButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            registerIndividualCustomersButton.ForeColor = Color.Black;
            creditProductsRegisterButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            creditProductsRegisterButton.ForeColor = Color.Black;
            newCreditProductButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            newCreditProductButton.ForeColor = Color.Black;
        }

        public static string SearchParameteres { get; set; }

        public static string[] CurrentColumnNames { get; set; }

        public static List<string[]> DataToBeDisplayed { get; set; }

        private void FillSearchParametersField()
        {
            searchParametersField.Text = SearchParameteres;
        }

        private void SetColumnNames()
        {
            int columnsCount = CurrentColumnNames.Length;
            customersDatagridView.ColumnCount = columnsCount;

            for (int column = 0; column < columnsCount; column++)
            {
                customersDatagridView.Columns[column].Name = CurrentColumnNames[column];
            }
        }

        private void DisplayData()
        {
            foreach (var row in DataToBeDisplayed)
            {
                customersDatagridView.Rows.Add(row);
            }
        }

        private void registerIndividualCustomers_Click(object sender, System.EventArgs e)
        {
            var searchForm = new SearchIndividualCustomers();
            searchForm.ShowDialog();
            FillSearchParametersField();
            CurrentColumnNames = individualCustomersColumnNames;
            SetColumnNames();
            DisplayData();
        }

        private void registerCorporateCustomers_Click(object sender, System.EventArgs e)
        {
            var searchForm = new SearchCorporateCustomers();
            searchForm.ShowDialog();
            FillSearchParametersField();
            CurrentColumnNames = corporateCustomersColumnNames;
            SetColumnNames();
            DisplayData();
        }

        private void creditProductsRegisterButton_Click(object sender, System.EventArgs e)
        {
            var searchForm = new SearchCreditProducts();
            searchForm.ShowDialog();
        }

        private void newCreditProductButton_Click(object sender, System.EventArgs e)
        {
            var newCreditProductForm = new AddNewCreditProduct();
            newCreditProductForm.ShowDialog();
        }

        private void customerDatagridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentRowSelected = customersDatagridView.CurrentRow;
            string PIN = currentRowSelected.Cells[0].Value.ToString();
            string firstName = currentRowSelected.Cells[1].Value.ToString();
            string lastName = currentRowSelected.Cells[2].Value.ToString();
            string email = currentRowSelected.Cells[3].Value.ToString();
            string phone = currentRowSelected.Cells[4].Value.ToString();
            string[] customerData = {PIN, firstName, lastName, email, phone};
            var editForm = new EditCustomerсInformation(CurrentColumnNames, customerData);
            editForm.ShowDialog();
        }
    }
}
