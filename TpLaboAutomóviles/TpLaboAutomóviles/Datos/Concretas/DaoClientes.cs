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
                cmd.Parameters.AddWithValue("@idTipoCliente", cliente.IdTipoCliente);
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

        public DataTable Read(int idTipoCliente)
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarClientes";
            cmd.Parameters.AddWithValue("@idTipoCliente", idTipoCliente);
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }
        public DataTable ReadTipoCliente()
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarTipoCliente";
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;

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
                cmd.Parameters.AddWithValue("@idTipoCliente", cliente.IdTipoCliente);
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
    }
}
