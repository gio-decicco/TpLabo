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
    public partial class FrmReporte7 : Form
    {
        public FrmReporte7()
        {
            InitializeComponent();
        }

        private void FrmReporte7_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSeptimaConsulta.DTClientes' Puede moverla o quitarla según sea necesario.
            this.dTClientesTableAdapter.Fill(this.dSSeptimaConsulta.DTClientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
