CREATE TABLE [dbo].[Basket] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NULL,
    [LastName]  NVARCHAR (MAX) NULL,
    [ContactNo] FLOAT (53)     NOT NULL,
    [Gender]    NVARCHAR (MAX) NULL,
    [Address]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Basket] PRIMARY KEY CLUSTERED ([ID] ASC)
);

