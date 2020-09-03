
Public Class Login
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("User") = ""
        Session("id") = ""
    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim idInt As Integer
        idInt = Convert.ToInt32(txtNombreUser.Text)

        nego.Login(idInt, txtContraseña.Text)

        If (nego.Sino1 = "1") Then

            Session("User") = txtNombreUser.Text
            Session("id") = nego.NombrePM1
            Response.Redirect("MenuPrincipal.aspx")

        Else

            lbSe.Text = "Usuario o Contraseña Incorrectos"
        End If


    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("ActivarCuenta.aspx")


    End Sub
End Class