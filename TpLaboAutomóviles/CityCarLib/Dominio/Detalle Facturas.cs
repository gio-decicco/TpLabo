using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCarLib.Dominio
{
    internal class Detalle_Facturas
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
    }
}
