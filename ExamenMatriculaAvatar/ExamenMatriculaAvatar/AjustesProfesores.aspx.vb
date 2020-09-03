
Public Class Formulario_web17
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            nego.vercarreras()
            gvCarrerras.DataSource = nego.Tablacarreras1
            gvCarrerras.DataBind()

        Catch ex As Exception
            lbMensaje.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            nego.AgregarProfesor(Convert.ToInt32(txtId.Text), txtNombre.Text, Convert.ToInt32(txtTelefono.Text), txtCorreo.Text, Convert.ToInt32(txtIDcarrera.Text))
            lbMensaje.Text = "Agregado Exitosamente"
        Catch ex As Exception
            lbMensaje.Text = ex.ToString()
        End Try
    End Sub
End Class