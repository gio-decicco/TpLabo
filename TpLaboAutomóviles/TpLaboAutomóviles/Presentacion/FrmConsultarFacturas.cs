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
using TpLaboAutomóviles.Servicios;
using TpLaboAutomóviles.Servicios.Factory;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Presentacion
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
            CargarComboClientes();
        }

        private void CargarComboClientes()
        {
            CboClientes.DataSource = servicioCliente.ReadClientes();
            CboClientes.DisplayMember = "p.ToString()";
            CboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void CargarLista()
        {
            LstFacturas.DataSource = null;
            Cliente cliente = (Cliente)CboClientes.SelectedItem;
            LstFacturas.DataSource = servicioFactura.GetFacturaList(cliente.IdCliente);
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
                if (servicioFactura.BajaFactura(factura))
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
