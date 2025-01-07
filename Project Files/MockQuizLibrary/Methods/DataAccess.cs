using MockQuizLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Net.NetworkInformation;
using System.Collections.Specialized;

namespace MockQuizLibrary.Methods
{
    public class DataAccess
    {
        /* the DataAccess class contains methods which utilize third-party software packages Dapper, Microsoft.Data.SqlClient, and System.Config.ConfigurationManager
          Please see the Credits.txt file for the copyright information, licensing agreements, and links in compliance with these packages' licensing agreements. */

        public void InsertBasicQuizInformation(QuizModel quizModel, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionStringGetter.GetConnectionString(databaseName)))
            {
                connection.Execute("dbo.spInsertQuiz @percentageRequiredToPass, @quizTitle", new {percentageRequiredToPass = quizModel.PercentageRequiredToPass, quizTitle = quizModel.QuizTitle }); 
            }
        }

        public List<QuizModel> FindQuizByTitle(string quizTitleParameter, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionStringGetter.GetConnectionString(databaseName)))
            {
                return connection.Query<QuizModel>("dbo.spFindQuizByTitle @quizTitle", new { quizTitle = quizTitleParameter }).ToList();
            }
        }

        public void InsertQuestions(QuizModel quizModel, string databaseName, int quizIdParameter)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionStringGetter.GetConnectionString(databaseName)))
            {
                foreach(QuestionModel question in quizModel.Questions)
                {
                   connection.Execute("dbo.spInsertQuestion @questionText, @questionNumber, @quizId", new { questionText = question.QuestionText, questionNumber = question.QuestionNumber, quizId = quizIdParameter });
                }
            }
        }

        public void InsertAnswers (QuestionModel question, string databaseName, int questionIdParameter)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionStringGetter.GetConnectionString(databaseName)))
            {
                foreach (AnswerModel answer in question.Answers)
                {
                    int answerIsCorrect = 0;

                    if (answer.AnswerIsCorrect)
                    {
                        answerIsCorrect = 1;
                    }

                    connection.Execute("dbo.spInsertAnswer @answerText, @isCorrect, @questionId", new { answerText = answer.AnswerText, isCorrect = answerIsCorrect, questionId = questionIdParameter });
                }

            }            
        }

        public List<AnswerModel> GetAnswersByQuestionId(int questionId, string databaseName)
        {
             using (IDbConnection connection = new SqlConnection (ConnectionStringGetter.GetConnectionString(databaseName)))
            {
                List<AnswerModel> output = connection.Query<AnswerModel>("dbo.spGetAnswersByQuestionId @id", new { id = questionId }).ToList();
                return output;
            }
        }

        public List<QuestionModel> GetQuestionsByQuizTitle(string quizTitleParameter, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionStringGetter.GetConnectionString(databaseName)))
            {
                return connection.Query<QuestionModel>("dbo.spGetQuestionsBasedOnQuizTitle @quizTitle", new { quizTitle = quizTitleParameter}).ToList();
            }
        }

        public int GetQuizId (QuizModel quizModel, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection (ConnectionStringGetter.GetConnectionString(databaseName)))
            {
                List<int> ints = connection.Query<int>("dbo.spGetQuizIdByTitle @quizTitle", quizModel).ToList();

                return ints[0];
            }
        }

        public int GetQuestionId(QuestionModel question, int quizIdParameter, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionStringGetter.GetConnectionString (databaseName)))
            {
                List<int> ints = connection.Query<int>("dbo.spGetQuestionId @quizId, @questionTitle", new {quizId = quizIdParameter, questionTitle = question.QuestionText }).ToList();

                return ints[ints.Count - 1];
            }
        }

        public List<QuizModel> GetQuizList(string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionStringGetter.GetConnectionString(databaseName)))
            {
                return connection.Query<QuizModel>("SELECT dbo.Quizzes.QuizTitle, dbo.Quizzes.PercentageRequiredToPass FROM dbo.Quizzes;").ToList();
            }
        }
        


    }
}
