namespace LearningCreditSystem.Desktop.Forms.Common
{
    using System.Windows.Forms;

    public partial class BaseForm : Form
    {
        protected  BaseForm()
        {
            this.InitializeComponent();

            // Font Settings
        }

        protected void ShowMessage(string caption, string message)
        {
            var buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
    }
}
