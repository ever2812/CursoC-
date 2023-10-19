using System.Windows.Forms;
namespace Sistema.Presentacion
{
    partial class frmArticulo
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.btnGuardarCodigo = new System.Windows.Forms.Button();
            this.btnGenerarCodigo = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCargarimagen = new System.Windows.Forms.Button();
            this.PicImagen = new System.Windows.Forms.PictureBox();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.chKSeleccionar = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TapGeneral = new System.Windows.Forms.TabControl();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.TapGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(159, 395);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "(*) INDICA QUE EL DATO ES OBLIGATORIO";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(159, 395);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(151, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(338, 395);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(327, 25);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 22);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(596, 310);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(401, 81);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(316, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtStock);
            this.tabPage2.Controls.Add(this.txtPrecioVenta);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.PanelCodigo);
            this.tabPage2.Controls.Add(this.btnGuardarCodigo);
            this.tabPage2.Controls.Add(this.btnGenerarCodigo);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.BtnCargarimagen);
            this.tabPage2.Controls.Add(this.PicImagen);
            this.tabPage2.Controls.Add(this.TxtImagen);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CboCategoria);
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnInsertar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1043, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(159, 310);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(151, 22);
            this.txtStock.TabIndex = 23;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(159, 272);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(151, 22);
            this.txtPrecioVenta.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Stock(*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Precio de Venta(*)";
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.Location = new System.Drawing.Point(159, 175);
            this.PanelCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(316, 80);
            this.PanelCodigo.TabIndex = 19;
            // 
            // btnGuardarCodigo
            // 
            this.btnGuardarCodigo.Enabled = false;
            this.btnGuardarCodigo.Location = new System.Drawing.Point(353, 147);
            this.btnGuardarCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarCodigo.Name = "btnGuardarCodigo";
            this.btnGuardarCodigo.Size = new System.Drawing.Size(125, 23);
            this.btnGuardarCodigo.TabIndex = 18;
            this.btnGuardarCodigo.Text = "Guardar codigo";
            this.btnGuardarCodigo.UseVisualStyleBackColor = true;
            this.btnGuardarCodigo.Click += new System.EventHandler(this.btnGuardarCodigo_Click);
            // 
            // btnGenerarCodigo
            // 
            this.btnGenerarCodigo.Location = new System.Drawing.Point(215, 147);
            this.btnGenerarCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarCodigo.Name = "btnGenerarCodigo";
            this.btnGenerarCodigo.Size = new System.Drawing.Size(132, 23);
            this.btnGenerarCodigo.TabIndex = 17;
            this.btnGenerarCodigo.Text = "Generar codigo";
            this.btnGenerarCodigo.UseVisualStyleBackColor = true;
            this.btnGenerarCodigo.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(159, 121);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(319, 22);
            this.txtCodigo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Codigo";
            // 
            // BtnCargarimagen
            // 
            this.BtnCargarimagen.Location = new System.Drawing.Point(883, 57);
            this.BtnCargarimagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCargarimagen.Name = "BtnCargarimagen";
            this.BtnCargarimagen.Size = new System.Drawing.Size(114, 23);
            this.BtnCargarimagen.TabIndex = 14;
            this.BtnCargarimagen.Text = "...";
            this.BtnCargarimagen.UseVisualStyleBackColor = true;
            this.BtnCargarimagen.Click += new System.EventHandler(this.BtnCargarimagen_Click);
            // 
            // PicImagen
            // 
            this.PicImagen.Location = new System.Drawing.Point(596, 90);
            this.PicImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicImagen.Name = "PicImagen";
            this.PicImagen.Size = new System.Drawing.Size(401, 193);
            this.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagen.TabIndex = 13;
            this.PicImagen.TabStop = false;
            // 
            // TxtImagen
            // 
            this.TxtImagen.Enabled = false;
            this.TxtImagen.Location = new System.Drawing.Point(596, 57);
            this.TxtImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(269, 22);
            this.TxtImagen.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Imagen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria :";
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(159, 54);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(316, 24);
            this.CboCategoria.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre (*)";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(380, 441);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(257, 441);
            this.btnDesactivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(94, 23);
            this.btnDesactivar.TabIndex = 6;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(131, 441);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(94, 23);
            this.btnActivar.TabIndex = 5;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // chKSeleccionar
            // 
            this.chKSeleccionar.AutoSize = true;
            this.chKSeleccionar.Location = new System.Drawing.Point(6, 443);
            this.chKSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chKSeleccionar.Name = "chKSeleccionar";
            this.chKSeleccionar.Size = new System.Drawing.Size(104, 21);
            this.chKSeleccionar.TabIndex = 4;
            this.chKSeleccionar.Text = "Seleccionar";
            this.chKSeleccionar.UseVisualStyleBackColor = true;
            this.chKSeleccionar.CheckedChanged += new System.EventHandler(this.chKSeleccionar_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(380, 14);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(6, 14);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(368, 22);
            this.txtbuscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(884, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
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
            this.DgvListado.Location = new System.Drawing.Point(6, 40);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 29;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(987, 378);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnReporte);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnDesactivar);
            this.tabPage1.Controls.Add(this.btnActivar);
            this.tabPage1.Controls.Add(this.chKSeleccionar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1043, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TapGeneral
            // 
            this.TapGeneral.Controls.Add(this.tabPage1);
            this.TapGeneral.Controls.Add(this.tabPage2);
            this.TapGeneral.Location = new System.Drawing.Point(12, 10);
            this.TapGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TapGeneral.Name = "TapGeneral";
            this.TapGeneral.SelectedIndex = 0;
            this.TapGeneral.Size = new System.Drawing.Size(1051, 513);
            this.TapGeneral.TabIndex = 1;
            // 
            // BtnReporte
            // 
            this.BtnReporte.Location = new System.Drawing.Point(529, 14);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(94, 23);
            this.BtnReporte.TabIndex = 8;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 532);
            this.Controls.Add(this.TapGeneral);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmArticulo";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TapGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ErrorProvider errorIcono;
        private TabControl TapGeneral;
        private TabPage tabPage1;
        private Button btnEliminar;
        private Button btnDesactivar;
        private Button btnActivar;
        private CheckBox chKSeleccionar;
        private Button btnBuscar;
        private TextBox txtbuscar;
        private Label label1;
        private DataGridView DgvListado;
        private DataGridViewCheckBoxColumn Seleccionar;
        private TabPage tabPage2;
        private Button btnActualizar;
        private Label label4;
        private Button btnInsertar;
        private Button btnCancelar;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label5;
        private ComboBox CboCategoria;
        private Button BtnCargarimagen;
        private PictureBox PicImagen;
        private TextBox TxtImagen;
        private Label label6;
        private Button btnGuardarCodigo;
        private Button btnGenerarCodigo;
        private TextBox txtCodigo;
        private Label label7;
        private Panel PanelCodigo;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private Label label9;
        private Label label8;
        private Button BtnReporte;
    }
}