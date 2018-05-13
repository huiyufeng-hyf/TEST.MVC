CREATE TABLE [dbo].[Dept] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [Created]   DATETIME      NULL DEFAULT getdate(),
    [Author]    INT           NULL,
    [Modified]  DATETIME      NULL DEFAULT getdate(),
    [Editor]    INT           NULL,
    [IsDeleted] BIT           NULL DEFAULT 0,
    CONSTRAINT [PK_Dept] PRIMARY KEY CLUSTERED ([Id] ASC)
);


