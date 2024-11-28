CREATE TABLE [dbo].[Policia] (
    [id]              INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]          VARCHAR (100)  NOT NULL,
    [Direccion]       VARCHAR (255)  NULL,
    [Dui]             VARCHAR (10)   NOT NULL,
    [DescripcionCaso] VARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([Dui] ASC)
);

