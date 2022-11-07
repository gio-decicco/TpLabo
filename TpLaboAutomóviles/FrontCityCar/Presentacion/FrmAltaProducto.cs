using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Datos;
using CityCarBackEnd.Datos.Concretas;
using CityCarBackEnd.Servicios.Factory;
using CityCarBackEnd.Servicios.Interfaces;
using Newtonsoft.Json;
using System.Linq.Expressions;
using CityCarFrontend.Cliente;

namespace CityCarFrontEnd.Presentacion
{
    public partial class FrmAltaProducto : Form
    {
        IServiceProducto servicio;
        public FrmAltaProducto(ServiceFactory fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServiceProducto();
        }
        
        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {

        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Descripcion = txtDescrpicion.Text;
            p.Precio = Convert.ToInt32(txtPrecio.Text);
            var productoJson = JsonConvert.SerializeObject(p);
            string url = "http://localhost:5106/CargarProductos";

            try
            {
                await ClienteSingleton.Instancia().PostAsync(url, productoJson);
                MessageBox.Show("Su producto ha sido cargado con exito");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ha habido un problema al cargar su producto");
            }
        }
        private void LimpiarCampos()
        {
            txtDescrpicion.Text = "";
            txtPrecio.Text = "";
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            new FrmActualizacionProducto(servicio).ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
