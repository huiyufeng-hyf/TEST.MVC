CREATE TABLE [dbo].[DeptUser] (
    [Dept_Id] INT NOT NULL,
    [User_Id] INT NOT NULL,
    CONSTRAINT [PK_DeptUser] PRIMARY KEY CLUSTERED ([Dept_Id] ASC, [User_Id] ASC),
    CONSTRAINT [FK_DeptUser_Dept] FOREIGN KEY ([Dept_Id]) REFERENCES [dbo].[Dept] ([Id]),
    CONSTRAINT [FK_DeptUser_User] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[User] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_DeptUser_User]
    ON [dbo].[DeptUser]([User_Id] ASC);

