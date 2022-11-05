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
using TpLaboAutomóviles.Dominio;
using TpLaboAutomóviles.Servicios.Factory;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Presentacion
{
    public partial class FrmConsulta8 : Form
    {
        IServiceProducto service;
        public FrmConsulta8(ServiceFactory fabrica)
        {
            InitializeComponent();
            service = fabrica.CrearServiceProducto();
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
            List<Producto> list = service.ReadProductosPorPrecio(Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value));
            foreach (Producto producto in list)
            {
                dgvProductos.Rows.Add(new object[] { producto.IdProducto, producto.Descripcion, producto.Precio});
            }
        }
    }
}
