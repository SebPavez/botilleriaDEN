using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dato;
using BibliotecaClases;

namespace Web_Botilleria
{
    public partial class EliminarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();
                if (producto.EliminarProducto(txbIdEliminar.Text.Trim()))
                    lblSalidaEliminar.Text = "Producto con ID " + txbIdEliminar.Text.Trim() + " eliminado!";
                else
                    lblSalidaEliminar.Text = "Producto no existe!";
            }
            catch (Exception)
            {
                
            }

        }

        
    }
}