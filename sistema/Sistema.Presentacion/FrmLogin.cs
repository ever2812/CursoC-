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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NUsuario.Login(txtEmail.Text.Trim(),txtClave.Text.Trim());
                if (tabla.Rows.Count<=0)
                {
                    MessageBox.Show("Email o Clave incorrecta", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToBoolean(tabla.Rows[0][4])==false)
                    {
                        MessageBox.Show("El usuario no esta activo", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FrmPrincipal frm = new FrmPrincipal();
                        Variables.Idusuario= Convert.ToInt32(tabla.Rows[0][0]);
                        frm.Idusuario= Convert.ToInt32(tabla.Rows[0][0]);
                        frm.Idrol = Convert.ToInt32(tabla.Rows[0][1]);
                        frm.Rol= Convert.ToString(tabla.Rows[0][2]);
                        frm.Nombre = Convert.ToString(tabla.Rows[0][3]);
                        frm.Estado = Convert.ToBoolean(tabla.Rows[0][4]);
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton= BtnAcceder;
        }
    }
}
