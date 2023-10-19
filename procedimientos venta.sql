--Procedimiento listar venta
create proc venta_listar
as
select v.idventa as ID, v.idusuario, u.nombre as Usuario, p.nombre as Cliente,
v.tipo_comprobante as Tipo_Comprobante, v.serie_comprobante as Serie,
v.num_comprobante as Numero, v.fecha as Fecha, v.impuesto as Impuesto,
v.total as Total, v.estado as Estado
from venta v inner join usuario u on v.idusuario=u.idusuario
inner join persona p on v.idcliente=p.idpersona
order by v.idventa desc
go

--Procedimiento Buscar venta
create proc venta_buscar
@valor varchar(59)
as
select v.idventa as ID, v.idusuario, u.nombre as Usuario, p.nombre as Cliente,
v.tipo_comprobante as Tipo_Comprobante, v.serie_comprobante as Serie,
v.num_comprobante as Numero, v.fecha as Fecha, v.impuesto as Impuesto,
v.total as Total, v.estado as Estado
from venta v inner join usuario u on v.idusuario=u.idusuario
inner join persona p on v.idcliente=p.idpersona
where v.num_comprobante like '%' + @valor + '%' Or p.nombre like '%' + @valor + '%'
order by v.fecha asc
go


--Procedimiento anular venta
create proc venta_anular
@idventa int
as
update venta set estado='Anulado'
where idventa=@idventa
--Actualiza el stock, regresa las cantidades vendidas al stock original
update articulo
set stock=stock+d.cantidad
from articulo a
inner join
(select idarticulo,cantidad from detalle_venta where idventa=@idventa) as d
on a.idarticulo=d.idarticulo



--Procedimiento para insertar una venta
create type type_detalle_venta as table
(
	idarticulo int,
	codigo varchar(50),
	articulo varchar(200),
	stock int,
	cantidad int,
	precio decimal(11,2),
	descuento decimal(11,2),
	importe decimal(11,2)
)
go

create proc venta_insertar
@idusuario int,
@idcliente int,
@tipo_comprobante varchar(20),
@serie_comprobante varchar(7),
@num_comprobante varchar(10),
@impuesto decimal(4,2),
@total decimal(11,2),
@detalle type_detalle_venta readonly
as
begin
	insert into venta(idusuario,idcliente,tipo_comprobante,serie_comprobante,num_comprobante,fecha,
	impuesto,total,estado)
	values(@idusuario,@idcliente,@tipo_comprobante,@serie_comprobante,@num_comprobante,GETDATE(),@impuesto,@total,'Aceptado');


	insert into detalle_venta(idventa,idarticulo,cantidad,precio,descuento) 
	select @@IDENTITY,d.idarticulo,d.cantidad,d.precio,d.descuento
	from @detalle d;
end



--trigger para actualizar stock despues de realizar una venta(se hace en automatico)
create trigger Venta_ActualizarStock
	on detalle_venta
	for insert
	as
	update a set a.stock=a.stock-d.cantidad
	from articulo as a inner join
	inserted as d on d.idarticulo=a.idarticulo
go



--Procedimiento para listar el detalle de cada venta
create proc venta_listar_detalle
@idventa int
as
select d.idarticulo as ID, a.codigo as CODIGO, a.nombre as ARTICULO,
d.cantidad as CANTIDAD, d.precio as PRECIO, d.descuento as DESCUENTO,
((d.cantidad*precio) - d.descuento) as IMPORTE
from detalle_venta d inner join articulo a on d.idarticulo=a.idarticulo
where d.idventa=@idventa
go


--Procedimiento para consultas de ventas entre fechas
create proc venta_consulta_fechas
@fecha_inicio date,
@fecha_fin date
as
select v.idventa as ID, v.idusuario, u.nombre as Usuario, p.nombre as Cliente,
v.tipo_comprobante as Tipo_Comprobante, v.serie_comprobante as Serie,
v.num_comprobante as Numero, v.fecha as Fecha, v.impuesto as Impuesto,
v.total as Total, v.estado as Estado
from venta v inner join usuario u on v.idusuario=u.idusuario
inner join persona p on v.idcliente=p.idpersona
where v.fecha>=@fecha_inicio and v.fecha<=@fecha_fin
order by v.idventa desc
go
