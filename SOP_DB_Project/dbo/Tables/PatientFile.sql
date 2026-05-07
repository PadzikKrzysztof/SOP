CREATE TABLE [dbo].[PatientFile] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NULL,
    [Description] VARCHAR (MAX) NULL,
    [PatientID]   INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PatientFile_ToTable] FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient] ([Id])
);

