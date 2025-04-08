CREATE PROCEDURE dbo.spDeleteQuizById

@quizId INT

AS 
BEGIN

	DELETE FROM Quizzes
	WHERE Quizzes.Id = @quizId;
	
END 