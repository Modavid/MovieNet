
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/24/2018 14:31:12
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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

-- Creating table 'NotesEntitySet'
CREATE TABLE [dbo].[NotesEntitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [UserEntity_Id] int  NOT NULL,
    [MovieEntity_Id] int  NOT NULL
);
GO

-- Creating table 'CommentEntitySet'
CREATE TABLE [dbo].[CommentEntitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Comment] nvarchar(max)  NOT NULL,
    [UserEntity_Id] int  NOT NULL,
    [MovieEntity_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'NotesEntitySet'
ALTER TABLE [dbo].[NotesEntitySet]
ADD CONSTRAINT [PK_NotesEntitySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CommentEntitySet'
ALTER TABLE [dbo].[CommentEntitySet]
ADD CONSTRAINT [PK_CommentEntitySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserEntity_Id] in table 'NotesEntitySet'
ALTER TABLE [dbo].[NotesEntitySet]
ADD CONSTRAINT [FK_UserEntityNotesEntity]
    FOREIGN KEY ([UserEntity_Id])
    REFERENCES [dbo].[UserEntitySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserEntityNotesEntity'
CREATE INDEX [IX_FK_UserEntityNotesEntity]
ON [dbo].[NotesEntitySet]
    ([UserEntity_Id]);
GO

-- Creating foreign key on [UserEntity_Id] in table 'CommentEntitySet'
ALTER TABLE [dbo].[CommentEntitySet]
ADD CONSTRAINT [FK_UserEntityCommentEntity]
    FOREIGN KEY ([UserEntity_Id])
    REFERENCES [dbo].[UserEntitySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserEntityCommentEntity'
CREATE INDEX [IX_FK_UserEntityCommentEntity]
ON [dbo].[CommentEntitySet]
    ([UserEntity_Id]);
GO

-- Creating foreign key on [MovieEntity_Id] in table 'CommentEntitySet'
ALTER TABLE [dbo].[CommentEntitySet]
ADD CONSTRAINT [FK_MovieEntityCommentEntity]
    FOREIGN KEY ([MovieEntity_Id])
    REFERENCES [dbo].[MovieEntitySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieEntityCommentEntity'
CREATE INDEX [IX_FK_MovieEntityCommentEntity]
ON [dbo].[CommentEntitySet]
    ([MovieEntity_Id]);
GO

-- Creating foreign key on [MovieEntity_Id] in table 'NotesEntitySet'
ALTER TABLE [dbo].[NotesEntitySet]
ADD CONSTRAINT [FK_MovieEntityNotesEntity]
    FOREIGN KEY ([MovieEntity_Id])
    REFERENCES [dbo].[MovieEntitySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieEntityNotesEntity'
CREATE INDEX [IX_FK_MovieEntityNotesEntity]
ON [dbo].[NotesEntitySet]
    ([MovieEntity_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------