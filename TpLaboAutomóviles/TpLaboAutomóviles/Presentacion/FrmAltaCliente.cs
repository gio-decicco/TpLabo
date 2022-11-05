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
using TpLaboAutomóviles.Servicios.Factory;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Presentacion
{
    public partial class FrmAltaCliente : Form
    {
        IServiceCliente servicio;
        
        public FrmAltaCliente(ServiceFactory fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServiceCliente();
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
            if (servicio.AltaCliente(c))
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
            CargarComboBarrio();
        }
        
        private void CargarComboBarrio()
        {
            cboBarrio.DataSource = servicio.CargarBarrios();
            cboBarrio.ValueMember = "idBarrio";
            cboBarrio.DisplayMember = "barrio";
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            new FrmActualizacionCliente(servicio).ShowDialog(); //mete este en el principal
        }
    }
}
