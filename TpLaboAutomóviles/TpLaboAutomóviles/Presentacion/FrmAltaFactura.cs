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
using TpLaboAutomóviles.Servicios.Concreta;
using TpLaboAutomóviles.Servicios.Factory;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Presentacion
{
    public partial class FrmAltaFactura : Form
    {

        private IServiceFactura servicio;
        private ServiceFactory fabrica;
        private Factura nueva;
        double subtotal = 0;
        double total = 0;
        public FrmAltaFactura(ServiceFactory fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            servicio = fabrica.CrearService();
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
            cargarComboTipoCliente();
            cargarComboTipoProducto();
            cargarComboFormasPago();
            GroupDetalles.Enabled = false;
        }

        private void cargarProximoId()
        {
            LblNroFactura.Text = "Factura N°" + DaoFacturas.Instancia().ConsultarProximoId();
        }

        private void cargarComboFormasPago()
        {
            CboFormaPago.DataSource = DaoFacturas.Instancia().ReadFormasPago();
            CboFormaPago.ValueMember = "idFormaPago";
            CboFormaPago.DisplayMember = "formaPago";
            CboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarComboTipoCliente()
        {
            CboTipoCliente.DataSource = DaoClientes.Instancia().ReadTipoCliente();
            CboTipoCliente.ValueMember = "idTipoCliente";
            CboTipoCliente.DisplayMember = "descripcion";
            CboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarComboCliente(int id)
        {
            CboClientes.DataSource = DaoClientes.Instancia().Read(id);
            CboClientes.ValueMember = "idCliente";
            CboClientes.DisplayMember = "nomCliente";
            CboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)CboTipoCliente.SelectedItem;
            cargarComboCliente(Convert.ToInt32(item[0]));
        }
        private void cargarComboTipoProducto()
        {
            CboTipoProducto.DataSource = DaoProductos.Instancia().ReadTiposProducto();
            CboTipoProducto.ValueMember = "idTipoProducto";
            CboTipoProducto.DisplayMember = "descripcion";
            CboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)CboTipoProducto.SelectedItem;
            cargarComboProducto(Convert.ToInt32(item[0]));
        }

        private void cargarComboProducto(int v)
        {
            CboProductos.DataSource = DaoProductos.Instancia().Read(v);
            CboProductos.ValueMember = "idProducto";
            CboProductos.DisplayMember = "descripcion";
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
            DataRowView item = (DataRowView)CboProductos.SelectedItem;

            Producto p = new Producto();
            p.IdProducto = Convert.ToInt32(item[0]);
            p.Descripcion = Convert.ToString(item[1]);
            p.Stock_Min = Convert.ToInt32(item[2]);
            p.Stock_Actual = Convert.ToInt32(item[3]);
            p.Precio = Convert.ToDouble(item[4]);
            p.IdTipoProducto = Convert.ToInt32(item[5]);

            Detalle_Facturas d = new Detalle_Facturas();
            d.Producto = p;
            d.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            d.PrecioUnitario = p.Precio;
            nueva.AgregarDetalle(d);
            DtgDetalles.Rows.Add(new object[] { p.IdProducto, p.Descripcion,p.Precio*Convert.ToInt32(TxtCantidad.Text), TxtCantidad.Text });
            subtotal += p.Precio * Convert.ToInt32(TxtCantidad.Text);
            TxtSubtotal.Text = "$ " + Convert.ToString(subtotal);
            total = total - (Convert.ToInt32(TxtDescuento.Text) * subtotal / 100);
            TxtTotal.Text = "$ " + Convert.ToString(total);
        }

        private bool validar()
        {
            if (CboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de Cliente");
                return false;
            }
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
            if (CboTipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un tipo de producto");
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

        private void BtnListo_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }
            GroupFactura.Enabled = false;
            GroupDetalles.Enabled = true;

            DataRowView item = (DataRowView)CboClientes.SelectedItem;
            nueva.IdCliente = Convert.ToInt32(item[0]);
            nueva.Fecha = DtpFecha.Value;
            DataRowView item2 = (DataRowView)CboFormaPago.SelectedItem;
            nueva.FormaPago = Convert.ToInt32(item2[0]);
            nueva.Descuento = Convert.ToInt32(TxtDescuento.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar la operacion?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void CboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)CboProductos.SelectedItem;
            TxtStock.Text = Convert.ToString(item[3]);
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            new FrmAltaCliente().ShowDialog();
        }
    }
}
