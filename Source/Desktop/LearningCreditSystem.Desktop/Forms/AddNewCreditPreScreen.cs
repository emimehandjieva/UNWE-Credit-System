namespace LearningCreditSystem.Desktop.Forms
{
    using LearningCreditSystem.Desktop.Common;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class AddNewCreditPreScreen : Form
    {
        public AddNewCreditPreScreen()
        {
            InitializeComponent();

            addCreditToIndividualCustomer.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            addCreditToIndividualCustomer.ForeColor = Color.Black;
            addCreditToCorporateCustomer.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            addCreditToCorporateCustomer.ForeColor = Color.Black;
        }

        private void addCreditToIndividualCustomer_Click(object sender, System.EventArgs e)
        {
            var addNewCreditForm = new AddNewCreditToIndividualCustomer();
            this.Hide();
            addNewCreditForm.ShowDialog();

        }

        private void addCreditToCorporateCustomer_Click(object sender, System.EventArgs e)
        {
            var addNewCreditForm = new AddNewCreditToCorporateCustomer();
            this.Hide();
            addNewCreditForm.ShowDialog();
        }                                          
    }
}
