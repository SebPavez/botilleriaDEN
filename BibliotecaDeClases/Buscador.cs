using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Dato;

namespace BibliotecaDeClases
{
    [Serializable]
    public class Buscador
    {       

        public static List<Producto> ConsultarParteNombre(String nombreProductoBuscado)
        {
            List<Producto> arrSalida = new List<Producto>();
            ArrayList arrTodos = MotorXML.getIntancia().BuscarTodos(new Producto());
            foreach ( Producto item in arrTodos)
            {
                Producto productoActual = (Producto)item;
                if (productoActual.Nombre.ToUpper().Contains(nombreProductoBuscado.ToUpper()))
                    arrSalida.Add(productoActual);
            }
            return arrSalida;
        }

        public static List<Producto> ConsultarStockDeMarca(String marcaProductoBuscado)
        {
            List<Producto> arrSalida = new List<Producto>();
            ArrayList arrTodos = MotorXML.getIntancia().BuscarTodos(new Producto());
            foreach (Producto item in arrTodos)
            {
                Producto productoActual = (Producto)item;
                if (productoActual.Marca.ToUpper().Contains(marcaProductoBuscado.ToUpper()))
                    arrSalida.Add(productoActual);
            }
            return arrSalida;
        }

        public static List<Producto> ConsultarPorPrecio(int precioBuscado)
        {
            List<Producto> arrSalida = new List<Producto>();
            ArrayList arrTodos = MotorXML.getIntancia().BuscarTodos(new Producto());
            foreach (Producto item in arrTodos)
            {
                Producto productoActual = (Producto)item;
                if (productoActual.Precio==precioBuscado)
                    arrSalida.Add(productoActual);
            }
            return arrSalida;
        }

        
    }
}
