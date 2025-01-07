CREATE PROCEDURE dbo.spGetAnswersByQuestionId

@id INT

AS 
BEGIN
	SELECT AnswerText, AnswerIsCorrect
	FROM Answers
	WHERE QuestionId = @id
END

