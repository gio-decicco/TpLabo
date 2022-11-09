using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityCarBackend.Dominio;
using CityCarBackEnd.Datos.Concretas;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios;
using CityCarBackEnd.Servicios.Factory;
using CityCarBackEnd.Servicios.Interfaces;
using CityCarFrontend.Cliente;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace CityCarFrontEnd.Presentacion
{
    public partial class FrmConsultarFacturas : Form
    {
        IServiceFactura servicioFactura;
        IServiceCliente servicioCliente;
        public FrmConsultarFacturas(ServiceFactory fabrica)
        {
            InitializeComponent();
            servicioFactura = fabrica.CrearServiceFactura();
            servicioCliente = fabrica.CrearServiceCliente();
        }

        private async void FrmConsultarFacturas_Load(object sender, EventArgs e)
        {
            await CargarComboClientesAsync();
        }

        private async Task CargarComboClientesAsync()
        {
            string url = ("http://localhost:5106/getClientes");
            var data = await ClienteSingleton.Instancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(data);

            CboClientes.DataSource = lst;
            CboClientes.DropDownStyle= ComboBoxStyle.DropDownList;
        }

        private async Task CargarCombos()
        {
            Factura factura = (Factura)LstFacturas.SelectedItem;
            if (factura != null)
            {
                TxtFecha.Text = Convert.ToString(factura.Fecha);
                TxtDescuento.Text = Convert.ToString(factura.Descuento);
                string url = ("http://localhost:5106/GetFormasPago/");
                var data = await ClienteSingleton.Instancia().GetAsync(url + factura.FormaPago);
                var lstJson = JsonConvert.DeserializeObject<List<FormasPago>>(data);
                CboFormasPago.DataSource = lstJson;
            }
        }

        private async Task CargarLista()
        {
            LstFacturas.DataSource = null;
            Cliente cliente = (Cliente)CboClientes.SelectedItem;
            string url = "http://localhost:5106/GetFacturaId/";
            var data = await ClienteSingleton.Instancia().GetAsync(url + cliente.IdCliente);
            var FacturaJson = JsonConvert.DeserializeObject<List<Factura>>(data);

            //LstFacturas.DataSource = DaoFacturas.Instancia().Read(cliente.IdCliente);

            LstFacturas.DataSource = FacturaJson;
        }

        private async void LstFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarCombos();
            await CargarDetalles();
            BtnEliminar.Enabled = true;
        }

        private async Task CargarDetalles()
        {
            DtgDetalles.Rows.Clear();
            Factura factura = (Factura)LstFacturas.SelectedItem;
            if (factura != null)
            {
                double subtotal = 0;
                foreach (Detalle_Facturas detalle in factura.lDetalles)
                {
                    DtgDetalles.Rows.Add(new object[] { detalle.Producto.IdProducto, detalle.Producto.Descripcion, detalle.Cantidad, detalle.PrecioUnitario });
                    subtotal += detalle.PrecioUnitario * detalle.Cantidad;
                }
                textBox1.Text = Convert.ToString(subtotal);
            }
        }

        private async void BtnCargar_Click(object sender, EventArgs e)
        {
            await CargarLista();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar esta factura?", "ELMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Factura factura = (Factura)LstFacturas.SelectedItem;
                var saveOk = await DeleteFactura();
                if (saveOk)
                {
                    MessageBox.Show("Se eliminó correctamente la factura");
                    CargarLista();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la factura");
                }
            }
        }

        private async Task<bool> DeleteFactura()
        {
            Factura factura = (Factura)LstFacturas.SelectedItem;
            var result = await ClienteSingleton.Instancia().DeleteAsync("http://localhost:5106/BorrarFactura/" + factura.IdFactura);
            return result.Equals("true");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtgDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
