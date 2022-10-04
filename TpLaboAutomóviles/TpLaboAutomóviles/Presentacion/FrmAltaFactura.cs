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
            cargarComboTipoCliente();
        }

        private void cargarComboTipoCliente()
        {
            CboTipoCliente.DataSource = DaoClientes.Instancia().ReadTipoCliente();
            CboTipoCliente.ValueMember = "idTipoCliente";
            CboTipoCliente.DisplayMember = "descripcion";
            CboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarComboCliente()
        {
            CboClientes.DataSource = DaoClientes.Instancia().Read(Convert.ToInt32(CboTipoCliente.SelectedValue));
            CboClientes.ValueMember = "idCliente";
            CboClientes.DisplayMember = "nomCliente";
            CboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
