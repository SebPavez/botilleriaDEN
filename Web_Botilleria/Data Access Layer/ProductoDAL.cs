using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;

namespace Data_Access_Layer
{
    class ProductoDAL
    {        
        //Debería de hacerse boolean este método
        public void ActualizarStock(int actualizacion, int idBodega, int idProducto)
        {
            var context = new WebBotilleriaEntities();            
            BodegaLocal primeraMuestra = (BodegaLocal)(context.BodegaLocal.Where(c => c.id_bodega == idBodega).Where(c => c.producto_fk == idProducto).ToList<BodegaLocal>())[0];
            primeraMuestra.cantidad += actualizacion;
            context.SaveChanges();
        }

        public Boolean EliminarProducto(String idProducto)
        {
        //    MotorXML xml = MotorXML.getIntancia();
        //    xml.EliminarObjeto(this, "ID");
        //    xml.GuardarXMLArchivo();
            return true;
        }
                
        public Boolean ingresarBebida(Bebida nuevoProducto)
        {
            if (!BuscarNombreBebida(nuevoProducto.Nombre))
            {
                var context = new WebBotilleriaEntities();
                List<Bebidas> listaBebidas = context.Bebida.ToList<Bebidas>();
                listaBebidas.Add(new Bebidas()
                    {
                        id_bebida = ObtenerIDUltimaBebida() + 1,
                        nombre_producto = nuevoProducto.Nombre,
                        marca = (int)nuevoProducto.Marca,
                        volumen_litros = nuevoProducto.VolumenLitros,
                        precio = nuevoProducto.Precio,
                        tipo = (int)nuevoProducto.TipoProducto,
                        grados_alcohol = nuevoProducto.GradosDeAlcohol,
                        comentario = nuevoProducto.Comentario,
                        es_retornable = nuevoProducto.Retornable
                    });
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;
        }

        public Boolean BuscarNombreBebida(string nombreBebida)
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
        public int ObtenerIDUltimaBebida()
        {
            using (var context = new WebBotilleriaEntities())
            {
                return context.Bebida.LastOrDefault().id_bebida;                
            }
        }
    }
}
