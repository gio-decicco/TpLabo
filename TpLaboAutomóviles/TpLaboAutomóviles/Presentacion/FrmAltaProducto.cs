using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLaboAutomóviles.Dominio;
namespace TpLaboAutomóviles.Presentacion
{
    public partial class FrmAltaProducto : Form
    {
        public FrmAltaProducto()
        {
            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            txtDescrpicion.Text = "";
            txtPrecio.Text = "";
            txtStockActual.Text = "";
            txtStockMinimo.Text = "";
            cboTipoProd.SelectedValue = -1;
        }
        
    }
}
