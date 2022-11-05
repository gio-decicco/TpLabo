using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Datos.Interfaces;
using TpLaboAutomóviles.Dominio;

namespace TpLaboAutomóviles.Datos.Concretas
{
    internal class DaoClientes : accesoDatos,IDaoClientes
    {
        private static DaoClientes instancia;
        public static DaoClientes Instancia()
        {
            if (instancia == null)
            {
                instancia = new DaoClientes();
            }
            return instancia;
        }
        public bool Create(Cliente cliente)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                cmd.CommandText = "spInsertarCliente";
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Parameters.AddWithValue("@nomCliente", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apeCliente", cliente.Apellido);
                cmd.Parameters.AddWithValue("@calle", cliente.Calle);
                cmd.Parameters.AddWithValue("@altura", cliente.Altura);
                cmd.Parameters.AddWithValue("@idBarrio", cliente.IdBarrio);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    Desconectar();
                }
            }
            return ok;
        }

        public bool Delete(Cliente cliente)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                cmd.CommandText = "spBorrarCliente";
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    Desconectar();
                }
            }
            return ok;
        }
        public DataTable ReadBarrios()
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarBarrios";
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }
        public List<Cliente> Read(int idTipoCliente)
        {
            List<Cliente> lista = new List<Cliente>();
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarClientes";
            cmd.Parameters.AddWithValue("@id", idTipoCliente);
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return lista;
        }
        public bool Update(Cliente cliente)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                cmd.CommandText = "spActualizarCliente";
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                cmd.Parameters.AddWithValue("@nomCliente", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apeCliente", cliente.Apellido);
                cmd.Parameters.AddWithValue("@calle", cliente.Calle);
                cmd.Parameters.AddWithValue("@altura", cliente.Altura);
                cmd.Parameters.AddWithValue("@idBarrio", cliente.IdBarrio);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    Desconectar();
                }
            }
            return ok;
        }
        public Cliente ReadConId(int idCliente)
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarClientesConId";
            cmd.Parameters.AddWithValue("@id", idCliente);
            tabla.Load(cmd.ExecuteReader());
            Cliente c = new Cliente();
            foreach (DataRow dr in tabla.Rows)
            {
                c.IdCliente = Convert.ToInt32(dr[0]);
                c.Nombre = Convert.ToString(dr[1]);
                c.Apellido = Convert.ToString(dr[2]);
                c.Calle = Convert.ToString(dr[3]);
                c.Altura = Convert.ToInt32(dr[4]);
                c.IdBarrio = Convert.ToInt32(dr[5]);
            }
            return c;
        }
    }
}
