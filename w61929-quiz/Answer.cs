using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w61929_quiz
{
    public class Answer
    {
        public int id;
        public bool correct;
        public string text;

        /// <summary>
        /// Initializes instance of <c>Answer</c> class with 4 arguments.
        /// </summary>
        /// <param name="id">Answer Id.</param>
        /// <param name="correct">true if answer is correct, false if not</param>
        /// <param name="text">Answer text</param>
        public Answer(int id, bool correct, string text)
        {
            this.id = id;
            this.correct = correct;
            this.text = text;
        }
    }
}
