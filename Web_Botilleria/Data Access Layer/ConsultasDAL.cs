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
            List<Bebida> resultado = new List<Bebida>();
            var context = new WebBotilleriaEntities();
            var matchingBodega = context.BodegaLocal.Where(b => b.id_bodega == idBodega).Where(c => c.Bebida.nombre_producto == nombreProductoBuscado);
            var matchingBebida = from c in context.Bebida where c.nombre_producto == nombreProductoBuscado select c;
            if(matchingBodega != null){
                foreach(var item in matchingBebida){
                    Bebida bebida = new Bebida();
                    bebida.ID = item.id_bebida;
                    bebida.Nombre = item.nombre_producto;
                    bebida.Precio = item.precio;                    
                    bebida.Marca = (Marca) Enum.Parse(typeof(Marca), item.MarcaBebida.marca, true);
                    bebida.VolumenLitros = item.volumen_litros;
                    foreach (var producto in matchingBodega)
                    {
                        if (producto.producto_fk == item.id_bebida)
                            bebida.Cantidad = producto.cantidad;                        
                    }
                    bebida.TipoProducto = (Tipo)Enum.Parse(typeof(Tipo), item.TipoBebida.tipo, true);
                    bebida.GradosDeAlcohol = item.grados_alcohol;
                    bebida.Comentario = item.comentario;
                    bebida.Retornable = item.es_retornable;
                    resultado.Add(bebida);
                }
            }                 
            return resultado;
        }

        public static List<Bebida> ConsultarPorNombre(String nombreProductoBuscado)
        {
            var context = new WebBotilleriaEntities();            
            List<Bebida> resultado = new List<Bebida>();
            var matchingBebida = from c in context.Bebida where c.nombre_producto == nombreProductoBuscado select c;            
            foreach (var item in matchingBebida)
            {
                Bebida bebida = new Bebida();
                bebida.ID = item.id_bebida;
                bebida.Nombre = item.nombre_producto;
                bebida.Precio = item.precio;
                bebida.Marca = (Marca) Enum.Parse(typeof(Marca), item.MarcaBebida.marca, true);
                bebida.VolumenLitros = item.volumen_litros;
                foreach (var producto in (from c in context.BodegaLocal where c.producto_fk == item.id_bebida select c))
                {
                    if (producto.producto_fk == item.id_bebida)
                        bebida.Cantidad = producto.cantidad;
                }
                bebida.TipoProducto = (Tipo) Enum.Parse(typeof(Tipo), item.TipoBebida.tipo, true);
                bebida.GradosDeAlcohol = item.grados_alcohol;
                bebida.Comentario = item.comentario;
                bebida.Retornable = item.es_retornable;
                resultado.Add(bebida);
            }
            return resultado;
        }


        public static List<Bebida> ConsultarStockDeMarca(String marcaProductoBuscado)
        {
            var context = new WebBotilleriaEntities();
            List<Bebida> resultado = new List<Bebida>();
            List<Bebidas> matching = context.Bebida.Where(c => c.MarcaBebida.marca == marcaProductoBuscado).ToList<Bebidas>();            
            foreach (Bebidas item in matching)
            {
                Bebida bebida = new Bebida();
                bebida.ID = item.id_bebida;
                bebida.Nombre = item.nombre_producto;
                bebida.Precio = item.precio;
                bebida.Marca = (Marca)Enum.Parse(typeof(Marca), item.MarcaBebida.marca, true);
                bebida.VolumenLitros = item.volumen_litros;
                foreach (var producto in (from c in context.BodegaLocal where c.producto_fk == item.id_bebida select c))
                {
                    if (producto.producto_fk == item.id_bebida)
                        bebida.Cantidad = producto.cantidad;
                }
                bebida.TipoProducto = (Tipo)Enum.Parse(typeof(Tipo), item.TipoBebida.tipo, true);
                bebida.GradosDeAlcohol = item.grados_alcohol;
                bebida.Comentario = item.comentario;
                bebida.Retornable = item.es_retornable;
                resultado.Add(bebida);
            }
            return resultado;
        }

        public static List<Bebida> ConsultarPorPrecio(int precioBuscado)
        {
            List<Bebida> resultado = new List<Bebida>();
            var context = new WebBotilleriaEntities();
            var matchings = from c in context.Bebida where c.precio == precioBuscado select c;
            foreach (var item in matchings)
            {
                Bebida bebida = new Bebida();
                bebida.ID = item.id_bebida;
                bebida.Nombre = item.nombre_producto;
                bebida.Precio = item.precio;
                bebida.Marca = (Marca)Enum.Parse(typeof(Marca), item.MarcaBebida.marca, true);
                bebida.VolumenLitros = item.volumen_litros;
                foreach (var producto in (from c in context.BodegaLocal where c.producto_fk == item.id_bebida select c))
                {
                    if (producto.producto_fk == item.id_bebida)
                        bebida.Cantidad = producto.cantidad;
                }
                bebida.TipoProducto = (Tipo)Enum.Parse(typeof(Tipo), item.TipoBebida.tipo, true);
                bebida.GradosDeAlcohol = item.grados_alcohol;
                bebida.Comentario = item.comentario;
                bebida.Retornable = item.es_retornable;
                resultado.Add(bebida);
            }
            return resultado;
        }  
    }

}
