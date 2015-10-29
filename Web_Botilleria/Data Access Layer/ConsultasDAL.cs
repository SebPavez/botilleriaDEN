using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Data.Objects;
using BibliotecaClases;

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
                    bebida.Cantidad = context.BodegaLocal.Where(c => c.id_bodega == idBodega).ToList<BodegaLocal>().FirstOrDefault().cantidad;
                    if (bebida.Cantidad == null)
                        bebida.Cantidad = 0;
                    bebida.TipoProducto = (Tipo)Enum.Parse(typeof(Tipo), item.TipoBebida.tipo, true);
                    bebida.GradosDeAlcohol = item.grados_alcohol;
                    bebida.Comentario = item.comentario;
                    bebida.Retornable = item.es_retornable;
                    resultado.Add(bebida);
                }
            }                 
            return resultado;
        }

        public static List<Bebida> ConsultarStockDeMarca(String marcaProductoBuscado, int idBodega)
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
                bebida.Cantidad = context.BodegaLocal.Where(c => c.id_bodega == idBodega).ToList<BodegaLocal>().FirstOrDefault().cantidad;
                if (bebida.Cantidad == null)
                    bebida.Cantidad = 0;
                bebida.TipoProducto = (Tipo)Enum.Parse(typeof(Tipo), item.TipoBebida.tipo, true);
                bebida.GradosDeAlcohol = item.grados_alcohol;
                bebida.Comentario = item.comentario;
                bebida.Retornable = item.es_retornable;
                resultado.Add(bebida);
            }
            return resultado;
        }

        public static List<Bebida> ConsultarPorPrecioExacto(int precioBuscado, int idBodega)
        {
            List<Bebida> resultado = new List<Bebida>();
            var context = new WebBotilleriaEntities();            
            foreach (var item in (from c in context.Bebida where c.precio == precioBuscado select c))
            {
                Bebida bebida = new Bebida();
                bebida.ID = item.id_bebida;
                bebida.Nombre = item.nombre_producto;
                bebida.Precio = item.precio;
                bebida.Marca = (Marca)Enum.Parse(typeof(Marca), item.MarcaBebida.marca, true);
                bebida.VolumenLitros = item.volumen_litros;
                bebida.Cantidad = context.BodegaLocal.Where(c => c.id_bodega == idBodega).ToList<BodegaLocal>().FirstOrDefault().cantidad;
                if (bebida.Cantidad == null)
                    bebida.Cantidad = 0;
                bebida.TipoProducto = (Tipo)Enum.Parse(typeof(Tipo), item.TipoBebida.tipo, true);
                bebida.GradosDeAlcohol = item.grados_alcohol;
                bebida.Comentario = item.comentario;
                bebida.Retornable = item.es_retornable;
                resultado.Add(bebida);
            }
            return resultado;
        }
        
        public static List<Bebida> ConsultarPorPrecioExactoGeneral(int precioBuscado) {
            List<Bebida> resultado = new List<Bebida>();
            using (var context = new WebBotilleriaEntities())
            {
                foreach (int id in (from c in context.BodegaLocal select c.id_bodega))
                {
                    resultado.AddRange(ConsultarPorPrecioExacto(precioBuscado, id));
                }
            }
            return resultado;
        }       
        
        public static List<Bebida> ConsultarStockDeMarcaGeneral(String marcaProductoBuscado) {
            List<Bebida> resultado = new List<Bebida>();
            using (var context = new WebBotilleriaEntities())
            {
                foreach (int id in (from c in context.BodegaLocal select c.id_bodega))
                {
                    resultado.AddRange(ConsultarStockDeMarca(marcaProductoBuscado,id);
                }
            }
            return resultado;

        }

        public static List<Bebida> ConsultarStockPorNombreGeneral(String nombreProductoBuscado) {
            List<Bebida> resultado = new List<Bebida>();
            using (var context = new WebBotilleriaEntities())
            {
                foreach(int id in (from c in context.BodegaLocal select c.id_bodega))
                {
                    resultado.AddRange(ConsultarPorNombre(id, nombreProductoBuscado));
                }
            }
            return resultado;
        }
    }

}
