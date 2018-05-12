CREATE TABLE [dbo].[UserLog]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Operation] NVARCHAR(50) NULL, 
    [Created] DATETIME NULL DEFAULT getdate(), 
    [IP] NVARCHAR(50) NULL, 
    [Browser] NVARCHAR(50) NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_UserLog_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
