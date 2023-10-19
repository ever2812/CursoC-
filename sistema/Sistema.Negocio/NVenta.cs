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
    public class NVenta
    {
        public static DataTable Listar()
        {
            DVenta Datos = new DVenta();
            return Datos.Listar();

        }

        public static DataTable Buscar(string valor)
        {
            DVenta Datos = new DVenta();
            return Datos.Buscar(valor);
        }

        public static DataTable ConsultaFechas(DateTime fecha_inicio, DateTime fecha_fin)
        {
            DVenta Datos = new DVenta();
            return Datos.ConsultaFechas(fecha_inicio,fecha_fin);
        }

        public static DataTable ListarDetalle(int idventa)
        {
            DVenta Datos = new DVenta();
            return Datos.ListarDetalle(idventa);
        }

        public static String Insertar(int idcliente, int idusuario, string tipo_comprobante, string serie_comprobante, string num_comprobante,decimal impuesto, decimal total, DataTable detalles)
        {
            DVenta Datos = new DVenta();
            Venta Obj = new Venta();

            Obj.IdCliente= idcliente;
            Obj.IdUsuario= idusuario;
            Obj.Tipocomprobante= tipo_comprobante;
            Obj.SerieComprobante= serie_comprobante;
            Obj.NumComprobante = num_comprobante;
            Obj.Impuesto= impuesto;
            Obj.Total=  total;
            Obj.Detalles= detalles;

            return Datos.Insertar(Obj);
          
        }

        public static string Anular(int id)
        {
            DVenta Datos = new DVenta();
            return Datos.Anular(id);
        }
    }
}
