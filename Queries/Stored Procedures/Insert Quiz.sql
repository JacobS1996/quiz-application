CREATE PROCEDURE dbo.spInsertQuiz

@percentageRequiredToPass INT,
@quizTitle VARCHAR(20)

AS
BEGIN
	INSERT INTO dbo.Quizzes(PercentageRequiredToPass, QuizTitle)
	VALUES(@percentageRequiredToPass, @quizTitle);

END