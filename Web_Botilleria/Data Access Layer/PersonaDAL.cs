using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;

namespace Data_Access_Layer
{
    public class PersonaDAL
    {
        public static Boolean BuscarUsername(string strUsername)
        {
            bool blnExiste = false;
            var context = new WebBotilleriaEntities();
            List<Usuario> listaPersonas = context.Usuarios.ToList<Usuario>(); 
            foreach (var item in listaPersonas)
            {
                if (item.nombre_usuario.Equals(strUsername))
                {
                    blnExiste = true;
                    return blnExiste;
                }
            }
            return blnExiste;
        }

        public static Boolean GuardarPersona(Persona nuevaPersona)
        {
            if (!BuscarUsername(nuevaPersona.NombreUsuario))
            {
                using (var context = new WebBotilleriaEntities())
                {
                    context.Usuarios.AddObject(Usuario.CreateUsuario(ObtenerIDUltimaPersona()+1,nuevaPersona.NombreUsuario,nuevaPersona.Password,nuevaPersona.Administrador));
                    context.SaveChanges();
                    return true;
                }
            }
            else
                return false;
        }

        public static int ObtenerIDUltimaPersona() 
        {
            using (var context = new WebBotilleriaEntities())
            {
                return context.Usuarios.LastOrDefault().id_usuario;                
            }
        }
    }
}
