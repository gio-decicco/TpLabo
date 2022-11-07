using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackEnd.Servicios.Interfaces;

namespace CityCarBackEnd.Servicios.Factory
{
    public abstract class ServiceFactory
    {
        public abstract IServiceFactura CrearServiceFactura();
        public abstract IServiceCliente CrearServiceCliente();
        public abstract IServiceProducto CrearServiceProducto();
    }
}
