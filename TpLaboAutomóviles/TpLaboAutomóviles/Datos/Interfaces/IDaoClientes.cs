using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Dominio;

namespace TpLaboAutomóviles.Datos.Interfaces
{
    internal interface IDaoClientes
    {
        bool Create(Cliente cliente);
        List<Cliente> Read(int idTipoCliente);
        bool Delete(Cliente cliente);
        bool Update(Cliente cliente);
    }
}
