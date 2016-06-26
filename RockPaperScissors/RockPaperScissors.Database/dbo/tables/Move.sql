CREATE TABLE [dbo].[Move]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [playerWins] BIT NULL, 
    [computerMove] INT NULL, 
    [humanMove] INT NULL, 
    [gameType] INT NULL, 
    [difficultyType] INT NULL
)
