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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            valor = Convert.ToInt32(txtPrecio.Text);
            this.productosTableAdapter.Fill(this.dataSet3.Productos,valor);
            this.reportViewer1.RefreshReport();

        }
    }
}
