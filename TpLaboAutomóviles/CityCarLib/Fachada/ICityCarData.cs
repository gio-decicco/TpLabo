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
        public List<FormasPago> ReadFormaPagoConId(int id);
        public List<Barrio> GetBarrios();
        public List<Cliente> GetClientes();
        public bool SaveCliente(Cliente cliente);
        public bool DeleteCliente(int id);
        public bool UpdateCliente(Cliente cliente);

        public bool SaveProducto(Producto producto);
        List<Producto> GetProductos();
        bool Deleteproducto(int id);
        bool UpdateProducto(Producto producto);

        bool Savefactura(Factura factura);
        List<Factura> GetFacturas(int idCliente);
        bool DeleteFacturas(int id);
        List<FormasPago> GetFormasPagos();
        int GetProximoId();
        

    }
}
