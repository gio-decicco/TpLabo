using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Dominio;

namespace TpLaboAutomóviles.Servicios.Interfaces
{
    public interface IServiceCliente
    {
        bool AltaCliente(Cliente cliente);
        bool BajaCliente(Cliente cliente);
        bool ModificacionCliente(Cliente cliente);
        List<Cliente> ReadClientes();
        DataTable CargarBarrios();
    }
}
