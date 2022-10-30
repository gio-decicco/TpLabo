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
using TpLaboAutomóviles.Presentacion.Reportes.Forms;

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
            new FrmAltaPedido().ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarFacturas().ShowDialog();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAltaFactura().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void consulta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte1().ShowDialog();
        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consulta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte2().ShowDialog();
        }

        private void consulta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte3().ShowDialog();
        }

        private void consulta4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte4().ShowDialog();
        }

        private void consulta5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte5().ShowDialog();
        }

        private void consulta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte6().ShowDialog();
        }

        private void consulta7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte7().ShowDialog();
        }

        private void consulta8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsulta8().ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmConsultarPedidos().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a punto de salir del programa", "SALIENDO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void nuevaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new FrmAltaFactura().ShowDialog();
        }

        private void consultarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new FrmConsultarFacturas().ShowDialog();
        }

        private void nuevoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            new FrmAltaPedido().ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            new frmConsultarPedidos().ShowDialog();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte1().ShowDialog();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte2().ShowDialog();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte3().ShowDialog();
        }

        private void reporte4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte4().ShowDialog();
        }

        private void reporte5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte5().ShowDialog();
        }

        private void reporte6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte6().ShowDialog();
        }

        private void reporte7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporte7().ShowDialog();
        }

        private void reporte8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsulta8().ShowDialog();
        }
    }
}
