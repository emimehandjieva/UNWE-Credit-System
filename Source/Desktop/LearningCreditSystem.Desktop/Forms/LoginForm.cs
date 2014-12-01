namespace LearningCreditSystem.Desktop.Forms
{
    using System;
    using LearningCreditSystem.Desktop.Common;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class LoginForm : Form
    {
        private const string UserName = "User";
        private const string Password = "123456";
        private const string ForbidenAccessCaption = "Отказ";
        private const string ForbidenAccessMessage = "Достъп отказан. Моля, въведете Вашето потребителско име и парола отново.";
        private const string SuccessfulLoginCaption = "Вход";
        private const string SuccessfulLoginMessage = "Влязохте успешно в системата";

        public LoginForm()
        {
            InitializeComponent();

            // Enter label
            var newPadding = new Padding(0, 10, 0, 10);
            enterLabel.Padding = newPadding;
            enterLabel.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);
            enterLabel.ForeColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            enterLabel.ForeColor = Color.FromArgb(0, 0, 0);

            // Login panel
            loginPanel.BackColor = ColorFactory.GetColor(ProjectColor.LightGrey);
            userNameLabel.BackColor = ColorFactory.GetColor(ProjectColor.Transperent);
            enterButton.BackColor = ColorFactory.GetColor(ProjectColor.DarkGrey);
            // Set user data for test usage
            userNameInput.Text = UserName;
            passwordInput.Text = Password;
            enterButton.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void ShowMessage(string caption, string message)
        {
            var buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
        //                                 Color.Black, 900, ButtonBorderStyle.Inset,
        //                                 Color.Black, 900, ButtonBorderStyle.Inset,
        //                                 Color.Black, 900, ButtonBorderStyle.Inset,
        //                                 Color.Black, 900, ButtonBorderStyle.Inset);
        //}

        private void enterButton_Click(object sender, EventArgs e)
        {
            string userNameEntered = userNameInput.Text;
            string passwordEntered = passwordInput.Text;

            if (userNameEntered.Equals(UserName) && passwordEntered.Equals(Password))
            {
                ShowMessage(SuccessfulLoginCaption, SuccessfulLoginMessage);
                var mainScreen = new MainScreen();
                this.Hide();
                mainScreen.ShowDialog();
                this.Close();
            }
            else
            {
                ShowMessage(ForbidenAccessCaption, ForbidenAccessMessage);
            }
        }
    }
}
