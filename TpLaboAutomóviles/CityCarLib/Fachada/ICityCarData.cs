using CityCarBackend.Dominio;
using CityCarBackEnd.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCarBackend.Fachada
{
    public interface ICityCarData
    {
        public List<Barrio> GetBarrios();
        public List<Cliente> GetClientes();
        public bool SaveCliente(Cliente cliente);
        public bool DeleteCliente(Cliente cliente);
        public bool UpdateCliente(Cliente cliente);

        public bool SaveProducto(Producto producto);
        List<Producto> GetProductos();
        bool Deleteproducto(Producto producto);
        bool UpdateProducto(Producto producto);

        bool Savefactura(Factura factura);
        List<Factura> GetFacturas(int idCliente);
        bool DeleteFacturas(Factura factura);
        

    }
}
