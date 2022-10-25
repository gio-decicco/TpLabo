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
            CargarLista();
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
            
        }

        private void CargarLista()
        {
            DataTable tabla = DaoFacturas.Instancia().Read();
            foreach (DataRow fila in tabla.Rows)
            {
                Factura f = new Factura();
                f.IdFactura = Convert.ToInt32(fila[0]);
                f.IdCliente = Convert.ToInt32(fila[1]);
                f.Fecha = Convert.ToDateTime(fila[2]);
                f.Descuento = Convert.ToInt32(fila[3]);
                f.IdAutoplan = Convert.ToInt32(fila[4]);
                f.FormaPago = Convert.ToInt32(fila[5]);
                DataTable tabla2 = DaoFacturas.Instancia().ReadDetalle(f.IdFactura);
                foreach (DataRow fila2 in tabla2.Rows)
                {
                    Detalle_Facturas d = new Detalle_Facturas();
                }
            }
        }

        private void LstFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboClientes();
        }
    }
}
