using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackEnd.Datos.Concretas;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Interfaces;

namespace CityCarBackEnd.Servicios
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

        public List<Factura> GetFacturaList(int idCliente)
        {
            return DaoFacturas.Instancia().Read(idCliente);
        }
        public DataTable ReadFormaDePagoConId(int id)
        {
            return DaoFacturas.Instancia().ReadFormasPagoConId(id);
        }

        public int CargarProxId()
        {
            return DaoFacturas.Instancia().ConsultarProximoId();
        }

        public DataTable ReadFormaPago()
        {
            return DaoFacturas.Instancia().ReadFormasPago();
        }
    }
}
