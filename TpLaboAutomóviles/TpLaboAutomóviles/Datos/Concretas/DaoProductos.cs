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
    internal class DaoProductos : accesoDatos, IDaoProductos
    {
        private static DaoProductos instancia;
        public static DaoProductos Instancia()
        {
            if (instancia == null)
            {
                instancia = new DaoProductos();
            }
            return instancia;
        }
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
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@stock_min", producto.Stock_Min);
                cmd.Parameters.AddWithValue("@stock_actual", producto.Stock_Actual);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@idTipoProducto", producto.IdTipoProducto);
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

        public bool Delete(Producto producto)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spBorrarProducto";
                cmd.Parameters.AddWithValue("@idProducto", producto.IdProducto);
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

        public DataTable Read(int idTipoProducto)
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarProductos";
            cmd.Parameters.AddWithValue("@id", idTipoProducto);
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }
        public DataTable ReadTiposProducto()
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarTipoProducto";
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public bool Update(Producto producto)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spActualizarProducto";
                cmd.Parameters.AddWithValue("@idProducto", producto.IdProducto);
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@stock_min", producto.Stock_Min);
                cmd.Parameters.AddWithValue("@stock_actual", producto.Stock_Actual);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@idTipoProducto", producto.IdTipoProducto);
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
