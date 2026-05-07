CREATE TABLE [dbo].[BankInfo] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [BankDetails] VARCHAR (50) NULL,
    [Name]        VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

