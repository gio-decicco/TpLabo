using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CityCarLib.Datos.Interfaces;
using CityCarLib.Dominio;

namespace CityCarLib.Datos.Concretas
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

        public Producto ReadConIndice(int i)
        {
            DataTable tabla = new DataTable();
            Producto p = new Producto();
            Conectar();
            cmd.CommandText = "spConsultarConIndice";
            cmd.Parameters.AddWithValue("@idProducto", i);
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            foreach(DataRow item in tabla.Rows)
            {
                p.IdProducto = Convert.ToInt32(item[0]);
                p.Descripcion = Convert.ToString(item[1]);
                p.Stock_Min = Convert.ToInt32(item[2]);
                p.Stock_Actual = Convert.ToInt32(item[3]);
                p.Precio = Convert.ToDouble(item[4]);
                p.IdTipoProducto = Convert.ToInt32(item[5]);
            }
            return p;
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
        public DataTable ReadProductosConsulta8(int min, int max)
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "precio_productos";
            cmd.Parameters.AddWithValue("@precio1", min);
            cmd.Parameters.AddWithValue("@precio2", max);
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
