CREATE TABLE [dbo].[Day] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [DayOfMonth] INT NOT NULL,
    [Month]      INT NOT NULL,
    [Year]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Day_MonthEnum] FOREIGN KEY ([Month]) REFERENCES [dbo].[MonthEnum] ([Id])
);

