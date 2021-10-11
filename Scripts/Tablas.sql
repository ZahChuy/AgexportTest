
CREATE TABLE [dbo].[Categoria]
(
[CategoriaId] INT IDENTITY (1, 1) NOT NULL,
[Nombre]  VARCHAR (100) NOT NULL,
[EstadoId] INT NOT NULL, --1 activo, 2 inactivo
[FechaMod] DATETIME NOT NULL
)


CREATE TABLE [dbo].[Parametro]
(
[ParametroId] INT IDENTITY (1, 1) NOT NULL,
[CategoriaId] INT,
[Nombre]  VARCHAR (100) NOT NULL,
[Codigo]  VARCHAR (20) NOT NULL,
[EstadoId] INT NOT NULL, --1 activo, 2 inactivo
[FechaMod] DATETIME NOT NULL
)

CREATE TABLE [dbo].[HEmpleado]
(
	[HEmpleadoId] INT IDENTITY (1, 1) NOT NULL,
    [EmpleadoId] INT   NOT NULL, 
	[Nombres]       VARCHAR (100) NOT NULL,
	[Apellidos]       VARCHAR (100) NOT NULL,
	[Genero]       VARCHAR (10) NOT NULL,--Masculino y Femenino
	[EstadoCivil]       VARCHAR (10) NOT NULL,-- Soltero, Casado, Separado, Divorciado y Viudo
    [FechaNacimiento] DATETIME NOT NULL, 
	[Edad] INT NOT NULL, 
	[DPI] INT NOT NULL, 
	[NIT] VARCHAR (20) NOT NULL,
	[AfiliacionIGGS] INT NOT NULL, 
	[AfilicacionIrtra] INT NOT NULL, 
	[NoPasaporte] INT NOT NULL, 
	[PaisId] INT NOT NULL, 
	[Telefono] INT NOT NULL, 
	[DireccionResidencia] VARCHAR (250) NOT NULL,
	[Puesto] VARCHAR (250) NOT NULL,
	[Sueldo] DECIMAL (16, 2) NOT NULL,
	[Bonificacion] DECIMAL (16, 2) NOT NULL,
	[EstadoId] INT NOT NULL, --1 activo, 2 inactivo
)


CREATE TABLE [dbo].Empleado
(
	[EmpleadoId] INT   IDENTITY (1, 1) NOT NULL, 
	[Nombres]       VARCHAR (100) NOT NULL,
	[Apellidos]       VARCHAR (100) NOT NULL,
	[Genero]       VARCHAR (10) NOT NULL,--Masculino y Femenino
	[EstadoCivil]       VARCHAR (10) NOT NULL,-- Soltero, Casado, Separado, Divorciado y Viudo
    [FechaNacimiento] DATE NOT NULL, 
	[Edad] INT NOT NULL, 
	[DPI] INT NOT NULL, 
	[NIT] VARCHAR (20) NOT NULL,
	[AfiliacionIGGS] INT NOT NULL, 
	[AfilicacionIrtra] INT NOT NULL, 
	[NoPasaporte] INT NOT NULL, 
	[PaisId] INT NOT NULL, 
	[Telefono] INT NOT NULL, 
	[DireccionResidencia] VARCHAR (250) NOT NULL,
	[Puesto] VARCHAR (250) NOT NULL,
	[Sueldo] DECIMAL (16, 2) NOT NULL,
	[Bonificacion] DECIMAL (16, 2) NOT NULL,
	[EstadoId] INT NOT NULL, --1 activo, 2 inactivo
    PRIMARY KEY CLUSTERED ([EmpleadoId] ASC)   
)

GO

CREATE TRIGGER [dbo].[Trigger_Empleado]
    ON [dbo].[HEmpleado]
    FOR UPDATE
    AS
    BEGIN
	
       INSERT INTO [HEmpleado]  
	   Select
	b.EmpleadoId, 
	b.Nombres,
	b.Apellidos,
	b.Genero,
	b.EstadoCivil,
    b.FechaNacimiento, 
	b.Edad, 
	b.DPI, 
	b.NIT,
	b.AfiliacionIGGS, 
	b.AfilicacionIrtra, 
	b.NoPasaporte, 
	b.PaisId, 
	b.Telefono, 
	b.DireccionResidencia,
	b.Puesto,
	b.sueldo,
	b.Bonificacion,
	b.EstadoId
	   From  deleted b ; 
    
	END