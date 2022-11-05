using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Datos.Concretas;
using TpLaboAutomóviles.Dominio;
using TpLaboAutomóviles.Servicios.Interfaces;

namespace TpLaboAutomóviles.Servicios.ServiciosConcretos
{
    internal class ProductoService : IServiceProducto
    {
        public bool AltaProducto(Producto producto)
        {
            return DaoProductos.Instancia().Create(producto);
        }

        public bool BajaProducto(Producto producto)
        {
            return DaoProductos.Instancia().Delete(producto);
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
