using MockQuizLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MockQuizLibrary.Methods
{
    public static class Methods
    {
        public static bool VerifySelectedAnswer(string? answerText, QuestionModel question)
        {
            AnswerModel answerModel = new AnswerModel();
            bool output = false;
           foreach(AnswerModel answer in question.Answers)
            {
                if(answer.AnswerText == answerText)
                {
                    answerModel = answer;
                }
            }

           if(answerModel.AnswerIsCorrect)
            {
                output = true;
            }
            return output;
        }

        public static double CalculateScore(QuizModel quiz) 
        {
            double output = 0;

            if(quiz.Questions.Count > 0)
            {
                output = (Math.Round(((double)quiz.NumberOfCorrectAnswers /(double)quiz.Questions.Count) * 100));
            }

            return output;
        }

        public static void DetermineIsPassing(QuizModel quiz)
        {
            if(CalculateScore(quiz) >= (double)quiz.PercentageRequiredToPass)
            {
                quiz.IsPassing = true;
            }

            else
            {
                quiz.IsPassing = false;
            }
        }
    }
}
