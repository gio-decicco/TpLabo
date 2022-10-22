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

namespace TpLaboAutomóviles.Presentacion
{
    public partial class FrmAltaPedido : Form
    {
        Pedido pedido;
        public FrmAltaPedido()
        {
            InitializeComponent();
            pedido = new Pedido();
            cargarIdPedido();
        }

        private void cargarIdPedido()
        {
            int nro = DaoPedidos.Instancia().ProximoId();
            lblTituloPedido.Text = "Pedido N°: " + nro.ToString(); 
        }

        private void FrmAltaPedido_Load(object sender, EventArgs e)
        {
            cargarTipoCliente();
            cargarTipoProducto();
            Clean(true);
            btnEditar.Enabled = false;
            txtTotal.Enabled = false;
        }

        private void Clean(bool valor)
        {
            gboPedido.Enabled = valor;
            nudCantidad.Value = 1;
            dgvPedidos.Rows.Clear();
        }

        private void cargarTipoProducto()
        {
            DataTable tabla = DaoProductos.Instancia().ReadTiposProducto();
            cboTipoProducto.DataSource = tabla;
            cboTipoProducto.ValueMember = "idTipoProducto";
            cboTipoProducto.DisplayMember = "descripcion";
            cboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarTipoCliente()
        {
            DataTable tabla = DaoClientes.Instancia().ReadTipoCliente();
            cboTipoCliente.DataSource = tabla;
            cboTipoCliente.ValueMember = "idTipoCliente";
            cboTipoCliente.DisplayMember = "descripcion";
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarGrilla())
            {
                Producto producto = new Producto();
                producto.IdProducto = (int)cboProducto.SelectedValue;
                producto.Descripcion = cboProducto.Text;
                int cantidad = (int)nudCantidad.Value;
                DataRowView item = (DataRowView)cboProducto.SelectedItem;
                producto.Precio = Convert.ToDouble(item[4]);

                Detalle_Pedido detalle = new Detalle_Pedido(producto, cantidad);
                pedido.AgregarDetalle(detalle);

                dgvPedidos.Rows.Add(new Object[] { producto.IdProducto, producto.Descripcion, cantidad, producto.Precio * cantidad});
                // evita cambiar datos
                CalcularTotal();
                gboPedido.Enabled = false;
                btnEditar.Enabled = true;
            }
        }

        private void CalcularTotal()
        {
            double total = 0;
            foreach(Detalle_Pedido detalle in pedido.lDetallesPedido)
            {
                total += detalle.CalcularSubtotal();
            }
            txtTotal.Text = total.ToString();
        }

        private bool validarGrilla()
        {
            foreach(Detalle_Pedido item in pedido.lDetallesPedido)
            {
                if (cboProducto.Text == item.Producto.Descripcion)
                {
                    MessageBox.Show("Este Producto ya existe !!", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return false;
                }
            }
            if (nudCantidad.Value < 1)
            {
                MessageBox.Show("Por favor ingrese una cantidad", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                return false;
            }
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor ingrese un Cliente", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            return true;
        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cboTipoCliente.SelectedItem;
            cargarComboCliente(Convert.ToInt32(item[0]));

        }

        private void cargarComboCliente(int id)
        {
            DataTable tabla = DaoClientes.Instancia().Read(id);
            cboCliente.DataSource = tabla;
            cboCliente.ValueMember = "idCliente";
            cboCliente.DisplayMember = "nomCliente";
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cboTipoProducto.SelectedItem;
            cargarProductos(Convert.ToInt32(item[0]));
        }

        private void cargarProductos(int id)
        {
            DataTable tabla = DaoProductos.Instancia().Read(id);
            cboProducto.DataSource = tabla;
            cboProducto.ValueMember = "idProducto";
            cboProducto.DisplayMember = "descripcion";
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.CurrentCell.ColumnIndex == 4)
            {
                pedido.QuitarDetalle(dgvPedidos.CurrentRow.Index);
                dgvPedidos.Rows.Remove(dgvPedidos.CurrentRow);
            }
            CalcularTotal();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarAceptar())
            {
                pedido.FechaPedido = dtpFechaPedido.Value;
                pedido.FechaOrden = dtpOrden.Value;
                DataRowView item = (DataRowView)cboCliente.SelectedItem;
                pedido.IdCliente = Convert.ToInt32(item[0]);

                if (MessageBox.Show("Quiere ingresar el Pedido ??", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DaoPedidos.Instancia().Create(pedido);
                    MessageBox.Show("Se inserto con exito !!", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    Clean(true);
                }

            }
        }

        private bool validarAceptar()
        {
            if (pedido.lDetallesPedido.Count == 0)
            {
                MessageBox.Show("Por favor agregue al menos un Producto !!", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere cambiar los Datos ?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                gboPedido.Enabled = true;
            }
        }
    }
}
