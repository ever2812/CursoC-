using System;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DUsuario
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usuario_listar", sqlcon);
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

        public DataTable Buscar(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usuario_buscar", sqlcon);
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

        public DataTable Login(string email, string clave)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usuario_login", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                return null;
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
                SqlCommand comando = new SqlCommand("usuario_existe", sqlcon);
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

        public string Insertar(usuario Obj)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usuario_insertar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.Idrol;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value= Obj.TipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value=Obj.NumDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value= Obj.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value= Obj.Telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value= Obj.Email;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave;
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

        public string Actualizar(usuario Obj)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usuario_actualizar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.idusuario;
                comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.Idrol;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value= Obj.TipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value=Obj.NumDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value= Obj.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value= Obj.Telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value= Obj.Email;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave;
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
                SqlCommand comando = new SqlCommand("usuario_eliminar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
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
                SqlCommand comando = new SqlCommand("usuario_activar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
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
                SqlCommand comando = new SqlCommand("usuario_desactivar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
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
