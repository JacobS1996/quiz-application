CREATE TABLE [dbo].[Quizzes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [QuizTitle] VARCHAR(20) NOT NULL, 
    [PercentageNeededToPass] INT NOT NULL
)
