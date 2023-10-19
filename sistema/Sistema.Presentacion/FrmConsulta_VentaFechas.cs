using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmConsulta_VentaFechas : Form
    {
        public FrmConsulta_VentaFechas()
        {
            InitializeComponent();
        }

        private void FrmConsulta_VentaFechas_Load(object sender, EventArgs e)
        {

        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NVenta.ConsultaFechas(Convert.ToDateTime(DtpFechaInicio.Value),Convert.ToDateTime(DtpFechafin.Value));
                Formato();
                Limpiar();
                LblTotal.Text = "Total de Registros : " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[6].HeaderText = "Serie";
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[7].HeaderText = "Número";
            DgvListado.Columns[8].Width = 60;
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[11].Width = 100;
        }

        private void Limpiar()
        {
           
            errorIcono.Clear();

            DgvListado.Columns[0].Visible = false;
        }


        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dgvMostrarDetalle.DataSource = NVenta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
                decimal Total, Subtotal;
                decimal impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                Subtotal = Total / (1 + impuesto);
                txtSubtotalD.Text = Subtotal.ToString("#0.00#");
                txtTotalImpuestoD.Text = (Total - Subtotal).ToString("#0.00#");
                txtTotalD.Text = Total.ToString("#0.00#");

                PanelMostrarDetalle.Visible = true;
             
            }

            catch (Exception ex)
            {

            }
        }

        private void BtnComprobante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nada");
            try
            {
                Variables.IdVenta = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);

                Reportes.FrmReporteComprobanteVenta reporte = new Reportes.FrmReporteComprobanteVenta();
                reporte.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCerarDetalle_Click(object sender, EventArgs e)
        {
            PanelMostrarDetalle.Visible = false;
        }
    }
}
