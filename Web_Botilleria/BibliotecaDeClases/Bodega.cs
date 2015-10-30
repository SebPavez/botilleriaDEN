using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClases
{
    public class Bodega
    {
        private int idBodega;

        public int IDBodega
        {
            get { return idBodega; }
            set { idBodega = value; }
        }

        private String nombreBodega;

        public String NombreBodega
        {
            get { return nombreBodega; }
            set { nombreBodega = value; }
        }

        private String direccionBodega;

        public String DireccionBodega
        {
            get { return direccionBodega; }
            set { direccionBodega = value; }
        }
        private String correoBodega;

        public String CorreoBodega
        {
            get { return correoBodega; }
            set { correoBodega = value; }
        }

        private int telefonoBodega;

        public int Telefono
        {
            get { return telefonoBodega; }
            set { telefonoBodega = value; }
        }

        private List<Bebida> bebidasEnBodega;

        public List<Bebida> BebidasEnBodega
        {
            get { return bebidasEnBodega; }
            set { bebidasEnBodega = value; }
        }
        
    }
}
