<%@ Page Title="" Language="C#" MasterPageFile="~/InterfazAdministrador.Master" AutoEventWireup="true" CodeBehind="AgregarNuevoProducto.aspx.cs" Inherits="Web_Botilleria.AgregarNuevoProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 29px;
            text-align: right;
            width: 566px;
        }
        .style2
        {
            width: 924px;
        }
        .style3
        {
            height: 29px;
            width: 924px;
        }
        .style4
        {
            width: 924px;
            text-align: left;
        }
        .style6
        {
            width: 566px;
        }
        .style7
        {
            text-align: right;
            width: 566px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table>
        <tr>
        <td class="style7">Nombre</td>
        <td class="style2"> 
            <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox> </td> 
        </tr>
        <tr>
        <td class="style7">Marca</td>
        <td class="style2"> <asp:TextBox ID="txbMarca" runat="server"></asp:TextBox> </td> 
        </tr>
        <tr>
        <td class="style7">Volumen</td>
        <td class="style2"> <asp:TextBox ID="txbVolumen" runat="server"></asp:TextBox> </td> 
        </tr>
        <tr>
        <td class="style7">Cantidad</td>
        <td class="style2"> <asp:TextBox ID="txbCantidad" runat="server"></asp:TextBox> </td> 
        </tr>
        <tr>
        <td class="style7">Precio</td>
        <td class="style2"> <asp:TextBox ID="txbPrecio" runat="server"></asp:TextBox> </td> 
        </tr>
        <tr>
        <td class="style1">Tipo</td>
        <td class="style3"> <asp:TextBox ID="txbTipo" runat="server"></asp:TextBox> </td> 
        </tr>
        <tr>
        <td class="style7">Comentario</td>
        <td class="style2"> <asp:TextBox ID="txbComentario" runat="server"></asp:TextBox> </td> 
        </tr>
        <tr>
        <td class="style7">Grados Alcohol </td>
        <td class="style2"> <asp:TextBox ID="txbGradosAlcohol" runat="server"></asp:TextBox> </td> 
        </tr>
        <tr>
        <td class="style7">Retornable</td>
        <td class="style2"> 
            <asp:CheckBox ID="chbRetornable" runat="server" /></td> 
        </tr>
        <tr>
        <td class="style6"></td>
        <td class="style2"> 
            <asp:Button ID="btnAgregar" runat="server" Text="AGREGAR" 
                onclick="btnAgregar_Click" /> </td> 
        </tr>
        <tr>
        <td class="style6"></td>
        <td class="style4"> 
            &nbsp;</td> 
        </tr>
    </table>

</asp:Content>

