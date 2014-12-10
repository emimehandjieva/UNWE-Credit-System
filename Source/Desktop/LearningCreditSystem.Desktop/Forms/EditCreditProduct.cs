namespace LearningCreditSystem.Desktop.Forms
{
    using LearningCreditSystem.Desktop.Common;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class EditCreditProduct : Form
    {
        public EditCreditProduct(string[] columnNames, string[] creditProductData)
        {
            InitializeComponent();

            int columnsCount = columnNames.Length;
            currentCreditProduct.ColumnCount = columnNames.Length;

            for (int column = 0; column < columnsCount; column++)
            {
                currentCreditProduct.Columns[column].Name = columnNames[column];
            }
            currentCreditProduct.Rows.Add(creditProductData);

            editButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            editButton.ForeColor = Color.Black;
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
