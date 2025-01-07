using MockQuizLibrary;
using MockQuizLibrary.Methods;
using MockQuizLibrary.Models;

namespace MockQuiz
{

   

  
    public partial class QuestionForm : Form
    {
        internal QuestionModel currentQuestion = new QuestionModel();
        public QuestionForm()
        {
            InitializeComponent();
              
        }
        internal void AssignQuestionToLabel()
        {
            questionText.Text = $"Question {currentQuestion.QuestionNumber}: {currentQuestion.QuestionText}";
        }

        internal void AssignAnswers()
        {

            checkBoxListOfAnswers.DataContext = currentQuestion.Answers;
            
                foreach (AnswerModel answer in currentQuestion.Answers)
                {
                
                    if (answer.AnswerText != null)
                    {
                        checkBoxListOfAnswers.Items.Add(answer.AnswerText);
                    }
                } 
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {


            if (checkBoxListOfAnswers.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please only select one answer", "Too many answers were selected.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (checkBoxListOfAnswers.CheckedItems.Count < 1)
            {
                MessageBox.Show("Please select an answer before moving on to the next question.", "No answer was selected.", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

            else
            {

                string verificationInput = "";
                foreach (var item in checkBoxListOfAnswers.CheckedItems)
                {
                    verificationInput += item.ToString();
                    break;
                }

                bool answerIsCorrect = Methods.VerifySelectedAnswer(verificationInput, currentQuestion);

                if (answerIsCorrect)
                {
                    Dashboard.quiz.NumberOfCorrectAnswers++;
                }

                this.Close();


            }
        }

        internal void UpdateButtonText()
        {
            this.nextQuestionButton.Text = "Submit";
        }
    }
}
