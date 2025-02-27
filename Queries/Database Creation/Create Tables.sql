
USE QuizApplicationDatabase;

CREATE TABLE dbo.Quizzes
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	QuizTitle VARCHAR(20) NOT NULL, 
	PercentageRequiredToPass INT NOT NULL
);

CREATE TABLE dbo.Questions
(
	Id INT NOT NULL PRIMARY KEY IDENTITY, 
	QuestionText VARCHAR(100) NOT NULL, 
	QuestionNumber INT NOT NULL, 
	QuizId INT NOT NULL
);

CREATE TABLE dbo.Answers
(
	Id INT NOT NULL PRIMARY KEY IDENTITY, 
	AnswerText VARCHAR(50) NOT NULL, 
	AnswerIsCorrect TINYINT NOT NULL, 
	QuestionId INT NOT NULL
);




