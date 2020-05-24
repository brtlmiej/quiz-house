using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using w61929_quiz;

namespace ApplicationUnitTests
{
    [TestClass]
    public class QuizHouseTests
    {
        /// <summary>
        /// If Query is incorrect becouse of e.g. Table doasn't exist SelectQuery should throw new Exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void SelectQuery_With_Nonexistent_Table()
        {
            string table = "NonExistentTable";
            string query = "SELECT * FROM " + table;
            QuizHouse.SelectQuery(query);
        }

        /// <summary>
        /// If user with given login and password doasn't exist Login should return false;
        /// </summary>
        [TestMethod]
        public void Login_With_Incorrect_User_Data()
        {
            string login = "";
            string password = "";

            Assert.IsFalse(QuizHouse.Login(login, password));
        }

        /// <summary>
        /// GetQuizzes should return List of Quizzes.
        /// </summary>
        [TestMethod]
        public void GetQuizzes_Test()
        {
            Assert.IsInstanceOfType(QuizHouse.GetQuizzes(), typeof(List<Quiz>));
        }
    }
}
