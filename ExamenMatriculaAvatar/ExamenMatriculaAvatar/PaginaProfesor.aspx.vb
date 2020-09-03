Public Class Formulario_web111
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            nego.verProfersoresEstudiantes(Session("user"))
            gvCosasProfe.DataSource = nego.TabProfesEstudi1
            gvCosasProfe.DataBind()
        Catch ex As Exception
            lbError.Text = ex.ToString()
        End Try


    End Sub

    Protected Sub btnNota_Click(sender As Object, e As EventArgs) Handles btnNota.Click
        Try
            nego.IngresarNota(Convert.ToInt32(txtIdEstu.Text), Convert.ToInt32(txtIDCurso.Text), Convert.ToInt32(txtNota.Text))
            lbError.Text = "Modificada correctamnete"
        Catch ex As Exception
            lbError.Text = ex.ToString()

        End Try
    End Sub
End Class