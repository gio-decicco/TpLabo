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

namespace TpLaboAutomóviles.Presentacion
{
    public partial class FrmAltaProducto : Form
    {
        Producto p;
        public FrmAltaProducto()
        {
            InitializeComponent();
            p= new Producto();
            
        }
        
        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            p.Descripcion = txtDescrpicion.Text;
            p.Precio = Convert.ToInt32(txtPrecio.Text);
            DataRowView item = (DataRowView)cboTipoProd.SelectedItem;
            p.IdTipoProducto = Convert.ToInt32(item[0]);
            p.Stock_Min = Convert.ToInt32(txtStockMinimo.Text);
            p.Stock_Actual=Convert.ToInt32(txtStockActual.Text);

            if (DaoProductos.Instancia().Create(p))
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
            txtStockActual.Text = "";
            txtStockMinimo.Text = "";
            cboTipoProd.SelectedValue = -1;
        }
         
        private void CargarCombo()
        {
            cboTipoProd.DataSource = DaoProductos.Instancia().ReadTiposProducto();
            cboTipoProd.ValueMember= "idTipoProducto";
            cboTipoProd.DisplayMember = "descripcion";
        }


        
    }
}
