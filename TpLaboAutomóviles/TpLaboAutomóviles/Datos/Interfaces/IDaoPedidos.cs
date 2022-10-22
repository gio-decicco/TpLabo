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
        bool Delete(int id);
        bool Update(Pedido pedido);
        List<Pedido> ConsultarPedidos(int id);
    }
}
