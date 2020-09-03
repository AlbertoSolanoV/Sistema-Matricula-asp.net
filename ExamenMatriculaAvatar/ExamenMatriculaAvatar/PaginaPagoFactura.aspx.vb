Public Class Formulario_web110
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            nego.verFacturaUna(Convert.ToInt32(Session("idFactura")))

            lbNumeroFactu.Text = Session("idFactura")
            lbEstado.Text = nego.TablaFacturaUna2.Rows(0)(1).ToString()
            lbCosto.Text = nego.TablaFacturaUna2.Rows(0)(0).ToString()

        Catch ex As Exception
            lbError.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Try
            nego.pagarFactura(Convert.ToInt32(Session("idFactura")))
        Catch ex As Exception
            lbError.Text = ex.ToString()
        End Try
    End Sub
End Class