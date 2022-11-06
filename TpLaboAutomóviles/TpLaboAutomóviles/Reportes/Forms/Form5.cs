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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            
        }
        public DateTime fechainicio { get; set; }
        public DateTime fechafinal { get; set; }
        
        private void button1_Click(object sender, EventArgs e)
        {
            fechainicio = dtpInicio.Value;
            fechafinal = dtpFinal.Value;
            this.reportViewer1.RefreshReport();
            this.dataTable1TableAdapter.Fill(this.dataSet5.DataTable1, fechainicio, fechafinal);
        }
    }
}
