<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Ajustes.Master" CodeBehind="AjustesCarreras.aspx.vb" Inherits="ExamenMatriculaAvatar.Formulario_web19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <div class="tutulosSecun">


        <asp:Label ID="Label4" runat="server" Text="Registro de Aulas"></asp:Label>

        </div>
    <asp:Label ID="lbMensaje" runat="server"></asp:Label>
    <br>
  <div class="contenidoSinCentro">

        <asp:Label ID="Label5" runat="server" Text="Ubicación:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtUbicaAULAS" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Cupo:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtCupoAula" runat="server" Width="220px"></asp:TextBox>
        <br />
        <br />
        <asp:GridView ID="gvAulas" runat="server"></asp:GridView>
      <br />
        <br />
       <asp:Button ID="btnAgregarAula" runat="server" Text="Agregar Aula" CssClass="contenido" />

        &nbsp;</div>
    <br>
     <div>
         
         <br />
        </div>
     <div class="tutulosSecun">


        <asp:Label ID="Label12" runat="server" Text="Registro Carrera"></asp:Label>


        </div>
     <div class="contenidoSinCentro">

        <asp:Label ID="Label1" runat="server" Text="Nombre Carrera:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtNombreCarrera" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
            <asp:Label ID="Label7" runat="server" Text="Descripción Carrera:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtDescripcionCarera" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
         <asp:GridView ID="gvCarreras" runat="server"></asp:GridView>
          <br>
          <br>
  <asp:Button ID="btnCarrera" runat="server" Text="Agregar Carrera" CssClass="contenido" />
       
    </div>
 
     <div class="tutulosSecun">


        <asp:Label ID="Label2" runat="server" Text="Registro Cursos"></asp:Label>


        </div>
     <div class="contenido">

          <asp:Label ID="Label10" runat="server" Text="Nombre Curso:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtNombreCurso" runat="server" Width="165px"></asp:TextBox>
         <br>
          <br>
        <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtDesripcionCurso" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label8" runat="server" Text="Costo:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtCostoCurso" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label9" runat="server" Text="Creditos:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtCreditosCurso" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label11" runat="server" Text="Requisitos:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtRequisitos" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label13" runat="server" Text="ID de Carrera:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtIdCarreraCurso" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label14" runat="server" Text="Periodo:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtPeriodoCurso" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />

         <asp:GridView ID="gvPeriodos" runat="server"></asp:GridView>
          <br>
          <br>
         <asp:GridView ID="gvCursos" runat="server"></asp:GridView>
          <br>
          <br>
  <asp:Button ID="btnCurso" runat="server" Text="Agregar Curso" />
       
    </div>

     <div class="tutulosSecun">


        <asp:Label ID="Label15" runat="server" Text="Registro Distribución"></asp:Label>


        </div>
     <div class="contenido">

          <asp:Label ID="Label16" runat="server" Text="ID de Curso:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtIdCursoDistri" runat="server" Width="165px"></asp:TextBox>
         <br>
          <br>
        <asp:Label ID="Label17" runat="server" Text="ID del Aula:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtidAulaDistri" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label18" runat="server" Text="ID Profesor:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtidProfeDistri" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label19" runat="server" Text="Código Día:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtidDiaDistri" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label20" runat="server" Text="ID Periodo:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtidPeriodo" runat="server" Width="165px"></asp:TextBox>
       
        <br />
        <br />
         <asp:GridView ID="gvProfesore" runat="server" CssClass="contenido"></asp:GridView>
          <br>
          <br>
          <asp:GridView ID="gvDias" runat="server"></asp:GridView>
          <br>
          <br>

  <asp:Button ID="Button1" runat="server" Text="Agregar Distribución" />
       
    </div>

</asp:Content>
