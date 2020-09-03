<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaPrincipal.Master" CodeBehind="PaginaPagoFactura.aspx.vb" Inherits="ExamenMatriculaAvatar.Formulario_web110" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
        <br />
        <div class="tutulosSecun">

           <asp:Label ID="Label4" runat="server" Text="Informaciòn del Estudiante"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
&nbsp;&nbsp;


            </div>
    
        <asp:Label ID="lbError" runat="server" ForeColor="Red"></asp:Label>
<br>

    <br>
    

     <div class="contenidoSinCentro" style="margin-left: 4px">

           
            <asp:Label ID="lbCorreo" runat="server" Text="Factura Número: "></asp:Label>

           
            &nbsp;<asp:Label ID="lbNumeroFactu" runat="server" Text="Label"></asp:Label>
            <br />

           
            

           
            <br />

           
            

           
            <asp:Label ID="lbNumTel" runat="server" Text="Costo de Factura: "></asp:Label>

           
            &nbsp;<asp:Label ID="lbCosto" runat="server" Text="Label"></asp:Label>
            <br />

           
           
  
 
    

           
            <br />

           
           
  
 
    

           
 <asp:Label ID="lbDire" runat="server" Text="Estado Actual: "></asp:Label>

           
            &nbsp;<asp:Label ID="lbEstado" runat="server" Text="Label"></asp:Label>
            <br><br>
         </div>
    <div class="contenido">
    &nbsp;<asp:Label ID="Label1" runat="server" Text="Nombre de Tarjeta"></asp:Label>
            &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br><br>
          &nbsp;<asp:Label ID="Label2" runat="server" Text="Número de Tarjeta"></asp:Label>
            &nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br><br>
          &nbsp;<asp:Label ID="Label3" runat="server" Text="Código de Tarjeta"></asp:Label>
            &nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br><br>
        <asp:Button ID="btnPagar" runat="server" Text="Pagar Factura" Width="142px" />

    </div>
   <
  
</asp:Content>
