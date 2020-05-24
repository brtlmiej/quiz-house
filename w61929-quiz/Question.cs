using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w61929_quiz
{
    /// <summary>
    /// <c>Question</c> class represents Question data model.
    /// </summary>
    public class Question
    {
        public int id;
        public string text;

        /// <summary>
        /// Initialize <c>Question</c> class instance with 2 given arguments.
        /// </summary>
        /// <param name="id">Question id</param>
        /// <param name="text">Question text</param>
        public Question(int id, string text)
        {
            this.id = id;
            this.text = text;
        }
    }
}
