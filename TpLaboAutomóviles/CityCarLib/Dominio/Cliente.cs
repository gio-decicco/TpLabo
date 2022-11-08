using CityCarBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CityCarBackEnd.Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int IdBarrio { get; set; }

        public Cliente()
        {
            IdCliente = 0;
            Nombre = String.Empty;
            Apellido = String.Empty;
            Calle = String.Empty;
            Altura = 0;
            IdBarrio = 0;
        }

        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }
    }
}
