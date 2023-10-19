using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Entidades;
using Sistema.Datos;

namespace Sistema.Negocio
{
    public class NUsuario
    {
        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Buscar(valor);
        }

        public static DataTable Login(string email, string clave)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Login(email,clave);
        }

        public static String Insertar(int idrol, string nombre, string tipo_documento, string num_ocumento, string direccion, string telefono, string email, string clave)
        {
            DUsuario Datos = new DUsuario();

            string Existe = Datos.Existe(email);
            if (Existe.Equals("1"))
            {
                return "El usuario con este email ya existe";
            }
            else
            {
                usuario Obj = new usuario();
                Obj.Idrol= idrol;
                Obj.Nombre= nombre;
                Obj.TipoDocumento = tipo_documento;
                Obj.NumDocumento= num_ocumento;
                Obj.Direccion= direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
                Obj.Clave = clave;
           
                return Datos.Insertar(Obj);
            }
        }

        public static String Actualizar(int idusuario, int idrol, string nombre, string tipo_documento, string num_ocumento, string direccion, string telefono,string email_ant, string email, string clave)
        {
            DUsuario Datos = new DUsuario();

            usuario Obj = new usuario();

            if (email_ant.Equals(email))
            {
                Obj.idusuario=idusuario;
                Obj.Idrol= idrol;
                Obj.Nombre= nombre;
                Obj.TipoDocumento = tipo_documento;
                Obj.NumDocumento= num_ocumento;
                Obj.Direccion= direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
                Obj.Clave = clave;

                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(email);
                if (Existe.Equals("1"))
                {
                    return "El usuario con este email ya existe";
                }
                else
                {
                    Obj.idusuario=idusuario;
                    Obj.Idrol= idrol;
                    Obj.Nombre= nombre;
                    Obj.TipoDocumento = tipo_documento;
                    Obj.NumDocumento= num_ocumento;
                    Obj.Direccion= direccion;
                    Obj.Telefono = telefono;
                    Obj.Email = email;
                    Obj.Clave = clave;

                    return Datos.Actualizar(Obj);
                }
            }
        }

        public static string Eliminar(int id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Desactivar(id);
        }

    }
}
