<%@ Page Title="" Language="C#" MasterPageFile="~/InterfazVendedor.Master" AutoEventWireup="true" CodeBehind="ConsultarProductoVendedor.aspx.cs" Inherits="Web_Botilleria.ConsultarProductoVendedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    <table>
        <tr>
        <td>ID</td>
        <td> 
            <asp:TextBox ID="txbIdBuscVend" runat="server"></asp:TextBox> </td> 
        <td> 
            <asp:Button ID="btnBuscarPorIdVendedor" runat="server" Text="Buscar por ID" 
                onclick="btnBuscarPorId_Click" Width="220px" /> </td>
        </tr>
        <tr>
        <td>Nombre</td>
        <td> <asp:TextBox ID="txbNombreBuscVend" runat="server"></asp:TextBox> </td> 
        <td> 
            <asp:Button ID="btnBuscarPorNombreVendedor" runat="server" Text="Buscar por Nombre" 
                onclick="btnBuscarPorNombre_Click" Width="220px" /> </td>
        </tr>
        <tr>
        <td>Marca</td>
        <td> <asp:TextBox ID="txbMarcaBuscVend" runat="server"></asp:TextBox> </td> 
        <td> 
            <asp:Button ID="btnBuscarPorMarcaVendedor" runat="server" Text="Buscar por Marca" 
                onclick="btnBuscarPorMarca_Click" Width="220px" /> </td>
        </tr>
        
    </table>

    <br />
    <asp:GridView ID="gvwVendBusc" runat="server" Width="461px">
    </asp:GridView>

    

    <br />
    <!--tabla que muestra los filtros disponibles para realizar una busqueda-->
    <br>
    <!--tabla que muestra los productos encontrados según la busqueda realizada-->
    </asp:Content>
