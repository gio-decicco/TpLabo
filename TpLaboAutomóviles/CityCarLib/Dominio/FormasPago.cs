using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCarBackend.Dominio
{
    public class FormasPago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public FormasPago()
        {
            Id = 0;
            Descripcion = String.Empty;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
