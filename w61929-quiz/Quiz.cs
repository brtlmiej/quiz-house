using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w61929_quiz
{
    /// <summary>
    /// Represents Quiz data.
    /// </summary>
    public class Quiz
    {
        public int id;
        public string title;
        public string category;
        public string numOfQuestions;

        /// <summary>
        /// Initializes new instance of <c>Quiz</c> class with 4 arguments.
        /// </summary>
        /// <param name="id">Quiz ID</param>
        /// <param name="title">Quiz Title</param>
        /// <param name="category">Quiz Category</param>
        /// <param name="number">Number of questions in Quiz</param>
        public Quiz(int id, string title, string category, string number)
        {
            this.id = id;
            this.title = title;
            this.category = category;
            this.numOfQuestions = number;
        }
    }
}
