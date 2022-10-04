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
    public partial class FrmAltaFactura : Form
    {
        Factura nueva;
        public FrmAltaFactura()
        {
            InitializeComponent();
            nueva = new Factura();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAltaFactura_Load(object sender, EventArgs e)
        {
            cargarProximoId();
            cargarComboTipoCliente();
            cargarComboTipoProducto();
            cargarComboFormasPago();
            cargarComboAutoPlan();
        }

        private void cargarProximoId()
        {
            LblNroFactura.Text = "Factura N°" + DaoFacturas.Instancia().ConsultarProximoId();
        }

        private void cargarComboAutoPlan()
        {
            CboAutoPlan.DataSource = DaoFacturas.Instancia().ReadAutoPlan();
            CboAutoPlan.ValueMember = "idAutoPlan";
            CboAutoPlan.DisplayMember = "descripcion";
            CboAutoPlan.DropDownStyle = ComboBoxStyle.DropDownList;
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
            cargarComboTipoProducto(Convert.ToInt32(item[0]));
        }

        private void cargarComboTipoProducto(int v)
        {
            CboProductos.DataSource = DaoProductos.Instancia().Read(v);
            CboProductos.ValueMember = "idProducto";
            CboProductos.DisplayMember = "descripcion";
            CboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
