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
    public partial class ScorePanel : UserControl
    {
        public ScorePanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads score, shows it on panel, and updates user's points.
        /// </summary>
        /// <param name="score">user's score</param>
        public void LoadScore(double score)
        {
            // update user points
            if(QuizHouse.UpdateUserPoints(score))
            {
                // show score on screen
                lblScorePoints.Text = score.ToString();
            }
            
        }

        private void btnGoBack_MouseEnter(object sender, EventArgs e)
        {
            btnGoBack.BackgroundImage = Properties.Resources.btn_go_back_hover;
        }

        private void btnGoBack_MouseLeave(object sender, EventArgs e)
        {
            btnGoBack.BackgroundImage = Properties.Resources.btn_go_back;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
