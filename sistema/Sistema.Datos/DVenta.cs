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
    public class DVenta
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("venta_listar", sqlcon);
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
                SqlCommand comando = new SqlCommand("venta_buscar", sqlcon);
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

        public DataTable ConsultaFechas(DateTime fecha_inicio, DateTime fecha_fin)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("venta_consulta_fechas", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = fecha_inicio;
                comando.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = fecha_fin;
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
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public DataTable ListarDetalle(int idventa)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("venta_listar_detalle", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idventa", SqlDbType.Int).Value = idventa;
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

        public string Insertar(Venta Obj)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon =  Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("venta_insertar", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idcliente", SqlDbType.Int).Value = Obj.IdCliente;
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
                SqlCommand comando = new SqlCommand("venta_anular", sqlcon);
                comando.CommandType= CommandType.StoredProcedure;
                comando.Parameters.Add("@idventa", SqlDbType.Int).Value = id;
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
