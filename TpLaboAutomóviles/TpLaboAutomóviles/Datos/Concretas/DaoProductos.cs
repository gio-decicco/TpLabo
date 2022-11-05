﻿using System;
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
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
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
                p.Precio = Convert.ToInt32(item[2]);
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
                cmd.Parameters.AddWithValue("@id", producto.IdProducto);
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

        public List<Producto> Read()
        {
            List<Producto> list = new List<Producto>();
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "spConsultarProductos";
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            foreach (DataRow dr in tabla.Rows)
            {
                Producto p = new Producto();
                p.IdProducto = Convert.ToInt32(dr[0]);
                p.Descripcion = Convert.ToString(dr[1]);
                p.Precio = Convert.ToDouble(dr[2]);
                list.Add(p);
            }
            return list;
        }
        public List<Producto> ReadProductosConsulta8(int min, int max)
        {
            List<Producto> list = new List<Producto>();
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = "precio_productos";
            cmd.Parameters.AddWithValue("@precio1", min);
            cmd.Parameters.AddWithValue("@precio2", max);
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            foreach (DataRow dr in tabla.Rows)
            {
                Producto p = new Producto();
                p.IdProducto = Convert.ToInt32(dr[0]);
                p.Descripcion = Convert.ToString(dr[1]);
                p.Precio = Convert.ToDouble(dr[3]);
                list.Add(p);
            }
            return list;

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
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
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
