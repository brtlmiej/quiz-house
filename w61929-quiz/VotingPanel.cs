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
    public partial class VotingPanel : UserControl
    {
        List<Question> questions;
        List<Answer> answers;
        int index = 0;
        public double points = 0;
        public VotingPanel()
        {
            InitializeComponent();
            voteQuestionText.ReadOnly = true;
        }

        /// <summary>
        /// Loads list of <c>Question</c>s for specific <c>Quiz</c>.
        /// </summary>
        /// <param name="quizID">Quiz Id</param>
        public void LoadQuestions(int quizId)
        {
            questions = QuizHouse.GetQuestions(quizId);
            index = 0;
            points = 0;

            // Enable next btn
            btnNext.Enabled = true;
            btnFinish.Enabled = false;

            // show number of questions
            voteNumOfQuestions.Text = questions.Count.ToString();

            // Show first question
            ShowQuestion();
        }

        /// <summary>
        /// Load list of <c>Answer</c>s for specific <c>Question</c>.
        /// </summary>
        /// <param name="questionId">Question Id</param>
        public void LoadAnswers(int questionId)
        {
            answers = QuizHouse.GetAnswers(questionId);
        }

        /// <summary>
        /// Shows Quiz on Panel
        /// </summary>
        /// <param name="index">index number for specific Question</param>
        public void ShowQuestion()
        {
            if (index < questions.Count)
            {
                Question question = questions[index];

                // show question data
                voteQuestionIndex.Text = (index + 1).ToString();
                voteQuestionText.Text = question.text;

                // load answers for this question
                LoadAnswers(question.id);

                // show answers
                rBtn1.Text = answers[0].text;
                rBtn2.Text = answers[1].text;
                rBtn3.Text = answers[2].text;
                rBtn4.Text = answers[3].text;

                // increment index
                index++;
            }

            if(index == questions.Count)
            {
                btnNext.Enabled = false;
                btnFinish.Enabled = true;
            }
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = Properties.Resources.btn_Next_hover;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = Properties.Resources.btn_Next;
        }

        private void btnFinish_MouseEnter(object sender, EventArgs e)
        {
            btnFinish.BackgroundImage = Properties.Resources.btn_finish_hover;
        }

        private void btnFinish_MouseLeave(object sender, EventArgs e)
        {
            btnFinish.BackgroundImage = Properties.Resources.btn_finish;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (rBtn1.Checked && answers[0].correct)
            {
                points++;
            }
            else if (rBtn2.Checked && answers[1].correct)
            {
                points++;
            }
            else if (rBtn3.Checked && answers[2].correct)
            {
                points++;
            }
            else if (rBtn4.Checked && answers[3].correct)
            {
                points++;
            }

            rBtn1.Checked = false;
            rBtn2.Checked = false;
            rBtn3.Checked = false;
            rBtn4.Checked = false;

            ShowQuestion();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (RadioButton radio in panelRadioBtns.Controls)
            {
                if (radio.Checked && answers[i].correct)
                {
                    points += 1;
                }
                radio.Checked = false;
            }

            Visible = false;
        }
    }
}
