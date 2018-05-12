CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Created] DATETIME NULL DEFAULT getdate(), 
    [Author] INT NULL, 
    [Modified] DATETIME NULL DEFAULT getdate(), 
    [Editor] INT NULL, 
    [IsDeleted] BIT NULL DEFAULT 0
)
