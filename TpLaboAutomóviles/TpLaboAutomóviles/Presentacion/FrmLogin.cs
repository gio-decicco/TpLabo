using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLaboAutomóviles;
using TpLaboAutomóviles.Presentacion;

namespace AppConcesionaria.Presentacion
{
    public partial class frmLogin : Form
    {
        public bool login = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.ForeColor = Color.AliceBlue;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.ForeColor = Color.AliceBlue;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.ForeColor = Color.DimGray;
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtClave.Text == "admin")
            {

                var frm = new FrmPrincipal(); frm.Show(); 
                this.Visible = false;
                login = true;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta !!");
                login = false;
            }
        }

    }
}
