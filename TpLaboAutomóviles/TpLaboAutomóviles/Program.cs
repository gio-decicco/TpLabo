using AppConcesionaria.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLaboAutomóviles.Presentacion;

namespace TpLaboAutomóviles
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin form = new frmLogin();
            form.ShowDialog();
            if (form.login)
            {
                form.Dispose();
                Application.Run(new frmBienvenido());
                //Application.Run(new frmPrincipal2());
                Application.Run(new FrmPrincipal());
            }
        }
    }
}
