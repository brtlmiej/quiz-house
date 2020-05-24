using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w61929_quiz
{
    public partial class SignInMenu : UserControl
    {
        public SignInMenu()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Text;

            if (!QuizHouse.Login(login, password))
            {
                errorMessage.Text = "Incorrect Login or Password";
            }
            else
            {
                errorMessage.Text = "";
                Visible = !Visible;
            }
        }

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            btnSignIn.BackgroundImage = Properties.Resources.btn_sign_in_hover;
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.BackgroundImage = Properties.Resources.btn_sign_in;
        }
    }
}
