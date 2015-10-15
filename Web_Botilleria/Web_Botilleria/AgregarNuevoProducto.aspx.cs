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
    public partial class AgregarNuevoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            try
            {
                producto.Nombre = txbNombre.Text.Trim();
                producto.Marca = txbNombre.Text.Trim();
                producto.Precio = Int32.Parse(txbPrecio.Text.Trim());
                producto.TipoProducto = txbTipo.Text.Trim();
                producto.VolumenLitros = Double.Parse(txbVolumen.Text.Trim());
                producto.Cantidad = Int32.Parse(txbCantidad.Text.Trim());
                producto.Comentario = txbComentario.Text.Trim();
                producto.GradosDeAlcohol = Double.Parse(txbGradosAlcohol.Text.Trim());
                producto.Retornable = (bool)chbRetornable.Checked;

                producto.ingresarProducto(producto);

                this.Page.Response.Write("Ingresado!");

              
              
            }
            catch(FormatException)
            {
                this.Page.Response.Write("Error al ingresar");
            }
        }
    }
}