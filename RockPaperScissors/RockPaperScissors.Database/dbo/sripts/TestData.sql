USE [RockPaperScissorsDB]
GO

--INSERT INTO [dbo].[Move] (playerWins,computerMove,humanMove,gameType,difficultyType) values(1,1,1,1,1)
--INSERT INTO [dbo].[Move] (playerWins,computerMove,humanMove,gameType,difficultyType) values(1,1,1,1,1)
--INSERT INTO [dbo].[Move] (playerWins,computerMove,humanMove,gameType,difficultyType) values(1,1,1,1,1)
--GO

INSERT INTO [dbo].[User] (createdUser,playsOfUser) values(CURRENT_TIMESTAMP,2)
GO