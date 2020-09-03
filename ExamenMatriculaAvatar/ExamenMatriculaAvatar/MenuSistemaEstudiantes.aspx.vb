Public Class Formulario_web16
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        nego.rangopro(Convert.ToInt32(Session("user")))


        If (nego.Rango1.Equals("2")) Then

            ImageButton2.Visible = False
            Label5.Text = ""

        End If
    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click
        Response.Redirect("PaginaFactura.aspx")

    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click

        Dim nego As New ClaseNego


        nego.rangopro(Convert.ToInt32(Session("user")))

        If (nego.Rango1.Equals("1")) Then

            Response.Redirect("PaginaEstudiante.aspx")

        End If
        If (nego.Rango1.Equals("2")) Then

            Response.Redirect("PaginaProfesor.aspx")

        End If
    End Sub
End Class