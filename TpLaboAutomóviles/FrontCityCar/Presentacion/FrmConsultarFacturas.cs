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

        private void FrmConsultarFacturas_Load(object sender, EventArgs e)
        {
            CargarComboClientesAsync();
        }

        private async void CargarComboClientesAsync()
        {
            string url = ("http://localhost:5106/getClientes");
            var data = await ClienteSingleton.Instancia().GetAsync(url);
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(data);

            CboClientes.DataSource = lst;
            CboClientes.ValueMember = "";
            CboClientes.DisplayMember = "p.ToString()";
            CboClientes.DropDownStyle= ComboBoxStyle.DropDownList;
        }

        private void CargarCombos()
        {
            Factura factura = (Factura)LstFacturas.SelectedItem;
            if (factura != null)
            {
                TxtFecha.Text = Convert.ToString(factura.Fecha);
                TxtDescuento.Text = Convert.ToString(factura.Descuento);
                CboFormasPago.DataSource = DaoFacturas.Instancia().ReadFormasPagoConId(factura.FormaPago);
                CboFormasPago.DisplayMember = "formaPago";
                CboFormasPago.ValueMember = "idFormaPago";
            }
        }

        private async void CargarLista()
        {
            Cliente cliente = (Cliente)CboClientes.SelectedItem;
            string url = "http://localhost:5106/GetFacturaId/";
            var data = await ClienteSingleton.Instancia().GetAsync(url + cliente.IdCliente);
            List<Factura> FacturaJson = JsonConvert.DeserializeObject<List<Factura>>(data);

            LstFacturas.DataSource = FacturaJson;
        }

        private void LstFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCombos();
            CargarDetalles();
            BtnEliminar.Enabled = true;
        }

        private void CargarDetalles()
        {
            DtgDetalles.Rows.Clear();
            Factura factura = (Factura)LstFacturas.SelectedItem;
            if (factura != null)
            {
                foreach (Detalle_Facturas detalle in factura.lDetalles)
                {
                    DtgDetalles.Rows.Add(new object[] { detalle.Producto.IdProducto, detalle.Producto.Descripcion, detalle.Cantidad, detalle.PrecioUnitario });
                }
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarLista();
            
        }

        private void CargarDgv()
        {
            throw new NotImplementedException();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar esta factura?", "ELMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Factura factura = (Factura)LstFacturas.SelectedItem;
                
                if (servicioFactura.BajaFactura(factura.IdFactura))
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
    }
}
