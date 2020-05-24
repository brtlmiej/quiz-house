using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w61929_quiz
{
    /// <summary>
    /// Class <c>User</c> represents User's model
    /// </summary>
    public class User
    {
        private string id;
        private string login;
        private string password;
        private double points;
        private int quizzes;
        private int rank;

        public User()
        {
            id = "id";
            login = "login";
            password = "password";
            points = 0.0;
            quizzes = 0;
            rank = 0;
        }

        public User(string id, string login, string password, double points, int quizzes, int rank)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.points = points;
            this.quizzes = quizzes;
            this.rank = rank;
        }

        public string Id
        {
            get { return this.id; }
        }
        public string Login
        {
            get { return this.login; }
        }

        public double Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public int Quizzes
        {
            get { return this.quizzes; }
            set { this.quizzes = value; }
        }

        public int Rank
        {
            get { return this.rank; }
            set { this.rank = value; }
        }
    }
}
