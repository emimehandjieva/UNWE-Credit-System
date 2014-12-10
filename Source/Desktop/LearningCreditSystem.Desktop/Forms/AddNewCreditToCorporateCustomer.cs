namespace LearningCreditSystem.Desktop.Forms
{
    using LearningCreditSystem.Desktop.Common;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class AddNewCreditToCorporateCustomer : Form
    {
        public AddNewCreditToCorporateCustomer()
        {
            InitializeComponent();

            fulfillCustomerDataButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            fulfillCustomerDataButton.ForeColor = Color.Black;
            fulfillCreditDataButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            fulfillCreditDataButton.ForeColor = Color.Black;
            addNewCreditButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            addNewCreditButton.ForeColor = Color.Black;
        }

        private void fulfillCustomerDataButton_Click(object sender, System.EventArgs e)
        {
            newCreditDataContainer.SelectedTab = customerTab;
        }

        private void fulfillCreditDataButton_Click(object sender, System.EventArgs e)
        {
            newCreditDataContainer.SelectedTab = creditTab;
        }
    }
}
