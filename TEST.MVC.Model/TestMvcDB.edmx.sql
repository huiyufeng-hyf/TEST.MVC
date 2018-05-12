
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2018 19:08:46
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
    ALTER TABLE [dbo].[UserLog] DROP CONSTRAINT [FK_UserLog_User];
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

IF OBJECT_ID(N'[dbo].[Dept]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dept];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[UserLog]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserLog];
GO
IF OBJECT_ID(N'[dbo].[DeptUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeptUser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Dept'
CREATE TABLE [dbo].[Dept] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Created] datetime  NULL,
    [Author] int  NULL,
    [Modified] datetime  NULL,
    [Editor] int  NULL,
    [IsDeleted] bit  NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Created] datetime  NULL,
    [Author] int  NULL,
    [Modified] datetime  NULL,
    [Editor] int  NULL,
    [IsDeleted] bit  NULL
);
GO

-- Creating table 'UserLog'
CREATE TABLE [dbo].[UserLog] (
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
    [Dept_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Dept'
ALTER TABLE [dbo].[Dept]
ADD CONSTRAINT [PK_Dept]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserLog'
ALTER TABLE [dbo].[UserLog]
ADD CONSTRAINT [PK_UserLog]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Dept_Id], [User_Id] in table 'DeptUser'
ALTER TABLE [dbo].[DeptUser]
ADD CONSTRAINT [PK_DeptUser]
    PRIMARY KEY CLUSTERED ([Dept_Id], [User_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'UserLog'
ALTER TABLE [dbo].[UserLog]
ADD CONSTRAINT [FK_UserLog_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserLog_User'
CREATE INDEX [IX_FK_UserLog_User]
ON [dbo].[UserLog]
    ([UserId]);
GO

-- Creating foreign key on [Dept_Id] in table 'DeptUser'
ALTER TABLE [dbo].[DeptUser]
ADD CONSTRAINT [FK_DeptUser_Dept]
    FOREIGN KEY ([Dept_Id])
    REFERENCES [dbo].[Dept]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [User_Id] in table 'DeptUser'
ALTER TABLE [dbo].[DeptUser]
ADD CONSTRAINT [FK_DeptUser_User]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeptUser_User'
CREATE INDEX [IX_FK_DeptUser_User]
ON [dbo].[DeptUser]
    ([User_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------