insert into Categoria(Nombre,EstadoId,FechaMod)values( 'Genero',1,getdate())
insert into Categoria(Nombre,EstadoId,FechaMod)values( 'Estado civil',1,getdate())

select * from Categoria

insert into Parametro(CategoriaId,Nombre,Codigo,EstadoId,FechaMod)values( 2,'Masculino','GEN',1,getdate())
insert into Parametro(CategoriaId,Nombre,Codigo,EstadoId,FechaMod)values( 2,'Femenino','GEN',1,getdate())
insert into Parametro(CategoriaId,Nombre,Codigo,EstadoId,FechaMod)values( 3,'Soltero','ESTCIV',1,getdate())
insert into Parametro(CategoriaId,Nombre,Codigo,EstadoId,FechaMod)values( 3,'Casado','ESTCIV',1,getdate())
insert into Parametro(CategoriaId,Nombre,Codigo,EstadoId,FechaMod)values( 3,'Separado','ESTCIV',1,getdate())
insert into Parametro(CategoriaId,Nombre,Codigo,EstadoId,FechaMod)values( 3,'Divorciado','ESTCIV',1,getdate())
insert into Parametro(CategoriaId,Nombre,Codigo,EstadoId,FechaMod)values( 3,'Viudo','ESTCIV',1,getdate())

select * from Parametro