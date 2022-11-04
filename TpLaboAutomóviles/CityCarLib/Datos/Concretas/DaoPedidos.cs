using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarLib.Datos.Interfaces;
using CityCarLib.Dominio;

namespace CityCarLib.Datos.Concretas
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
                cmd.Parameters.AddWithValue("@Activo", 1);
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

        public bool Delete(int nro)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spBorrarPedido";
                cmd.Parameters.AddWithValue("@nroPedido", nro);
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

        public List<Pedido> ConsultarPedidos(int id)
        {
            List<Pedido> pedidos = new List<Pedido>();
            string sp = "SP_CONSULTAR_PEDIDOS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@idCliente", id));
            DataTable tabla = consultaSql(sp, lst);

            foreach(DataRow row in tabla.Rows)
            {
                Pedido pedido = new Pedido();
                pedido.IdPedido = int.Parse(row[0].ToString());
                pedido.FechaOrden = Convert.ToDateTime(row[1].ToString());
                pedido.FechaPedido = Convert.ToDateTime(row[2].ToString());
                pedido.IdCliente = (int)row[3];
                pedidos.Add(pedido);
            }
            return pedidos;
        }
        public DataTable consultaSql(string NameSP, List<Parametro> values)
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = NameSP;
            if (values != null)
            {
                foreach(Parametro val in values)
                {
                    cmd.Parameters.AddWithValue(val.Clave, val.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public Pedido ConsultarPedidoPorNro(int idPedido)
        {
            Pedido pedido = new Pedido();
            string sp = "SP_CONSULTAR_PEDIDO_DETALLES";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@nroPedido", idPedido));

            DataTable tabla = consultaSql(sp, lst);

            foreach(DataRow fila in tabla.Rows)
            {
                Producto producto = new Producto();
                producto.IdProducto = Convert.ToInt32(fila["idProducto"].ToString());
                producto.Descripcion = fila["descripcion"].ToString();
                producto.Precio = Convert.ToDouble(fila["precio"].ToString());
                int cantidad = Convert.ToInt32(fila["cantidad"].ToString());
                Detalle_Pedido detalle = new Detalle_Pedido(producto, cantidad);
                pedido.AgregarDetalle(detalle);
            }
            return pedido;
        }
    }
}
