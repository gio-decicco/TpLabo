using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLaboAutomóviles.Dominio
{
    internal class Factura
    {
        private List<Detalle_Facturas> lDetalles;
        private int IdFactura { get; set; }
        private Cliente Cliente { get; set; }
        private DateTime Fecha { get; set; }
        private int Descuento { get; set; }
        private int Interes { get; set; }
        private int Cuotas { get; set; }
        private int FormaPago { get; set; }

        public Factura()
        {
            this.Cliente = new Cliente();
            lDetalles = new List<Detalle_Facturas>();
            Fecha = DateTime.Today;
            Descuento = 0;
            Interes = 0;
            Cuotas = 0;
            FormaPago = 0;
        }
    }
}
