using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLaboAutomóviles.Dominio
{
    internal abstract class Producto
    {
        private int IdProducto { get; set; }
        private string Descripcion { get; set; }
        private int Stock_Min { get; set; }
        private int Stock_Max { get; set; }
        private double Precio { get; set; }
    }
}
