CREATE PROCEDURE dbo.spInsertAnswer

@answerText VARCHAR(20), 
@answerIsCorrect TINYINT,
@questionId INT

AS
BEGIN
	INSERT INTO dbo.Answers(AnswerText, AnswerIsCorrect, QuestionId)
	VALUES (@answerText, @answerIsCorrect, @questionId);
END