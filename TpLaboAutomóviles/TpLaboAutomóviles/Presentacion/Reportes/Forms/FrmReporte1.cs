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
            // TODO: esta línea de código carga datos en la tabla 'dSListado.DTVista' Puede moverla o quitarla según sea necesario.
            this.dTVistaTableAdapter.Fill(this.dSListado.DTVista);

            this.reportViewer1.RefreshReport();
        }
    }
}
