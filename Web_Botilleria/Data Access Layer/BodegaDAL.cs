using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;

namespace Data_Access_Layer
{
    public class BodegaDAL
    {
        public static Boolean agregarNuevaBodega(Bodega nuevaBodega) {
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
                if(context.Bodegas.LastOrDefault()!=null)
                    return (context.Bodegas.LastOrDefault().id_bodega)+1;
                else
                    return 1;
            }
        }

        //eliminarBodega
        //modificarDatosBodega(Bodega bodegaModificada
        
    }
}
