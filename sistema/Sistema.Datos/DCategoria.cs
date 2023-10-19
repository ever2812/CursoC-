using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Entidades;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class DCategoria
    {

        public DataTable Listar() {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_listar",sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally {
                if (sqlcon.State== ConnectionState.Open) sqlcon.Close();
            }
        }

        public DataTable Buscar(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_buscar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State== ConnectionState.Open) sqlcon.Close();
            }
        }

        public DataTable Seleccionar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_seleccionar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State== ConnectionState.Open) sqlcon.Close();
            }
        }

        public string Existe(string valor)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_existe", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType= SqlDbType.Int;
                ParExiste.Direction= ParameterDirection.Output;
                comando.Parameters.Add(ParExiste);
                sqlcon.Open();

              comando.ExecuteNonQuery();
                rpta= ParExiste.Value.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State== ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

        public string Insertar(categoria Obj)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try 
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_insertar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                sqlcon.Open();

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
           
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State== ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

        public string Actualizar(categoria Obj)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();


            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_actualizar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                sqlcon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State== ConnectionState.Open) sqlcon.Close();
            }
            return rpta;

        }

        public string Eliminar(int id)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();


            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_eliminar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;
                sqlcon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State== ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

        public string Activar(int id)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();


            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_activar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;
                sqlcon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State== ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

        public string Desactivar(int id)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_desactivar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;
                sqlcon.Open();

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State== ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }
    }
}
