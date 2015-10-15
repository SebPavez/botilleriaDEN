<%@ Page Title="" Language="C#" MasterPageFile="~/InterfazAdministrador.Master" AutoEventWireup="true" CodeBehind="ConsultarProductoAdministrador.aspx.cs" Inherits="Web_Botilleria.ConsultarProductoAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <br />
    <!--tabla que muestra los filtros disponibles para realizar una busqueda-->
    <table>
        <tr>
        <td>ID</td>
        <td> 
            <asp:TextBox ID="txbIdBuscAd" runat="server"></asp:TextBox> </td> 
        <td> 
            <asp:Button ID="btnBuscarPorId" runat="server" Text="Buscar por ID" 
                onclick="btnBuscarPorId_Click" Width="220px" /> </td>
        </tr>
        <tr>
        <td>Nombre</td>
        <td> <asp:TextBox ID="txbNombreBuscAd" runat="server"></asp:TextBox> </td> 
        <td> 
            <asp:Button ID="btnBuscarPorNombre" runat="server" Text="Buscar por Nombre" 
                onclick="btnBuscarPorNombre_Click" Width="220px" /> </td>
        </tr>
        <tr>
        <td>Marca</td>
        <td> <asp:TextBox ID="txbMarcaBuscAd" runat="server"></asp:TextBox> </td> 
        <td> 
            <asp:Button ID="btnBuscarPorMarca" runat="server" Text="Buscar por Marca" 
                onclick="btnBuscarPorMarca_Click" Width="220px" /> </td>
        </tr>
        
    </table>

    <br>
    <!--tabla que muestra los productos encontrados según la busqueda realizada-->
    <asp:GridView ID="gvwAdminBusc" runat="server" Width="461px">
    </asp:GridView>
</asp:Content>
