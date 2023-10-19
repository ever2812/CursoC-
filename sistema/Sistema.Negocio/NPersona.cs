using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NPersona
    {
        public static DataTable Listar()
        {
            DPersona Datos = new DPersona();
            return Datos.Listar();
        }
        public static DataTable ListarProveedores()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarProveedores();
        }

        public static DataTable ListarClientes()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarClientes();
        }

        public static DataTable Buscar(string valor)
        {
            DPersona Datos = new DPersona();
            return Datos.Buscar(valor);
        }

        public static DataTable BuscarProveedores(string valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarProveedores(valor);
        }

        public static DataTable BuscarClientes(string valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarClientes(valor);
        }

        public static String Insertar(string tipo_persona, string nombre, string tipo_documento, string num_ocumento, string direccion, string telefono, string email)
        {
            DPersona Datos = new DPersona();

            string Existe = Datos.Existe(nombre);
            if (Existe.Equals("1"))
            {
                return "Esta persona ya esta registrada";
            }
            else
            {
                persona Obj = new persona();
                Obj.TipoPersona= tipo_persona;
                Obj.Nombre= nombre;
                Obj.TipoDocumento = tipo_documento;
                Obj.NumDocumento= num_ocumento;
                Obj.Direccion= direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
                return Datos.Insertar(Obj);
            }
        }

        public static String Actualizar(int idpersona, string tipo_persona, string nombre_ant, string nombre, string tipo_documento, string num_ocumento, string direccion, string telefono, string email)
        {
            DPersona Datos = new DPersona();

            persona Obj = new persona();

            if (nombre_ant.Equals(email))
            {
                Obj.IdPersona=idpersona;
                Obj.TipoPersona= tipo_persona;
                Obj.Nombre= nombre;
                Obj.TipoDocumento = tipo_documento;
                Obj.NumDocumento= num_ocumento;
                Obj.Direccion= direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
           
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(nombre);
                if (Existe.Equals("1"))
                {
                    return "Una persona con ese nombre ya ha sido registrada";
                }
                else
                {

                    Obj.IdPersona=idpersona;
                    Obj.TipoPersona= tipo_persona;
                    Obj.Nombre= nombre;
                    Obj.TipoDocumento = tipo_documento;
                    Obj.NumDocumento= num_ocumento;
                    Obj.Direccion= direccion;
                    Obj.Telefono = telefono;
                    Obj.Email = email;


                    return Datos.Actualizar(Obj);
                }
            }
        }

        public static string Eliminar(int id)
        {
            DPersona Datos = new DPersona();
            return Datos.Eliminar(id);
        }
    }
}
