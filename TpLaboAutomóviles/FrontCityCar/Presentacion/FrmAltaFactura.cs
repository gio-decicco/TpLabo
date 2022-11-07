using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityCarBackEnd.Datos.Concretas;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios;
using CityCarBackEnd.Servicios.Concreta;
using CityCarBackEnd.Servicios.Factory;
using CityCarBackEnd.Servicios.Interfaces;

namespace CityCarFrontEnd.Presentacion
{
    public partial class FrmAltaFactura : Form
    {

        private IServiceFactura servicioFactura;
        private IServiceProducto servicioProducto;
        private IServiceCliente servicioCliente;
        private ServiceFactory fabrica;
        private Factura nueva;
        double subtotal = 0;
        double total = 0;
        public FrmAltaFactura(ServiceFactory fabrica)
        {
            InitializeComponent();
            nueva = new Factura();
            this.fabrica = fabrica;
            servicioFactura = fabrica.CrearServiceFactura();
            servicioCliente = fabrica.CrearServiceCliente();
            servicioProducto = fabrica.CrearServiceProducto();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgDetalles.CurrentCell.ColumnIndex == 4)
            {
                nueva.QuitarDetalle(DtgDetalles.CurrentRow.Index); 
                DtgDetalles.Rows.Remove(DtgDetalles.CurrentRow);
            }
        }

        private void FrmAltaFactura_Load(object sender, EventArgs e)
        {
            cargarProximoId();
            cargarComboFormasPago();
            GroupDetalles.Enabled = true;
            cargarComboCliente();
            cargarComboProducto();
            TxtDescuento.Text = "0";
        }

        private void cargarProximoId()
        {
            LblNroFactura.Text = "Factura N°" + servicioFactura.CargarProxId();
        }

        private void cargarComboFormasPago()
        {
            CboFormaPago.DataSource = servicioFactura.ReadFormaPago();
            CboFormaPago.ValueMember = "idFormaPago";
            CboFormaPago.DisplayMember = "formaPago";
            CboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarComboCliente()
        {
            CboClientes.DataSource = servicioCliente.ReadClientes();
            CboClientes.DisplayMember = "c.ToString()";
            CboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarComboProducto()
        {
            CboProductos.DataSource = servicioProducto.ReadProductos();
            CboProductos.DisplayMember = "p.ToString()";
            CboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Detalle_Facturas detalle in nueva.lDetalles)
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
            nueva.AgregarDetalle(d);
            DtgDetalles.Rows.Add(new object[] { producto.IdProducto, producto.Descripcion,producto.Precio*Convert.ToInt32(TxtCantidad.Text), TxtCantidad.Text });
            subtotal += producto.Precio * Convert.ToInt32(TxtCantidad.Text);
            TxtSubtotal.Text = "$ " + Convert.ToString(subtotal);
            total = total - (Convert.ToInt32(TxtDescuento.Text) * subtotal / 100);
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

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            Cliente cliente = (Cliente)CboClientes.SelectedItem;
            nueva.Cliente = cliente;
            nueva.Fecha = DtpFecha.Value;
            DataRowView item2 = (DataRowView)CboFormaPago.SelectedItem;
            nueva.FormaPago = Convert.ToInt32(item2[0]);
            nueva.Descuento = Convert.ToInt32(TxtDescuento.Text);

            if (DaoFacturas.Instancia().Create(nueva))
            {
                MessageBox.Show("La factura se ingreso correctamente");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No fue posible la incersion");
            }
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
        }
    }
}
