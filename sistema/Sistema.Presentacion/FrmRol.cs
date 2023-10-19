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
    public partial class frmRol : Form
    {
        public frmRol()
        {
            InitializeComponent();
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource= NRol.Listar();
                Formato();
                this.Limpiar();
                label1.Text= "Total de Registros : " + Convert.ToString(DgvListado.Rows.Count);
                TapGeneral.SelectedIndex=0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Width=100;
            DgvListado.Columns[0].HeaderText="ID";
            DgvListado.Columns[1].Width=200;
            DgvListado.Columns[1].HeaderText="Nombre";


        }

        private void Limpiar()
        { 
            
        }
    }
}
