using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarLib.Dominio;

namespace CityCarLib.Datos.Interfaces
{
    internal interface IDaoProductos
    {
        bool Create(Producto producto);
        DataTable Read(int idTipoProducto);
        bool Delete(Producto producto);
        bool Update(Producto producto);
        DataTable ReadProductosConsulta8(int min, int max);
        DataTable ReadTiposProducto();
    }
}
