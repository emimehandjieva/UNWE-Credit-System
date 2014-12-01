using LearningCreditSystem.Desktop.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCreditSystem.Desktop.Forms
{
    public partial class SearchCreditProducts : Form
    {
        public SearchCreditProducts()
        {
            InitializeComponent();

            searchButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            searchButton.ForeColor = Color.Black;
        }

       
    }
}
