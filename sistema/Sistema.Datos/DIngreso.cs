using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DIngreso
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ingreso_listar", sqlcon);
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
                SqlCommand comando = new SqlCommand("ingreso_buscar", sqlcon);
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

        public DataTable ListarDetalle(int idingreso)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ingreso_listar_detalle", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idingreso", SqlDbType.Int).Value = idingreso;
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

        public string Insertar(Ingreso Obj)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ingreso_insertar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idproveedor", SqlDbType.Int).Value = Obj.IdProveedor;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value= Obj.IdUsuario;
                comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = Obj.Tipocomprobante;
                comando.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = Obj.SerieComprobante;
                comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value= Obj.NumComprobante;
                comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = Obj.Impuesto;
                comando.Parameters.Add("@total", SqlDbType.Decimal).Value = Obj.Total;
                comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = Obj.Detalles;
                sqlcon.Open();
                comando.ExecuteNonQuery();
                rpta =  "OK";

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

        public string Anular(int id)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ingreso_anular", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idingreso", SqlDbType.Int).Value = id;
                sqlcon.Open();
                comando.ExecuteNonQuery();
                rpta = "OK";
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
