<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaPrincipal.Master" CodeBehind="PaginaProfesor.aspx.vb" Inherits="ExamenMatriculaAvatar.Formulario_web111" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tutulosSecun">
         <asp:Label ID="Label3" runat="server" Text="Ingresar Nota Estudiante"></asp:Label>
          </div>
    <div>
         <asp:Label ID="lbError" runat="server" ForeColor="Red"></asp:Label>
          </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="ID Estudiante: "></asp:Label>

        <asp:TextBox ID="txtIdEstu" runat="server"></asp:TextBox>

        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text=" ID Curso : "></asp:Label>

        <asp:TextBox ID="txtIDCurso" runat="server"></asp:TextBox>

        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Nota: "></asp:Label>

        <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>

        <br />
        <br />
    </div>
     
    <div>
        <asp:GridView ID="gvCosasProfe" runat="server"></asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnNota" runat="server" Text="Modificar Nota" Width="114px" />

        <br />
        <br />

        </div>
</asp:Content>
