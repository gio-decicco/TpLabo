using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Dominio;

namespace TpLaboAutomóviles.Servicios.Interfaces
{
    public interface IServiceFactura
    {
        bool BajaFactura(Factura factura);
        bool AltaFactura(Factura factura);
    }
}
