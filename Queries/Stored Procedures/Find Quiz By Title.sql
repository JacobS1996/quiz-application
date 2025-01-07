CREATE PROCEDURE dbo.spFindQuizByTitle

@quizTitle VARCHAR(20)

AS
BEGIN
	SELECT Id, QuizTitle, PercentageRequiredToPass
	FROM dbo.Quizzes
	WHERE QuizTitle = @quizTitle;

END

