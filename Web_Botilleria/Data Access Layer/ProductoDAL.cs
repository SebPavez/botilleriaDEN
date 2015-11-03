using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;


namespace Data_Access_Layer
{
    public class ProductoDAL
    {
        public static Boolean ActualizarStock(int actualizacion, int idBodega, int idProducto)
        {
            try
            {
                var context = new WebBotilleriaEntities();
                DetalleEnBodega detalle = context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega).Where(c => c.id_bebida_fk == idProducto).ToList<DetalleEnBodega>().FirstOrDefault();
                //if ((context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega).Where(c => c.id_bebida_fk == idProducto).ToList<DetalleEnBodega>().FirstOrDefault()) != null)
                if (detalle != null)
                {
                    //if (context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega).Where(c => c.id_bebida_fk == idProducto).ToList<DetalleEnBodega>().First().cantidad + actualizacion >= 0)
                    if (detalle.cantidad + actualizacion >= 0)
                    {
                        //context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega).Where(c => c.id_bebida_fk == idProducto).ToList<DetalleEnBodega>().First().cantidad += actualizacion;
                        detalle.cantidad += actualizacion;
                        context.SaveChanges();
                        return true;
                    }
                }
                else
                {
                    if (actualizacion >= 0 && context.Bodegas.Where(c => c.id_bodega == idBodega).FirstOrDefault() != null)
                    {
                        context.DetalleBodegaLocals.AddObject(DetalleEnBodega.CreateDetalleEnBodega(idBodega, idProducto, actualizacion));
                        context.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public static Boolean EliminarProducto(int idProducto)
        {
            using (var context = new WebBotilleriaEntities())
            {
                List<EntidadBebida> listaBebidas = context.Bebidas.ToList<EntidadBebida>();
                if (listaBebidas.Where(s => s.id_bebida == idProducto).FirstOrDefault() != null)
                {
                    context.Bebidas.DeleteObject(listaBebidas.Where(s => s.id_bebida == idProducto).FirstOrDefault());
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
        }

        public static Boolean ingresarBebida(Bebida nuevoProducto)
        {
            if (!BuscarNombreBebida(nuevoProducto.Nombre))
            {
                using (var context = new WebBotilleriaEntities())
                {
                    EntidadBebida bebida = new EntidadBebida()
                    {
                        id_bebida = ObtenerIDUltimaBebida() + 1,
                        nombre_producto = nuevoProducto.Nombre,
                        marca = (int)nuevoProducto.Marca,
                        volumen_litros = (float)nuevoProducto.VolumenLitros,
                        precio = (float)nuevoProducto.Precio,
                        tipo = (int)nuevoProducto.TipoProducto,
                        grados_alcohol = (float)nuevoProducto.GradosDeAlcohol,
                        comentario = nuevoProducto.Comentario,
                        es_retornable = nuevoProducto.Retornable
                    };
                    context.Bebidas.AddObject(bebida);
                    context.SaveChanges();
                    return true;
                }
            }
            else
                return false;
        }

        public static Boolean BuscarNombreBebida(string nombreBebida)
        {
            bool existe = false;
            var context = new WebBotilleriaEntities();
            List<EntidadBebida> listaEBebidas = context.Bebidas.ToList<EntidadBebida>();
            foreach (var item in listaEBebidas)
            {
                if (item.nombre_producto.Equals(nombreBebida))
                {
                    existe = true;
                    return existe;
                }
            }
            return existe;
        }

        public static int ObtenerIDUltimaBebida()
        {
            using (var context = new WebBotilleriaEntities("name=WebBotilleriaEntities"))
            {
                var conjunto = context.Bebidas.ToList<EntidadBebida>().LastOrDefault();
                if (conjunto == null)
                    return 0;
                else
                {
                    int id = conjunto.id_bebida;
                    return id;
                }

            }
        }
    }
}
