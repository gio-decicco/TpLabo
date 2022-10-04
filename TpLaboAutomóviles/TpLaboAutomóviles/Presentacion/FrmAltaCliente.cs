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
        
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
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
            else
            {
                MessageBox.Show("Error en la carga de cliente");
            }
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            CargarComboTipoClientes();
           
            CargarComboBarrio();
        }
        private void CargarComboTipoClientes()
        {
            cboTipoCliente.DataSource = DaoClientes.Instancia().ReadTipoCliente();
            cboTipoCliente.ValueMember = "idTipoCliente";
            cboTipoCliente.DisplayMember = "descripcion";
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        private void CargarComboBarrio()
        {
            cboBarrio.DataSource = DaoClientes.Instancia().ReadBarrios();
            cboBarrio.ValueMember = "idBarrio";
            cboBarrio.DisplayMember = "barrio";
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
