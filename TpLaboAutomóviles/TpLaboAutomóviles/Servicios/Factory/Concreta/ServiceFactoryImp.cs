using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Servicios.Factory;
using TpLaboAutomóviles.Servicios.Interfaces;
using TpLaboAutomóviles.Servicios.ServiciosConcretos;

namespace TpLaboAutomóviles.Servicios.Concreta
{
    internal class ServiceFactoryImp : ServiceFactory
    {
        private static ServiceFactoryImp instancia;
        public override IServiceFactura CrearServiceFactura()
        {
            return new FacturaService();
        }
        public override IServiceCliente CrearServiceCliente()
        {
            return new ClienteService();
        }

        public override IServiceProducto CrearServiceProducto()
        {
            return new ProductoService();
        }

        public static ServiceFactoryImp Instancia()
        {
            if (instancia == null)
            {
                instancia = new ServiceFactoryImp();
            }
            return instancia;
        }

        
    }
}
