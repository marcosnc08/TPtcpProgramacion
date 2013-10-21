<%@ Page Language="C#" AutoEventWireup="true" CodeFile="agregar.aspx.cs" Inherits="agregar" %>

<%@ Register src="WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:WebUserControl ID="WebUserControl1" runat="server" />

        <table>
            <tr>
                <td>Nombre:</td>  
                <td><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>  
            </tr>
            <tr>
                <td>DNI:</td>
                <td><asp:TextBox ID="txtDni" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Dirección:</td>
                <td><asp:TextBox ID="txtdir" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Fecha de nacimiento:</td>
                <td><asp:Calendar ID="cldNacimiento" runat="server"></asp:Calendar></td>
            </tr>
        </table>

        <asp:Button ID="btnCrear" runat="server" Text="Crear" 
            onclick="btnCrear_Click" />
    </div>
    </form>
</body>
</html>
