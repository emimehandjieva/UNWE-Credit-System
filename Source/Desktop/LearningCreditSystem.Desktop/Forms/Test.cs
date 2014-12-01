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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            //Wrapper
            wrapper.BackColor = ColorFactory.GetColor(ProjectColor.Blue);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         Color.Black, 900, ButtonBorderStyle.Inset,
                                         Color.Black, 900, ButtonBorderStyle.Inset,
                                         Color.Black, 900, ButtonBorderStyle.Inset,
                                         Color.Black, 900, ButtonBorderStyle.Inset);
        }
    }
}
