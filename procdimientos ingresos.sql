-- Procedimiento Listar
create proc ingreso_listar
as
select i.idingreso as ID, i.idusuario, u.nombre as Usuario, p.nombre as Proveedor, i.tipo_comprobante as Tipo_comprobante,
i.serie_comprobante as Serie, i.num_comprobante as Numero, i.fecha as Fecha, i.impuesto as Impuesto,
i.total as Total, i.estado as Estado
from ingreso i inner join usuario u on i.idusuario=u.idusuario inner join persona p on i.idproveedor=p.idpersona
order by i.idingreso desc
go

-- Procedimiento Buscar
create proc ingreso_buscar
@valor varchar(50)
as
select i.idingreso as ID, i.idusuario, u.nombre as Usuario, p.nombre as Proveedor, i.tipo_comprobante as Tipo_comprobante,
i.serie_comprobante as Serie, i.num_comprobante as Numero, i.fecha as Fecha, i.impuesto as Impuesto,
i.total as Total, i.estado as Estado
from ingreso i inner join usuario u on i.idusuario=u.idusuario inner join persona p on i.idproveedor=p.idpersona
where i.num_comprobante like '%' +@valor + '%' Or p.nombre like '%' +@valor + '%'
order by i.fecha asc
go

--Procedimiento ingreso_anular
create proc ingreso_anular
@idingreso int
as
update ingreso set estado='Anulado'
where idingreso=@idingreso;
update articulo
set stock=stock-d.cantidad
from articulo a
inner join (select idarticulo,cantidad from detalle_ingreso where idingreso=@idingreso) as d
on a.idarticulo=d.idarticulo;


create type type_detalle_ingreso as table(

	idarticulo int,
	codigo varchar(50),
	articulo varchar(100),
	cantidad int,
	precio decimal(11,2),
	importe decimal(11,2)
	)
go

--Procedimiento ingreso_insertar
create proc ingreso_insertar
@idusuario int,
@idproveedor int,
@tipo_comprobante varchar(20),
@serie_comprobante varchar(7),
@num_comprobante varchar(10),
@impuesto decimal(4,2),
@total decimal(11,2),
@detalle type_detalle_ingreso readonly
as
begin
	--Inserta los datos en la tabla
	insert into ingreso(idproveedor,idusuario,tipo_comprobante,serie_comprobante,num_comprobante,fecha,impuesto,total,estado)
	values(@idproveedor,@idusuario,@tipo_comprobante,@serie_comprobante,@num_comprobante,getdate(),@impuesto,@total,'Aceptado')
	
	--Insertar los detalles del ingreso
	insert detalle_ingreso(idingreso,idarticulo,cantidad,precio)
	select @@identity,d.idarticulo,d.cantidad,d.precio
	from @detalle d;
end
go

--Procedimiento para listar el detalle de cada ingreso
create proc ingreso_listar_detalle
@idingreso int
as
select d.idarticulo as ID, a.codigo as CODIGO, a.nombre as ARTICULO, d.cantidad as CANTIDAD, d.precio as PRECIO,
 (d.precio*d.cantidad)  as IMPORTE
from detalle_ingreso d inner join articulo a on d.idarticulo=a.idarticulo
where d.idingreso=@idingreso
go