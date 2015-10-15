using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Access_Layer
{
    class ProductoDAL
    {
        
        ////Suma o resta una cantidad ingresada por parametro al producto actual, luego actualiza la BD
        //public void ActualizarStock(int actualizacion)
        //{
        //    this.Cantidad += actualizacion;
        //    MotorXML xml = MotorXML.getIntancia();
        //    xml.ModificarObjeto(this, "ID");
        //    xml.GuardarXMLArchivo();
        //}

        //public Boolean EliminarProducto(String idProducto)
        //{
        //    MotorXML xml = MotorXML.getIntancia();
        //    xml.EliminarObjeto(this, "ID");
        //    xml.GuardarXMLArchivo();
        //    return true;
        //}

        ////Agrega un nuevo producto, asignándole una ID única
        //public Boolean ingresarProducto(Producto nuevoProducto)
        //{
        //    MotorXML xml = MotorXML.getIntancia();
        //    ID = xml.ObtenerIdentificadorNuevo("ID", "ID");
        //    xml.AgregarObjeto(this, "ID", "ID");
        //    xml.GuardarXMLArchivo();
        //    return true;
        //}

        ////Busca la existencia de un producto con "idProductoValidando".
        ////Si existe, carga sus parametros en una instancia de Producto y devuelve "true"
        ////De lo contrario, solo devuelve "false" sin cargar datos a la instancia
        //public Boolean RecuperarEstadoPorId(String idProductoValidando)
        //{
        //    if (MotorXML.getIntancia().Buscar(ID.ToString(), "ID", this) != null)
        //        return true;
        //    else
        //        return false;
        //}
    }
}
