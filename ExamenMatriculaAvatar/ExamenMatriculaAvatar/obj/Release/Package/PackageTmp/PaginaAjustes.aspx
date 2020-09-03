<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Ajustes.Master" CodeBehind="PaginaAjustes.aspx.vb" Inherits="ExamenMatriculaAvatar.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <div class="tutulosSecun">


        <asp:Label ID="Label4" runat="server" Text="Registro de Estudiantes"></asp:Label>


        </div>
    <asp:Label ID="lbMensaje" runat="server"></asp:Label>
    <br>
  <div class="contenidoSinCentro">

        <asp:Label ID="Label5" runat="server" Text="Identificacion:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtId" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Nombre Completo:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtNombre" runat="server" Width="220px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Correo:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtCorreo" runat="server" Width="219px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Telefono:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtTelefono" runat="server" Width="166px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Direccion:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtDireccion" runat="server" Height="37px" Width="258px"></asp:TextBox>
        <br />
      <br />
        <asp:Label ID="Label10" runat="server" Text="ID de Carrera:"></asp:Label>
        
       

        &nbsp;<asp:TextBox ID="txtIDcarrera" runat="server" Width="80px"></asp:TextBox>
    </div>
    <br>
     <div>
         <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="centerDiv" />
        </div>
    <br>
         <div>
             <asp:GridView ID="gvCarrerras" runat="server" CssClass="contenido"></asp:GridView>
        </div>
     <br>
<div>

        </div>
    <br>
    <div>

        </div>
    <br>
</asp:Content>
