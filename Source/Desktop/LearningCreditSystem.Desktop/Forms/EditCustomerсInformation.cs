namespace LearningCreditSystem.Desktop.Forms
{
    using LearningCreditSystem.Desktop.Common;
    using System.Drawing;
    using System.Windows.Forms;
    using System;

    public partial class EditCustomerсInformation : Form
    {
        public EditCustomerсInformation(string[] columnNames, string[] customerData)
        {
            InitializeComponent();

            int columnsCount = columnNames.Length;
            currentCustomer.ColumnCount = columnNames.Length;

            for (int column = 0; column < columnsCount; column++)
            {
                currentCustomer.Columns[column].Name = columnNames[column];
            }
            currentCustomer.Rows.Add(customerData);

            editButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            editButton.ForeColor = Color.Black;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // TODO Update query to modify the data entered in the datagridview
            // Success or error message
            this.Close();
        }
    }
}
