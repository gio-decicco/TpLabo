using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLaboAutomóviles.Dominio
{
    internal class Cliente
    {
        private int IdCliente { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Calle { get; set; }
        private int Altura { get; set; }
        private int IdBarrio { get; set; }
        private int IdAutoplan { get; set; }
        private int IdTipoCliente { get; set; }
    }
}
