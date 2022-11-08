﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCarBackEnd.Dominio
{
    public class Detalle_Facturas
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }

        public Detalle_Facturas()
        {
            Producto = new Producto();
            Cantidad = 0;
            PrecioUnitario = 0;
        }
    }
}
