CREATE TABLE [dbo].[Questions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [QuestionText] VARCHAR(100) NOT NULL, 
    [QuestionNumber] INT NOT NULL, 
    [QuizId] INT NOT NULL
)
