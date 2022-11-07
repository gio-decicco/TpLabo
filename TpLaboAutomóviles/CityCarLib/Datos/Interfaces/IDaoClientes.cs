using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CityCarBackEnd.Dominio;

namespace CityCarBackEnd.Datos.Interfaces
{
    internal interface IDaoClientes
    {
        bool Create(Cliente cliente);
        List<Cliente> Read();
        bool Delete(Cliente cliente);
        bool Update(Cliente cliente);
    }
}
