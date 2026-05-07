CREATE TABLE [dbo].[PaymentInfo] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Addres]     VARCHAR (50) NOT NULL,
    [BankNumber] INT          NOT NULL,
    [BankInfoID] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PaymentInfo_BankInfo] FOREIGN KEY ([BankInfoID]) REFERENCES [dbo].[BankInfo] ([Id])
);

