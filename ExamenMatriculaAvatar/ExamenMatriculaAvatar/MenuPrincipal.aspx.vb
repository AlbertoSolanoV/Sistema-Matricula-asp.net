
Public Class Formulario_web1
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        nego.rangopro(Convert.ToInt32(Session("user")))

        If (nego.Rango1.Equals("1")) Then

            ibServiciosGenerales.Visible = False
            lbSeviGen.Text = ""

        End If
        If (nego.Rango1.Equals("2")) Then

            ibServiciosGenerales.Visible = False
            lbSeviGen.Text = ""

        End If

    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click

        Response.Redirect("Pagina1Matricula.aspx")

    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click

        Response.Redirect("MenuSistemaEstudiantes.aspx")

    End Sub

    Protected Sub ibServiciosGenerales_Click(sender As Object, e As ImageClickEventArgs) Handles ibServiciosGenerales.Click

        Response.Redirect("PaginaAjustes.aspx")

    End Sub
End Class