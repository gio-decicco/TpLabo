using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackEnd.Dominio;

namespace CityCarBackEnd.Servicios.Interfaces
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
