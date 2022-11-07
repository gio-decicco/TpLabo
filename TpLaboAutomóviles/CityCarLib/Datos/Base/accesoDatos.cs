using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackEnd.Dominio;

namespace CityCarBackEnd.Datos
{
    public class accesoDatos
    {
        protected SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-921LSJK\SQLEXPRESS01;Initial Catalog=automotriz;Integrated Security=True");
        protected SqlCommand cmd = new SqlCommand();
        protected SqlParameter param = new SqlParameter();

        protected void Conectar()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
        }
        protected void Desconectar()
        {
            cnn.Close();
        }
    }
}