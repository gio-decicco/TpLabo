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
    public partial class FrmReporte5 : Form
    {
        public FrmReporte5()
        {
            InitializeComponent();
        }

        private void FrmReporte5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSQuintaConsulta.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dSQuintaConsulta.Clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
