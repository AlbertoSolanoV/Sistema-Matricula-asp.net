<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ActivarCuenta.aspx.vb" Inherits="ExamenMatriculaAvatar.ActivarCuenta" %>

<!DOCTYPE html>
<link href="HojaEstilos.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenidoSinCentro">

            <asp:Label ID="Label1" runat="server" Text="Ingrese su Id: "></asp:Label>

            &nbsp;<asp:TextBox ID="txtId" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ingrese su nueva Contraseña: "></asp:Label>

            &nbsp;<asp:TextBox ID="txtContra" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Confirme su nueva Contraseña: "></asp:Label>

        &nbsp;<asp:TextBox ID="txtConfirmacion" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="LBerror" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />

        </div>
    </form>
</body>
</html>
