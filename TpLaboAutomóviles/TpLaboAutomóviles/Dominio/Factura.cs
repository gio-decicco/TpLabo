using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLaboAutomóviles.Dominio
{
    internal class Factura
    {
        public List<Detalle_Facturas> lDetalles;
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int Descuento { get; set; }
        public int FormaPago { get; set; }
        public int IdAutoplan { get; set; }

        public Factura()
        {
            lDetalles = new List<Detalle_Facturas>();
            Fecha = DateTime.Today;
            Descuento = 0;
            FormaPago = 0;
            IdAutoplan = 0;
        }
        public void AgregarDetalle(Detalle_Facturas detalle)
        {
            lDetalles.Add(detalle);
        }
        public void QuitarDetalle(int indice)
        {
            lDetalles.RemoveAt(indice);
        }
    }
}
