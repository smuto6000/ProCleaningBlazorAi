-- 1. Vytvorenie tabuliek
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Roles]') AND type in (N'U'))
BEGIN
    CREATE TABLE [Roles] (
        [Id] int NOT NULL,
        [Name] nvarchar(50) NOT NULL,
        [DisplayName] nvarchar(100) NOT NULL,
        CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Users]') AND type in (N'U'))
BEGIN
    CREATE TABLE [Users] (
        [Id] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(100) NOT NULL,
        [LastName] nvarchar(100) NOT NULL,
        [Email] nvarchar(200) NOT NULL,
        [PasswordHash] nvarchar(max) NOT NULL,
        [CreatedAt] datetime2 NOT NULL,
        [ValidTo] datetime2 NULL,
        [RoleId] int NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([Id]) ON DELETE NO ACTION
    );
    
    CREATE UNIQUE INDEX [IX_Users_Email] ON [Users] ([Email]);
    CREATE INDEX [IX_Users_RoleId] ON [Users] ([RoleId]);
END;
GO

-- 2. Vloženie dát (Seeding)
-- Role
IF NOT EXISTS (SELECT 1 FROM [Roles] WHERE [Id] = 1)
    INSERT INTO [Roles] ([Id], [Name], [DisplayName]) VALUES (1, N'Admin', N'Administrator');

IF NOT EXISTS (SELECT 1 FROM [Roles] WHERE [Id] = 2)
    INSERT INTO [Roles] ([Id], [Name], [DisplayName]) VALUES (2, N'Manager', N'Manager');

IF NOT EXISTS (SELECT 1 FROM [Roles] WHERE [Id] = 3)
    INSERT INTO [Roles] ([Id], [Name], [DisplayName]) VALUES (3, N'Worker', N'Pracovnik');
GO

-- Admin User
IF NOT EXISTS (SELECT 1 FROM [Users] WHERE [Email] = N'admin@procleaning.sk')
BEGIN
    INSERT INTO [Users] ([Id], [FirstName], [LastName], [Email], [PasswordHash], [CreatedAt], [ValidTo], [RoleId])
    VALUES (
        '99999999-9999-9999-9999-999999999999', 
        N'System', 
        N'Admin', 
        N'admin@procleaning.sk', 
        N'AQAAAAIAAYagAAAAEK7OPyQtTX9i7/BiIPRlAEzeGTxK5XjBVElUQicMxVM3dt6uvGwoXqP9v1FPqbk3Kg==', -- Heslo: "a"
        '2024-01-01T00:00:00.0000000Z', 
        NULL, 
        1 -- Admin Role ID
    );
END;
GO

