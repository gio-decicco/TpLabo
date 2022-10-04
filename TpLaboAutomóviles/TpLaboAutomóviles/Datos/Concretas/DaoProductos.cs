using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Datos.Interfaces;
using TpLaboAutomóviles.Dominio;

namespace TpLaboAutomóviles.Datos.Concretas
{
    internal class DaoProductos : accesoDatos, IDaoProductos
    {
        public bool Create(Producto producto)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spInsertarProducto";
                cmd.Parameters.AddWithValue("@descripcion", producto.);
            }
        }

        public bool Delete(Producto producto)
        {
            throw new NotImplementedException();
        }

        public DataTable Read(int idTipoProducto)
        {
            throw new NotImplementedException();
        }

        public bool Update(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
