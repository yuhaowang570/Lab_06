IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201119054626_InitialCreate')
BEGIN
    CREATE TABLE [Student] (
        [ID] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [Program] nvarchar(50) NOT NULL,
        CONSTRAINT [PK_Student] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201119054626_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201119054626_InitialCreate', N'3.1.10');
END;

GO

