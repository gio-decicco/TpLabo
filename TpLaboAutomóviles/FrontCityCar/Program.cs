using CityCarFrontEnd.Presentacion;
using CityCarBackEnd.Servicios.Concreta;

namespace CityCarFrontEnd
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            frmLogin form = new frmLogin();
            form.ShowDialog();
            if (form.login)
            {
                form.Dispose();
                Application.Run(new frmBienvenido());
                Application.Run(new frmPrincipal2(new ServiceFactoryImp()));
                //Application.Run(new FrmPrincipal());
            }
        }
    }
}