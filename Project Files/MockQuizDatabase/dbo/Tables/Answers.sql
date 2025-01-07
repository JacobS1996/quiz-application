CREATE TABLE [dbo].[Answers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AnswerText] VARCHAR(50) NOT NULL, 
    [AnswerIsCorrect] TINYINT NOT NULL, 
    [QuestionId] INT NOT NULL
)
