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
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Factory;
using CityCarBackEnd.Servicios.Interfaces;
using CityCarFrontend.Cliente;
using Newtonsoft.Json;

namespace CityCarFrontEnd.Presentacion
{
    public partial class FrmActualizacionCliente : Form
    {
        IServiceCliente servicio;
        
        //teoricamente no va así, hay que ponerlo en el principal
        public FrmActualizacionCliente(IServiceCliente servicio/*ServiceFactory fabrica*/)
        {
            InitializeComponent();
            //servicio = fabrica.CrearServiceCliente();
            this.servicio = servicio;
        }

        private void FrmActualizacionCliente_Load(object sender, EventArgs e)
        {
            cargarLista();
            cargarComboBarrios();
        }

        private async void cargarComboBarrios()
        {
            var data = await ClienteSingleton.Instancia().GetAsync("http://localhost:5106/getBarrios");
            List<Barrio> lst = JsonConvert.DeserializeObject<List<Barrio>>(data);
            CboBarrios.DataSource = lst;
            CboBarrios.DisplayMember = "Nombre";
            CboBarrios.ValueMember = "Id";
            CboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void cargarLista()
        {
           
            var data = await ClienteSingleton.Instancia().GetAsync("http://localhost:5106/getClientes");
            List<Cliente> lst= JsonConvert.DeserializeObject<List<Cliente>>(data);
            LstClientes.DataSource = lst; ;
            
               
        }

        private void LstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos();
        }

        private void cargarCampos()
        {
            Cliente cliente = (Cliente)LstClientes.SelectedItem;
            if (cliente != null)
            {
                TxtNombre.Text = cliente.Nombre;
                TxtApellido.Text = cliente.Apellido;
                TxtCalle.Text = cliente.Calle;
                TxtAltura.Text = Convert.ToString(cliente.Altura);
                CboBarrios.SelectedValue = cliente.IdBarrio;
            }
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            GroupLista.Enabled = false;
            GroupDatos.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnConfirmar.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            GroupLista.Enabled = true;
            GroupDatos.Enabled = false;
            BtnModificar.Enabled = true;
            BtnCancelar.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnConfirmar.Enabled = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¡Está a punto de eliminar este cliente!", "Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)  == DialogResult.Yes)
            {
                Cliente c = (Cliente)LstClientes.SelectedItem;
                if (c != null)
                {
                    try
                    {
                        await ClienteSingleton.Instancia().DeleteAsync("http://localhost:5106/BorrarClientes/"+c.IdCliente);
                        MessageBox.Show("Se eliminó el cliente.");
                        cargarLista();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el cliente");
                    }
                }
            }
        }

        private async void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (MessageBox.Show("Confirme la modificacion del cliente", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Cliente c = new Cliente();
                    Cliente cliente = (Cliente)LstClientes.SelectedItem;
                    c.IdCliente = cliente.IdCliente;
                    c.Nombre = TxtNombre.Text;
                    c.Apellido = TxtApellido.Text;
                    c.Calle = TxtCalle.Text;
                    c.Altura = Convert.ToInt32(TxtAltura.Text);
                    c.IdBarrio = Convert.ToInt32(CboBarrios.SelectedValue);
                    string url = "http://localhost:5106/ModificarClientes";
                    string clienteJson = JsonConvert.SerializeObject(c);
                    try 
                    {
                        await ClienteSingleton.Instancia().PutAsync(url, clienteJson);                    
                        MessageBox.Show("Se actualizo el cliente con éxito");
                        cargarLista();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo actualizar el cliente");
                    }
                }
            }
        }

        private bool validar()
        {
            if (CboBarrios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un barrio");
                return false;
            }
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("Escriba un nombre");
                return false;
            }
            if (TxtApellido.Text == "")
            {
                MessageBox.Show("Escriba un apellido");
                return false;
            }
            if (TxtCalle.Text == "")
            {
                MessageBox.Show("Escriba una calle");
                return false;
            }
            if (TxtAltura.Text == "")
            {
                MessageBox.Show("Escriba una altura de calle");
                return false;
            }
            try
            {
                int.Parse(TxtAltura.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un valor numerico para la altura");
                return false;
            }
            return true;
        }
    }
}
