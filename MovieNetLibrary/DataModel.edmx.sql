
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2018 12:09:28
-- Generated from EDMX file: C:\Users\David\source\repos\MovieNetWPF\MovieNetLibrary\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MovieEntityNoteEntity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteEntitySet] DROP CONSTRAINT [FK_MovieEntityNoteEntity];
GO
IF OBJECT_ID(N'[dbo].[FK_UserEntityNoteEntity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteEntitySet] DROP CONSTRAINT [FK_UserEntityNoteEntity];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserEntitySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserEntitySet];
GO
IF OBJECT_ID(N'[dbo].[MovieEntitySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieEntitySet];
GO
IF OBJECT_ID(N'[dbo].[NoteEntitySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NoteEntitySet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserEntitySet'
CREATE TABLE [dbo].[UserEntitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MovieEntitySet'
CREATE TABLE [dbo].[MovieEntitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Genre] nvarchar(max)  NOT NULL,
    [Summary] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NoteEntitySet'
CREATE TABLE [dbo].[NoteEntitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rating] int  NOT NULL,
    [Comment] nvarchar(max)  NOT NULL,
    [MovieEntity_Id] int  NOT NULL,
    [UserEntity_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserEntitySet'
ALTER TABLE [dbo].[UserEntitySet]
ADD CONSTRAINT [PK_UserEntitySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MovieEntitySet'
ALTER TABLE [dbo].[MovieEntitySet]
ADD CONSTRAINT [PK_MovieEntitySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NoteEntitySet'
ALTER TABLE [dbo].[NoteEntitySet]
ADD CONSTRAINT [PK_NoteEntitySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MovieEntity_Id] in table 'NoteEntitySet'
ALTER TABLE [dbo].[NoteEntitySet]
ADD CONSTRAINT [FK_MovieEntityNoteEntity]
    FOREIGN KEY ([MovieEntity_Id])
    REFERENCES [dbo].[MovieEntitySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieEntityNoteEntity'
CREATE INDEX [IX_FK_MovieEntityNoteEntity]
ON [dbo].[NoteEntitySet]
    ([MovieEntity_Id]);
GO

-- Creating foreign key on [UserEntity_Id] in table 'NoteEntitySet'
ALTER TABLE [dbo].[NoteEntitySet]
ADD CONSTRAINT [FK_UserEntityNoteEntity]
    FOREIGN KEY ([UserEntity_Id])
    REFERENCES [dbo].[UserEntitySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserEntityNoteEntity'
CREATE INDEX [IX_FK_UserEntityNoteEntity]
ON [dbo].[NoteEntitySet]
    ([UserEntity_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------