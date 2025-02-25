using Microsoft.IdentityModel.Tokens;
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
    public partial class QuizCreatorForm : Form
    {
        QuizModel Quiz = new QuizModel();

       
        public QuizCreatorForm()
        {
            InitializeComponent();
        }

        private void initiateQuizSetupButton_Click(object sender, EventArgs e)
        {
            /* the DataAccess class contains methods which utilize third-party software packages Dapper, Microsoft.Data.SqlClient, and System.Config.ConfigurationManager
          Please see the Credits.txt file for the copyright information, licensing agreements, and links in compliance with these packages' licensing agreements. */

            DataAccess dataAccess = new DataAccess();
            bool quizTitleIsValid = (dataAccess.FindQuizByTitle(this.quizTitleTextbox.Text, Dashboard.databaseName).Count < 1) && !string.IsNullOrWhiteSpace(quizTitleTextbox.Text);
            bool questionNumberIsInt = int.TryParse(questionCountTextbox.Text, out int questionNumber);   
            bool percentageIsInt = int.TryParse(this.passingPercentageTextbox.Text, out int percentageToInt);
            bool percentageIsValid = percentageIsInt && percentageToInt >= 0 && percentageToInt <= 100;
            bool questionCountIsValid = questionNumberIsInt && questionNumber > 0;
            if (quizTitleIsValid && percentageIsValid && questionCountIsValid)
            {
                Quiz.QuizTitle = this.quizTitleTextbox.Text;
                Quiz.PercentageRequiredToPass = percentageToInt;



                dataAccess.InsertBasicQuizInformation(Quiz, Dashboard.databaseName);
                this.Hide();


                for (int i = 1; i <= questionNumber; i++)
                {
                    QuestionCreationForm questionCreationForm = new QuestionCreationForm();
                    questionCreationForm.GetQuestionLabelNumber(i);
                    questionCreationForm.ShowDialog();
                  
                    Quiz.Questions.Add(questionCreationForm.question);
                    questionCreationForm.Close();
                }

                int quizId = dataAccess.GetQuizId(Quiz, Dashboard.databaseName);
                dataAccess.InsertQuestions(Quiz, Dashboard.databaseName, quizId);
                foreach(QuestionModel question in Quiz.Questions)
                {
                    dataAccess.InsertAnswers(question, Dashboard.databaseName, dataAccess.GetQuestionId(question, quizId, Dashboard.databaseName));
                }

                



            }

            else if (quizTitleIsValid == false)
            {
                MessageBox.Show("Quiz titles cannot be empty or already exist.", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (questionCountIsValid == false)
            {
                MessageBox.Show("Question count must be a whole number above 0.", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Percentage to pass must be a whole number within the range of 0 and 100.", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    } 
}
