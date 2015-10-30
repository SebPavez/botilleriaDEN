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
            var matchingBodega = context.DetalleBodegaLocals.Where(b => b.id_bodega_fk == idBodega).Where(c => c.Bebida.nombre_producto == nombreProductoBuscado);
            var matchingBebida = from c in context.Bebidas where c.nombre_producto == nombreProductoBuscado select c;
            if(matchingBodega != null){
                foreach(var item in matchingBebida){
                    Bebida bebida = new Bebida();
                    bebida.ID = item.id_bebida;
                    bebida.Nombre = item.nombre_producto;
                    bebida.Precio = item.precio;                    
                    bebida.Marca = (Marca) Enum.Parse(typeof(Marca), item.MarcaBebida.marca, true);
                    bebida.VolumenLitros = item.volumen_litros;
                    bebida.Cantidad = context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega).ToList<DetalleEnBodega>().FirstOrDefault().cantidad;                    
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
            List<EntidadBebida> matching = context.Bebidas.Where(c => c.MarcaBebida.marca == marcaProductoBuscado).ToList<EntidadBebida>();            
            foreach (EntidadBebida item in matching)
            {
                Bebida bebida = new Bebida();
                bebida.ID = item.id_bebida;
                bebida.Nombre = item.nombre_producto;
                bebida.Precio = item.precio;
                bebida.Marca = (Marca)Enum.Parse(typeof(Marca), item.MarcaBebida.marca, true);
                bebida.VolumenLitros = item.volumen_litros;
                bebida.Cantidad = context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega).ToList<DetalleEnBodega>().FirstOrDefault().cantidad;                
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
            foreach (var item in (from c in context.Bebidas where c.precio == precioBuscado select c))
            {
                Bebida bebida = new Bebida();
                bebida.ID = item.id_bebida;
                bebida.Nombre = item.nombre_producto;
                bebida.Precio = item.precio;
                bebida.Marca = (Marca)Enum.Parse(typeof(Marca), item.MarcaBebida.marca, true);
                bebida.VolumenLitros = item.volumen_litros;
                bebida.Cantidad = context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega).ToList<DetalleEnBodega>().FirstOrDefault().cantidad;                
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
                foreach (int id in (from c in context.DetalleBodegaLocals select c.id_bodega_fk))
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
                foreach (int id in (from c in context.DetalleBodegaLocals select c.id_bodega_fk))
                {
                    resultado.AddRange(ConsultarStockDeMarca(marcaProductoBuscado,id));
                }
            }
            return resultado;

        }

        public static List<Bebida> ConsultarStockPorNombreGeneral(String nombreProductoBuscado) {
            List<Bebida> resultado = new List<Bebida>();
            using (var context = new WebBotilleriaEntities())
            {
                foreach(int id in (from c in context.DetalleBodegaLocals select c.id_bodega_fk))
                {
                    resultado.AddRange(ConsultarPorNombre(id, nombreProductoBuscado));
                }
            }
            return resultado;
        }
    }

}
