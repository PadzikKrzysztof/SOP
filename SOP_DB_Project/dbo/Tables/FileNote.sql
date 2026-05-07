CREATE TABLE [dbo].[FileNote] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NULL,
    [Description] VARCHAR (MAX) NULL,
    [LabTestID]   INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FileNote_LabTest] FOREIGN KEY ([LabTestID]) REFERENCES [dbo].[LabTest] ([Id])
);

