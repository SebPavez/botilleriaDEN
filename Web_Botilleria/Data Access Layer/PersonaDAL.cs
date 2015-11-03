using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;

namespace Data_Access_Layer
{
    public class PersonaDAL
    {
        public static Boolean BuscarUsername(string strUsername, out Persona instanciaPersona)
        {
            bool blnExiste = false;
            instanciaPersona = new Persona();
            var context = new WebBotilleriaEntities();
            List<Usuario> listaPersonas = context.Usuarios.ToList<Usuario>();
            foreach (var item in listaPersonas)
            {
                if (item.nombre_usuario.Equals(strUsername))
                {
                    blnExiste = true;
                    instanciaPersona.ID = item.id_usuario;
                    instanciaPersona.NombreUsuario = item.nombre_usuario;
                    instanciaPersona.Password = item.contrasenja_usuario;
                    instanciaPersona.Administrador = item.esAdministrador;
                    return blnExiste;
                }
            }
            return blnExiste;
        }

        public static Boolean GuardarPersona(Persona nuevaPersona)
        {
            Persona instancia = new Persona();
            if (!BuscarUsername(nuevaPersona.NombreUsuario, out instancia))
            {
                using (var context = new WebBotilleriaEntities())
                {
                    context.Usuarios.AddObject(Usuario.CreateUsuario(ObtenerIDUltimaPersona() + 1, nuevaPersona.NombreUsuario, nuevaPersona.Password, nuevaPersona.Administrador));
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
                var conjunto = context.Usuarios.ToList<Usuario>().LastOrDefault<Usuario>();
                if (conjunto == null)
                    return 0;
                else
                {
                    int id = conjunto.id_usuario;
                    return id;
                }


            }
        }
    }
}
