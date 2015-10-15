<%@ Page Title="" Language="C#" MasterPageFile="~/InterfazAdministrador.Master" AutoEventWireup="true" CodeBehind="EliminarProducto.aspx.cs" Inherits="Web_Botilleria.EliminarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr>
            <td>ID</td>
            <td class="style1">
                <asp:TextBox ID="txbIdEliminar" runat="server"></asp:TextBox></td>
            <td>&nbsp;&nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td> 
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" 
                    onclick="btnEliminar_Click" /> </td>
        </tr>
    </table>

    <br />
    <asp:Label ID="lblSalidaEliminar" runat="server"></asp:Label>

</asp:Content>
