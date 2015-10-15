using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace BibliotecaClases
{
    [Serializable]
    public class Persona
    {
        #region ID
        private int intID;

	    public int ID	{		
            get { return intID;}
            set { intID = value;}
        }
        #endregion
        #region Nombre
        private String strNombreUsuario;

        public String NombreUsuario
        {
            get { return strNombreUsuario; }
            set 
            {
                if(!value.ToString().Equals(""))
                    strNombreUsuario = value; 
            }
        }
        #endregion Nombre
        #region Password

        private String strPassword;

        public String Password
        {
            get { return strPassword; }
            set 
            {
                if(!value.ToString().Equals(""))
                    strPassword = value; 
            }
        }
        #endregion Password
        #region esAdministrador
        private bool blnAdministrador;

        public bool Administrador
        {
            get { return blnAdministrador; }
            set { blnAdministrador = value; }
        }
        #endregion esAdministrador
    }
}
