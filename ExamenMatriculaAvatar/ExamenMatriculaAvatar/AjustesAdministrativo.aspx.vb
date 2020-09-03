
Public Class Formulario_web18
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            nego.verPuestos()
            nego.verRoles()

            gvPuestos.DataSource = nego.TablaPuestos1
            gvRoles.DataSource = nego.TablaRoles1
            gvRoles.DataBind()
            gvPuestos.DataBind()

        Catch ex As Exception

        End Try


    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            nego.AgregarAdmnistrativo(Convert.ToInt32(txtId.Text), txtNombre.Text, Convert.ToInt32(txtTelefono.Text), txtDireccion.Text, txtCorreo.Text, Convert.ToInt32(txtPuestoAdmin.Text), Convert.ToInt32(txtRolAdmin.Text))
            lbMensaje.Text = "Agregado Exitosamente"
        Catch ex As Exception
            lbMensaje.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub btnRol_Click(sender As Object, e As EventArgs) Handles btnRol.Click
        Try
            nego.agregarRol(txtDescripción.Text)
        Catch ex As Exception
            lbMensaje.Text = ex.ToString()
        End Try

    End Sub

    Protected Sub btnPuesto_Click(sender As Object, e As EventArgs) Handles btnPuesto.Click
        Try
            nego.agregarPuesto(txtPuesto.Text, txtPuestoDescrip.Text)
        Catch ex As Exception
            lbMensaje.Text = ex.ToString()
        End Try
    End Sub
End Class