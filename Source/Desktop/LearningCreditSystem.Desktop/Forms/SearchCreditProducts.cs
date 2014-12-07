namespace LearningCreditSystem.Desktop.Forms
{
    using LearningCreditSystem.Desktop.Common;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class SearchCreditProducts : Form
    {
        public SearchCreditProducts()
        {
            InitializeComponent();

            searchButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            searchButton.ForeColor = Color.Black;
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            // Get search parametes
            string creditProductCode = productCode.Text.Trim();
            string creditProductName = productName.Text.Trim();
            string creditProductStatus = productStatus.Text.Trim();
            string creditProductMinimalInterestRate = minimumInterestRate.Text;
            string creditProductMaximalInterestRate = maximumInterestRate.Text;
            string creditProductMinimumTerm = minimumTerm.Text;
            string creditProductMaximumTerm = maximumTerm.Text;
            string creditPeoductMinimumSum = minimumSum.Text;
            string creditProductMaximumSum = maximumSum.Text;

            // Retieve information and pass it to the main form to be displayed
            // Data from database search
            List<string[]> searchResults = new List<string[]>();

            // Sample data for test usage
            string[] firstSampleResult = { "129010050", "СуперПродукт", "Активен", "2540", "8527", "765786", "786876", "8686", "86876" };
            searchResults.Add(firstSampleResult);
            MainScreen.DataToBeDisplayed = searchResults;

            // Pass to the main form all search parametes
            // This way we allow the user to see all search parameters used in the query
            // Sample format : "<Parameter Name> : <Value>"
            //                   Име на кредитен продукт: Име
            MainScreen.SearchParameteres = "These are the results from credit product search search";
            this.Close();
        }

       
    }
}
