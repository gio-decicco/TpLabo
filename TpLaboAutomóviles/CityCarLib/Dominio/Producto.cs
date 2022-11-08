using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCarBackEnd.Dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public Producto()
        {
            IdProducto = 0;
            Descripcion = String.Empty;
            Precio = 0;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
