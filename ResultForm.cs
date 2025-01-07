using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockQuizLibrary.Methods;

namespace MockQuiz
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            DisplayPassFailMessage();
            DisplayScore();

        }

        public void DisplayScore()
        {
            userScore.Text = Math.Round(Methods.CalculateScore(Dashboard.quiz)) + "%";

        }

        public void DisplayPassFailMessage()
        {
            Methods.DetermineIsPassing(Dashboard.quiz);
            bool isPassing = Dashboard.quiz.IsPassing;
            if (isPassing)
            {
                passFailLabel.Text = "Passed!";
                passFailLabel.ForeColor = Color.Green;

            }
            else
            {
                passFailLabel.Text = "Failed";   
                passFailLabel.ForeColor = Color.Red;
            }
        }

        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
