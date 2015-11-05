<%@ Page Title="" Language="C#" MasterPageFile="~/InterfazVendedor.Master" AutoEventWireup="true" CodeBehind="VentaVendedor.aspx.cs" Inherits="Web_Botilleria.VentaVendedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h2>
        Nueva Venta
    </h2>
    <pre>
          <asp:GridView ID="gvwVenta" runat="server" Width="461px" >
    </asp:GridView>
    </pre>
    <asp:Button ID="Button1" runat="server" Text="Realizar compra" />

</asp:Content>
