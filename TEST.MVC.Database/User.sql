CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Created] DATETIME NULL, 
    [Author] INT NULL, 
    [Modified] DATETIME NULL, 
    [Editor] INT NULL, 
    [IsDeleted] BIT NULL
)
