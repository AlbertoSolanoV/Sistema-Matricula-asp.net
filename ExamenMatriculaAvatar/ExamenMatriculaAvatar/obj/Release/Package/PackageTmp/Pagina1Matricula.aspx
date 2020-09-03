<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaPrincipal.Master" CodeBehind="Pagina1Matricula.aspx.vb" Inherits="ExamenMatriculaAvatar.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
        <br />
        <div class="tutulosSecun">

           <asp:Label ID="Label4" runat="server" Text="Informaciòn del Estudiante"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
&nbsp;&nbsp;


            </div>
   
 <asp:LinkButton ID="LinkButton1" runat="server">Siguiente -&gt;</asp:LinkButton>
  
        <asp:Label ID="lbError" runat="server" ForeColor="Red"></asp:Label>
<br>

    <br>
    

     <div class="contenidoSinCentro" style="margin-left: 4px">

           
            <asp:Label ID="lbCorreo" runat="server" Text="Correo: "></asp:Label>

           
            &nbsp;<asp:TextBox ID="txtCorreo" runat="server" Width="239px"></asp:TextBox>

           
            

           
            <br />

           
            

           
            <br />

           
            

           
            <asp:Label ID="lbNumTel" runat="server" Text="Nùmero de Telèfono: "></asp:Label>

           
            &nbsp;<asp:TextBox ID="txtTelefono" runat="server" Width="148px"></asp:TextBox>

           
           
  
 
    

           
            <br />

           
           
  
 
    

           
            <br />

           
           
  
 
    

           
 <asp:Label ID="lbDire" runat="server" Text="Direcciòn: "></asp:Label>

           
            &nbsp;<asp:TextBox ID="txtDireccion" runat="server" Height="56px" Width="203px"></asp:TextBox>

           
         
    <br><br>
   

        <asp:Button ID="btnModificar" runat="server" Text="Modificar Informaciòn" Width="142px" />

    </div>
   
    <br>
</asp:Content>

 
 
