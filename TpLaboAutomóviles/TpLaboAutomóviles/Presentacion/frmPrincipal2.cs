using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLaboAutomóviles.Reportes.Forms;
using TpLaboAutomóviles.Servicios.Factory;

namespace TpLaboAutomóviles.Presentacion
{
    public partial class frmPrincipal2 : Form
    {
        private ServiceFactory factory;
        public frmPrincipal2(ServiceFactory factory)
        {
            InitializeComponent();
            CustomizeDesign();
            this.factory = factory;
        }
        private void CustomizeDesign()
        {
            panelSoporteSubMenu.Visible = false;
            panelAcercade.Visible = false;
            panelFactura.Visible = false;
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
            new FrmAltaProducto(this.factory).ShowDialog();

            HideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmAltaCliente(this.factory).ShowDialog();
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FrmAltaFactura(this.factory).ShowDialog();
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FrmConsultarFacturas(this.factory).ShowDialog();
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FrmConsultarFacturas(this.factory).ShowDialog();
            HideSubMenu();
        }


        private void button17_Click(object sender, EventArgs e)
        {
            new FrmConsulta8(this.factory).ShowDialog();
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

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void btnReporte5_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void panelReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }
    }
}
