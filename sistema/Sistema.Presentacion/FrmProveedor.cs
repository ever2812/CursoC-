using System;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class frmProveedor : Form
    {

        private string NombreAnt;
      

        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource= NPersona.ListarProveedores();
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

        private void Limpiar()
        {
            txtId.Clear();
            txtbuscar.Clear();
            txtNombre.Clear();
            txtNumDocumento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        
            btnInsertar.Visible=true;
            btnActualizar.Visible=false;
            errorIcono.Clear();

            DgvListado.Columns[0].Visible=false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if ( txtNombre.Text==string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtNombre, "Debe escribir el nombre");
                    errorIcono.SetError(txtEmail, "Debe escribir el email");
                }
                else
                {
                    rpta = NPersona.Insertar("Proveedor",txtNombre.Text.Trim(), cboTipoDocumento.Text, txtNumDocumento.Text.Trim(), txtDireccion.Text, txtTelefono.Text.Trim(), txtEmail.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("El registro fue insertado correctamente.");
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
                NombreAnt= Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtNombre.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                cboTipoDocumento.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Tipo_Documento"].Value);
                txtNumDocumento.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Num_Documento"].Value);
                txtDireccion.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                txtTelefono.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                txtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                TapGeneral.SelectedIndex=1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre | Error " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtId.Text==string.Empty  || txtNombre.Text==string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtNombre, "Debe escribir el nombre");
                }
                else
                {
                    rpta = NPersona.Actualizar(Convert.ToInt32(txtId.Text),"Proveedor", this.NombreAnt, txtNombre.Text.Trim(), cboTipoDocumento.Text, txtNumDocumento.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEmail.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("Se actualizo de forma correcta el resgistro");
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
            Limpiar();
            TapGeneral.SelectedIndex=0;
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

                            rpta= NPersona.Eliminar(codigo);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se elmino el registro " + Convert.ToString(row.Cells[3].Value));
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

      

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkeliminar.Value= !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void chKSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chKSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible=true;
                btnEliminar.Visible=true;
            }
            else
            {
                DgvListado.Columns[0].Visible=false;
                btnEliminar.Visible=false;
            }
        }
    }
}
