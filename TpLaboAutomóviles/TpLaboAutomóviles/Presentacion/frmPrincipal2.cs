using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLaboAutomóviles.Presentacion.Reportes.Forms;

namespace TpLaboAutomóviles.Presentacion
{
    public partial class frmPrincipal2 : Form
    {
        public frmPrincipal2()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelSoporteSubMenu.Visible = false;
            panelAcercade.Visible = false;
            panelFactura.Visible = false;
            panelPedido.Visible = false;
            panelReportes.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelSoporteSubMenu.Visible == true)
                panelSoporteSubMenu.Visible = false;
            if (panelAcercade.Visible == true)
                panelAcercade.Visible = false;
            if (panelFactura.Visible == true)
                panelFactura.Visible = false;
            if (panelPedido.Visible == true)
                panelPedido.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void frmPrincipal2_Load(object sender, EventArgs e)
        {

        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSoporteSubMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmAltaProducto().ShowDialog();
            
            HideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmAltaCliente().ShowDialog();
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FrmAltaFactura().ShowDialog();
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FrmConsultarFacturas().ShowDialog();
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FrmConsultarFacturas().ShowDialog();
            HideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new FrmReporte1().ShowDialog();
            HideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new FrmReporte2().ShowDialog();
            HideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new FrmReporte3().ShowDialog();
            HideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new FrmReporte4().ShowDialog();
            HideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new FrmReporte5().ShowDialog();
            HideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new FrmReporte6().ShowDialog();
            HideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new FrmReporte7().ShowDialog();
            HideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new FrmConsulta8().ShowDialog();
            HideSubMenu();
        }

        private void button20_Click(object sender, EventArgs e)
        {

            Form formBG = new Form();
            using (frmDesarrolladores frmD = new frmDesarrolladores())
            {
                formBG.StartPosition = FormStartPosition.Manual;
                formBG.FormBorderStyle = FormBorderStyle.None;
                formBG.Opacity = .70d;
                formBG.BackColor = Color.Black;
                formBG.WindowState = FormWindowState.Maximized;
                formBG.TopMost = true;
                formBG.Location = this.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                frmD.Owner = formBG;
                frmD.ShowDialog();

                formBG.Dispose();
                HideSubMenu();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFactura);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPedido);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAcercade);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere salir de la Aplicacion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
