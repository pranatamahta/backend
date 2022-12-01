IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221130153134_bpkb')
BEGIN
    CREATE TABLE [ms_storage_location] (
        [location_id] nvarchar(450) NOT NULL,
        [location_name] nvarchar(max) NULL,
        CONSTRAINT [PK_ms_storage_location] PRIMARY KEY ([location_id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221130153134_bpkb')
BEGIN
    CREATE TABLE [tr_bpkb] (
        [agreement_number] nvarchar(450) NOT NULL,
        [bpkb_no] nvarchar(max) NULL,
        [branch_id] nvarchar(max) NULL,
        [bpkb_date] datetime2 NOT NULL,
        [faktur_no] nvarchar(max) NULL,
        [faktur_date] datetime2 NOT NULL,
        [location_id] nvarchar(450) NULL,
        [police_no] nvarchar(max) NULL,
        [bpkb_date_in] datetime2 NOT NULL,
        CONSTRAINT [PK_tr_bpkb] PRIMARY KEY ([agreement_number]),
        CONSTRAINT [FK_tr_bpkb_ms_storage_location_location_id] FOREIGN KEY ([location_id]) REFERENCES [ms_storage_location] ([location_id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221130153134_bpkb')
BEGIN
    CREATE INDEX [IX_tr_bpkb_location_id] ON [tr_bpkb] ([location_id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221130153134_bpkb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221130153134_bpkb', N'3.1.31');
END;

GO

