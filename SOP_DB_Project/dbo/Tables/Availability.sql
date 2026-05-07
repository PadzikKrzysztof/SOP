CREATE TABLE [dbo].[Availability] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [TimeStart] TIME (7) NOT NULL,
    [TimeEnd]   TIME (7) NOT NULL,
    [DoctorID]  INT      NOT NULL,
    [DayID]     INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Availability_Day] FOREIGN KEY ([DayID]) REFERENCES [dbo].[Day] ([Id]),
    CONSTRAINT [FK_Availability_Doctor] FOREIGN KEY ([DoctorID]) REFERENCES [dbo].[Doctor] ([Id])
);

