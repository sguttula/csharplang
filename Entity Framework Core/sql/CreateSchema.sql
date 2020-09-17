IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Forums] (
    [Id] int NOT NULL IDENTITY(1, 1),
    [Title] nvarchar(max),
    CONSTRAINT [PK_Forum] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Topics] (
    [Id] int NOT NULL IDENTITY(1, 1),
    [Title] nvarchar(max),
    [Description] nvarchar(max),
    [PostedDateTime] datetime2 NOT NULL DEFAULT GETDATE(),
    [ForumId] int,
    CONSTRAINT [PK_Topic] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Forum] FOREIGN KEY ([ForumId]) REFERENCES [Forums] ([Id])
);

GO

CREATE TABLE [Replies] (
    [Id] int NOT NULL IDENTITY(1, 1),
    [Message] nvarchar(max),
    [PostedDateTime] datetime2 NOT NULL DEFAULT GETDATE(),
    [TopicId] int,
    CONSTRAINT [PK_Reply] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Topic] FOREIGN KEY ([TopicId]) REFERENCES [Topics] ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'201907150000_InitialSchema', N'2.2.4-servicing-10062');

GO
