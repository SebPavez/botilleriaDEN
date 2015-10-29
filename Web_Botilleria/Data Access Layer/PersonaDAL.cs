using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;

namespace Data_Access_Layer
{
    class PersonaDAL
    {
        public static Boolean BuscarUsername(string strUsername)
        {
            bool blnExiste = false;
            var context = new WebBotilleriaEntities();
            List<Usuario> listaPersonas = context.Usuario.ToList<Usuario>(); 
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
                    context.Usuario.AddObject(new Usuario()
                    {
                        id_usuario = ObtenerIDUltimaPersona() + 1,
                        nombre_usuario = nuevaPersona.NombreUsuario,
                        contrasenja_usuario = nuevaPersona.Password,
                        esAdministrador = nuevaPersona.Administrador
                    });
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
                return context.Usuario.LastOrDefault().id_usuario;                
            }
        }
    }
}
