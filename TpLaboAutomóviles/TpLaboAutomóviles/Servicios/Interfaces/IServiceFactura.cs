using System;
using System.Collections.Generic;
using System.Data;
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
        List<Factura> GetFacturaList(int idCliente);
        DataTable ReadFormaDePagoConId(int id);
        DataTable ReadFormaPago();
        int CargarProxId();
    }
}
