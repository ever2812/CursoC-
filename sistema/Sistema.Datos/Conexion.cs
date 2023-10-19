﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Sistema.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private Boolean seguridad;

        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "dbsistema";
            this.Servidor= "EVER-PC\\SQLEXPRESS";
            this.Usuario = "sa";
            this.Clave = "";
            this.seguridad= true;

        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = "Server="+this.Servidor + "; Database="+this.Base + ";";
                if (seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + " Integrated Security=SSPI";
                }
                else 
                {
                    cadena.ConnectionString = cadena.ConnectionString + " User Id=" + this.Usuario + "; Password="+this.Clave+";";
                }

            }

            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;

        }
    }
}
