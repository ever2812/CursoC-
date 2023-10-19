using Sistema.Negocio;
using System;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmVista_Proveedoringreso : Form
    {
        public FrmVista_Proveedoringreso()
        {
            InitializeComponent();
        }

        private void FrmVista_Proveedoringreso_Load(object sender, EventArgs e)
        {
         // Listar();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource= NPersona.ListarProveedores();
                Formato();
                label1.Text= "Total de Registros : " + Convert.ToString(DgvListado.Rows.Count);
                TapGeneral.SelectedIndex=0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource= NPersona.BuscarProveedores(txtbuscar.Text);
                label1.Text= "Total de Registros : " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible=false;
            DgvListado.Columns[1].Width=50;
            DgvListado.Columns[2].Width=120;
            DgvListado.Columns[2].HeaderText="Tipo Persona";
            DgvListado.Columns[3].Width=180;
            DgvListado.Columns[4].Width=120;
            DgvListado.Columns[4].HeaderText="Documento";
            DgvListado.Columns[5].Width=140;
            DgvListado.Columns[5].HeaderText="Número Doc";
            DgvListado.Columns[6].Width=130;
            DgvListado.Columns[6].HeaderText="Dirección";
            DgvListado.Columns[7].Width=120;
            DgvListado.Columns[7].HeaderText="Teléfono";
            DgvListado.Columns[8].Width=120;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdProveedor= Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
            Variables.NombreProveedor = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
            this.Close();
        }

        
    }
}
