using System;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NArticulo
    {
        public static DataTable Listar()
        {
            DArticulo Datos = new DArticulo();
            return Datos.Listar();

        }

        public static DataTable Buscar(string valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Buscar(valor);
        }

        public static DataTable BuscarVenta(string valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.BuscarVenta(valor);
        }

        public static DataTable BuscarCodigo(string valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.BuscarCodigo(valor);
        }

        public static DataTable BuscarCodigoVenta(string valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.BuscarCodigoVenta(valor);
        }

        public static String Insertar(int idcategoria, string codigo, string nombre, decimal precio_venta, int stock, string descripcion, string imagen)
        {
            DArticulo Datos = new DArticulo();

            string Existe = Datos.Existe(nombre);
            if (Existe.Equals("1"))
            {
                return "El Articulo ya existe y esta registrada";
            }
            else
            {
                articulo Obj = new articulo();
                Obj.IdCategoria= idcategoria;
                Obj.Codigo=codigo;
                Obj.Nombre=nombre;
                Obj.PrecioVenta= precio_venta;
                Obj.Stock=stock;
                Obj.Descripcion= descripcion;
                Obj.imagen= imagen;

                return Datos.Insertar(Obj);
            }
        }

        public static String Actualizar(int id, int idcategoria, string codigo, string nombre_ant, string nombre, decimal precio_venta, int stock, string descripcion, string imagen)
        {
            DArticulo Datos = new DArticulo();

            articulo Obj = new articulo();

            if (nombre_ant.Equals(nombre))
            {
                Obj.IdArticulo= id;
                Obj.IdCategoria=idcategoria;
                Obj.Codigo=codigo;
                Obj.Nombre=nombre;
                Obj.PrecioVenta= precio_venta;
                Obj.Stock=stock;
                Obj.Descripcion= descripcion;
                Obj.imagen= imagen;

                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(nombre);
                if (Existe.Equals("1"))
                {
                    return "Este articulo ya existe";
                }
                else
                {
                    Obj.IdArticulo= id;
                    Obj.IdCategoria=idcategoria;
                    Obj.Codigo=codigo;
                    Obj.Nombre=nombre;
                    Obj.PrecioVenta= precio_venta;
                    Obj.Stock=stock;
                    Obj.Descripcion= descripcion;
                    Obj.imagen= imagen;

                    return Datos.Actualizar(Obj);

                }
            }


        }

        public static string Eliminar(int id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Desactivar(id);
        }

    }
}
