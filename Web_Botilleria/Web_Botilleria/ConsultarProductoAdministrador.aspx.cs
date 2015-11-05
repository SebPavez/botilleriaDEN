using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaClases;
using Dato;
using System.Collections;
using Data_Access_Layer;

namespace Web_Botilleria
{
    public partial class ConsultarProductoAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //protected void btnBuscarPorId_Click(object sender, EventArgs e)
        //{
        //    ArrayList lista = new ArrayList();
        //    ConsultasDAL producto;
        //    producto= new ConsultasDAL();
        //    producto.(txbIdBuscAd.Text.Trim());

        //    if (!producto.Equals(null))
        //    {
        //        lista.Add(producto);
        //    }
            
        //    gvwAdminBusc.DataSource = new ArrayList();
        //    gvwAdminBusc.DataSource = lista;
        //    gvwAdminBusc.DataBind();

        //}

        protected void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {            
            
            List<Bebida> lista = ConsultasDAL.ConsultarStockPorNombreGeneral(txbNombreBuscAd.Text.Trim());

            gvwAdminBusc.DataSource = new ArrayList();
            gvwAdminBusc.DataSource = lista;
            gvwAdminBusc.DataBind();
        }

        //protected void btnBuscarPorMarca_Click(object sender, EventArgs e)
        //{            
        //    List<Bebida> lista = Buscador.ConsultarStockDeMarca(txbMarcaBuscAd.Text.Trim());

        //    gvwAdminBusc.DataSource = new ArrayList();
        //    gvwAdminBusc.DataSource = lista;
        //    gvwAdminBusc.DataBind();
        //}
    }
}