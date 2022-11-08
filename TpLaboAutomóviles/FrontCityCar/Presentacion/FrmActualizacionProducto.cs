using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Factory;
using CityCarBackEnd.Servicios.Interfaces;
using CityCarFrontend.Cliente;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace CityCarFrontEnd.Presentacion
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

        private async void FrmActualizacionProducto_Load(object sender, EventArgs e)
        {
            await cargarLista();
        }

        private async Task cargarLista()
        {
            List<Producto> lst;
            var data = await ClienteSingleton.Instancia().GetAsync("http://localhost:5106/GetProductos");
            lst = JsonConvert.DeserializeObject<List<Producto>>(data);
            LstProductos.DataSource = lst;
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

        private async void BtnConfirmar_Click(object sender, EventArgs e)
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
            var saveOk = await ModificarProductoAsync(producto);
            
            if (MessageBox.Show("¿Desea modificar el producto?", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (saveOk)
                {
                    MessageBox.Show("Se modificó con éxito el producto");
                    await cargarLista();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el producto");
                }
            }
        }
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el producto?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Producto producto = (Producto)LstProductos.SelectedItem;
                var saveOk = await BorrarProducto(producto);

                if (saveOk)
                {
                    MessageBox.Show("Se eliminó con éxito el producto");
                    await cargarLista();
                }
                else
                {
                    MessageBox.Show("No pudo eliminarse el producto");
                }
            }
        }

        private async Task<bool> BorrarProducto(Producto oProducto)
        {
            string url = "http://localhost:5106/BorrarProductos/";
            string productoJson= JsonConvert.SerializeObject(oProducto);

            var result = await ClienteSingleton.Instancia().DeleteAsync(url+oProducto.IdProducto);
            return result.Equals("true");
        }
        private async Task<bool> ModificarProductoAsync(Producto producto)
        {
            string url = "http://localhost:5106/ModificarProductos";
            string productoJson = JsonConvert.SerializeObject(producto);
            var result = await ClienteSingleton.Instancia().PutAsync(url, productoJson);

            return result.Equals("true");
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