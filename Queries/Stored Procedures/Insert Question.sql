CREATE PROCEDURE dbo.spInsertQuestion

@questionText VARCHAR(50), 
@questionNumber INT,
@quizId INT

AS
BEGIN
	INSERT INTO dbo.Questions (QuestionText, QuestionNumber, QuizId)
	VALUES (@questionText, @questionNumber, @quizId);
END