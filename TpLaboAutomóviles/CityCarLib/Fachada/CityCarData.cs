using CityCarBackend.Dominio;
using CityCarBackEnd.Datos.Concretas;
using CityCarBackEnd.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCarBackend.Fachada
{
    public class CityCarData : ICityCarData
    {
        public static CityCarData instancia;
        public CityCarData()
        {
            
        }
        public static CityCarData Instancia()
        {

            if (instancia == null)
                instancia = new CityCarData();
            return instancia;
        }

        public List<Barrio> GetBarrios()
        {
            return DaoClientes.Instancia().ReadBarrios();
        }
        
        public List<Cliente> GetClientes()
        {
            return DaoClientes.Instancia().Read();
        }

        public bool DeleteCliente(Cliente cliente)
        {
            return DaoClientes.Instancia().Delete(cliente);

        }

        public bool SaveCliente(Cliente cliente)
        {
            return DaoClientes.Instancia().Create(cliente);
        }

        public bool UpdateCliente(Cliente cliente)
        {
            return DaoClientes.Instancia().Update(cliente);
        }





        public List<Factura> GetFacturas(int idCliente)
        {
            return DaoFacturas.Instancia().Read(idCliente);
        }

        public bool DeleteFacturas(Factura factura)
        {
            return DaoFacturas.Instancia().Delete(factura);
        }
        
        public bool Savefactura(Factura factura)
        {
            return DaoFacturas.Instancia().Create(factura);
        }





        public bool Deleteproducto(Producto producto)
        {
            return DaoProductos.Instancia().Delete(producto);
        }

        public List<Producto> GetProductos()
        {
            return DaoProductos.Instancia().Read();
        }

        public bool SaveProducto(Producto producto)
        {
            return DaoProductos.Instancia().Create(producto);
        }

        public bool UpdateProducto(Producto producto)
        {
            return DaoProductos.Instancia().Update(producto);
        }
    }
}
