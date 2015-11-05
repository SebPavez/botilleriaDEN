using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_Layer;
using BibliotecaClases;
namespace Web_Botilleria
{
    public partial class VentaVendedor : System.Web.UI.Page
    {

        private List<Bebida> lstProducto = new List<Bebida>();
        protected void Page_Load(object sender, EventArgs e)
        {

            lstProducto = (List<Bebida>)Session["MandarLista"];
            gvwVenta.DataSource = lstProducto;
            gvwVenta.DataBind();
        }

    }
}
