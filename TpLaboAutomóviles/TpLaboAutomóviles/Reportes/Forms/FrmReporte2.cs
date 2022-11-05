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
    public partial class FrmReporte2 : Form
    {
        public FrmReporte2()
        {
            InitializeComponent();
        }

        private void FrmReporte2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSegundaConsulta.DTSegCons' table. You can move, or remove it, as needed.
            this.dTSegConsTableAdapter.Fill(this.dSSegundaConsulta.DTSegCons);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
