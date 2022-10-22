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
    public partial class FrmConsulta2 : Form
    {
        public FrmConsulta2()
        {
            InitializeComponent();
        }

        private void FrmConsulta2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSegundaConsulta.DTSegCons' Puede moverla o quitarla según sea necesario.
            this.dTSegConsTableAdapter.Fill(this.dSSegundaConsulta.DTSegCons);
            // TODO: esta línea de código carga datos en la tabla 'dSListado.DTVista' Puede moverla o quitarla según sea necesario.
            
            this.reportViewer1.RefreshReport();
        }
    }
}
