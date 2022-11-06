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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.vis_cliente_barrio' Puede moverla o quitarla según sea necesario.
            this.vis_cliente_barrioTableAdapter.Fill(this.dataSet1.vis_cliente_barrio);

            this.reportViewer1.RefreshReport();
        }
    }
}
