CREATE PROCEDURE dbo.spGetQuestionId

@quizId INT,
@questionTitle VARCHAR(50)

AS
BEGIN
	SELECT Questions.Id 
	FROM Questions
	left join Quizzes on QuizId = Quizzes.Id
	WHERE (@questionTitle = QuestionText) and (@quizId = QuizId);
END