using System;
using System.Collections.Generic;
using System.Text;

namespace MockQuizLibrary.Models
{
    public class QuestionModel
    {
        public int QuestionNumber { get; set; }


        public string? QuestionText { get; set; }

        public List<AnswerModel> Answers { get; set; } = new List<AnswerModel>();
    }
}
