<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="ExamenMatriculaAvatar.Login" %>

<!DOCTYPE html>

<link href="HojaEstilos.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>LOGIN</title>
     <div class="divTituloPrin">
        <asp:Label ID="Label4" runat="server" CssClass="tituloPrincipa" Text="Bienvenido"></asp:Label>
    </div>
</head>

   <body>
    <form id="form1" runat="server">
        <div>
            <div class="divpie">
                <asp:Label ID="Label1" runat="server"   CssClass="tutulosSecun"  Text="Inicio de sesión"></asp:Label>
            </div>
        </div>
    <div class="contenido">
        <asp:Label ID="Label2" runat="server" Text="Nombre de Usuario"></asp:Label>
    </div>
        <div class="contenido">
    </div>
    <div class="contenido">
        <asp:TextBox ID="txtNombreUser" runat="server"></asp:TextBox>
    </div>
        <div class="contenido">
            <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
        </div>
        <div class="contenido">
        <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
        </div>
            <div class="contenido"> 
            <asp:Label ID="lbSe" runat="server"></asp:Label>
        </div>
        <div class="contenido">
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
            <br />
            <br />
        </div>
        <div class="contenido">

            <asp:LinkButton ID="LinkButton1" runat="server">Activar Cuenta</asp:LinkButton>

        </div>
    </form>
    </body>
</html>

