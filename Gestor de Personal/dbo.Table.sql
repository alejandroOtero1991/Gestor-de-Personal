CREATE TABLE [dbo].[Table] (
    [Id]         INT          NOT NULL IDENTITY(1,1),
    [DNI]        VARCHAR (50) NULL DEFAULT 0,
    [Nombre]     VARCHAR (50) NULL ,
    [Apellidos]  VARCHAR (50) NULL ,
    [Edad]       INT          NULL DEFAULT 18,
    [Antiguedad] INT          NULL DEFAULT 0,
    [Activo]     BIT          DEFAULT ((1)) NULL,
    [Baja]       BIT          NULL DEFAULT ((0)),
    [Vacaciones] BIT          NULL DEFAULT ((0)),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

