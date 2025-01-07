CREATE PROCEDURE dbo.spGetQuizIdByTitle

@quizTitle VARCHAR(20)

AS
BEGIN
	SELECT Id 
	FROM dbo.Quizzes
	WHERE QuizTitle = @quizTitle;
END