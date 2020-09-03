
Public Class Formulario_web12
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Dim id As Integer = Convert.ToInt32(Session("user"))
            nego.DatosEstudiante(id)


            lbCorreo.Text = "Correo:" + "  " + nego.Correo1
            lbNumTel.Text = "Número de Teléfono:" + " " + nego.Tele1.ToString()
            lbDire.Text = "Dirección:" + "  " + nego.Dire1



        Catch ex As Exception
            lbError.Text = ex.ToString()
        End Try



    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("PaginaCursosMatri.aspx")
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            Dim id As Integer = Convert.ToInt32(Session("user"))



            nego.modificarEstudiante(id, Convert.ToInt32(txtTelefono.Text), txtCorreo.Text, txtDireccion.Text)
            Response.Redirect("Pagina1Matricula.aspx")

        Catch ex As Exception
            lbError.Text = ex.ToString()
        End Try


    End Sub
End Class