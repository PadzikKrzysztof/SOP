CREATE TABLE [dbo].[LabTest] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (50)  NULL,
    [Description]   VARCHAR (MAX) NULL,
    [SpecificData]  VARCHAR (MAX) NULL,
    [PatientFileID] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LabTest_PatientFile] FOREIGN KEY ([PatientFileID]) REFERENCES [dbo].[PatientFile] ([Id])
);

