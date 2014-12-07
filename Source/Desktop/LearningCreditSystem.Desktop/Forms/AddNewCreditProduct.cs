namespace LearningCreditSystem.Desktop.Forms
{
    using LearningCreditSystem.Desktop.Common;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class AddNewCreditProduct : Form
    {
        public AddNewCreditProduct()
        {
            InitializeComponent();

            addNewProductButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            addNewProductButton.ForeColor = Color.Black;
        }
    }
}
