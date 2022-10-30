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
    public partial class FrmConsultarFacturas : Form
    {
        List<Factura> lFacturas = new List<Factura>();
        public FrmConsultarFacturas()
        {
            InitializeComponent();
        }

        private void FrmConsultarFacturas_Load(object sender, EventArgs e)
        {
            CargarComboTipoCliente();
            CargarComboClientes();
        }

        private void CargarComboTipoCliente()
        {
            CboTipoCliente.DataSource = DaoClientes.Instancia().ReadTipoCliente();
            CboTipoCliente.ValueMember = "idTipoCliente";
            CboTipoCliente.DisplayMember = "descripcion";
            CboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboClientes()
        {
            DataRowView row = (DataRowView)CboTipoCliente.SelectedItem;
            CboClientes.DataSource = DaoClientes.Instancia().Read(Convert.ToInt32(row[0]));
            CboClientes.ValueMember = "idCliente";
            CboClientes.DisplayMember = "nomCliente";
            CboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCombos()
        {
            TxtFecha.Text = Convert.ToString(lFacturas[Convert.ToInt32(LstFacturas.SelectedIndex)].Fecha);
            TxtDescuento.Text = Convert.ToString(lFacturas[Convert.ToInt32(LstFacturas.SelectedIndex)].Descuento);
            CboAutoPlan.DataSource = DaoFacturas.Instancia().ReadAutoPlanConIndice(lFacturas[Convert.ToInt32(LstFacturas.SelectedIndex)].IdAutoplan);
            CboAutoPlan.DisplayMember = "descripcion";
            CboAutoPlan.ValueMember = "idAutoPlan";
            CboFormasPago.DataSource = DaoFacturas.Instancia().ReadFormasPagoConId(lFacturas[Convert.ToInt32(LstFacturas.SelectedIndex)].FormaPago);
            CboFormasPago.DisplayMember = "formaPago";
            CboFormasPago.ValueMember = "idFormaPago";
        }

        private void CargarLista()
        {
            LstFacturas.Items.Clear();
            DataRowView item = (DataRowView)CboClientes.SelectedItem;
            DataTable tabla = DaoFacturas.Instancia().Read(Convert.ToInt32(item[0]));
            foreach (DataRow fila in tabla.Rows)
            {
                Factura f = new Factura();
                f.IdFactura = Convert.ToInt32(fila[0]);
                f.IdCliente = Convert.ToInt32(fila[1]);
                f.Fecha = Convert.ToDateTime(fila[2]);
                f.Descuento = Convert.ToInt32(fila[3]);
                f.IdAutoplan = Convert.ToInt32(fila[4]);
                f.FormaPago = Convert.ToInt32(fila[5]);
                lFacturas.Add(f);
                LstFacturas.Items.Add(f.Fecha);
            }
        }

        private void LstFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCombos();
            CargarDetalles(lFacturas[Convert.ToInt32(LstFacturas.SelectedIndex)]);
            BtnEliminar.Enabled = true;
        }

        private void CargarDetalles(Factura factura)
        {
            DtgDetalles.Rows.Clear();
            DataTable tabla = DaoFacturas.Instancia().ReadDetalle(factura.IdFactura);
            foreach(DataRow item in tabla.Rows)
            {
                Producto p = DaoProductos.Instancia().ReadConIndice(Convert.ToInt32(item[2]));
                DtgDetalles.Rows.Add(new object[] { item[2], p.Descripcion, item[3], item[4] });
            }
        }

        private void CboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboClientes();
            DataRowView item = (DataRowView)CboTipoCliente.SelectedItem;
            if (Convert.ToInt32(item[0]) == 4)
            {
                TxtDescuento.Text = "10";
            }
            else
            {
                TxtDescuento.Text = "0";
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
                if (DaoFacturas.Instancia().Delete(lFacturas[Convert.ToInt32(LstFacturas.SelectedIndex)]))
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
