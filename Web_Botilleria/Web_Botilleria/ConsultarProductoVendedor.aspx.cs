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
    public partial class ConsultarProductoVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnBuscarPorId_Click(object sender, EventArgs e)
        //{
        //    ArrayList lista = new ArrayList();
        //    Bebida producto;
        //    producto = new Bebida();
        //    producto.RecuperarEstadoPorId(txbIdBuscVend.Text.Trim());

        //    if (!producto.Equals(null))
        //    {
        //        lista.Add(producto);
        //    }

        //    gvwVendBusc.DataSource = new ArrayList();
        //    gvwVendBusc.DataSource = lista;
        //    gvwVendBusc.DataBind();
        //}

        protected void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            List<Bebida> lista = ConsultasDAL.ConsultarStockPorNombreGeneral(txbNombreBuscVend.Text.Trim());

            gvwVendBusc.DataSource = new ArrayList();
            gvwVendBusc.DataSource = lista;
            gvwVendBusc.DataBind();
        }

        protected void btnBuscarPorMarca_Click(object sender, EventArgs e)
        {
            List<Bebida> listaEncontrados = ConsultasDAL.ConsultarStockDeMarcaGeneral(txbMarcaBuscVend.Text.Trim());

            gvwVendBusc.DataSource = new ArrayList();
            gvwVendBusc.DataSource = listaEncontrados;
            gvwVendBusc.DataBind();
        }

        

        protected void gvwVendBusc_SelectedIndexChanged(object sender, GridViewSelectEventArgs e)
        {
            try
            {

                List<Bebida> obj = new List<Bebida>();
                obj = (List<Bebida>)Session["MandarLista"];
                obj = ConsultasDAL.ConsultarStockPorNombreGeneral(gvwVendBusc.Rows[e.NewSelectedIndex].Cells[2].Text);

            }
            catch (Exception)
            {
                Console.WriteLine("No se a podido agregar");
            }
        }
    }
}