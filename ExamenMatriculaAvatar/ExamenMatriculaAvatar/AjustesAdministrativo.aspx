<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Ajustes.Master" CodeBehind="AjustesAdministrativo.aspx.vb" Inherits="ExamenMatriculaAvatar.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <div class="tutulosSecun">


        <asp:Label ID="Label4" runat="server" Text="Registro de Personal Administrativo"></asp:Label>


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
        <br>
       <br>
      <asp:Label ID="Label11" runat="server" Text="Puesto:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtPuestoAdmin" runat="server" Height="16px" Width="127px"></asp:TextBox>
        <br>
       <br>
      <asp:Label ID="Label13" runat="server" Text="Rol:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtRolAdmin" runat="server" Height="16px" Width="123px"></asp:TextBox>
        <br>
       <br>
       <asp:Button ID="btnAgregar" runat="server" Text="Agregar personal Administrativo" CssClass="contenido" />

        &nbsp;</div>
    <br>
     <div>
         
         <br />
        </div>
     <div class="tutulosSecun">


        <asp:Label ID="Label12" runat="server" Text="Registro Roles"></asp:Label>


        </div>
     <div class="contenidoSinCentro">

        <asp:Label ID="Label1" runat="server" Text="Descripción:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtDescripción" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
         <asp:GridView ID="gvRoles" runat="server"></asp:GridView>
          <br>
          <br>
  <asp:Button ID="btnRol" runat="server" Text="Agregar Rol"  />
       
    </div>
 
     <div class="tutulosSecun">


        <asp:Label ID="Label2" runat="server" Text="Registro Puestos"></asp:Label>


        </div>
     <div class="contenidoSinCentro">

          <asp:Label ID="Label10" runat="server" Text="Puesto:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtPuesto" runat="server" Width="165px"></asp:TextBox>
         <br>
          <br>
        <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtPuestoDescrip" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
         <asp:GridView ID="gvPuestos" runat="server"></asp:GridView>
          <br>
          <br>
  <asp:Button ID="btnPuesto" runat="server" Text="Agregar Puestos" />
       
    </div>

</asp:Content>
