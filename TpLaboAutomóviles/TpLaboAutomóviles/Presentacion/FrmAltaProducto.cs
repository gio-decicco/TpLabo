using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLaboAutomóviles.Dominio;
using TpLaboAutomóviles.Datos;
using TpLaboAutomóviles.Datos.Concretas;
using TpLaboAutomóviles.Servicios.Factory;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Presentacion
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Descripcion = txtDescrpicion.Text;
            p.Precio = Convert.ToInt32(txtPrecio.Text);
            if (servicio.AltaProducto(p))
            {
                MessageBox.Show("Su producto ha sido cargado con exito");
                LimpiarCampos();
            }
            else
                MessageBox.Show("ha habido un problema al cargar su producto");
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
