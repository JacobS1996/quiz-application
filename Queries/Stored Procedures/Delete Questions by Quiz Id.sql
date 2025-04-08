CREATE PROCEDURE dbo.spDeleteQuestionsByQuizId

@quizId INT

AS 
BEGIN

	DELETE FROM Questions
	WHERE Questions.QuizId = @quizId;
	
END 