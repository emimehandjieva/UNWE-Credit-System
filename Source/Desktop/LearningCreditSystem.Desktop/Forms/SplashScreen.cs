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
    using LearningCreditSystem.Data;

    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            var context = new CreaditSystemEntities();

            context.CLIENT.Add(new CLIENT
            {
                CLIENT_FULLNAME = "Pesho Pehev",

            });

            

            InitializeComponent();
        }
    }
}
