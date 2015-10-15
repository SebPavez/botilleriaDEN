using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;

namespace Data_Access_Layer
{
    public class ConsultasDAL
    {
        public static List<Producto> ConsultarPorNombre(String nombreProductoBuscado)
        {
            using (var contexto = new BotilleriaEntities()) 
            {
                var matchings = from v in contexto.Bebidas where v.nombre_producto.Contains(nombreProductoBuscado) select v;
        //    List<Producto> arrSalida = new List<Producto>();
        //    ArrayList arrTodos = MotorXML.getIntancia().BuscarTodos(new Producto());
        //    foreach ( Producto item in arrTodos)
        //    {
        //        Producto productoActual = (Producto)item;
        //        if (productoActual.Nombre.ToUpper().Contains(nombreProductoBuscado.ToUpper()))
        //            arrSalida.Add(productoActual);
        //    }
        //    return arrSalida;
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
