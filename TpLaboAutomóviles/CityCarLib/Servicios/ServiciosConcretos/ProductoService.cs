using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackEnd.Datos.Concretas;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Interfaces;

namespace CityCarBackEnd.Servicios.ServiciosConcretos
{
    internal class ProductoService : IServiceProducto
    {
        public bool AltaProducto(Producto producto)
        {
            return DaoProductos.Instancia().Create(producto);
        }

        public bool BajaProducto(int id)
        {
            return DaoProductos.Instancia().Delete(id);
        }

        public bool ModificacionProducto(Producto producto)
        {
            return DaoProductos.Instancia().Update(producto);
        }

        public List<Producto> ReadProductos()
        {
            return DaoProductos.Instancia().Read();
        }
        public List<Producto> ReadProductosPorPrecio(int max, int min)
        {
            return DaoProductos.Instancia().ReadProductosConsulta8(max, min);
        }
    }
}
