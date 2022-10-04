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
    public partial class FrmAltaCliente : Form
    {
        DaoClientes oDao;
        Cliente c;
        
        public FrmAltaCliente()
        {
            InitializeComponent();
            oDao = new DaoClientes();
            c = new Cliente();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            CargarComboTipoClientes();
            CargarComboAutoPlanes();
            CargarComboBarrio();
        }
        private void CargarComboTipoClientes()
        {
            cboTipoCliente.DataSource = oDao.ReadTipoClientes();
            cboTipoCliente.ValueMember = "idTipoCliente";
            cboTipoCliente.DisplayMember = "descripcion";
        }
        private void CargarComboAutoPlanes()
        {
            cboTipoCliente.DataSource = oDao.ReadTipoClientes();
            cboTipoCliente.ValueMember = "idTipoCliente";
            cboTipoCliente.DisplayMember = "descripcion";
        }
        private void CargarComboBarrio()
        {
            cboTipoCliente.DataSource = oDao.ReadTipoClientes();
            cboTipoCliente.ValueMember = "idTipoCliente";
            cboTipoCliente.DisplayMember = "descripcion";
        }
    }
}
