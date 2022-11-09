using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCarBackend.Dominio;
using CityCarBackEnd.Datos.Interfaces;
using CityCarBackEnd.Dominio;

namespace CityCarBackEnd.Datos.Concretas
{
    public class DaoFacturas : accesoDatos, IDaoFacturas
    {
        private static DaoFacturas instancia;
        public static DaoFacturas Instancia()
        {
            if (instancia == null)
            {
                instancia = new DaoFacturas();
            }
            return instancia;
        }
        public List<FormasPago> ReadFormasPagoConId(int id)
        {
            List<FormasPago> lst = new List<FormasPago>();
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spReadFormasPagoConId";
            cmd.Parameters.AddWithValue("@id", id);
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            FormasPago f = new FormasPago();
            foreach (DataRow dr in tabla.Rows)
            {
                f.Id = Convert.ToInt32(dr[0]);
                f.Descripcion = Convert.ToString(dr[1]);
                lst.Add(f);
            }
            return lst;
        }
        public int ConsultarProximoId()
        {
            int nro = 0;

            try
            {
                Conectar();
                cmd.CommandText = "spProximoIdFactura";
                SqlParameter param = new SqlParameter();
                param.Direction = ParameterDirection.Output;
                param.ParameterName = "@id";
                param.DbType = DbType.Int32;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                nro = param.Value.GetType() == typeof(int) ? (int)param.Value : 1;
            }
            catch (Exception)
            {
                nro = 1;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    Desconectar();
                }
            }
            return nro;
        }
        public bool Create(Factura factura)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spInsertarFacturaMaestro";
                cmd.Parameters.AddWithValue("@idCliente", factura.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@descuento", factura.Descuento);
                cmd.Parameters.AddWithValue("@idFormaPago", factura.FormaPago);
                SqlParameter param = new SqlParameter();
                param.Direction = ParameterDirection.Output;
                param.ParameterName = "@id";
                param.DbType = DbType.Int32;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int nro = (int)param.Value;
                int idDetalle = 1;
                foreach (Detalle_Facturas detalle in factura.lDetalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.CommandText = "spInsertarFacturaDetalle";
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.Transaction = t;
                    cmdDetalle.Parameters.AddWithValue("@nroFactura", nro);
                    cmdDetalle.Parameters.AddWithValue("@idDetalleFactura", idDetalle);
                    cmdDetalle.Parameters.AddWithValue("@idProducto", detalle.Producto.IdProducto);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@pre_unitario", detalle.PrecioUnitario);
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

        public bool Delete(int id)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spBorrarFactura";
                cmd.Parameters.AddWithValue("@id", id);
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

        public List<Factura> Read(int idCliente)
        {
            List<Factura> facturas = new List<Factura>();
            DataTable tabla = new DataTable();
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spConsultarFacturas";
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                tabla.Load(cmd.ExecuteReader());
                cmd.Parameters.Clear();
                foreach (DataRow dr in tabla.Rows)
                {
                    Factura f = new Factura();
                    f.IdFactura = Convert.ToInt32(dr[0]);
                    f.Cliente = DaoClientes.Instancia().ReadConId(Convert.ToInt32(dr[1]));
                    f.Fecha = Convert.ToDateTime(dr[2]);
                    f.Descuento = Convert.ToInt32(dr[3]);
                    f.FormaPago = Convert.ToInt32(dr[4]);
                    cmd.CommandText = "spConsultarDetalle";
                    cmd.Parameters.AddWithValue("@idFactura", f.IdFactura);
                    DataTable tablaDetalle = new DataTable();
                    tablaDetalle.Load(cmd.ExecuteReader());
                    cmd.Parameters.Clear();
                    foreach (DataRow dr2 in tablaDetalle.Rows)
                    {
                        Detalle_Facturas d = new Detalle_Facturas();
                        d.Producto = DaoProductos.Instancia().ReadConIndice(Convert.ToInt32(dr2[2]));
                        d.Cantidad = Convert.ToInt32(dr2[3]);
                        d.PrecioUnitario = Convert.ToDouble(dr2[4]);
                        f.AgregarDetalle(d);
                    }
                    facturas.Add(f);
                }
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    Desconectar();
                }
            }
            return facturas;
        }

        public bool Update(Factura factura)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spActualizarFacturaMaestro";
                cmd.Parameters.AddWithValue("@nroFactura", factura.IdFactura);
                cmd.Parameters.AddWithValue("@idCliente", factura.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@descuento", factura.Descuento);
                cmd.Parameters.AddWithValue("@idFormaPago", factura.FormaPago);
                cmd.ExecuteNonQuery();
                int idDetalle = 1;
                foreach (Detalle_Facturas detalle in factura.lDetalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.CommandText = "spActualizarFacturaDetalle";
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.Transaction = t;
                    cmdDetalle.Parameters.AddWithValue("@nroFactura", factura.IdFactura);
                    cmdDetalle.Parameters.AddWithValue("@idDetalleFactura", idDetalle);
                    cmdDetalle.Parameters.AddWithValue("@idProducto", detalle.Producto.IdProducto);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@pre_unitario", detalle.PrecioUnitario);
                    cmdDetalle.ExecuteNonQuery();
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
        public List<FormasPago> ReadFormasPago()
        {
            List<FormasPago> list = new List<FormasPago>();
            DataTable dt = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarFormasPago";
            dt.Load(cmd.ExecuteReader());
            foreach (DataRow item in dt.Rows)
            {
                FormasPago fp = new FormasPago();
                fp.Id = Convert.ToInt32(item[0]);
                fp.Descripcion = Convert.ToString(item[1]);
                list.Add(fp);
            }
            Desconectar();
            return list;
        }
    }
}
