using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityCarBackend.Dominio;
using CityCarBackEnd.Datos.Concretas;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Factory;
using CityCarBackEnd.Servicios.Interfaces;
using CityCarFrontend.Cliente;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace CityCarFrontEnd.Presentacion
{
    public partial class FrmAltaCliente : Form
    {
        IServiceCliente servicio;
        
        
        public FrmAltaCliente(ServiceFactory fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServiceCliente();
           
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Calle = txtCalle.Text;
            c.Altura = Convert.ToInt32(txtAltura.Text);
            c.Nombre = txtNombre.Text;
            c.Apellido=txtApellido.Text;
            Barrio b = (Barrio)cboBarrio.SelectedItem;
            c.IdBarrio = b.Id;
            string url = "http://localhost:5106/altaClientes";
            string clienteJson = JsonConvert.SerializeObject(c);
            try
            {
                await ClienteSingleton.Instancia().PostAsync(url, clienteJson);
                MessageBox.Show("Su cliente ha sido cargado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga de cliente");
            }
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            CargarComboBarrioAsync();
        }
        
        private async void CargarComboBarrioAsync()
        {
            var data = await ClienteSingleton.Instancia().GetAsync("http://localhost:5106/getBarrios");
            List<Barrio>lst= JsonConvert.DeserializeObject<List<Barrio>>(data);

            cboBarrio.DataSource = lst;
            cboBarrio.ValueMember = "Id";
            cboBarrio.DisplayMember = "Nombre";
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
