using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace w61929_quiz
{
    /// <summary>
    /// <c>QuizHouse</c> class is main system in app. It is responsible for selecting data from database and includes <c>User</c> object.
    /// </summary>
    static public class QuizHouse
    {
        static string cnString = @"Data Source=.\SQLEXPRESS;
                            AttachDbFilename=c:\Users\HP\source\repos\w61929-quiz\w61929-quiz\Database.mdf;
                            Integrated Security = True;
                            Connect Timeout = 30;
                            User Instance = True";
        static SqlConnection connection = new SqlConnection(cnString);
        public static User user = new User("id", "l", "p", 0, 0, 0);

        /// <summary>
        /// Runs given query on database.
        /// </summary>
        /// <param name="query">query sent to database</param>
        /// <returns><c>DataTable</c> class object.</returns>
        static public DataTable RunQuery(string query)
        {
            DataTable table = new DataTable();
            connection.Open();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }
            catch (Exception)
            {
                connection.Close();
                throw new Exception("Could not load data");
            }

            connection.Close();

            return table;
        }

        /// <summary>
        /// Sign In to QuizHouse system.
        /// </summary>
        /// <param name="uLogin">User login</param>
        /// <param name="uPassword">User password</param>
        /// <returns>True if user exists an False if not.</returns>
        public static bool Login(string uLogin, string uPassword)
        {
            string query = String.Format("SELECT * FROM(SELECT *, ROW_NUMBER() OVER(ORDER BY Points DESC) as Rank FROM dbo.Users) AS Tab WHERE Login = '{0}' AND Password = '{1}'", uLogin, uPassword);
            try
            {
                DataTable table = RunQuery(query);
                DataRow[] row = table.Select();

                string id = row[0]["Id"].ToString();
                string login = row[0]["Login"].ToString();
                string password = row[0]["Password"].ToString();
                double points = Convert.ToDouble(row[0]["Points"]);
                int quizzes = Convert.ToInt32(row[0]["Quizzes"]);
                int rank = Convert.ToInt32(row[0]["Rank"]);

                user = new User(id, login, password, points, quizzes, rank);

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Updates user's points
        /// </summary>
        /// <param name="points">points scored by user</param>
        /// <returns>true if operation went successfully, false if not</returns>
        public static bool UpdateUserPoints(double points)
        {
            user.Points += points;
            user.Quizzes += 1;

            string query = "SELECT Id, Points, Quizzes FROM Users";

            DataTable table = new DataTable();
            connection.Open();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.UpdateCommand = new SqlCommand("UPDATE Users SET Points = @Points, Quizzes = @Quizzes WHERE Id = @Id", connection);
                SqlParameter paramPoints = adapter.UpdateCommand.Parameters.Add("@Points", SqlDbType.Float);
                paramPoints.SourceColumn = "Points";

                SqlParameter paramQuizzes = adapter.UpdateCommand.Parameters.Add("@Quizzes", SqlDbType.Int);
                paramQuizzes.SourceColumn = "Quizzes";

                SqlParameter paramId = adapter.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int);
                paramId.SourceColumn = "Id";
                paramId.SourceVersion = DataRowVersion.Original;

                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["Id"].ToString() == user.Id)
                    {
                        row["Points"] = user.Points;
                        row["Quizzes"] = user.Quizzes;
                    }
                }

                adapter.Update(table);

                connection.Close();

                GetUserRank();

                return true;
            }
            catch (Exception e)
            {
                connection.Close();
                throw new Exception(e.GetType().ToString() + e.Message);
            }
        }

        /// <summary>
        /// Gets user's ranking position
        /// </summary>
        public static bool GetUserRank()
        {
            string query = String.Format("SELECT Rank FROM(SELECT Id, ROW_NUMBER() OVER(ORDER BY Points DESC) as Rank FROM dbo.Users) AS Tab WHERE Id = {0}", Convert.ToInt32(user.Id));

            try
            {
                DataTable table = RunQuery(query);
                DataRow[] rows = table.Select();
                user.Rank = Convert.ToInt32(rows[0]["Rank"]);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets all quizzes from Database.
        /// </summary>
        /// <returns>List of quizzes.</returns>
        public static List<Quiz> GetQuizzes()
        {
            List<Quiz> quizzes = new List<Quiz>();

            try
            {
                string query = "SELECT q.Id, q.Title, c.Name as Category, (SELECT COUNT(Id) FROM Questions WHERE QuizId = q.Id) as Number FROM Quizzes q LEFT JOIN Categories c ON q.Category = c.Id; ";
                DataTable table = RunQuery(query);
                table.Rows.Add(1, "Title", "Mathematics", 10);

                foreach (DataRow row in table.Select())
                {
                    quizzes.Add(new Quiz(
                        Convert.ToInt32(row["Id"]),
                        row["Title"].ToString(),
                        row["Category"].ToString(),
                        row["Number"].ToString()
                        ));
                }
            }
            catch(Exception e)
            {
                quizzes.Add(new Quiz(-1, e.Message, "null", "0"));
            }

            return quizzes;
        }

        /// <summary>
        /// Gets all Questions from database if they belong to specific Quiz.
        /// </summary>
        /// <param name="quizId">Quiz Id</param>
        /// <returns>List of Questions</returns>
        public static List<Question> GetQuestions(int quizId)
        {
            List<Question> questions = new List<Question>();
            string query = String.Format("SELECT q.Id, q.Text FROM Questions q WHERE q.QuizId = {0}", quizId);
            
            try
            {
                DataTable table = RunQuery(query);

                foreach(DataRow row in table.Select())
                {
                    questions.Add(new Question(
                            Convert.ToInt32(row["Id"]),
                            row["Text"].ToString()
                            ));
                }
            }
            catch(Exception)
            {
                questions.Add(new Question(-1, "Null Null Null"));
            }

            return questions;
        }

        /// <summary>
        /// Gets all Answers from database if they belong to specific Question.
        /// </summary>
        /// <param name="questionId">Specific Question Id.</param>
        /// <returns></returns>
        public static List<Answer> GetAnswers(int questionId)
        {
            List<Answer> answers = new List<Answer>();
            string query = String.Format("SELECT Id, Correct, Text FROM Answers WHERE QuestionId = {0};", questionId);

            try
            {
                DataTable table = RunQuery(query);

                foreach (DataRow row in table.Select())
                {
                    answers.Add(new Answer(
                        Convert.ToInt32(row["Id"]),
                        Convert.ToBoolean(row["correct"]),
                        row["text"].ToString()
                        ));
                }
            }
            catch(Exception)
            {
                for(int i=1; i<=4; i++)
                {
                    answers.Add(new Answer(-1 * i, false, "Database error"));
                }
            }

            return answers;
        }
    }
}