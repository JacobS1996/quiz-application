using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
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
    public partial class QuestionCreationForm : Form
    {
        public QuestionModel question = new QuestionModel();

        public QuestionCreationForm()
        {
            InitializeComponent();
        }

        private void submitQuestionInfoButton_Click(object sender, EventArgs e)
        {
            if (questionTextBox.Text.IsNullOrEmpty() || firstAnswerTextBox.Text.IsNullOrEmpty() || secondAnswerTextbox.Text.IsNullOrEmpty()
                || thirdAnswerTextbox.Text.IsNullOrEmpty() || fourthAnswerTextbox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("The question box and answer boxes cannot be blank.", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<bool> checkedBoxes = new List<bool>();
                checkedBoxes.Add(this.isCorrectCheckBox1.Checked);
                checkedBoxes.Add(this.isCorrectCheckBox2.Checked);
                checkedBoxes.Add(this.isCorrectCheckBox3.Checked);
                checkedBoxes.Add(this.isCorrectCheckBox4.Checked);

                List<bool> selectedCheckBoxes = new List<bool>();
                foreach (var item in checkedBoxes)
                {
                    if (item == true)
                    {
                        selectedCheckBoxes.Add(item);
                    }
                }
                if (selectedCheckBoxes.Count > 1)
                {
                    MessageBox.Show("There can only be one correct answer.", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedCheckBoxes.Count < 1)
                {
                    MessageBox.Show("Must select a correct answer.", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    question.QuestionText = this.questionTextBox.Text;


                    question.Answers.Add(new AnswerModel() { AnswerText = this.firstAnswerTextBox.Text, AnswerIsCorrect = isCorrectCheckBox1.Checked });
                    question.Answers.Add(new AnswerModel() { AnswerText = this.secondAnswerTextbox.Text, AnswerIsCorrect = isCorrectCheckBox2.Checked });
                    question.Answers.Add(new AnswerModel() { AnswerText = this.thirdAnswerTextbox.Text, AnswerIsCorrect = isCorrectCheckBox3.Checked });
                    question.Answers.Add(new AnswerModel() { AnswerText = this.fourthAnswerTextbox.Text, AnswerIsCorrect = isCorrectCheckBox4.Checked });

                    this.Hide();

                }
            }

            

            
        }

        public void GetQuestionLabelNumber(int questionNumber)
        {
            this.questionNumberLabel.Text = "Question Number " + questionNumber; 
            question.QuestionNumber = questionNumber;
        }
    }
}
