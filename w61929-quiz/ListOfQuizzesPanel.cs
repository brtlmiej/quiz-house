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
    /// Represents List of all quizzes. Each Quiz is represented by QuizLInkPanel.
    /// </summary>
    public partial class ListOfQuizzesPanel : UserControl
    {
        // Id of chosen Quiz
        public int clickedId;
        public ListOfQuizzesPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates <c>QuizLinkPanel</c> objects and shows them on control.
        /// </summary>
        public void ShowQuizzes()
        {
            screenQuizzes.Controls.Clear();
            int xCord = 0;

            foreach(Quiz quiz in QuizHouse.GetQuizzes())
            {
                QuizLinkPanel panel = new QuizLinkPanel(quiz.id, quiz.title, quiz.category, quiz.numOfQuestions, xCord, 100);

                panel.Click += new EventHandler(QuizClicked);
                screenQuizzes.Controls.Add(panel);

                xCord += 320;
            }

            xCord = 0;
        }

        public void QuizClicked(object sender, EventArgs e)
        {
            QuizLinkPanel panel = (QuizLinkPanel) sender;
            clickedId = panel.id;
            Visible = false;
        }
    }
}
