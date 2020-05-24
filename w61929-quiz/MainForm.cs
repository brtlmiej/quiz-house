using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w61929_quiz
{
    public partial class MainForm : Form
    {
        private Database data = new Database();
        public MainForm()
        {
            InitializeComponent();
            signInMenu1.VisibleChanged += new EventHandler(signInMenu1_VisibleChanged);
        }

        #region left-panel
        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackgroundImage = Properties.Resources.menu_btn_hover;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackgroundImage = Properties.Resources.menu_btn;
        }
        #endregion

        #region control-panel
        private void btnClose_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnMax_MouseUp(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnMin_MouseUp(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNormal_MouseUp(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnNormal.Visible = false;
        }

        private void btnNormal_MouseEnter(object sender, EventArgs e)
        {
            btnNormal.BackgroundImage = Properties.Resources.btn_normal_hover;
        }

        private void btnNormal_MouseLeave(object sender, EventArgs e)
        {
            btnNormal.BackgroundImage = Properties.Resources.btn_normal;
        }

        private void btnMax_MouseEnter(object sender, EventArgs e)
        {
            btnMax.BackgroundImage = Properties.Resources.btn_max_hover;
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            btnMax.BackgroundImage = Properties.Resources.btn_max;
        }
        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackgroundImage = Properties.Resources.btn_min_hover;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackgroundImage = Properties.Resources.btn_min;
        }
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.btn_close_hover;
            panelCloseBtn.BackColor = Color.FromArgb(255, 199, 13, 13);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.btn_close;
            panelCloseBtn.BackColor = Color.FromArgb(255, 27, 27, 32);
        }

        #endregion

        /// <summary>
        /// Runs after sign in
        /// </summary>
        private void signInMenu1_VisibleChanged(object sender, EventArgs e)
        {
            if(signInMenu1.Visible == false)
            {
                // hide welcomePanel
                welcomePanel1.Visible = false;

                // show loading screen
                loadingPanel1.showLoadingScreen();

                // show list of quizzes
                listOfQuizzesPanel1.ShowQuizzes();
                listOfQuizzesPanel1.Visible = true;

                // load and show user stats
                userStats1.LoadStats();
                userStats1.Visible = true;
            }

        }

        /// <summary>
        /// Runs after click on specific quiz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listOfQuizzesPanel1_VisibleChanged(object sender, EventArgs e)
        {
            if(listOfQuizzesPanel1.Visible == false)
            {
                // show loading screen
                loadingPanel1.showLoadingScreen();

                // load quiz show voting panel
                votingPanel1.LoadQuestions(listOfQuizzesPanel1.clickedId);
                votingPanel1.Visible = true;
            }
        }

        /// <summary>
        /// Runs after voteing on specific quiz
        /// </summary>
        private void votingPanel1_VisibleChanged(object sender, EventArgs e)
        {
            if(votingPanel1.Visible == false)
            {
                // load score and show scorePanel
                scorePanel1.LoadScore(votingPanel1.points);
                scorePanel1.Visible = true;
            }
        }

        private void scorePanel1_VisibleChanged(object sender, EventArgs e)
        {
            if(scorePanel1.Visible == false)
            {
                // load stats and shows list of quizzes
                userStats1.LoadStats();
                listOfQuizzesPanel1.ShowQuizzes();
                listOfQuizzesPanel1.Visible = true;
            }
        }
    }
}