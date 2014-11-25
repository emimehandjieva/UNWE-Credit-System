﻿using System;
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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            splashScreenTimer.Enabled = true;
            splashScreenTimer.Interval = 3000;
            splashScreenTimer.Tick += (splashScreenTimer_Tick);
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            splashScreenTimer.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
