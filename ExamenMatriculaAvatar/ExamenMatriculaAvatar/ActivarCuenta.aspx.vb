
Public Class ActivarCuenta
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            nego.activarcuenta(txtId.Text, txtContra.Text, txtConfirmacion.Text)



            LBerror.Text = nego.Errores1


        Catch ex As Exception
            LBerror.Text = ex.ToString
        End Try


    End Sub
End Class