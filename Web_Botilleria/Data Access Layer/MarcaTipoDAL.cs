using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;

namespace Data_Access_Layer
{
    public class MarcaTipoDAL
    {
        public Boolean AgregarTipo(Tipo nuevoTipo) {
            using (var context = new WebBotilleriaEntities())
            {
                context.TipoBebidas.AddObject(new TipoBebida() {id_tipo = (int)nuevoTipo, tipo= nuevoTipo.ToString() });
            }
            return true;
        }

        public Boolean AgregarMarca(Marca nuevaMarca) {
            using (var context = new WebBotilleriaEntities())
            {
                context.MarcaBebidas.AddObject(new MarcaBebida() {  id_marca= (int)nuevaMarca, marca = nuevaMarca.ToString() });
            }
            return true;
        }

    }
}
