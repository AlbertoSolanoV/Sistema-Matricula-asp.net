
Public Class PaginaPrincipal
    Inherits System.Web.UI.MasterPage
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        lbUser.Text = Session("User") + "  " + Session("id")


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Login.aspx")
        Session("User") = ""
        Session("id") = ""
    End Sub
End Class