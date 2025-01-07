using MockQuizLibrary.Methods;
using MockQuizLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockQuiz
{
    public partial class Dashboard : Form
    {
        List<QuizModel> quizzes = new List<QuizModel>();

        /* the DataAccess class contains methods which utilize third-party software packages Dapper, Microsoft.Data.SqlClient, and System.Config.ConfigurationManager
            Please see the Credits.txt file for the copyright information, licensing agreements, and links in compliance with these packages' licensing agreements. */

        DataAccess dataAccess = new DataAccess();

        internal static string databaseName = ""; // change this to match your database name


        
        internal static QuizModel quiz = new QuizModel();
        
        public Dashboard()
        {
            InitializeComponent();
            DisplayQuizzes();
            
        }

        private void CycleQuestions()
        {
            
            this.Hide();
            foreach (QuestionModel question in quiz.Questions)
            {
               
                int questionId = dataAccess.GetQuestionId(question, dataAccess.GetQuizId(quiz, databaseName), databaseName);
                question.Answers = dataAccess.GetAnswersByQuestionId(questionId, databaseName);
                QuestionForm questionForm = new QuestionForm();
                questionForm.currentQuestion.QuestionNumber = question.QuestionNumber;
                questionForm.currentQuestion.QuestionText = question.QuestionText;
                questionForm.currentQuestion.Answers = question.Answers;
               
                if(question.QuestionNumber == quiz.Questions.Count)
                {
                    questionForm.UpdateButtonText();
                }
                questionForm.AssignQuestionToLabel();
                questionForm.AssignAnswers();
                questionForm.ShowDialog();
            }


        }

        private void DisplayResultPage()
        {
            ResultForm resultForm = new ResultForm();
            resultForm.ShowDialog();
            quiz = new QuizModel();
            this.Show();

        }

        private void createQuizButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuizCreatorForm quizCreatorForm = new QuizCreatorForm();
            quizCreatorForm.ShowDialog();

            quizCreatorForm.Close();
            DisplayQuizzes();
            this.Show();
        }

        private void DisplayQuizzes()
        {
            quizzes = dataAccess.GetQuizList(databaseName);

            quizListBox.DataSource = quizzes;
            quizListBox.DisplayMember = "QuizTitle";
           
           
        }

        private void selectQuizButton_Click(object sender, EventArgs e)
        {
            quiz = new QuizModel();
            if(quizListBox.SelectedItem != null)
            {
                foreach (QuizModel item in quizzes)
                {
                    if (item == quizListBox.SelectedItem)
                    {
                        if (item.QuizTitle != null)
                        {
                            List<QuestionModel> questions = dataAccess.GetQuestionsByQuizTitle(item.QuizTitle, databaseName);
                            quiz.QuizTitle = item.QuizTitle;
                            quiz.PercentageRequiredToPass = item.PercentageRequiredToPass;
                            quiz.Questions = questions;
                            CycleQuestions();
                            DisplayResultPage();

                        }                    
                    }
                }
            }
            else
            {
                MessageBox.Show("No quiz selected.", "null selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }
    }
}
