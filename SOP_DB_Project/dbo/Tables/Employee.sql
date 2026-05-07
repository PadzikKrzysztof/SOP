CREATE TABLE [dbo].[Employee] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (50) NOT NULL,
    [Surname]       VARCHAR (50) NOT NULL,
    [PaymentInfoID] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Employee_PaymentInfo] FOREIGN KEY ([PaymentInfoID]) REFERENCES [dbo].[PaymentInfo] ([Id])
);

