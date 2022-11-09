using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackend.Dominio;
using CityCarBackEnd.Dominio;

namespace CityCarBackEnd.Servicios.Interfaces
{
    public interface IServiceFactura
    {
        bool BajaFactura(int id);
        bool AltaFactura(Factura factura);
        List<Factura> GetFacturaList(int idCliente);
        List<FormasPago> ReadFormaDePagoConId(int id);
        List<FormasPago> ReadFormaPago();
        int CargarProxId();
    }
}
