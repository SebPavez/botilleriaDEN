using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;
using System.Data.Objects;

namespace Data_Access_Layer
{
    public class ConsultasDAL
    {
        public static List<Bebida> ConsultarPorNombre(int idBodega, String nombreProductoBuscado)
        {
            List<Bebida> productosEncontrandos = new List<Bebida>();
            var context = new BotilleriaEntities();
            var matching = context.BodegaLocals.Where(b => b.id_bodega == idBodega);
            var matchings = from c in context.Bebidas where c.nombre_producto == nombreProductoBuscado select c;
            if(matching != null){
                //IQueryable<Bebida> match = context.Bebidas.Where(c => c.nombre_producto == nombreProductoBuscado).Where(c => c.BodegaLocals. == idBodega);
                
            } 
                
            

        }

        public static List<Bebida> ConsultarPorNombre(String nombreProductoBuscado)
        {
            var context = new BotilleriaEntities();
            ObjectSet<Bebida> matchings = from c in context.Bebidas where c.nombre_producto == nombreProductoBuscado select c;

        }
        //public static List<Producto> ConsultarStockDeMarca(String marcaProductoBuscado)
        //{
        //    List<Producto> arrSalida = new List<Producto>();
        //    ArrayList arrTodos = MotorXML.getIntancia().BuscarTodos(new Producto());
        //    foreach (Producto item in arrTodos)
        //    {
        //        Producto productoActual = (Producto)item;
        //        if (productoActual.Marca.ToUpper().Contains(marcaProductoBuscado.ToUpper()))
        //            arrSalida.Add(productoActual);
        //    }
        //    return arrSalida;
        //}

        //public static List<Producto> ConsultarPorPrecio(int precioBuscado)
        //{
        //    List<Producto> arrSalida = new List<Producto>();
        //    ArrayList arrTodos = MotorXML.getIntancia().BuscarTodos(new Producto());
        //    foreach (Producto item in arrTodos)
        //    {
        //        Producto productoActual = (Producto)item;
        //        if (productoActual.Precio==precioBuscado)
        //            arrSalida.Add(productoActual);
        //    }
        //    return arrSalida;
        //}  
    }

}
