using System;
using System.Data;
using System.Windows.Forms;
using Sistema.Negocio;


namespace Sistema.Presentacion
{
    public partial class FrmVenta : Form
    {

        private DataTable DtDetalle = new DataTable();

   

        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            Listar();
            CrearTabla();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource= NVenta.Listar();
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
                DgvListado.DataSource= NVenta.Buscar(txtbuscar.Text);
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
            DgvListado.Columns[1].Visible=false;
            DgvListado.Columns[2].Visible=false;
            DgvListado.Columns[0].Width=100;
            DgvListado.Columns[3].Width=150;
            DgvListado.Columns[4].Width=150;
            DgvListado.Columns[5].Width=100;
            DgvListado.Columns[5].HeaderText="Documento";
            DgvListado.Columns[6].Width=70;
            DgvListado.Columns[6].HeaderText="Serie";
            DgvListado.Columns[7].Width=70;
            DgvListado.Columns[7].HeaderText="Número";
            DgvListado.Columns[8].Width=60;
            DgvListado.Columns[9].Width=100;
            DgvListado.Columns[10].Width=100;
            DgvListado.Columns[11].Width=100;
        }

        private void FormatoArticulos()
        {

            dgvArticulos.Columns[1].Visible=false;
            dgvArticulos.Columns[2].Width=100;
            dgvArticulos.Columns[2].HeaderText="Categoría";
            dgvArticulos.Columns[3].Width=100;
            dgvArticulos.Columns[3].HeaderText="Código";
            dgvArticulos.Columns[4].Width=150;
            dgvArticulos.Columns[5].Width=100;
            dgvArticulos.Columns[5].HeaderText="Precio Venta";
            dgvArticulos.Columns[6].Width=70;
            dgvArticulos.Columns[7].Width=200;
            dgvArticulos.Columns[7].HeaderText="Descripción";
            dgvArticulos.Columns[8].Width=100;
        }

        private void formato_detalle_venta()
        {
            dgvMostrarDetalle.Columns[0].Width=50;
            dgvMostrarDetalle.Columns[1].Width=100;
            dgvMostrarDetalle.Columns[2].Width=200;
            dgvMostrarDetalle.Columns[3].Width=80;

            dgvMostrarDetalle.Columns[4].Width=80;
            dgvMostrarDetalle.Columns[5].Width=80;
            dgvMostrarDetalle.Columns[6].Width=80;
        }


        private void Limpiar()
        {
            txtId.Clear();
            txtbuscar.Clear();
            txtIdCliente.Clear();
            txtNombreCliente.Clear();
            txtSerieComprobante.Clear();
            txtNumComprobante.Clear();
            DtDetalle.Clear();
            txtSubtotal.Text="0.00";
            txtTotalImpuesto.Text="0.00";
            txtTotal.Text="0.00";


            errorIcono.Clear();

            DgvListado.Columns[0].Visible=false;
            btnAnular.Visible=false;
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

        private void CrearTabla()
        {
            this.DtDetalle.Columns.Add("idarticulo", Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("articulo", Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("stock", Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("cantidad", Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("descuento", Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", Type.GetType("System.Decimal"));

            dgvDetalle.DataSource= this.DtDetalle;

            dgvDetalle.Columns[0].Visible= false;
            dgvDetalle.Columns[1].HeaderText="CODIGO";
            dgvDetalle.Columns[1].Width=100;
            dgvDetalle.Columns[2].HeaderText="ARTICULO";
            dgvDetalle.Columns[2].Width=200;
            dgvDetalle.Columns[3].HeaderText="STOCK";
            dgvDetalle.Columns[3].Width=100;
            dgvDetalle.Columns[4].HeaderText="CANTIDAD";
            dgvDetalle.Columns[4].Width=100;
            dgvDetalle.Columns[5].HeaderText="PRECIO";
            dgvDetalle.Columns[5].Width=100;
            dgvDetalle.Columns[6].HeaderText="DESCUENTO";
            dgvDetalle.Columns[6].Width=100;
            dgvDetalle.Columns[7].HeaderText="IMPORTE";
            dgvDetalle.Columns[7].Width=100;

            dgvDetalle.Columns[1].ReadOnly= true;
            dgvDetalle.Columns[2].ReadOnly= true;
            dgvDetalle.Columns[3].ReadOnly= true;
            dgvDetalle.Columns[7].ReadOnly= true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmVista_ClienteVenta vista = new FrmVista_ClienteVenta();
            vista.ShowDialog();
            txtIdCliente.Text= Convert.ToString(Variables.idcliente);
            txtNombreCliente.Text= Variables.NombreCliente;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode== Keys.Enter)
                {
                    DataTable tabla = new DataTable();
                    tabla= NArticulo.BuscarCodigoVenta(txtCodigo.Text.Trim());
                    if (tabla.Rows.Count<=0)
                    {
                        MensajeError("No existe arcículo con ese código de barras o no hay stock disponible");
                    }
                    else
                    {
                        AgregarDetalle(Convert.ToInt32(tabla.Rows[0][0]), Convert.ToString(tabla.Rows[0][1]), Convert.ToString(tabla.Rows[0][2]), Convert.ToInt32(tabla.Rows[0][4]), Convert.ToDecimal(tabla.Rows[0][3]));
                        txtCodigo.Clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarDetalle(int idarticulo, string codigo, string nombre,int stock, decimal precio)
        {

            //se valida que no permita agregar el mismo articulo
            bool agregar = true;
            foreach (DataRow FilaTemp in DtDetalle.Rows)
            {
                if (Convert.ToInt32(FilaTemp["idarticulo"]) == idarticulo)
                {

                    agregar= false;
                    MensajeError("Este articulo ya ha sido agregado");

                    //esta linea aumenta la cantidad del articulo si se agrega mas de una vez
                    //FilaTemp["cantidad"]= Convert.ToInt32(FilaTemp["cantidad"]) + 1;
                }
            }
            if (agregar)
            {
                DataRow fila = DtDetalle.NewRow();
                fila["idarticulo"] = idarticulo;
                fila["codigo"] = codigo;
                fila["articulo"] = nombre;
                fila["stock"] = stock;
                fila["cantidad"] = 1;
                fila["precio"] = precio;
                fila["descuento"] =0;
                fila["importe"] = precio;
                this.DtDetalle.Rows.Add(fila);
                CalcularTotales();
            }
        }

       

        private void CalcularTotales()
        {
            decimal total = 0;
            decimal subtotal = 0;

            if (dgvDetalle.Rows.Count==0)
            {
                total=0;
            }
            else
            {
                foreach (DataRow FilaTemp in DtDetalle.Rows)
                {
                    total  = total +  Convert.ToDecimal(FilaTemp["importe"]);
                }
            }

            subtotal = total / (1 + Convert.ToDecimal(txtImpuesto.Text));
            txtTotal.Text= total.ToString("#0.00#");
            txtSubtotal.Text = subtotal.ToString("#0.00#");
            txtTotalImpuesto.Text= (total-subtotal).ToString("#0.00#");
        }

        private void btnVerArticulo_Click(object sender, EventArgs e)
        {
            PanelArticulos.Visible=true;
        }

        private void btnCerrarArticulos_Click(object sender, EventArgs e)
        {
            PanelArticulos.Visible=false;
        }

        private void btnFiltraArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                dgvArticulos.DataSource= NArticulo.Buscar(txtBuscarArticulos.Text);
                this.FormatoArticulos();
                LblTotalArticulos.Text = "Total de registros:  " + Convert.ToString(dgvArticulos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdArticulo;
            string codigo, nombre;
            decimal precio;
            int stock;

            IdArticulo= Convert.ToInt32(dgvArticulos.CurrentRow.Cells["ID"].Value);
            codigo = Convert.ToString(dgvArticulos.CurrentRow.Cells["Codigo"].Value);
            nombre = Convert.ToString(dgvArticulos.CurrentRow.Cells["Nombre"].Value);
            stock = Convert.ToInt32(dgvArticulos.CurrentRow.Cells["Stock"].Value);
            precio = Convert.ToDecimal(dgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);
           

            this.AgregarDetalle(IdArticulo, codigo, nombre, stock, precio);
        }

        private void dgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow fila = (DataRow)DtDetalle.Rows[e.RowIndex];

            string Articulo = Convert.ToString(fila["articulo"]);
            int cantidad = Convert.ToInt32(fila["cantidad"]);
            int stock = Convert.ToInt32(fila["stock"]);
            decimal Precio = Convert.ToDecimal(fila["precio"]);
            decimal descuento = Convert.ToInt32(fila["descuento"]);
            if (cantidad>stock)
            {
                cantidad = stock;
                MensajeError("La cantidad de venta del articulo " + Articulo + "No puede ser mayor que el stock");
                fila["cantidad"]=stock;
            }
            fila["importe"]= (Precio*cantidad) - descuento;
      
            this.CalcularTotales();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtIdCliente.Text==string.Empty || txtImpuesto.Text== string.Empty || txtNumComprobante.Text==string.Empty || DtDetalle.Rows.Count==0)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtNombreCliente, "Tiene que elegir un cliente");
                    errorIcono.SetError(txtImpuesto, "Revise el impuesto");
                    errorIcono.SetError(txtNumComprobante, "Debe ingresar el numero de comprobante");
                    errorIcono.SetError(dgvDetalle, "Deben haber articulos agredados");
                }
                else
                {
                    rpta = NVenta.Insertar(Convert.ToInt32(txtIdCliente.Text), Variables.Idusuario, cboComprobante.Text, txtSerieComprobante.Text.Trim(), txtNumComprobante.Text.Trim(), Convert.ToDecimal(txtImpuesto.Text), Convert.ToDecimal(txtTotal.Text), DtDetalle);
                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("La venta fue guardada correctamente.");
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

        private void dgvDetalle_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalcularTotales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TapGeneral.SelectedIndex=0;
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dgvMostrarDetalle.DataSource= NVenta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
                decimal Total, Subtotal;
                decimal impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                Subtotal = Total / (1 + impuesto);
                txtSubtotalD.Text = Subtotal.ToString("#0.00#");
                txtTotalImpuestoD.Text = (Total-Subtotal).ToString("#0.00#");
                txtTotalD.Text = Total.ToString("#0.00#");
                
                PanelMostrarDetalle.Visible=true;
                formato_detalle_venta();
            }

            catch (Exception ex)
            {

            }
        }

        private void BtnCerarDetalle_Click(object sender, EventArgs e)
        {
            PanelMostrarDetalle.Visible=false;
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
                btnAnular.Visible=true;
            }
            else
            {
                DgvListado.Columns[0].Visible=false;
                btnAnular.Visible=false;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas anular el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                            rpta= NVenta.Anular(codigo);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Anuló el registro " + Convert.ToString(row.Cells[6].Value) + " " + Convert.ToString(row.Cells[7].Value));
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

        private void BtnComprobante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nada");
            try 
            {
                Variables.IdVenta = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                
                Reportes.FrmReporteComprobanteVenta reporte = new Reportes.FrmReporteComprobanteVenta();
                reporte.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
