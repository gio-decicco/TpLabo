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
            c.Calle = txtCalle.Text;
            c.Altura = Convert.ToInt32(txtAltura.Text);
            c.Nombre = txtNombre.Text;
            c.Apellido=txtApellido.Text;
            DataRowView item1 = (DataRowView)cboBarrio.SelectedItem;
            c.IdBarrio = Convert.ToInt32(item1[0]);
            DataRowView item2 = (DataRowView)cboTipoCliente.SelectedItem;
            c.IdTipoCliente = Convert.ToInt32(item2[0]);
            if (oDao.Create(c))
            {
                MessageBox.Show("Su cliente ha sido cargado con exito");
            }
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            CargarComboTipoClientes();
           
            CargarComboBarrio();
        }
        private void CargarComboTipoClientes()
        {
            cboTipoCliente.DataSource = oDao.ReadTipoClientes();
            cboTipoCliente.ValueMember = "idTipoCliente";
            cboTipoCliente.DisplayMember = "descripcion";
        }
        
        private void CargarComboBarrio()
        {
            cboBarrio.DataSource = oDao.ReadBarrio();
            cboBarrio.ValueMember = "idBarrio";
            cboBarrio.DisplayMember = "barrio";
        }
    }
}
