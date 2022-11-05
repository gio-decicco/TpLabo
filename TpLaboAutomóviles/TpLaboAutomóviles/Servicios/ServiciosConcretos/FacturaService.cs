using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Datos.Concretas;
using TpLaboAutomóviles.Dominio;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Servicios
{
    public class FacturaService : IServiceFactura
    {
        public bool BajaFactura(Factura factura)
        {
            return DaoFacturas.Instancia().Delete(factura);
        }
        public bool AltaFactura(Factura factura)
        {
            return DaoFacturas.Instancia().Create(factura);
        }
    }
}
