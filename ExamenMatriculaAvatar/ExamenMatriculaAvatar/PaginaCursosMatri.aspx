<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaPrincipal.Master" CodeBehind="PaginaCursosMatri.aspx.vb" Inherits="ExamenMatriculaAvatar.Formulario_web13" %>

<%@ Register Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="tutulosSecun">
        <asp:Label ID="Label4" runat="server" Text="Cursos disponibles para Usted"></asp:Label>
    </div>


    <asp:Label ID="lbErrores" runat="server" ForeColor="Red"></asp:Label>


    <br />

    <asp:UpdatePanel runat="server">
        <contenttemplate>
            <asp:GridView ID="gvCursos" runat="server" Width="803px" CssClass="contenido">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="MatriBoton" Text="Matricular" />
                </Columns>
            </asp:GridView>
        
        </contenttemplate>

    </asp:UpdatePanel>

    <asp:Panel ID="Panel2" runat="server" CssClass="tutulosSecun">
        <asp:Label ID="Label5" runat="server" Text="Cursos Seleccionados"></asp:Label>



    </asp:Panel>
    <asp:UpdatePanel ID="UpdatePanelEliminar" runat="server" CssClass="contenido">
        <contenttemplate>
            <asp:GridView ID="dvCursosMatriccular" runat="server" Width="803px" CssClass="contenido">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar" />

                </Columns>
            </asp:GridView>
        </contenttemplate>
        <triggers>
            <asp:PostBackTrigger ControlID="dvCursosMatriccular" />
        </triggers>
    </asp:UpdatePanel>


    <asp:Panel ID="Panel3" runat="server" CssClass="contenido">
        <asp:Button ID="btnMatricular" runat="server" Text="Confirmar Matricular Cursos" Height="40px" Width="181px" />
    </asp:Panel>



    <br>
</asp:Content>
