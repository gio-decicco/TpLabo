using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpLaboAutomóviles.Reportes.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.vis_facturas_total' Puede moverla o quitarla según sea necesario.
            this.vis_facturas_totalTableAdapter.Fill(this.dataSet2.vis_facturas_total);

            this.reportViewer1.RefreshReport();
        }
    }
}
