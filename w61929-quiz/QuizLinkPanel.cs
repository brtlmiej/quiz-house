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
    /// <summary>
    /// Represents link for voting in specific quiz.
    /// </summary>
    public partial class QuizLinkPanel : UserControl
    {
        public int id;
        public string title;
        public string category;
        public string numOfQuestions;
        Color color;
        
        /// <summary>
        /// Initializes new instance of <c>QuizLinkPanel</c> class with 6 parameters.
        /// </summary>
        /// <param name="id">Quiz id</param>
        /// <param name="title">Quiz title</param>
        /// <param name="category">Quiz category</param>
        /// <param name="numQest">Number of questions in quiz</param>
        /// <param name="locX">X position for this control</param>
        /// <param name="locY">Y position for this control</param>
        public QuizLinkPanel(int id, string title, string category, string numQest, int locX, int locY )
        {
            this.id = id;
            this.title = title;
            this.category = category;
            numOfQuestions = numQest;
            Location = new Point(locX, locY);
            InitializeComponent();
        }

        private void QuizLinkPanel_Load(object sender, EventArgs e)
        {
            setColor();
            QuizTitle.Text = title;

            QuizCategory.Text = category;
            QuizCategory.ForeColor = color;

            QuizNumOfQuestions.Text = numOfQuestions.ToString();
            QuizNumOfQuestions.ForeColor = color;

            start.ForeColor = color;
        }

        /// <summary>
        ///  Sets color for category name text
        /// </summary>
        private void setColor()
        {
            switch (category)
            {
                case "Mathematics":
                    color = Color.FromArgb(255, 166, 40, 40);
                    break;

                case "IT":
                    color = Color.FromArgb(255, 61, 116, 158);
                    break;

                case "History":
                    color = Color.FromArgb(255, 185, 168, 32);
                    break;

                case "Geography":
                    color = Color.FromArgb(255, 157, 34, 137);
                    break;

                case "Physics":
                    color = Color.FromArgb(255, 40, 154, 60);
                    break;

                default:
                    color = Color.White;
                    break;
            }
        }

        private void child_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
