CREATE TABLE [dbo].[Customers] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NOT NULL,
    [LastName]  NVARCHAR (MAX) NOT NULL,
    [Address]   NVARCHAR (MAX) NULL,
    [Phone]     NVARCHAR (MAX) NULL,
    [Email]     NVARCHAR (MAX) ,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

