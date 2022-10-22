using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLaboAutomóviles.Presentacion;

namespace TpLaboAutomóviles
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAltaProducto().ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmActualizacionProducto().ShowDialog();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmAltaCliente().ShowDialog();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmActualizacionCliente().ShowDialog();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Presentacion.FrmAltaPedido().ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarFacturas form = new FrmConsultarFacturas();
            form.ShowDialog();
            form.Dispose();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAltaFactura().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarPedidos frm = new frmConsultarPedidos();
            frm.ShowDialog();
        }
    }
}
