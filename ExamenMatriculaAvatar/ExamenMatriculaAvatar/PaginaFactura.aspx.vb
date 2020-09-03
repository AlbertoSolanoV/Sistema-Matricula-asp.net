
Public Class Formulario_web15
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            nego.VerFacturas(Session("user"))
            GridView1.DataSource = nego.TablaFacturasEstudiante1
            GridView1.DataBind()
        Catch ex As Exception
            Lberror.Text = nego.Errores1
        End Try
    End Sub


    Protected Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Response.Redirect("MenuSistemaEstudiantes.aspx")
    End Sub

    Protected Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
        Try
            Dim idfactura As Integer
            Dim estado As String
            If e.CommandName = "Pagar" Then

                Dim crow As Integer
                crow = Convert.ToInt32(e.CommandArgument.ToString())

                idfactura = GridView1.Rows(crow).Cells(1).Text
                estado = GridView1.Rows(crow).Cells(5).Text
                If estado.Equals("Pagado") Then

                    Lberror.Text = "La factura ya fue pagada"

                Else

                    Session("idFactura") = idfactura
                    Response.Redirect("PaginaPagoFactura.aspx")

                End If

            End If
        Catch ex As Exception
            Lberror.Text = ex.ToString()
        End Try

    End Sub
End Class