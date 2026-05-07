CREATE TABLE [dbo].[Doctor] (
    [Id]             INT IDENTITY (1, 1) NOT NULL,
    [Specialization] INT NOT NULL,
    [EmployeeID]     INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Doctor_DoctorSpecializationEnum] FOREIGN KEY ([Specialization]) REFERENCES [dbo].[DoctorSpecializationEnum] ([Id]),
    CONSTRAINT [FK_Doctor_Employee] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee] ([Id])
);

