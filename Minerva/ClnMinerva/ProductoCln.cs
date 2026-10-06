using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class ProductoCln
    {
        public static int crear(Producto producto)
        {
            using (var context = new MinervaEntities())
            {
                var existe = context.Producto.Where(x => x.codigo == producto.codigo).FirstOrDefault();
                if (existe != null) throw new Exception($"El producto {producto.codigo} ya existe");

                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var context = new MinervaEntities())
            {
                var existe = context.Producto.Find(producto.id);
                if (existe == null) throw new Exception($"El producto con id {producto.id} no existe");

                existe.idUnidadMedida = producto.idUnidadMedida;
                existe.codigo = producto.codigo;
                existe.descripcion = producto.descripcion;
                existe.saldo = producto.saldo;
                existe.precioVenta = producto.precioVenta;
                existe.usuarioRegistro = producto.usuarioRegistro;

                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new MinervaEntities())
            {
                var existe = context.Producto.Find(id);
                if (existe == null) throw new Exception($"El producto con id {id} no existe");

                existe.estado = (short)Estado.Eliminado;
                existe.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }

        public static Producto obtenerUno(int id)
        {
            using (var context = new MinervaEntities())
            {
                var producto = context.Producto.Find(id);
                if (producto == null) throw new Exception($"El producto con id {id} no existe");
                return producto;
            }
        }

        public static List<Producto> listar()
        {
            using (var context = new MinervaEntities())
            {
                return context.Producto.Where(x => x.estado == (short)Estado.Activo).OrderBy(x => x.descripcion).ToList();
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro)
        {
            using (var context = new MinervaEntities())
            {
                return context.paProductoListar(parametro.Trim()).ToList();
            }
        }
    }
}
