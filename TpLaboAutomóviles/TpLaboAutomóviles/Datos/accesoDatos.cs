using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLaboAutomóviles.Datos
{
    internal class accesoDatos
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public accesoDatos()
        {
            cnn = new SqlConnection(Properties.Resources.String1);
            cmd = new SqlCommand();
        }
        public void Conectar()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
        }
        public void Desconectar()
        {
            cnn.Close();
        }
    }
}
