using System.Windows.Forms;

namespace Sistema.Presentacion
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email :";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(80, 118);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
           // this.txtClave.PlaceholderText = "Contraseña";
            this.txtClave.Size = new System.Drawing.Size(268, 27);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 47);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 67);
            this.txtEmail.Name = "txtEmail";
           // this.txtEmail.PlaceholderText = "Email del usuario";
            this.txtEmail.Size = new System.Drawing.Size(268, 27);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "admin@prueba.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Acceso al Sistema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clave :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema.Presentacion.Properties.Resources.Banned_User;
            this.pictureBox2.Location = new System.Drawing.Point(379, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 149);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnAcceder
            // 
            this.BtnAcceder.Location = new System.Drawing.Point(80, 172);
            this.BtnAcceder.Name = "btnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(118, 29);
            this.BtnAcceder.TabIndex = 2;
            this.BtnAcceder.Text = "Acceder";
            this.BtnAcceder.UseVisualStyleBackColor = true;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // btnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(227, 172);
            this.BtnCancelar.Name = "btnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 29);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 213);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAcceder);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtClave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Button BtnAcceder;
        private Button BtnCancelar;
    }
}