using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLaboAutomóviles.Dominio
{
    internal class Pedido
    {
        public List<Detalle_Pedido> lDetalles;
        public int IdPedido { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaPedido { get; set; }
        public Cliente Cliente { get; set; }
    }
}
