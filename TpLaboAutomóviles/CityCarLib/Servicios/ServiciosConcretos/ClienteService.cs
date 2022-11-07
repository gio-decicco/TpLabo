using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackend.Dominio;
using CityCarBackEnd.Datos.Concretas;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Interfaces;

namespace CityCarBackEnd.Servicios.ServiciosConcretos
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

        public List<Barrio> CargarBarrios()
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
