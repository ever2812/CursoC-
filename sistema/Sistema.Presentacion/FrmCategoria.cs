using System.Windows.Forms;
using System;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmCategoria : Form
    {

      
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private string nombreAnt;
        
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Listar(); 
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource= NCategoria.Listar();
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
            DgvListado.Columns[0].Visible=false;
            DgvListado.Columns[1].Visible=false;
            DgvListado.Columns[2].Width=150;
            DgvListado.Columns[3].Width=400;
            DgvListado.Columns[3].HeaderText="Descripción";
            DgvListado.Columns[4].Width=100;
        }

        private void Limpiar()
        {
            txtId.Text="";
            txtbuscar.Text="";
            txtNombre.Text="";
            txtDescripcion.Text="";
            btnInsertar.Visible=true;
            btnActualizar.Visible=false;
            errorIcono.Clear();

            DgvListado.Columns[0].Visible=false;
            btnActivar.Visible=false;
            btnDesactivar.Visible=false;
            btnEliminar.Visible=false;

            chKSeleccionar.Checked=false;
        }

     
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Buscar() 
        {
            try
            {
                DgvListado.DataSource= NCategoria.Buscar(txtbuscar.Text);
                label1.Text= "Total de Registros : " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtNombre.Text==string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtNombre, "Ingrese su nombre");
                }
                else
                {
                    rpta = NCategoria.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("El registro fue insertado correctamente.");
                        Limpiar();
                        Listar();
                    }
                    else
                    {
                        MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TapGeneral.SelectedIndex=0;
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtNombre.Text==string.Empty || txtId.Text==String.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtNombre, "Ingrese su nombre");
                }
                else
                {
                    rpta = NCategoria.Actualizar(Convert.ToInt16(txtId.Text),this.nombreAnt, txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("El registro fue actualizado correctamente.");
                        Limpiar();
                        Listar();
                    }
                    else
                    {
                        MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }


        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                this.Limpiar();
                btnActualizar.Visible=true;
                btnInsertar.Visible=false;

                txtId.Text= Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                this.nombreAnt=Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtNombre.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtDescripcion.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                TapGeneral.SelectedIndex=1;

            }
            catch {
                MessageBox.Show("Seleccione desde la celda Nombre");
            }
          
        }

        private void chKSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chKSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible=true;
                btnActivar.Visible=true;
                btnDesactivar.Visible=true;
                btnEliminar.Visible=true;
            }
            else {
                DgvListado.Columns[0].Visible=false;
                btnActivar.Visible=false;
                btnDesactivar.Visible=false;
                btnEliminar.Visible=false;
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==DgvListado.Columns["Seleccionar"].Index) 
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkeliminar.Value= !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            //MessageBox.Show(codigo.ToString());
                            rpta= NCategoria.Eliminar(codigo);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se elmino el registro " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Listar();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas activar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            //MessageBox.Show(codigo.ToString());
                            rpta= NCategoria.Activar(codigo);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se activo el registro " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Listar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas desactivar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                           // MessageBox.Show(codigo.ToString());
                            rpta= NCategoria.Desactivar(codigo);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se desactivo el registro " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Listar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
