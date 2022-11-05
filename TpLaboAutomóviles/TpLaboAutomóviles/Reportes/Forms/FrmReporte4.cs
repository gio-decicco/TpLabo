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
    public partial class FrmReporte4 : Form
    {
        public FrmReporte4()
        {
            InitializeComponent();
        }

        private void FrmReporte4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSCuartaConsulta.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dSCuartaConsulta.DataTable1);
            // TODO: esta línea de código carga datos en la tabla 'dSCuartaConsulta3.DTImporteAnual' Puede moverla o quitarla según sea necesario.
            this.dTImporteAnualTableAdapter.Fill(this.dSCuartaConsulta3.DTImporteAnual);
            // TODO: esta línea de código carga datos en la tabla 'dSCuartaConsulta2.DTImporteMensual' Puede moverla o quitarla según sea necesario.
            this.dTImporteMensualTableAdapter.Fill(this.dSCuartaConsulta2.DTImporteMensual);

            this.reportViewer1.RefreshReport();
        }
    }
}
