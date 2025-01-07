using System;
using System.Collections.Generic;
using System.Text;

namespace MockQuizLibrary.Models
{
    public class QuizModel
    {
        public string? QuizTitle { get; set; }

        public List<QuestionModel> Questions { get; set; } = new List<QuestionModel>();

        public double NumberOfCorrectAnswers { get; set; }

        public double PercentageRequiredToPass { get; set; }

        public bool IsPassing { get; set; }
    }
}
