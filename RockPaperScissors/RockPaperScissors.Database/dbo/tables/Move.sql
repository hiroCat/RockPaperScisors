CREATE TABLE [dbo].[Move]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [playerWins] INT NULL, 
    [computerMove] INT NULL, 
    [humanMove] INT NULL, 
    [gameType] INT NULL, 
    [difficultyType] INT NULL
)
