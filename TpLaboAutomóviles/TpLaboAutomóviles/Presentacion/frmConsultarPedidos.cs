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
    public partial class frmConsultarPedidos : Form
    {
        public frmConsultarPedidos()
        {
            InitializeComponent();
        }

        private void frmConsultarPedidos_Load(object sender, EventArgs e)
        {
            cargarTipoCliente();
        }

        private void cargarTipoCliente()
        {
            DataTable tabla = DaoClientes.Instancia().ReadTipoCliente();
            cboTipoCliente.DataSource = tabla;
            cboTipoCliente.ValueMember = "idTipoCliente";
            cboTipoCliente.DisplayMember = "descripcion";
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cboTipoCliente.SelectedItem;
            cargarComboCliente(Convert.ToInt32(item[0]));
        }

        private void cargarComboCliente(int id)
        {
            DataTable tabla = DaoClientes.Instancia().Read(id);
            cboCliente.DataSource = tabla;
            cboCliente.ValueMember = "idCliente";
            cboCliente.DisplayMember = "nomCliente";
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                dgvConsulta.Rows.Clear();
                DataRowView valor = (DataRowView)cboCliente.SelectedItem;
                List<Pedido> lst = DaoPedidos.Instancia().ConsultarPedidos((int)valor[0]);
                foreach(Pedido p in lst)
                {
                    dgvConsulta.Rows.Add(new object[] { p.IdPedido, p.FechaOrden.ToString("dd/MM/yyyy"), p.FechaPedido.ToString("dd/MM/yyyy"), valor[1].ToString() + " " + valor[2].ToString() });
                }
                
            }
        }

        private bool validar()
        {
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un Cliente !!");
                return false;
            }
            if (cboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un Tipo de Cliente !!");
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere Salir de las Consultas?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea quitar el Pedido seleccionado?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (dgvConsulta.CurrentRow != null)
                {
                    int nro = (int)dgvConsulta.CurrentRow.Cells[0].Value;
                    DaoPedidos.Instancia().Delete(nro);
                    MessageBox.Show("El Pedido se quitó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnConsultar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("El Pedido NO se quitó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
