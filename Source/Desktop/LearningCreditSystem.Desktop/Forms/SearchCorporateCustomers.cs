namespace LearningCreditSystem.Desktop.Forms
{
    using LearningCreditSystem.Desktop.Common;
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

        private void SearchCorporateCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen.SearchParameteres = "These are the results from coporate customers search";
        }
    }
}
