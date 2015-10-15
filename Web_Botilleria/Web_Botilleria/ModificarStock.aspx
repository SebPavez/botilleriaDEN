<%@ Page Title="" Language="C#" MasterPageFile="~/InterfazAdministrador.Master" AutoEventWireup="true" CodeBehind="ModificarStock.aspx.cs" Inherits="Web_Botilleria.ModificarStock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 284px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>ID</td>
            <td class="style1">
                <asp:TextBox ID="txbIDMod" runat="server"></asp:TextBox></td>
            <td>CANTIDAD</td>
            <td class="style1">
                <asp:TextBox ID="txbCantMod" runat="server"></asp:TextBox></td>
            <td> 
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" 
                    onclick="btnModificar_Click" /> </td>
        </tr>
    </table>
</asp:Content>
