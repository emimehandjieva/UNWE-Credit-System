namespace LearningCreditSystem.Desktop
{
    using System;
    using System.Windows.Forms;
    using LearningCreditSystem.Desktop.Forms;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //var splashScreen = new SplashScreen();
            //if (splashScreen.ShowDialog() == DialogResult.OK)
            //{
                Application.Run(new LoginForm());
            //}

        }
    }
}
