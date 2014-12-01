namespace LearningCreditSystem.Desktop.Forms
{
    using LearningCreditSystem.Desktop.Common;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class SearchCorporateCustomers : Form
    {
        public SearchCorporateCustomers()
        {
            InitializeComponent();

            searchPanel.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);
            searchButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            customerMainData.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);
            customerDetails.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);
            searchButton.ForeColor = Color.Black;
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            // Get search parametes
            string UIC = companyUIC.Text;
            string name = companyName.Text;
            string email = companyEmail.Text;
            string phone = companyPhone.Text;

            // Retieve information and pass it to the main form to be displayed
            // Data from database search
            List<string[]> searchResults = new List<string[]>();

            // Sample data for test usage
            string[] firstSampleResult = { "129010050", "ФирмаООД", "mail.bg", "08594752369" };
            searchResults.Add(firstSampleResult);
            MainScreen.DataToBeDisplayed = searchResults;

            // Pass to the main form all search parametes
            // This way we allow the user to see all search parameters used in the query
            // Sample format : "<Parameter Name> : <Value>"
            //                   Фирма: ФирмаООД
            MainScreen.SearchParameteres = "These are the results from coporate customers search";
            this.Close();
        }
    }
}
