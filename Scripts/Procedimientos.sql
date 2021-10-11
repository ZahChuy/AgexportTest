Create procedure emp_grabar(
@Nombres VARCHAR (100),
	@Apellidos  VARCHAR (100),
	@Genero  VARCHAR (10),
	@EstadoCivil  VARCHAR (10),
    @FechaNacimiento DATETIME, 
	@Edad INT, 
	@DPI INT, 
	@NIT VARCHAR (20),
	@AfiliacionIGGS INT, 
	@AfilicacionIrtra INT, 
	@NoPasaporte INT, 
	@PaisId INT, 
	@Telefono INT, 
	@DireccionResidencia VARCHAR (250),
	@Puesto VARCHAR (250),
	@Sueldo DECIMAL (16, 2),
	@Bonificacion DECIMAL (16, 2))
as begin 
insert into Empleado (
	Nombres,
	Apellidos,
	Genero,
	EstadoCivil,
    FechaNacimiento, 
	Edad, 
	DPI, 
	NIT,
	AfiliacionIGGS, 
	AfilicacionIrtra, 
	NoPasaporte, 
	PaisId, 
	Telefono, 
	DireccionResidencia,
	Puesto,
	Sueldo,
	Bonificacion,
	EstadoId
)
values(
@Nombres,
	@Apellidos,
	@Genero,
	@EstadoCivil,
    @FechaNacimiento, 
	@Edad, 
	@DPI, 
	@NIT,
	@AfiliacionIGGS, 
	@AfilicacionIrtra, 
	@NoPasaporte, 
	@PaisId, 
	@Telefono, 
	@DireccionResidencia,
	@Puesto,
	@Sueldo,
	@Bonificacion,
	1
)
end
go

Create procedure emp_modificar
(
@EmpleadoId INT, 
@Nombres VARCHAR (100),
	@Apellidos  VARCHAR (100),
	@Genero  VARCHAR (10),
	@EstadoCivil  VARCHAR (10),
    @FechaNacimiento DATETIME, 
	@Edad INT, 
	@DPI INT, 
	@NIT VARCHAR (20),
	@AfiliacionIGGS INT, 
	@AfilicacionIrtra INT, 
	@NoPasaporte INT, 
	@PaisId INT, 
	@Telefono INT, 
	@DireccionResidencia VARCHAR (250),
	@Puesto VARCHAR (250),
	@Sueldo DECIMAL (16, 2),
	@Bonificacion DECIMAL (16, 2))
as begin 

update Empleado set 
	Nombres = @Nombres ,
	Apellidos = @Apellidos,
	Genero = @Genero,
	EstadoCivil = @EstadoCivil ,
    FechaNacimiento = @FechaNacimiento, 
	Edad = @Edad, 
	DPI = @DPI, 
	NIT = @NIT,
	AfiliacionIGGS = @AfiliacionIGGS, 
	AfilicacionIrtra = @AfilicacionIrtra, 
	NoPasaporte = @NoPasaporte, 
	PaisId = @PaisId, 
	Telefono =  @Telefono, 
	DireccionResidencia = @DireccionResidencia,
	Puesto = @Puesto,
	Sueldo = @Sueldo,
	Bonificacion = @Bonificacion
	where  EmpleadoId = @EmpleadoId


end
go



Create procedure emp_listar
as begin 
select * from Empleado where EstadoId = 1
end
go


Create procedure emp_obtener(
@EmpleadoId INT
)
as begin 
select * from Empleado where  EmpleadoId = @EmpleadoId
end
go

Create procedure emp_eliminar(
@EmpleadoId INT
)
as begin 
update Empleado set EstadoId = 2 where  EmpleadoId = @EmpleadoId
end
go

 
