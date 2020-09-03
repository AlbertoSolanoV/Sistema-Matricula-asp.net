<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaPrincipal.Master" CodeBehind="PaginaEstudiante.aspx.vb" Inherits="ExamenMatriculaAvatar.Formulario_web11" %>

<%@ Register Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    <br />
    <div class="contenidoSinCentro">


        <asp:Label ID="lbError" runat="server" ForeColor="Red"></asp:Label>


        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Estudiante:"></asp:Label>

        <asp:Label ID="lbNombreEstu" runat="server" Text="IDNombre"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Label ID="Label6" runat="server" Text="Año: "></asp:Label>&nbsp;&nbsp;&nbsp;<asp:ListBox ID="lbAños" runat="server" Rows="1">
            <asp:ListItem Value="2020">Año 2020</asp:ListItem>
            <asp:ListItem Value="2021">Año 2021</asp:ListItem>
            <asp:ListItem Value="2022">Año 2022</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


        <asp:Label ID="Label7" runat="server" Text="Perido: "></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lbPeriodo" runat="server" Height="20px" Rows="1">
            <asp:ListItem Value="1">Primer Cuatrimestre</asp:ListItem>
            <asp:ListItem Value="2">Segundo Cuatrimestre</asp:ListItem>
            <asp:ListItem Value="3">Tercer Cuatrimestre</asp:ListItem>
            <asp:ListItem Value="4">Cuarto Cuatrimestre</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />


       
      </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
<asp:GridView runat="server" CssClass="contenido" ID="gvCursosSelec">

            </asp:GridView>
              </ContentTemplate>
    </asp:UpdatePanel>

   
         
            
        

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Button ID="btnVer" runat="server" Text="Ver" Height="39px" Width="96px" />
            <br><br>
            <asp:Button ID="btnPlanEstudio" runat="server" Text="Ver Plan de Estudio" Width="127px" />
        </ContentTemplate>

    </asp:UpdatePanel>



</asp:Content>
