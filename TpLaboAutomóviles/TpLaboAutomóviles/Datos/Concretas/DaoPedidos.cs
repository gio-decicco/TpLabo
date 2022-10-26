using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLaboAutomóviles.Datos.Interfaces;
using TpLaboAutomóviles.Dominio;

namespace TpLaboAutomóviles.Datos.Concretas
{
    internal class DaoPedidos : accesoDatos, IDaoPedidos
    {
        private static DaoPedidos instancia;
        public static DaoPedidos Instancia()
        {
            if (instancia == null)
            {
                instancia = new DaoPedidos();
            }
            return instancia;
        }
        public bool Create(Pedido pedido)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "SpInsertarPedidoMaestro";
                cmd.Parameters.AddWithValue("@fechaOrden", pedido.FechaOrden);
                cmd.Parameters.AddWithValue("@fechaPedido", pedido.FechaPedido);
                cmd.Parameters.AddWithValue("@idCliente", pedido.IdCliente);
                SqlParameter param = new SqlParameter();
                param.Direction = ParameterDirection.Output;
                param.ParameterName = "@id";
                param.DbType = DbType.Int32;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int nro = (int)param.Value;
                int idDetalle = 1;
                foreach(Detalle_Pedido detalle in pedido.lDetallesPedido)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.CommandText = "spInsertarPedidoDetalle";
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.Transaction = t;
                    cmdDetalle.Parameters.AddWithValue("@nroPedido", nro);
                    cmdDetalle.Parameters.AddWithValue("@idDetallePedido", idDetalle);
                    cmdDetalle.Parameters.AddWithValue("@idProducto", detalle.Producto.IdProducto);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    idDetalle++;
                }
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
                    cnn.Close();
                }
            }
            return ok;
        }

        public bool Delete(Pedido pedido)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spBorrarPedido";
                cmd.Parameters.AddWithValue("@nroPedido", pedido.IdPedido);
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
                if(cnn.State == ConnectionState.Open)
                {
                    Desconectar();
                }
            }
            return ok;
        }

        public DataTable Read()
        {
            throw new NotImplementedException();
        }

        public bool Update(Pedido pedido)
        {
            throw new NotImplementedException();
        }
        public int ProximoId()
        {
            int nro = 0;
            SqlTransaction t = null;

            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spProximoPedido";
                SqlParameter param = new SqlParameter();
                param.Direction = ParameterDirection.Output;
                param.ParameterName = "@next";
                param.DbType = DbType.Int32;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                nro = param.Value.GetType() == typeof(int) ? (int)param.Value : 1;
                t.Commit();
            }
            catch (Exception)
            {
                nro = 1;
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    Desconectar();
                }
            }
            return nro;
        }
    }
}
