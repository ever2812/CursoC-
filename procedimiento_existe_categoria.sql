create proc categoria_existe
--parametro de entrada
@valor varchar(100),
--parametro de salida
@existe bit output
as
	if exists (select nombre from categoria where nombre = ltrim(rtrim(@valor)))
		--ltrim borra espacios en blanco a la izquiera y rtrim a la derecha
		begin
			set @existe=1
		end
	else
		begin
			set @existe =0
		end
