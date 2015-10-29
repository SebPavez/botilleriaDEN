using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;


namespace Data_Access_Layer
{
    class ProductoDAL
    {                
        public static Boolean ActualizarStock(int actualizacion, int idBodega, int idProducto)
        {            
            var context = new WebBotilleriaEntities();            
            BodegaLocal primeraMuestra = context.BodegaLocal.Where(c => c.id_bodega == idBodega).Where(c => c.producto_fk == idProducto).ToList<BodegaLocal>().FirstOrDefault();
            if (primeraMuestra.cantidad + actualizacion >= 0)
            {
                primeraMuestra.cantidad += actualizacion;
                context.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public static Boolean EliminarProducto(int idProducto)
        {
            using (var context = new WebBotilleriaEntities())
            {
                List<Bebidas> listaBebidas = context.Bebida.ToList<Bebidas>();
                if (listaBebidas.Where(s => s.id_bebida == idProducto).FirstOrDefault() != null)
                {
                    context.Bebida.DeleteObject(listaBebidas.Where(s => s.id_bebida == idProducto).FirstOrDefault());
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
                    context.Bebida.AddObject(new Bebidas()
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
                        });
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
            List<Bebidas> listaBebidas = context.Bebida.ToList<Bebidas>();
            foreach (var item in listaBebidas)
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
            using (var context = new WebBotilleriaEntities())
            {
                return context.Bebida.LastOrDefault().id_bebida;                
            }
        }
    }
}
