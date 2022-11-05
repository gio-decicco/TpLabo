using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Dominio;

namespace TpLaboAutomóviles.Datos.Interfaces
{
    internal interface IDaoProductos
    {
        bool Create(Producto producto);
        List<Producto> Read(int idTipoProducto);
        bool Delete(Producto producto);
        bool Update(Producto producto);
        List<Producto> ReadProductosConsulta8(int min, int max);
    }
}
