using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;
using System.Data;

namespace Sistema.Negocio
{
    public class NCategoria
    {

        public static DataTable Listar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        
        }

        public static DataTable Buscar(string valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(valor);
        }

        public static DataTable Seleccionar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Seleccionar();

        }

        public static String Insertar(string nombre, string descripcion)
        {
            DCategoria Datos = new DCategoria();

            string Existe = Datos.Existe(nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe y esta registrada";
            }
            else
            {
                categoria Obj = new categoria();
                Obj.Nombre=nombre;
                Obj.Descripcion= descripcion;

                return Datos.Insertar(Obj);
            }
        }

        public static String  Actualizar(int id, string nombre_ant, string nombre, string descripcion)
        {
            DCategoria Datos = new DCategoria();

            categoria Obj = new categoria();

            if (nombre_ant.Equals(nombre))
            {
                Obj.IdCategoria=id;
                Obj.Nombre=nombre;
                Obj.Descripcion= descripcion;

                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(nombre);
                if (Existe.Equals("1"))
                {
                    return "La categoria ya existe y esta registrada";
                }
                else
                {
                    Obj.IdCategoria=id;
                    Obj.Nombre=nombre;
                    Obj.Descripcion= descripcion;

                    return Datos.Actualizar(Obj);

                }
            }
           
           
        }

        public static string  Eliminar(int id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Desactivar(id);
        }

      

    }
}
