CREATE TABLE [dbo].[Dept] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [Created]   DATETIME      NULL,
    [Author]    INT           NULL,
    [Modified]  DATETIME      NULL,
    [Editor]    INT           NULL,
    [IsDeleted] BIT           NULL,
    CONSTRAINT [PK_Dept] PRIMARY KEY CLUSTERED ([Id] ASC)
);


