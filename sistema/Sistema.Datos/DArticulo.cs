using System;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DArticulo
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_listar", sqlcon);
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
                SqlCommand comando = new SqlCommand("articulo_buscar", sqlcon);
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

        public DataTable BuscarVenta(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_buscar_venta", sqlcon);
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

        public DataTable BuscarCodigo(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_buscar_codigo", sqlcon);
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

        public DataTable BuscarCodigoVenta(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_buscar_codigo_venta", sqlcon);
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

        public string Existe(string valor)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_existe", sqlcon);

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

        public string Insertar(articulo ObjETO)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_insertar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
              
                comando.Parameters.Add("@idcategoria", SqlDbType.VarChar).Value=ObjETO.IdCategoria;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjETO.Codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjETO.Nombre;
                comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = ObjETO.PrecioVenta;
                comando.Parameters.Add("@stock", SqlDbType.Int).Value= ObjETO.Stock;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = ObjETO.Descripcion;
                comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = ObjETO.imagen;

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

        public string Actualizar(articulo Obj)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_actualizar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;

                comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value= Obj.IdArticulo;
                comando.Parameters.Add("@idcategoria", SqlDbType.VarChar).Value=Obj.IdCategoria;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.PrecioVenta;
                comando.Parameters.Add("@stock", SqlDbType.Int).Value= Obj.Stock;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.imagen;

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
                SqlCommand comando = new SqlCommand("articulo_eliminar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;

                comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
                
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
                SqlCommand comando = new SqlCommand("articulo_activar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
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
                SqlCommand comando = new SqlCommand("articulo_desactivar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
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
