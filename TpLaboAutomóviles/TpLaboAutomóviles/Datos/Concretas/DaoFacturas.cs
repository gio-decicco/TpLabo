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
    internal class DaoFacturas : accesoDatos, IDaoFacturas
    {
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
                cmd.Parameters.AddWithValue("@idAutoPlan", factura.IdAutoplan);
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

        public bool Delete(Factura factura)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "spBorrarFactura";
                cmd.Parameters.AddWithValue("@nroFactura", factura.IdFactura);
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

        public DataTable Read()
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarFacturas";
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
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
                cmd.Parameters.AddWithValue("@idAutoPlan", factura.IdAutoplan);
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
    }
}
