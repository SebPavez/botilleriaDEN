using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;

namespace Data_Access_Layer
{
    public class BodegaDAL
    {
        public static List<Bebida> BuscarProductosEnBodega(int idBodega)
        {
            List<Bebida> listado = new List<Bebida>();
            using (var context = new WebBotilleriaEntities())
            {
                var relaciones = context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega);
                foreach (var item in relaciones)
                {
                    Bebida instancia = new Bebida();
                    instancia.ID = item.id_bebida_fk;
                    instancia.Nombre = item.Bebida.nombre_producto;
                    instancia.Marca = (Marca)item.Bebida.marca;
                    instancia.Precio = item.Bebida.precio;
                    instancia.GradosDeAlcohol = item.Bebida.grados_alcohol;
                    instancia.TipoProducto = (Tipo)item.Bebida.tipo;
                    instancia.Retornable = item.Bebida.es_retornable;
                    instancia.VolumenLitros = item.Bebida.volumen_litros;
                    instancia.Comentario = item.Bebida.comentario;
                    instancia.Cantidad = item.cantidad;
                    listado.Add(instancia);
                }
                return listado;
            }
        }

        public static Boolean EliminarProductoDeBodega(int idProducto, int idBodega) {
            using (var context = new WebBotilleriaEntities()) 
            {
                if (context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega).Where(c => c.id_bebida_fk == idProducto).FirstOrDefault().cantidad == 0)
                {
                    context.DeleteObject(context.DetalleBodegaLocals.Where(c => c.id_bodega_fk == idBodega).Where(c => c.id_bebida_fk == idProducto).FirstOrDefault());
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
        }

        public static Boolean AgregarNuevaBodega(Bodega nuevaBodega) {
            using (var context = new WebBotilleriaEntities())
            {
                context.Bodegas.AddObject(
                    new EntidadBodega()
                    {
                        id_bodega = GenerarNuevaIDBodega(),
                        nombre_bodega = nuevaBodega.NombreBodega,
                        direccion = nuevaBodega.DireccionBodega,
                        telefono = nuevaBodega.Telefono,
                        correo_electronico = nuevaBodega.CorreoBodega
                    }
                    );
                return true;
            }
        }

        public static int GenerarNuevaIDBodega() {
            using (var context = new WebBotilleriaEntities())
            {
                if (context.Bodegas.LastOrDefault() != null)
                {
                    int idBodega = context.Bodegas.LastOrDefault().id_bodega;
                    return idBodega + 1;
                }
                else
                    return 1;
            }
        }

        public static Boolean EliminarBodega(int idBodegaEliminar){
            using (var context = new WebBotilleriaEntities())
            {                
                foreach (Bebida item in BuscarProductosEnBodega(idBodegaEliminar))
                {
                    if (!EliminarProductoDeBodega(item.ID, idBodegaEliminar))
                        return false;
                }
                context.DeleteObject(context.Bodegas.FirstOrDefault().id_bodega == idBodegaEliminar);
                context.SaveChanges();
            }            
            return true;
        }
        //modificarDatosBodega(Bodega bodegaModificada)

        
    }
}
