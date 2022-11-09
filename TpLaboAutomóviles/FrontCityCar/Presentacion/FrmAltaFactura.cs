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
using CityCarBackEnd.Servicios.Concreta;
using CityCarBackEnd.Servicios.Factory;
using CityCarBackEnd.Servicios.Interfaces;
using CityCarFrontend.Cliente;
using Newtonsoft.Json;

namespace CityCarFrontEnd.Presentacion
{
    public partial class FrmAltaFactura : Form
    {

        private IServiceFactura servicioFactura;
        private IServiceProducto servicioProducto;
        private IServiceCliente servicioCliente;
        private ServiceFactory fabrica;
        private Factura factura;
        double subtotal = 0;
        double total = 0;
        public FrmAltaFactura(ServiceFactory fabrica)
        {
            InitializeComponent();
            factura = new Factura();
            this.fabrica = fabrica;
            servicioFactura = fabrica.CrearServiceFactura();
            servicioCliente = fabrica.CrearServiceCliente();
            servicioProducto = fabrica.CrearServiceProducto();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgDetalles.CurrentCell.ColumnIndex == 4)
            {
                factura.QuitarDetalle(DtgDetalles.CurrentRow.Index);
                DtgDetalles.Rows.Remove(DtgDetalles.CurrentRow);
            }
        }

        private async void FrmAltaFactura_Load(object sender, EventArgs e)
        {
            await cargarProximoId();
            await cargarComboFormasPago();
            GroupDetalles.Enabled = true;
            await cargarComboCliente();
            await cargarComboProducto();
            TxtDescuento.Text = "0";
        }

        private async Task cargarProximoId()
        {
            //var data = ClienteSingleton.Instancia().GetAsync("http://localhost:5106/GetProximoId");
            //List<int> lst= JsonConvert.DeserializeObject<List<int>>(data);

            LblNroFactura.Text = "Factura N°: " + await ClienteSingleton.Instancia().GetAsync("http://localhost:5106/GetProximoId");
        }

        private async Task cargarComboFormasPago()
        {
            CboFormaPago.DataSource = null;
            var data = await ClienteSingleton.Instancia().GetAsync("http://localhost:5106/getFormasPago");
            var lst = JsonConvert.DeserializeObject<List<FormasPago>>(data);
                          
            CboFormaPago.DataSource = lst;
            CboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        

        private async Task cargarComboCliente()
        {
            CboClientes.DataSource = null;
            var data = await ClienteSingleton.Instancia().GetAsync("http://localhost:5106/getClientes");
            var lst=JsonConvert.DeserializeObject<List<Cliente>>(data);

            CboClientes.DataSource = lst;
            CboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task cargarComboProducto()
        {
            var data = await ClienteSingleton.Instancia().GetAsync("http://localhost:5106/getProductos");
            var lst = JsonConvert.DeserializeObject<List<Producto>>(data);

            CboProductos.DataSource = lst;
            CboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Detalle_Facturas detalle in factura.lDetalles)
            {
                if (CboProductos.Text == detalle.Producto.Descripcion)
                {
                    MessageBox.Show("El producto ya se encuentra como detalle!");
                    return;
                }
            }
            if (!validar())
            {
                return;
            }
            Producto producto = (Producto)CboProductos.SelectedItem;

            Detalle_Facturas d = new Detalle_Facturas();
            d.Producto = producto;
            d.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            d.PrecioUnitario = producto.Precio;
            factura.AgregarDetalle(d);
            DtgDetalles.Rows.Add(new object[] { producto.IdProducto, producto.Descripcion, producto.Precio * Convert.ToInt32(TxtCantidad.Text), TxtCantidad.Text });
            double subtotal = 0;
            foreach(Detalle_Facturas detalle in factura.lDetalles)
            {
                subtotal += detalle.PrecioUnitario *detalle.Cantidad;
            }
            TxtSubtotal.Text = "$ " + Convert.ToString(subtotal);
            double total = subtotal - Convert.ToInt32(TxtDescuento.Text)*subtotal/100;
            TxtTotal.Text = "$ " + Convert.ToString(total);
        }

        private bool validar()
        {
            if (CboClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente");
                return false;
            }
            if (CboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una forma de pago");
                return false;
            }
            if (TxtDescuento.Text == "")
            {
                MessageBox.Show("Ingrese un valor para descuento");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(TxtDescuento.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un valor numérico para descuento");
                    return false;
                }
            }
            if (Convert.ToInt32(TxtDescuento.Text) > 100 || Convert.ToInt32(TxtDescuento.Text) < 0)
            {
                MessageBox.Show("Ingrese un valor entre 0 y 100 para descuento");
                return false;
            }
            if (CboProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un producto");
                return false;
            }
            if (TxtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese un valor para cantidad");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(TxtCantidad.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un valor numérico para cantidad");
                    return false;
                }
            }
            if (Convert.ToInt32(TxtCantidad.Text) < 0)
            {
                MessageBox.Show("Ingrese un valor positivo para cantidad");
                return false;
            }
            return true;
        }

        private async void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)CboClientes.SelectedItem;
            factura.Cliente = cliente;
            factura.Fecha = DtpFecha.Value;
            FormasPago item2 = (FormasPago)CboFormaPago.SelectedItem;
            factura.FormaPago = item2.Id;
            factura.Descuento = Convert.ToInt32(TxtDescuento.Text);
            var saveOk = await AltaFacturaAsync(factura);

            if (saveOk)
            {
                MessageBox.Show("La factura se ingreso correctamente");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No fue posible la incersion");
            }
        }
        private async Task<bool> AltaFacturaAsync(Factura factura)
        {
            string url = "http://localhost:5106/AltaFactura";
            var facturaJson = JsonConvert.SerializeObject(factura);
            
            var result =  await ClienteSingleton.Instancia().PostAsync(url, facturaJson);
            return result.Equals("true");

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar la operacion?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            new FrmAltaCliente(this.fabrica).ShowDialog();
            cargarComboCliente();
        }

        private void BtnListo_Click(object sender, EventArgs e)
        {
            GroupFactura.Enabled = false;
        }
    }
}
