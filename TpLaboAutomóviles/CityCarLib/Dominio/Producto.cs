using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCarLib.Dominio
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int Stock_Min { get; set; }
        public int Stock_Actual { get; set; }
        public double Precio { get; set; }
        public int IdTipoProducto { get; set; }
    }
}
