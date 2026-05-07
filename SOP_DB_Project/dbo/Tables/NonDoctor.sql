CREATE TABLE [dbo].[NonDoctor] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [Role]       INT NOT NULL,
    [EmployeeID] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_NonDoctor_Employee] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee] ([Id]),
    CONSTRAINT [FK_NonDoctor_RoleEnum] FOREIGN KEY ([Role]) REFERENCES [dbo].[RoleEnum] ([Id])
);

