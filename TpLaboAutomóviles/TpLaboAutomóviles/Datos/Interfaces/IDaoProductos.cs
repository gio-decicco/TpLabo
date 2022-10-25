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
        DataTable Read(int idTipoProducto);
        bool Delete(Producto producto);
        bool Update(Producto producto);
        DataTable ReadProductosConsulta8(double min, double max);
        DataTable ReadTiposProducto();
    }
}
