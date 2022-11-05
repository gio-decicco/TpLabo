using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Datos.Concretas;
using TpLaboAutomóviles.Dominio;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Servicios.ServiciosConcretos
{
    internal class ClienteService : IServiceCliente
    {
        public bool AltaCliente(Cliente cliente)
        {
            return DaoClientes.Instancia().Create(cliente);
        }

        public bool BajaCliente(Cliente cliente)
        {
            return DaoClientes.Instancia().Delete(cliente);
        }

        public DataTable CargarBarrios()
        {
            return DaoClientes.Instancia().ReadBarrios();
        }

        public bool ModificacionCliente(Cliente cliente)
        {
            return DaoClientes.Instancia().Update(cliente);
        }

        public List<Cliente> ReadClientes()
        {
            return DaoClientes.Instancia().Read();
        }
    }
}
