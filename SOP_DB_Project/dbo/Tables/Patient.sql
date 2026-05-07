CREATE TABLE [dbo].[Patient] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (50) NOT NULL,
    [Surname] VARCHAR (50) NOT NULL,
    [PESEL]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

