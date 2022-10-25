using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLaboAutomóviles.Datos.Concretas;

namespace TpLaboAutomóviles.Presentacion
{
    public partial class FrmConsulta8 : Form
    {
        public FrmConsulta8()
        {
            InitializeComponent();
        }

        
        
        private void FrmConsulta8_Load(object sender, EventArgs e)
        {
            limpiar();
            
        }
        public void limpiar()
        {
            nudMax.Value = 1;
            nudMin.Value = 0;
            

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            if (nudMax.Value < nudMin.Value)
            {
                MessageBox.Show("El mínimo debe ser menor al máximo!!");
                return;
            }
            else
            {
                CargarDgv();
                
            }
        }
        public void CargarDgv()
        {
            DataTable tabla = new DataTable();
            tabla = DaoProductos.Instancia().ReadProductosConsulta8(Convert.ToDouble(nudMin.Value), Convert.ToDouble(nudMin.Value));
            foreach (DataRow item in tabla.Rows)
            {
                dgvProductos.Rows.Add(new object[] { item[0], item[1], item[2] });
            }
        }
    }
}
