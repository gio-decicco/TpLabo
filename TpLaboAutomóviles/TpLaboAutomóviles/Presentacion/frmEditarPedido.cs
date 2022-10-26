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
    public partial class frmEditarPedido : Form
    {
        private int nro;

        public frmEditarPedido(int nro)
        {
            InitializeComponent();
            Pedido pedido = new Pedido();
            pedido.IdPedido = nro;
        }

        private void frmEditarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
