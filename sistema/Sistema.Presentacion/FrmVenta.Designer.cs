using System.Windows.Forms;
namespace Sistema.Presentacion
{
    partial class FrmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.dgvMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelMostrarDetalle = new System.Windows.Forms.Panel();
            this.txtTotalD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalImpuestoD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSubtotalD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnCerarDetalle = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.chKSeleccionar = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboComprobante = new System.Windows.Forms.ComboBox();
            this.txtSerieComprobante = new System.Windows.Forms.TextBox();
            this.txtNumComprobante = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.TapGeneral = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelArticulos = new System.Windows.Forms.Panel();
            this.LblTotalArticulos = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnCerrarArticulos = new System.Windows.Forms.Button();
            this.btnFiltraArticulos = new System.Windows.Forms.Button();
            this.txtBuscarArticulos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalImpuesto = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnVerArticulo = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnComprobante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalle)).BeginInit();
            this.PanelMostrarDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TapGeneral.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PanelArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Artículo:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(765, 32);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(114, 26);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(854, 105);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(98, 26);
            this.txtImpuesto.TabIndex = 17;
            this.txtImpuesto.Text = "0.16";
            // 
            // dgvMostrarDetalle
            // 
            this.dgvMostrarDetalle.AllowUserToAddRows = false;
            this.dgvMostrarDetalle.AllowUserToDeleteRows = false;
            this.dgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDetalle.Location = new System.Drawing.Point(14, 55);
            this.dgvMostrarDetalle.Name = "dgvMostrarDetalle";
            this.dgvMostrarDetalle.ReadOnly = true;
            this.dgvMostrarDetalle.RowHeadersWidth = 51;
            this.dgvMostrarDetalle.RowTemplate.Height = 29;
            this.dgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarDetalle.Size = new System.Drawing.Size(757, 220);
            this.dgvMostrarDetalle.TabIndex = 0;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // PanelMostrarDetalle
            // 
            this.PanelMostrarDetalle.BackColor = System.Drawing.Color.Khaki;
            this.PanelMostrarDetalle.Controls.Add(this.txtTotalD);
            this.PanelMostrarDetalle.Controls.Add(this.label15);
            this.PanelMostrarDetalle.Controls.Add(this.txtTotalImpuestoD);
            this.PanelMostrarDetalle.Controls.Add(this.label14);
            this.PanelMostrarDetalle.Controls.Add(this.txtSubtotalD);
            this.PanelMostrarDetalle.Controls.Add(this.label13);
            this.PanelMostrarDetalle.Controls.Add(this.BtnCerarDetalle);
            this.PanelMostrarDetalle.Controls.Add(this.dgvMostrarDetalle);
            this.PanelMostrarDetalle.Location = new System.Drawing.Point(371, 164);
            this.PanelMostrarDetalle.Name = "PanelMostrarDetalle";
            this.PanelMostrarDetalle.Size = new System.Drawing.Size(791, 374);
            this.PanelMostrarDetalle.TabIndex = 7;
            this.PanelMostrarDetalle.Visible = false;
            // 
            // txtTotalD
            // 
            this.txtTotalD.Enabled = false;
            this.txtTotalD.Location = new System.Drawing.Point(646, 345);
            this.txtTotalD.Name = "txtTotalD";
            this.txtTotalD.Size = new System.Drawing.Size(125, 26);
            this.txtTotalD.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(579, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Total";
            // 
            // txtTotalImpuestoD
            // 
            this.txtTotalImpuestoD.Enabled = false;
            this.txtTotalImpuestoD.Location = new System.Drawing.Point(646, 313);
            this.txtTotalImpuestoD.Name = "txtTotalImpuestoD";
            this.txtTotalImpuestoD.Size = new System.Drawing.Size(125, 26);
            this.txtTotalImpuestoD.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(507, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Total Impuesto";
            // 
            // txtSubtotalD
            // 
            this.txtSubtotalD.Enabled = false;
            this.txtSubtotalD.Location = new System.Drawing.Point(646, 281);
            this.txtSubtotalD.Name = "txtSubtotalD";
            this.txtSubtotalD.Size = new System.Drawing.Size(125, 26);
            this.txtSubtotalD.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Subtotal";
            // 
            // BtnCerarDetalle
            // 
            this.BtnCerarDetalle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnCerarDetalle.ForeColor = System.Drawing.Color.Red;
            this.BtnCerarDetalle.Location = new System.Drawing.Point(752, 3);
            this.BtnCerarDetalle.Name = "BtnCerarDetalle";
            this.BtnCerarDetalle.Size = new System.Drawing.Size(36, 28);
            this.BtnCerarDetalle.TabIndex = 1;
            this.BtnCerarDetalle.Text = "X";
            this.BtnCerarDetalle.UseVisualStyleBackColor = true;
            this.BtnCerarDetalle.Click += new System.EventHandler(this.BtnCerarDetalle_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(247, 392);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(94, 29);
            this.btnAnular.TabIndex = 6;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // chKSeleccionar
            // 
            this.chKSeleccionar.AutoSize = true;
            this.chKSeleccionar.Location = new System.Drawing.Point(12, 398);
            this.chKSeleccionar.Name = "chKSeleccionar";
            this.chKSeleccionar.Size = new System.Drawing.Size(118, 24);
            this.chKSeleccionar.TabIndex = 4;
            this.chKSeleccionar.Text = "Seleccionar";
            this.chKSeleccionar.UseVisualStyleBackColor = true;
            this.chKSeleccionar.CheckedChanged += new System.EventHandler(this.chKSeleccionar_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(380, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(6, 17);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(368, 26);
            this.txtbuscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(6, 50);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 29;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1156, 321);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnComprobante);
            this.tabPage1.Controls.Add(this.PanelMostrarDetalle);
            this.tabPage1.Controls.Add(this.btnAnular);
            this.tabPage1.Controls.Add(this.chKSeleccionar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1188, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtImpuesto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboComprobante);
            this.groupBox1.Controls.Add(this.txtSerieComprobante);
            this.groupBox1.Controls.Add(this.txtNumComprobante);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 149);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Impuesto(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Serie";
            // 
            // cboComprobante
            // 
            this.cboComprobante.FormattingEnabled = true;
            this.cboComprobante.Items.AddRange(new object[] {
            "Factura",
            "Boleta",
            "Ticket",
            "Guia"});
            this.cboComprobante.Location = new System.Drawing.Point(142, 105);
            this.cboComprobante.Name = "cboComprobante";
            this.cboComprobante.Size = new System.Drawing.Size(217, 28);
            this.cboComprobante.TabIndex = 9;
            this.cboComprobante.Text = "Factura";
            // 
            // txtSerieComprobante
            // 
            this.txtSerieComprobante.Location = new System.Drawing.Point(363, 107);
            this.txtSerieComprobante.Name = "txtSerieComprobante";
            this.txtSerieComprobante.Size = new System.Drawing.Size(162, 26);
            this.txtSerieComprobante.TabIndex = 13;
            // 
            // txtNumComprobante
            // 
            this.txtNumComprobante.Location = new System.Drawing.Point(556, 107);
            this.txtNumComprobante.Name = "txtNumComprobante";
            this.txtNumComprobante.Size = new System.Drawing.Size(162, 26);
            this.txtNumComprobante.TabIndex = 12;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(362, 35);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(392, 26);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(126, 35);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(217, 26);
            this.txtIdCliente.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Comprobante(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cliente";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(901, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(51, 26);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // TapGeneral
            // 
            this.TapGeneral.Controls.Add(this.tabPage1);
            this.TapGeneral.Controls.Add(this.tabPage2);
            this.TapGeneral.Location = new System.Drawing.Point(12, 12);
            this.TapGeneral.Name = "TapGeneral";
            this.TapGeneral.SelectedIndex = 0;
            this.TapGeneral.Size = new System.Drawing.Size(1196, 649);
            this.TapGeneral.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelArticulos);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnInsertar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1188, 616);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelArticulos
            // 
            this.PanelArticulos.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelArticulos.Controls.Add(this.LblTotalArticulos);
            this.PanelArticulos.Controls.Add(this.dgvArticulos);
            this.PanelArticulos.Controls.Add(this.btnCerrarArticulos);
            this.PanelArticulos.Controls.Add(this.btnFiltraArticulos);
            this.PanelArticulos.Controls.Add(this.txtBuscarArticulos);
            this.PanelArticulos.Controls.Add(this.label12);
            this.PanelArticulos.Location = new System.Drawing.Point(111, 161);
            this.PanelArticulos.Name = "PanelArticulos";
            this.PanelArticulos.Size = new System.Drawing.Size(847, 393);
            this.PanelArticulos.TabIndex = 10;
            this.PanelArticulos.Visible = false;
            // 
            // LblTotalArticulos
            // 
            this.LblTotalArticulos.AutoSize = true;
            this.LblTotalArticulos.Location = new System.Drawing.Point(660, 366);
            this.LblTotalArticulos.Name = "LblTotalArticulos";
            this.LblTotalArticulos.Size = new System.Drawing.Size(42, 20);
            this.LblTotalArticulos.TabIndex = 5;
            this.LblTotalArticulos.Text = "Total";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToOrderColumns = true;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(19, 47);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 29;
            this.dgvArticulos.Size = new System.Drawing.Size(784, 313);
            this.dgvArticulos.TabIndex = 4;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            // 
            // btnCerrarArticulos
            // 
            this.btnCerrarArticulos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCerrarArticulos.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarArticulos.Location = new System.Drawing.Point(806, 3);
            this.btnCerrarArticulos.Name = "btnCerrarArticulos";
            this.btnCerrarArticulos.Size = new System.Drawing.Size(29, 29);
            this.btnCerrarArticulos.TabIndex = 3;
            this.btnCerrarArticulos.Text = "X";
            this.btnCerrarArticulos.UseVisualStyleBackColor = true;
            this.btnCerrarArticulos.Click += new System.EventHandler(this.btnCerrarArticulos_Click);
            // 
            // btnFiltraArticulos
            // 
            this.btnFiltraArticulos.Location = new System.Drawing.Point(576, 14);
            this.btnFiltraArticulos.Name = "btnFiltraArticulos";
            this.btnFiltraArticulos.Size = new System.Drawing.Size(94, 29);
            this.btnFiltraArticulos.TabIndex = 2;
            this.btnFiltraArticulos.Text = "Buscar";
            this.btnFiltraArticulos.UseVisualStyleBackColor = true;
            this.btnFiltraArticulos.Click += new System.EventHandler(this.btnFiltraArticulos_Click);
            // 
            // txtBuscarArticulos
            // 
            this.txtBuscarArticulos.Location = new System.Drawing.Point(96, 15);
            this.txtBuscarArticulos.Name = "txtBuscarArticulos";
            this.txtBuscarArticulos.Size = new System.Drawing.Size(470, 26);
            this.txtBuscarArticulos.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Buscar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtTotalImpuesto);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvDetalle);
            this.groupBox2.Controls.Add(this.btnVerArticulo);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 375);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(865, 342);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(98, 26);
            this.txtTotal.TabIndex = 25;
            // 
            // txtTotalImpuesto
            // 
            this.txtTotalImpuesto.Enabled = false;
            this.txtTotalImpuesto.Location = new System.Drawing.Point(865, 310);
            this.txtTotalImpuesto.Name = "txtTotalImpuesto";
            this.txtTotalImpuesto.Size = new System.Drawing.Size(98, 26);
            this.txtTotalImpuesto.TabIndex = 24;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(865, 278);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(98, 26);
            this.txtSubtotal.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(788, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(724, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total Impuesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(765, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sub-Total";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(6, 73);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 29;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(957, 188);
            this.dgvDetalle.TabIndex = 20;
            this.dgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellEndEdit);
            this.dgvDetalle.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDetalle_UserDeletedRow);
            // 
            // btnVerArticulo
            // 
            this.btnVerArticulo.Location = new System.Drawing.Point(849, 41);
            this.btnVerArticulo.Name = "btnVerArticulo";
            this.btnVerArticulo.Size = new System.Drawing.Size(114, 26);
            this.btnVerArticulo.TabIndex = 18;
            this.btnVerArticulo.Text = "Ver";
            this.btnVerArticulo.UseVisualStyleBackColor = true;
            this.btnVerArticulo.Click += new System.EventHandler(this.btnVerArticulo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(746, 26);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "(*) INDICA QUE EL DATO ES OBLIGATORIO";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(64, 581);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(151, 29);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 581);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // BtnComprobante
            // 
            this.BtnComprobante.Location = new System.Drawing.Point(491, 17);
            this.BtnComprobante.Name = "BtnComprobante";
            this.BtnComprobante.Size = new System.Drawing.Size(127, 29);
            this.BtnComprobante.TabIndex = 8;
            this.BtnComprobante.Text = "Comprobante";
            this.BtnComprobante.UseVisualStyleBackColor = true;
            this.BtnComprobante.Click += new System.EventHandler(this.BtnComprobante_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 662);
            this.Controls.Add(this.TapGeneral);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Name = "FrmVenta";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalle)).EndInit();
            this.PanelMostrarDetalle.ResumeLayout(false);
            this.PanelMostrarDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TapGeneral.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.PanelArticulos.ResumeLayout(false);
            this.PanelArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label8;
        private Button btnBuscarCliente;
        private TextBox txtImpuesto;
        private DataGridView dgvMostrarDetalle;
        private DataGridViewCheckBoxColumn Seleccionar;
        private Panel PanelMostrarDetalle;
        private TextBox txtTotalD;
        private Label label15;
        private TextBox txtTotalImpuestoD;
        private Label label14;
        private TextBox txtSubtotalD;
        private Label label13;
        private Button BtnCerarDetalle;
        private Button btnAnular;
        private CheckBox chKSeleccionar;
        private Button btnBuscar;
        private TextBox txtbuscar;
        private Label label1;
        private DataGridView DgvListado;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cboComprobante;
        private TextBox txtSerieComprobante;
        private TextBox txtNumComprobante;
        private TextBox txtNombreCliente;
        private TextBox txtIdCliente;
        private Label label3;
        private Label label2;
        private TextBox txtId;
        private TabControl TapGeneral;
        private TabPage tabPage2;
        private Panel PanelArticulos;
        private Label LblTotalArticulos;
        private DataGridView dgvArticulos;
        private Button btnCerrarArticulos;
        private Button btnFiltraArticulos;
        private TextBox txtBuscarArticulos;
        private Label label12;
        private GroupBox groupBox2;
        private TextBox txtTotal;
        private TextBox txtTotalImpuesto;
        private TextBox txtSubtotal;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridView dgvDetalle;
        private Button btnVerArticulo;
        private TextBox txtCodigo;
        private Label label4;
        private Button btnInsertar;
        private Button btnCancelar;
        private ErrorProvider errorIcono;
        private Button BtnComprobante;
    }
}