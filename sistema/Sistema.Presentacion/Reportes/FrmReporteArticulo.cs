using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Presentacion.Reportes.DsSistemaTableAdapters;
using Sistema.Presentacion.Reportes;
using System.Windows.Forms;

namespace Sistema.Presentacion.Reportes
{
    public partial class FrmReporteArticulo : Form
    {
        public FrmReporteArticulo()
        {
            InitializeComponent();
        }

        private void FrmRporteArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.articulo_listar' Puede moverla o quitarla según sea necesario.
            this.articulo_listarTableAdapter.Fill(this.dsSistema.articulo_listar);
         
               
            reportViewer1.RefreshReport();
        }
    }
}
