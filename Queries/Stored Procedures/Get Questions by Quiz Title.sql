CREATE PROCEDURE dbo.spGetQuestionsBasedOnQuizTitle
@quizTitle VARCHAR(20)

AS
BEGIN
	SELECT Questions.QuestionNumber, Questions.QuestionText
	FROM Questions
	left join Quizzes on Quizzes.Id = QuizId
	WHERE Quizzes.QuizTitle = @quizTitle
END