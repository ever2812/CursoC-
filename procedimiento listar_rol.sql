insert into rol(nombre) values('Administrador');
insert into rol(nombre) values('Vendedor');
insert into rol(nombre) values('Almacenista');
go


-- procedimiento para listar roles
create proc rol_listar
as
select idrol,nombre from rol where estado=1
go

