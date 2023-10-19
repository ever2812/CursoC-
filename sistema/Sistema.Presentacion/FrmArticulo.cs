using Sistema.Negocio;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class frmArticulo : Form
    {

        private string RutaOrigen;
        private string RutaDestino;
        private string Directorio = "C:\\Users\\Ever\\Documents\\cursoCS\\imgs\\";
        private string NombreAnt;
        

        public frmArticulo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource= NArticulo.Listar();
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
            DgvListado.Columns[2].Visible=false;
            DgvListado.Columns[0].Width=100;
            DgvListado.Columns[1].Width=60;
            DgvListado.Columns[3].Width=100;
            DgvListado.Columns[3].HeaderText="´Categoría";
            DgvListado.Columns[4].Width=100;
            DgvListado.Columns[4].HeaderText="Código";
            DgvListado.Columns[5].Width=150;
            DgvListado.Columns[6].Width=100;
            DgvListado.Columns[6].HeaderText="Precio Venta";
            DgvListado.Columns[7].Width=100;
            DgvListado.Columns[8].Width=200;           
            DgvListado.Columns[8].HeaderText="Descripción";
            DgvListado.Columns[9].Width=100;
            DgvListado.Columns[10].Width=80;
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtbuscar.Clear();
            txtNombre.Clear();
            txtCodigo.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            TxtImagen.Clear();
            PicImagen.Image=null;
            PanelCodigo.BackgroundImage=null;
            btnGuardarCodigo.Enabled=true;
            this.RutaDestino="";
            this.RutaOrigen="";

            txtDescripcion.Clear();
            btnInsertar.Visible=true;
            btnActualizar.Visible=false;
            errorIcono.Clear();


            DgvListado.Columns[0].Visible=false;
            btnActivar.Visible=false;
            btnDesactivar.Visible=false;
            btnEliminar.Visible=false;

            chKSeleccionar.Checked=false;
        }


        private void cargar_categoria() {

            try
            {
                CboCategoria.DataSource= NCategoria.Seleccionar();
                CboCategoria.ValueMember= "idcategoria";
                CboCategoria.DisplayMember="nombre";
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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
                DgvListado.DataSource= NArticulo.Buscar(txtbuscar.Text);
                label1.Text= "Total de Registros : " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            Listar();
            cargar_categoria();
          
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnCargarimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter= "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (file.ShowDialog()== DialogResult.OK)
            {
                PicImagen.Image= Image.FromFile(file.FileName);
                TxtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\")+1);
                this.RutaOrigen= file.FileName;
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();

            codigo.IncludeLabel= true;
            PanelCodigo.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text, Color.Black, Color.White);
            btnGuardarCodigo.Enabled=true;
        }

        private void btnGuardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgfinal = (Image)PanelCodigo.BackgroundImage.Clone();

            SaveFileDialog DialogoGuardar = new SaveFileDialog();
            DialogoGuardar.AddExtension=true;
            DialogoGuardar.Filter="Image PNG (*.png) | *.png";
            DialogoGuardar.ShowDialog();

            if (!string.IsNullOrEmpty(DialogoGuardar.FileName))
            {
                imgfinal.Save(DialogoGuardar.FileName, ImageFormat.Png);
            }
            imgfinal.Dispose();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (CboCategoria.Text==String.Empty ||   txtNombre.Text==string.Empty || txtPrecioVenta.Text ==String.Empty || txtStock.Text== String.Empty)
                {
                    MensajeError("Falta por ingresar algunos datos");
                    errorIcono.SetError(CboCategoria, "Seleccione una categoria");
                    errorIcono.SetError(txtNombre, "Ingrese el nombre");
                    errorIcono.SetError(txtPrecioVenta, "Ingrese el precio de venta");
                    errorIcono.SetError(txtStock, "Ingrese el Stock inicial");
                }
                else
                {
                  
                    rpta = NArticulo.Insertar(Convert.ToInt32(CboCategoria.SelectedValue), txtCodigo.Text.Trim(), txtNombre.Text.Trim(), Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToInt32(txtStock.Text), txtDescripcion.Text.Trim(), (TxtImagen.Text));
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("El registro fue insertado correctamente.");
                        if (TxtImagen.Text!="")
                        {
                            this.RutaDestino= TxtImagen.Text;
                            File.Copy(RutaOrigen, RutaDestino);
                        }
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
                txtId.Text= Convert.ToString(DgvListado.CurrentRow.Cells["id"].Value);
                CboCategoria.SelectedValue= Convert.ToString(DgvListado.CurrentRow.Cells["idcategoria"].Value);
                txtCodigo.Text= Convert.ToString(DgvListado.CurrentRow.Cells["codigo"].Value);
                NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["nombre"].Value);
                txtNombre.Text =Convert.ToString(DgvListado.CurrentRow.Cells["nombre"].Value);
                txtPrecioVenta.Text= Convert.ToString(DgvListado.CurrentRow.Cells["precio_venta"].Value);
                txtStock.Text= Convert.ToString(DgvListado.CurrentRow.Cells["stock"].Value);
                txtDescripcion.Text= Convert.ToString(DgvListado.CurrentRow.Cells["descripcion"].Value);
                string imagen = Convert.ToString(DgvListado.CurrentRow.Cells["imagen"].Value);

                if (imagen != string.Empty)
                {
                    PicImagen.Image= Image.FromFile(this.Directorio+imagen);
                    TxtImagen.Text= imagen;
                }
                else 
                {
                    PicImagen.Image=null;
                    TxtImagen.Text="";
                }
                TapGeneral.SelectedIndex=1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre " + " | Error " + ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (CboCategoria.Text==String.Empty ||   txtNombre.Text==string.Empty || txtPrecioVenta.Text ==String.Empty || txtStock.Text== String.Empty || txtId.Text==String.Empty)
                {
                    MensajeError("Falta por ingresar algunos datos");
                    errorIcono.SetError(CboCategoria, "Seleccione una categoria");
                    errorIcono.SetError(txtNombre, "Ingrese el nombre");
                    errorIcono.SetError(txtPrecioVenta, "Ingrese el precio de venta");
                    errorIcono.SetError(txtStock, "Ingrese el Stock inicial");
                }
                else
                {

                    rpta = NArticulo.Actualizar(Convert.ToInt32(txtId.Text), Convert.ToInt32(CboCategoria.SelectedValue), txtCodigo.Text.Trim(), NombreAnt, txtNombre.Text.Trim(), Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToInt32(txtStock.Text), txtDescripcion.Text.Trim(), (Directorio+TxtImagen.Text));
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("El registro fue actualizado correctamente.");
                        if (TxtImagen.Text!=String.Empty && RutaOrigen!=String.Empty)
                        {
                            this.RutaDestino= TxtImagen.Text;
                            File.Copy(RutaOrigen, RutaDestino);
                        }
                        Listar();
                        TapGeneral.SelectedIndex=0;
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
                    string imagen;

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                     
                            imagen = Convert.ToString(row.Cells[9].Value);

                            rpta= NArticulo.Eliminar(codigo);
                            
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se elmino el registro " + Convert.ToString(row.Cells[5].Value));
                                File.Delete(this.Directorio+imagen);
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
                            rpta= NArticulo.Desactivar(codigo);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se desactivo el registro " + Convert.ToString(row.Cells[5].Value));
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
                            //MessageBox.Show(codigo.ToString());
                            rpta= NArticulo.Activar(codigo);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se activo el registro " + Convert.ToString(row.Cells[5].Value));
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

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteArticulo rptart = new Reportes.FrmReporteArticulo();
            rptart.ShowDialog();
        }
    }
}
