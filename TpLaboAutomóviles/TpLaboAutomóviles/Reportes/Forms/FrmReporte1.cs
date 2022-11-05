using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpLaboAutomóviles.Presentacion.Reportes.Forms
{
    public partial class FrmReporte1 : Form
    {
        public FrmReporte1()
        {
            InitializeComponent();
        }

        private void FrmReporte1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPrimerConsulta.vis_cantidadytotal_x_cliente' table. You can move, or remove it, as needed.
            this.vis_cantidadytotal_x_clienteTableAdapter.Fill(this.dSPrimerConsulta.vis_cantidadytotal_x_cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
