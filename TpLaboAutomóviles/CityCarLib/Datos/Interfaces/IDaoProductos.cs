﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackEnd.Dominio;

namespace CityCarBackEnd.Datos.Interfaces
{
    internal interface IDaoProductos
    {
        bool Create(Producto producto);
        List<Producto> Read();
        bool Delete(int id);
        bool Update(Producto producto);
        List<Producto> ReadProductosConsulta8(int min, int max);
    }
}
