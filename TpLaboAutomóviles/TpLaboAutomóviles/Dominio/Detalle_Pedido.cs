using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLaboAutomóviles.Dominio
{
    internal class Detalle_Pedido
    {
        public Detalle_Pedido(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
        public double CalcularSubtotal()
        {
            return Producto.Precio * Cantidad;
        }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
