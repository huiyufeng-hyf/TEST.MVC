
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2018 18:42:12
-- Generated from EDMX file: C:\Users\Micha\Downloads\TEST.MVC\TEST.MVC.Model\TestMvcDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TEST.MVC.DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserLog_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserLogs] DROP CONSTRAINT [FK_UserLog_User];
GO
IF OBJECT_ID(N'[dbo].[FK_DeptUser_Dept]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeptUser] DROP CONSTRAINT [FK_DeptUser_Dept];
GO
IF OBJECT_ID(N'[dbo].[FK_DeptUser_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeptUser] DROP CONSTRAINT [FK_DeptUser_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Depts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Depts];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[UserLogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserLogs];
GO
IF OBJECT_ID(N'[dbo].[DeptUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeptUser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Depts'
CREATE TABLE [dbo].[Depts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Created] datetime  NULL,
    [Author] int  NULL,
    [Modified] datetime  NULL,
    [Editor] int  NULL,
    [IsDeleted] bit  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Created] datetime  NULL,
    [Author] int  NULL,
    [Modified] datetime  NULL,
    [Editor] int  NULL,
    [IsDeleted] bit  NULL
);
GO

-- Creating table 'UserLogs'
CREATE TABLE [dbo].[UserLogs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Operation] nvarchar(50)  NULL,
    [Created] datetime  NULL,
    [IP] nvarchar(50)  NULL,
    [Browser] nvarchar(50)  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'DeptUser'
CREATE TABLE [dbo].[DeptUser] (
    [Depts_Id] int  NOT NULL,
    [Users_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Depts'
ALTER TABLE [dbo].[Depts]
ADD CONSTRAINT [PK_Depts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserLogs'
ALTER TABLE [dbo].[UserLogs]
ADD CONSTRAINT [PK_UserLogs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Depts_Id], [Users_Id] in table 'DeptUser'
ALTER TABLE [dbo].[DeptUser]
ADD CONSTRAINT [PK_DeptUser]
    PRIMARY KEY CLUSTERED ([Depts_Id], [Users_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'UserLogs'
ALTER TABLE [dbo].[UserLogs]
ADD CONSTRAINT [FK_UserLog_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserLog_User'
CREATE INDEX [IX_FK_UserLog_User]
ON [dbo].[UserLogs]
    ([UserId]);
GO

-- Creating foreign key on [Depts_Id] in table 'DeptUser'
ALTER TABLE [dbo].[DeptUser]
ADD CONSTRAINT [FK_DeptUser_Dept]
    FOREIGN KEY ([Depts_Id])
    REFERENCES [dbo].[Depts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_Id] in table 'DeptUser'
ALTER TABLE [dbo].[DeptUser]
ADD CONSTRAINT [FK_DeptUser_User]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeptUser_User'
CREATE INDEX [IX_FK_DeptUser_User]
ON [dbo].[DeptUser]
    ([Users_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------