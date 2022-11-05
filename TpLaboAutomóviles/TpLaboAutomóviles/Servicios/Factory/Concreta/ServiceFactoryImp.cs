using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Servicios.Factory;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Servicios.Concreta
{
    internal class ServiceFactoryImp : ServiceFactory
    {
        private static ServiceFactoryImp instancia;
        public override IServiceFactura CrearService()
        {
            return new FacturaService();
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
