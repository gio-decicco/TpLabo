using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Dominio;

namespace TpLaboAutomóviles.Datos.Interfaces
{
    internal interface IDaoPedidos
    {
        bool Create(Pedido pedido);
        DataTable Read();
        bool Delete(Pedido pedido);
        bool Update(Pedido pedido);
    }
}
