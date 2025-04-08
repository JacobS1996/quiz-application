CREATE PROCEDURE dbo.spDeleteAnswersByQuestionId

@questionId INT

AS 
BEGIN

	DELETE FROM Answers
	WHERE Answers.QuestionId = @questionId;
	
END 