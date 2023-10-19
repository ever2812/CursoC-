
namespace Sistema.Presentacion
{
    partial class FrmConsulta_VentaFechas
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
            this.TapGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnComprobante = new System.Windows.Forms.Button();
            this.PanelMostrarDetalle = new System.Windows.Forms.Panel();
            this.txtTotalD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalImpuestoD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSubtotalD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnCerarDetalle = new System.Windows.Forms.Button();
            this.dgvMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFechafin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TapGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelMostrarDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TapGeneral
            // 
            this.TapGeneral.Controls.Add(this.tabPage1);
            this.TapGeneral.Location = new System.Drawing.Point(12, 12);
            this.TapGeneral.Name = "TapGeneral";
            this.TapGeneral.SelectedIndex = 0;
            this.TapGeneral.Size = new System.Drawing.Size(1196, 543);
            this.TapGeneral.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DtpFechafin);
            this.tabPage1.Controls.Add(this.DtpFechaInicio);
            this.tabPage1.Controls.Add(this.BtnComprobante);
            this.tabPage1.Controls.Add(this.PanelMostrarDetalle);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1188, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnComprobante
            // 
            this.BtnComprobante.Location = new System.Drawing.Point(1017, 9);
            this.BtnComprobante.Name = "BtnComprobante";
            this.BtnComprobante.Size = new System.Drawing.Size(127, 29);
            this.BtnComprobante.TabIndex = 8;
            this.BtnComprobante.Text = "Comprobante";
            this.BtnComprobante.UseVisualStyleBackColor = true;
            this.BtnComprobante.Click += new System.EventHandler(this.BtnComprobante_Click);
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
            this.PanelMostrarDetalle.Location = new System.Drawing.Point(371, 131);
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
            this.txtTotalD.Size = new System.Drawing.Size(125, 22);
            this.txtTotalD.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(579, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Total";
            // 
            // txtTotalImpuestoD
            // 
            this.txtTotalImpuestoD.Enabled = false;
            this.txtTotalImpuestoD.Location = new System.Drawing.Point(646, 313);
            this.txtTotalImpuestoD.Name = "txtTotalImpuestoD";
            this.txtTotalImpuestoD.Size = new System.Drawing.Size(125, 22);
            this.txtTotalImpuestoD.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(507, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Total Impuesto";
            // 
            // txtSubtotalD
            // 
            this.txtSubtotalD.Enabled = false;
            this.txtSubtotalD.Location = new System.Drawing.Point(646, 281);
            this.txtSubtotalD.Name = "txtSubtotalD";
            this.txtSubtotalD.Size = new System.Drawing.Size(125, 22);
            this.txtSubtotalD.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(839, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(1051, 398);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(40, 17);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total";
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
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(82, 15);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaInicio.TabIndex = 9;
            // 
            // DtpFechafin
            // 
            this.DtpFechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechafin.Location = new System.Drawing.Point(441, 16);
            this.DtpFechafin.Name = "DtpFechafin";
            this.DtpFechafin.Size = new System.Drawing.Size(200, 22);
            this.DtpFechafin.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desde :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hasta :";
            // 
            // FrmConsulta_VentaFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 574);
            this.Controls.Add(this.TapGeneral);
            this.Name = "FrmConsulta_VentaFechas";
            this.Text = "Consulta de Ventas entre Fechas";
            this.Load += new System.EventHandler(this.FrmConsulta_VentaFechas_Load);
            this.TapGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PanelMostrarDetalle.ResumeLayout(false);
            this.PanelMostrarDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TapGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnComprobante;
        private System.Windows.Forms.Panel PanelMostrarDetalle;
        private System.Windows.Forms.TextBox txtTotalD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalImpuestoD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSubtotalD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnCerarDetalle;
        private System.Windows.Forms.DataGridView dgvMostrarDetalle;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechafin;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
    }
}