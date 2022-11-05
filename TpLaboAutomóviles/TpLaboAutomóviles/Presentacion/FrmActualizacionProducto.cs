using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLaboAutomóviles.Dominio;
using TpLaboAutomóviles.Servicios.Factory;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Presentacion
{
    public partial class FrmActualizacionProducto : Form
    {
        IServiceProducto serviceProducto;
        public FrmActualizacionProducto(IServiceProducto servicio/*ServiceFactory fabrica*/)
        {
            InitializeComponent();
            //serviceProducto = fabrica.CrearServiceProducto();
            serviceProducto = servicio;
        }

        private void FrmActualizacionProducto_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            LstProductos.DataSource = null;
            LstProductos.DataSource = serviceProducto.ReadProductos();
        }

        private void LstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto producto = (Producto)LstProductos.SelectedItem;
            if (producto != null)
            {
                TxtDescripcion.Text = producto.Descripcion;
                TxtPrecio.Text = Convert.ToString(producto.Precio);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text == "")
            {
                return;
            }
            if (TxtPrecio.Text == "")
            {
                return;
            }
            try
            {
                double.Parse(TxtPrecio.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }
            Producto producto = (Producto)LstProductos.SelectedItem;
            producto.Descripcion = TxtDescripcion.Text;
            producto.Precio = Convert.ToDouble(TxtPrecio.Text);
            if (MessageBox.Show("¿Desea modificar el producto?", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (serviceProducto.ModificacionProducto(producto))
                {
                    MessageBox.Show("Se modificó con éxito el producto");
                    cargarLista();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el producto");
                }
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el producto?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Producto producto = (Producto)LstProductos.SelectedItem;
                if (serviceProducto.BajaProducto(producto))
                {
                    MessageBox.Show("Se eliminó con éxito el producto");
                    cargarLista();
                }
                else
                {
                    MessageBox.Show("No pudo eliminarse el producto");
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            GroupProductos.Enabled = false;
            GroupDetalles.Enabled = true;
            BtnModificar.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnConfirmar.Enabled = true;
            BtnEliminar.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnCancelar.Enabled = false;
            GroupDetalles.Enabled = false;
            GroupProductos.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnModificar.Enabled = true;
            BtnConfirmar.Enabled = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}