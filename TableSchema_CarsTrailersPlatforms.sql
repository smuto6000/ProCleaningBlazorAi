-- CARS
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Cars]') AND type in (N'U'))
BEGIN
    CREATE TABLE [Cars] (
        [Id] uniqueidentifier NOT NULL,
        [Model] nvarchar(100) NOT NULL,
        [Plate] nvarchar(20) NOT NULL,
        [Vin] nvarchar(50) NULL,
        [VignetteValidTo] datetime2 NULL,
        [EmissionControlValidTo] datetime2 NULL,
        [ServiceValidTo] datetime2 NULL,
        [ValidTo] datetime2 NULL,
        CONSTRAINT [PK_Cars] PRIMARY KEY ([Id])
    );
END;
GO

-- TRAILERS
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Trailers]') AND type in (N'U'))
BEGIN
    CREATE TABLE [Trailers] (
        [Id] uniqueidentifier NOT NULL,
        [Model] nvarchar(100) NOT NULL,
        [Plate] nvarchar(20) NOT NULL,
        [EmissionControlValidTo] datetime2 NULL,
        [ServiceValidTo] datetime2 NULL,
        [ValidTo] datetime2 NULL,
        CONSTRAINT [PK_Trailers] PRIMARY KEY ([Id])
    );
END;
GO

-- PLATFORMS
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Platforms]') AND type in (N'U'))
BEGIN
    CREATE TABLE [Platforms] (
        [Id] uniqueidentifier NOT NULL,
        [Model] nvarchar(100) NOT NULL,
        [Plate] nvarchar(20) NOT NULL,
        [EmissionControlValidTo] datetime2 NULL,
        [ServiceValidTo] datetime2 NULL,
        [ValidTo] datetime2 NULL,
        CONSTRAINT [PK_Platforms] PRIMARY KEY ([Id])
    );
END;
GO

