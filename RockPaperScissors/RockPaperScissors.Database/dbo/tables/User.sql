CREATE TABLE [dbo].[User]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [createdUser] DATETIME NOT NULL, 
    [playsOfUser] BIGINT NULL, 
    CONSTRAINT [FK_User_ToTable] FOREIGN KEY (playsOfUser) REFERENCES [Move](Id)
)
