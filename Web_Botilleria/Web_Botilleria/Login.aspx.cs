using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaClases;
using Dato;

namespace Web_Botilleria
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                Button1.Enabled = false;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.NombreUsuario = "alexis.veas";
            persona.Administrador = false;
            persona.Password = "veas123";

            Persona persona2 = new Persona();
            persona2.NombreUsuario = "alan.munoz";
            persona2.Administrador = true;
            persona2.Password = "munoz123";

            Bebida primerProducto = new Bebida();
            primerProducto.Nombre = "stoli";
            primerProducto.Marca = "stoli s.a";
            primerProducto.VolumenLitros = 1.8;
            primerProducto.Cantidad = 60;
            primerProducto.Precio = 5990;
            primerProducto.TipoProducto = "vodka";
            primerProducto.GradosDeAlcohol = 50;
            primerProducto.Comentario = "";
            primerProducto.Retornable = false;


            persona.GuardarPersona();
            persona2.GuardarPersona();
            primerProducto.ingresarProducto(primerProducto);
        }

        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            String user = Login1.UserName.ToString().Trim();
            String pass = Login1.Password.ToString().Trim();            
            Persona persona = (Persona)MotorXML.getIntancia().Buscar(user, "NombreUsuario", new Persona());
            try
            {
                if (!persona.Equals(null))
                {
                    if (persona.Password.Equals(pass))
                    {
                        if (persona.Administrador)
                            Server.Transfer("InicioAdministrador.aspx", true);
                        else
                            Server.Transfer("InicioVendedor.aspx", true); 
                    }
                }
            }
            catch (Exception)
            {
                
            }
              
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("InicioAdministrador.aspx", true);
        }

        private Boolean validarDatos(String Nombre, String Pass)
        {
            if (Nombre.Equals(String.Empty))
            {
                lblSalida.Text = "Nombre de usuario vacio...";
                return false;
            }
            return true;

        }


    }
}