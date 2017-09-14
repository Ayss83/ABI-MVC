
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/14/2017 10:50:50
-- Generated from EDMX file: C:\Users\DL-CDI\documents\visual studio 2015\Projects\ABI csharp mvc\ABIDAO\AbiDao.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ABI];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CollaborateurContrat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratSet] DROP CONSTRAINT [FK_CollaborateurContrat];
GO
IF OBJECT_ID(N'[dbo].[FK_CollaborateurAugmentationSalaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AugmentationSalaireSet] DROP CONSTRAINT [FK_CollaborateurAugmentationSalaire];
GO
IF OBJECT_ID(N'[dbo].[FK_ContratAvenant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AvenantSet] DROP CONSTRAINT [FK_ContratAvenant];
GO
IF OBJECT_ID(N'[dbo].[FK_CDI_inherits_Contrat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratSet_CDI] DROP CONSTRAINT [FK_CDI_inherits_Contrat];
GO
IF OBJECT_ID(N'[dbo].[FK_ContratTemporaire_inherits_Contrat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratSet_ContratTemporaire] DROP CONSTRAINT [FK_ContratTemporaire_inherits_Contrat];
GO
IF OBJECT_ID(N'[dbo].[FK_CDD_inherits_ContratTemporaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratSet_CDD] DROP CONSTRAINT [FK_CDD_inherits_ContratTemporaire];
GO
IF OBJECT_ID(N'[dbo].[FK_Stage_inherits_ContratTemporaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratSet_Stage] DROP CONSTRAINT [FK_Stage_inherits_ContratTemporaire];
GO
IF OBJECT_ID(N'[dbo].[FK_Interim_inherits_ContratTemporaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratSet_Interim] DROP CONSTRAINT [FK_Interim_inherits_ContratTemporaire];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CollaborateurSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CollaborateurSet];
GO
IF OBJECT_ID(N'[dbo].[ContratSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratSet];
GO
IF OBJECT_ID(N'[dbo].[AugmentationSalaireSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AugmentationSalaireSet];
GO
IF OBJECT_ID(N'[dbo].[AvenantSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AvenantSet];
GO
IF OBJECT_ID(N'[dbo].[ContratSet_CDI]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratSet_CDI];
GO
IF OBJECT_ID(N'[dbo].[ContratSet_ContratTemporaire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratSet_ContratTemporaire];
GO
IF OBJECT_ID(N'[dbo].[ContratSet_CDD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratSet_CDD];
GO
IF OBJECT_ID(N'[dbo].[ContratSet_Stage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratSet_Stage];
GO
IF OBJECT_ID(N'[dbo].[ContratSet_Interim]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratSet_Interim];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CollaborateurSet'
CREATE TABLE [dbo].[CollaborateurSet] (
    [Matricule] int IDENTITY(1,1) NOT NULL,
    [NomCollabo] nvarchar(max)  NOT NULL,
    [PrenomCollabo] nvarchar(max)  NOT NULL,
    [FonctionCollabo] nvarchar(max)  NOT NULL,
    [Adresse] nvarchar(max)  NULL,
    [Statut] nvarchar(max)  NULL,
    [Photo] nvarchar(max)  NULL,
    [SituationFamiliale] nvarchar(max)  NULL
);
GO

-- Creating table 'ContratSet'
CREATE TABLE [dbo].[ContratSet] (
    [NumContrat] int IDENTITY(1,1) NOT NULL,
    [Qualification] nvarchar(max)  NOT NULL,
    [DateDebutContrat] datetime  NOT NULL,
    [DateFinContrat] datetime  NULL,
    [Collaborateur_Matricule] int  NOT NULL
);
GO

-- Creating table 'AugmentationSalaireSet'
CREATE TABLE [dbo].[AugmentationSalaireSet] (
    [Date] datetime  NOT NULL,
    [Augmentation] decimal(18,0)  NOT NULL,
    [IdAugmentation] int IDENTITY(1,1) NOT NULL,
    [Collaborateur_Matricule] int  NOT NULL
);
GO

-- Creating table 'AvenantSet'
CREATE TABLE [dbo].[AvenantSet] (
    [NumAvenant] int IDENTITY(1,1) NOT NULL,
    [DateAvenant] datetime  NOT NULL,
    [Contrat_NumContrat] int  NOT NULL
);
GO

-- Creating table 'ContratSet_CDI'
CREATE TABLE [dbo].[ContratSet_CDI] (
    [SalaireBrut] decimal(18,0)  NOT NULL,
    [NumContrat] int  NOT NULL
);
GO

-- Creating table 'ContratSet_ContratTemporaire'
CREATE TABLE [dbo].[ContratSet_ContratTemporaire] (
    [Motif] nvarchar(max)  NOT NULL,
    [DateFinPrevue] datetime  NULL,
    [NumContrat] int  NOT NULL
);
GO

-- Creating table 'ContratSet_CDD'
CREATE TABLE [dbo].[ContratSet_CDD] (
    [SalaireBrut] decimal(18,0)  NOT NULL,
    [NumContrat] int  NOT NULL
);
GO

-- Creating table 'ContratSet_Stage'
CREATE TABLE [dbo].[ContratSet_Stage] (
    [Ecole] nvarchar(max)  NOT NULL,
    [Mission] nvarchar(max)  NOT NULL,
    [Indemnite] decimal(18,0)  NULL,
    [NumContrat] int  NOT NULL
);
GO

-- Creating table 'ContratSet_Interim'
CREATE TABLE [dbo].[ContratSet_Interim] (
    [AgenceInterim] nvarchar(max)  NOT NULL,
    [NumContrat] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Matricule] in table 'CollaborateurSet'
ALTER TABLE [dbo].[CollaborateurSet]
ADD CONSTRAINT [PK_CollaborateurSet]
    PRIMARY KEY CLUSTERED ([Matricule] ASC);
GO

-- Creating primary key on [NumContrat] in table 'ContratSet'
ALTER TABLE [dbo].[ContratSet]
ADD CONSTRAINT [PK_ContratSet]
    PRIMARY KEY CLUSTERED ([NumContrat] ASC);
GO

-- Creating primary key on [IdAugmentation] in table 'AugmentationSalaireSet'
ALTER TABLE [dbo].[AugmentationSalaireSet]
ADD CONSTRAINT [PK_AugmentationSalaireSet]
    PRIMARY KEY CLUSTERED ([IdAugmentation] ASC);
GO

-- Creating primary key on [NumAvenant] in table 'AvenantSet'
ALTER TABLE [dbo].[AvenantSet]
ADD CONSTRAINT [PK_AvenantSet]
    PRIMARY KEY CLUSTERED ([NumAvenant] ASC);
GO

-- Creating primary key on [NumContrat] in table 'ContratSet_CDI'
ALTER TABLE [dbo].[ContratSet_CDI]
ADD CONSTRAINT [PK_ContratSet_CDI]
    PRIMARY KEY CLUSTERED ([NumContrat] ASC);
GO

-- Creating primary key on [NumContrat] in table 'ContratSet_ContratTemporaire'
ALTER TABLE [dbo].[ContratSet_ContratTemporaire]
ADD CONSTRAINT [PK_ContratSet_ContratTemporaire]
    PRIMARY KEY CLUSTERED ([NumContrat] ASC);
GO

-- Creating primary key on [NumContrat] in table 'ContratSet_CDD'
ALTER TABLE [dbo].[ContratSet_CDD]
ADD CONSTRAINT [PK_ContratSet_CDD]
    PRIMARY KEY CLUSTERED ([NumContrat] ASC);
GO

-- Creating primary key on [NumContrat] in table 'ContratSet_Stage'
ALTER TABLE [dbo].[ContratSet_Stage]
ADD CONSTRAINT [PK_ContratSet_Stage]
    PRIMARY KEY CLUSTERED ([NumContrat] ASC);
GO

-- Creating primary key on [NumContrat] in table 'ContratSet_Interim'
ALTER TABLE [dbo].[ContratSet_Interim]
ADD CONSTRAINT [PK_ContratSet_Interim]
    PRIMARY KEY CLUSTERED ([NumContrat] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Collaborateur_Matricule] in table 'ContratSet'
ALTER TABLE [dbo].[ContratSet]
ADD CONSTRAINT [FK_CollaborateurContrat]
    FOREIGN KEY ([Collaborateur_Matricule])
    REFERENCES [dbo].[CollaborateurSet]
        ([Matricule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollaborateurContrat'
CREATE INDEX [IX_FK_CollaborateurContrat]
ON [dbo].[ContratSet]
    ([Collaborateur_Matricule]);
GO

-- Creating foreign key on [Collaborateur_Matricule] in table 'AugmentationSalaireSet'
ALTER TABLE [dbo].[AugmentationSalaireSet]
ADD CONSTRAINT [FK_CollaborateurAugmentationSalaire]
    FOREIGN KEY ([Collaborateur_Matricule])
    REFERENCES [dbo].[CollaborateurSet]
        ([Matricule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollaborateurAugmentationSalaire'
CREATE INDEX [IX_FK_CollaborateurAugmentationSalaire]
ON [dbo].[AugmentationSalaireSet]
    ([Collaborateur_Matricule]);
GO

-- Creating foreign key on [Contrat_NumContrat] in table 'AvenantSet'
ALTER TABLE [dbo].[AvenantSet]
ADD CONSTRAINT [FK_ContratAvenant]
    FOREIGN KEY ([Contrat_NumContrat])
    REFERENCES [dbo].[ContratSet]
        ([NumContrat])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContratAvenant'
CREATE INDEX [IX_FK_ContratAvenant]
ON [dbo].[AvenantSet]
    ([Contrat_NumContrat]);
GO

-- Creating foreign key on [NumContrat] in table 'ContratSet_CDI'
ALTER TABLE [dbo].[ContratSet_CDI]
ADD CONSTRAINT [FK_CDI_inherits_Contrat]
    FOREIGN KEY ([NumContrat])
    REFERENCES [dbo].[ContratSet]
        ([NumContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumContrat] in table 'ContratSet_ContratTemporaire'
ALTER TABLE [dbo].[ContratSet_ContratTemporaire]
ADD CONSTRAINT [FK_ContratTemporaire_inherits_Contrat]
    FOREIGN KEY ([NumContrat])
    REFERENCES [dbo].[ContratSet]
        ([NumContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumContrat] in table 'ContratSet_CDD'
ALTER TABLE [dbo].[ContratSet_CDD]
ADD CONSTRAINT [FK_CDD_inherits_ContratTemporaire]
    FOREIGN KEY ([NumContrat])
    REFERENCES [dbo].[ContratSet_ContratTemporaire]
        ([NumContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumContrat] in table 'ContratSet_Stage'
ALTER TABLE [dbo].[ContratSet_Stage]
ADD CONSTRAINT [FK_Stage_inherits_ContratTemporaire]
    FOREIGN KEY ([NumContrat])
    REFERENCES [dbo].[ContratSet_ContratTemporaire]
        ([NumContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumContrat] in table 'ContratSet_Interim'
ALTER TABLE [dbo].[ContratSet_Interim]
ADD CONSTRAINT [FK_Interim_inherits_ContratTemporaire]
    FOREIGN KEY ([NumContrat])
    REFERENCES [dbo].[ContratSet_ContratTemporaire]
        ([NumContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------