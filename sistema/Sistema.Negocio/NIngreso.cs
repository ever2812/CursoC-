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
    public class NIngreso
    {
        public static DataTable Listar()
        {
            DIngreso Datos = new DIngreso();
            return Datos.Listar();

        }

        public static DataTable Buscar(string valor)
        {
            DIngreso Datos = new DIngreso();
            return Datos.Buscar(valor);
        }

        public static DataTable ListarDetalle(int idingreso)
        {
            DIngreso Datos = new DIngreso();
            return Datos.ListarDetalle(idingreso);
        }

        public static String Insertar(int idproveedor, int idusuario, string tipo_comprobante, string serie_comprobante, string num_comprobante,decimal impuesto, decimal total, DataTable detalles)
        {
            DIngreso Datos = new DIngreso();

            Ingreso Obj = new Ingreso();

            Obj.IdProveedor= idproveedor;
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
            DIngreso Datos = new DIngreso();
            return Datos.Anular(id);
        }
    }
}
