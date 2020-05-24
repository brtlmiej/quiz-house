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
    public partial class UserStats : UserControl
    {
        public UserStats()
        {
            InitializeComponent();
        }

        public void LoadStats()
        {
            lblUserName.Text = QuizHouse.user.Login;
            lblPoints.Text = QuizHouse.user.Points.ToString();
            lblQuizzes.Text = QuizHouse.user.Quizzes.ToString();
            lblRank.Text = QuizHouse.user.Rank.ToString();
        }
    }
}
