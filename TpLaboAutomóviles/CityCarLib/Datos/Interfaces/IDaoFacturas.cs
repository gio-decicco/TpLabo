using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarLib.Dominio;

namespace CityCarLib.Datos.Interfaces
{
    internal interface IDaoFacturas
    {
        bool Create(Factura factura);
        DataTable Read(int idCliente);
        bool Delete(Factura factura);
        bool Update(Factura factura);
    }
}
