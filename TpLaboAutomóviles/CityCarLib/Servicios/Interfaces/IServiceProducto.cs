using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackEnd.Dominio;

namespace CityCarBackEnd.Servicios.Interfaces
{
    public interface IServiceProducto
    {
        bool AltaProducto(Producto producto);
        bool BajaProducto(Producto producto);
        bool ModificacionProducto(Producto producto);
        List<Producto> ReadProductos();
        List<Producto> ReadProductosPorPrecio(int max, int min);
    }
}
