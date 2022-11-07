using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackEnd.Dominio;

namespace CityCarBackEnd.Datos.Interfaces
{
    internal interface IDaoFacturas
    {
        bool Create(Factura factura);
        List<Factura> Read(int idCliente);
        bool Delete(Factura factura);
    }
}
