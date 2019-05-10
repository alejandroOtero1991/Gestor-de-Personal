CREATE TABLE [dbo].[Table]
(
	[DNI] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Nombre] VARCHAR(50) NOT NULL, 
    [Apellidos] VARCHAR(50) NOT NULL, 
    [Edad] INT NOT NULL, 
    [Antiguedad] INT NULL, 
    [Activo] Bit  NULL DEFAULT 1, 
    [Baja] BIT NULL, 
    [Vacaciones] BIT NULL
)
