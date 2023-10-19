using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public int Idusuario;
        public int Idrol;
        public string Nombre;
        public string Rol;
        public bool Estado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.MdiParent= this;
            frm.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frm = new frmArticulo();
            frm.MdiParent= this;
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRol frm = new frmRol();
            frm.MdiParent=this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.MdiParent=this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            stBarraInferior.Text= "Desarrolado por Ever López, Usuario: " + this.Nombre;
            MessageBox.Show("Bienvenido: " + this.Nombre, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Rol=="Administrador")
            {
                MnuAlmacen.Enabled= true;
                MnuIngresos.Enabled= true;
                MnuVentas.Enabled= true;
                MnuAccesos.Enabled= true;
                MnuConsultas.Enabled = true;
                tsCompras.Enabled= true;
                TsVentas.Enabled= true;
            }
            else
            {
                if (Rol=="Vendedor")
                {
                    MnuAlmacen.Enabled= false;
                    MnuIngresos.Enabled= false;
                    MnuVentas.Enabled= true;
                    MnuAccesos.Enabled= false;
                    MnuConsultas.Enabled = true;
                    tsCompras.Enabled= false;
                    TsVentas.Enabled= true;
                }
                else
                {
                    if (Rol=="Almacenista")
                    {
                        MnuAlmacen.Enabled= true;
                        MnuIngresos.Enabled= true;
                        MnuVentas.Enabled= false;
                        MnuAccesos.Enabled= false;
                        MnuConsultas.Enabled = true;
                        tsCompras.Enabled= true;
                        TsVentas.Enabled= false;
                    }
                    else {
                        MnuAlmacen.Enabled= false;
                        MnuIngresos.Enabled= false;
                        MnuVentas.Enabled= false;
                        MnuAccesos.Enabled= false;
                        MnuConsultas.Enabled = false;
                        tsCompras.Enabled= false;
                        TsVentas.Enabled= false;
                    }
                }
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void cerrar()
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del sistema?..", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcion==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.MdiParent=this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.MdiParent= this;
            frm.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngreso frm = new frmIngreso();
            frm.MdiParent=this;
            frm.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            frm.MdiParent=this;
            frm.Show();
        }

        private void consultaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta_VentaFechas frm = new FrmConsulta_VentaFechas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
