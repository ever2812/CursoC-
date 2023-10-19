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
    public partial class frmUsuario : Form
    {
        string EmailAnt;
        public frmUsuario()
        {
            InitializeComponent();
        }

        
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Listar();
            cargar_rol();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource= NUsuario.Listar();
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
                DgvListado.DataSource= NUsuario.Buscar(txtbuscar.Text);
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
            DgvListado.Columns[2].Visible=false;
            DgvListado.Columns[1].Width=50;
            DgvListado.Columns[3].Width=100;
            DgvListado.Columns[4].Width=170;
            DgvListado.Columns[5].Width=100;
            DgvListado.Columns[5].HeaderText="Documento";
            DgvListado.Columns[6].Width=100;
            DgvListado.Columns[6].HeaderText="Número doc";
            DgvListado.Columns[7].Width=120;
            DgvListado.Columns[7].HeaderText="Dirección";
            DgvListado.Columns[8].Width=100;
            DgvListado.Columns[8].HeaderText="Telefono";
            DgvListado.Columns[9].Width=120;

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
            txtClave.Clear();

            btnInsertar.Visible=true;
            btnActualizar.Visible=false;
            errorIcono.Clear();

            DgvListado.Columns[0].Visible=false;
            btnActivar.Visible=false;
            btnDesactivar.Visible=false;
            btnEliminar.Visible=false;

            chKSeleccionar.Checked=false;
        }

        private void cargar_rol()
        {
            cboRol.DataSource= NRol.Listar();
            cboRol.ValueMember="idrol";
            cboRol.DisplayMember="nombre";
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
            this.Buscar();
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (cboRol.Text==String.Empty  || txtNombre.Text==string.Empty || txtEmail.Text==String.Empty || txtClave.Text==String.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(cboRol, "Debe elegir un rol");
                    errorIcono.SetError(txtNombre, "Debe escribir el nombre");
                    errorIcono.SetError(txtEmail, "Debe escribir el email");
                    errorIcono.SetError(txtClave, "Se debe escribir la clave");
                }
                else
                {
                    rpta = NUsuario.Insertar(Convert.ToInt32(cboRol.SelectedValue),txtNombre.Text.Trim(), cboTipoDocumento.Text, txtNumDocumento.Text.Trim(),txtDireccion.Text,txtTelefono.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("El registro fue insertado correctamente.");
                       // Limpiar();
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
                cboRol.SelectedValue= Convert.ToString(DgvListado.CurrentRow.Cells["idrol"].Value);
                txtNombre.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                cboTipoDocumento.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Tipo_Documento"].Value);
                txtNumDocumento.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Num_Documento"].Value);
                txtDireccion.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                txtTelefono.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                txtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                this.EmailAnt=Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                TapGeneral.SelectedIndex=1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre | Error " + ex.Message);
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
            else
            {
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
                           
                            rpta= NUsuario.Eliminar(codigo);
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
                          
                            rpta= NUsuario.Activar(codigo);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se activo el registro " + Convert.ToString(row.Cells[4].Value));
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
                        
                            rpta= NUsuario.Desactivar(codigo);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se desactivo el registro " + Convert.ToString(row.Cells[4].Value));
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtId.Text==string.Empty || cboRol.Text==String.Empty  || txtNombre.Text==string.Empty || txtEmail.Text==String.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(cboRol, "Debe elegir un rol");
                    errorIcono.SetError(txtNombre, "Debe escribir el nombre");
                    errorIcono.SetError(txtEmail, "Debe escribir el email");
                    errorIcono.SetError(txtClave, "Se debe escribir la clave");
                }
                else
                {
                    rpta = NUsuario.Actualizar(Convert.ToInt32(txtId.Text), Convert.ToInt32(cboRol.SelectedValue), txtNombre.Text.Trim(), cboTipoDocumento.Text, txtNumDocumento.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), this.EmailAnt, txtEmail.Text.Trim(), txtClave.Text);
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("Se actualizo de manera correcta");
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
    }
}
