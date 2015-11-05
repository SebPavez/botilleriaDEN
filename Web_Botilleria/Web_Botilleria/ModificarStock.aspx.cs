using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaClases;
using Dato;
using Data_Access_Layer;

namespace Web_Botilleria
{
    public partial class ModificarStock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnModificar_Click(object sender, EventArgs e)
        //{
        //    String strID = txbIDMod.Text.Trim();
        //    Bebida producto = new Bebida();            

        //    try
        //    {
        //        if (!strID.Equals(String.Empty))
        //        {
        //            ConsultasDAL.ConsultarStockPorNombreGeneral(strID);
        //            if (!producto.Equals(null))
        //            {
        //                ProductoDAL.ActualizarStock(Int32.Parse(txbCantMod.Text.Trim()));
        //            }

        //        }
        //    }
        //    catch (Exception)
        //    {
                
        //    }
        //}
    }
}