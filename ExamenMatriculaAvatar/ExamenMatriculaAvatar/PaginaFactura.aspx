<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaPrincipal.Master" CodeBehind="PaginaFactura.aspx.vb" Inherits="ExamenMatriculaAvatar.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="tutulosSecun">
        <asp:Label ID="Label1" runat="server" Text="Tus Facturas"></asp:Label>

    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server">

        <asp:Label ID="Lberror" runat="server" ForeColor="Red"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" CssClass="contenido">
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Pagar" Text="Pagar" />
            </Columns>
        </asp:GridView>

    </asp:Panel>
    <div class="divpie">
        <asp:Button ID="btnVolver" runat="server" Text="Volver" Height="30px" Width="102px" />
    </div>
    <p>

        <br />
    </p>
    <p>
    </p>
</asp:Content>
