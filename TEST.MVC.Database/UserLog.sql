CREATE TABLE [dbo].[UserLog] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Operation] NVARCHAR (50) NULL,
    [Created]   DATETIME      NULL,
    [IP]        NVARCHAR (50) NULL,
    [Browser]   NVARCHAR (50) NULL,
    [UserId]    INT           NOT NULL,
    CONSTRAINT [PK_UserLog] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UserLog_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);



GO
CREATE NONCLUSTERED INDEX [IX_FK_UserLog_User]
    ON [dbo].[UserLog]([UserId] ASC);

