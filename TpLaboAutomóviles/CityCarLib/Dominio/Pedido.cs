using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCarLib.Dominio
{
    internal class Pedido
    {
        public List<Detalle_Pedido> lDetallesPedido;
        public int IdPedido { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaPedido { get; set; }
        public int IdCliente { get; set; }
        public Pedido()
        {
            lDetallesPedido = new List<Detalle_Pedido>();   
        }
        public void AgregarDetalle(Detalle_Pedido detalle)
        {
            lDetallesPedido.Add(detalle);
        }
        public void QuitarDetalle(int indice)
        {
            lDetallesPedido.RemoveAt(indice);
        }
    }
}
