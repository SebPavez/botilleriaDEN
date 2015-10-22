using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClases
{
    [Serializable]
    public class Venta
    {
        #region IDVenta
        private String strIdVenta;

        public String IdVenta
        {
            get { return strIdVenta; }
            set { strIdVenta = value; }
        }
        #endregion IDVenta
        #region listaProductos
        private List<Bebida> lstProductos;

        public List<Bebida> Productos
        {
            get { return lstProductos; }
            set { lstProductos = value; }
        }
        #endregion listaProductos
        #region FechaVenta
        public DateTime Fecha { get; set; }
        #endregion FechaVenta

    }
}
