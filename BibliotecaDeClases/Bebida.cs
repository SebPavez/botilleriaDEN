using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BibliotecaClases
{
    [Serializable]
    public class Bebida
    {
        #region IdProducto
        private int strIdProducto;

        public int ID
        {
            get { return strIdProducto; }
            set { strIdProducto = value; }
        }
        #endregion
        #region Nombre
        private String strNombre;

        public String Nombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }
        #endregion
        #region Marca
        private String strMarca;

        public String Marca
        {
            get { return strMarca; }
            set { strMarca = value; }
        }
        #endregion
        #region volumen
        private Double dblVolumenLitros;

        public Double VolumenLitros
        {
            get { return dblVolumenLitros; }
            set {
                if (dblVolumenLitros < 0)
                    throw new Exception("El volumen del producto NO puede ser menor a 0");
                dblVolumenLitros = value; }
        }
        #endregion volumen
        #region cantidad
        private int intCantidad;

        public int Cantidad
        {
            get { return intCantidad; }
            set {
                if (intCantidad < 0)
                    throw new Exception("La cantidad NO puede ser menor a 0");
                intCantidad = value; }
        }
        #endregion cantidad
        #region precio
        private Double dblPrecio;

        public Double Precio
        {
            get { return dblPrecio; }
            set {
                if(dblPrecio<0)
                    throw new Exception("El precio NO puede ser menor a 0");
                dblPrecio = value; }
        }
        #endregion precio
        #region tipo
        private Tipo tipoProducto;

        public Tipo TipoProducto
        {
            get { return tipoProducto; }
            set { tipoProducto = value; }
        }
        #endregion
        #region GradosDeAlcohol
        private double dblGradosDeAlcohol;

        public double GradosDeAlcohol
        {
            get { return dblGradosDeAlcohol; }
            set { dblGradosDeAlcohol = value; }
        }
#endregion 
        #region comentario
        private String srtComentario;

        public String Comentario
        {
            get { return srtComentario; }
            set { srtComentario = value; }
        }
        #endregion
        #region Retornable
        private bool blnRetornable;

        public bool Retornable
        {
            get { return blnRetornable; }
            set { blnRetornable = value; }
        }
        
        #endregion
    }

	


}
