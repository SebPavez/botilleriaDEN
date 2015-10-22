using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaClases;

namespace Data_Access_Layer
{
    class PersonaDAL
    {
        public Boolean BuscarUsername(string strUsername)
        {
            bool blnExiste = false;
            var context = new BotilleriaEntities();
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


        //generar ID nuevo desde procedimiento almacenado o método en DAL? 
        public Boolean GuardarPersona(Persona nuevaPersona)
        {
            if (!BuscarUsername(nuevaPersona.NombreUsuario))
            {
                var context = new BotilleriaEntities();
                List<Usuario> listaPersonas = context.Usuarios.ToList<Usuario>();
                listaPersonas.Add(new Usuario()
                {
                    id_usuario = listaPersonas.Count+1, //cambiar por método o procedimiento almacenado, ejemplo = ObtenerIdentificadorNuevo("ID", "ID");
                    nombre_usuario = nuevaPersona.NombreUsuario,
                    contrasenja_usuario = nuevaPersona.Password,
                    esAdministrador = nuevaPersona.Administrador,
                    Ventas = new System.Data.Objects.DataClasses.EntityCollection<Venta>()
                });
                context.SaveChanges();                
                return true;
            }
            else
                return false;
        }
    }
}
