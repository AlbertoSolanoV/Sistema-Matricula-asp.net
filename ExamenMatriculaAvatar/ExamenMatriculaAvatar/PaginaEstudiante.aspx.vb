
Public Class Formulario_web11
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            lbNombreEstu.Text = Session("id")
            nego.MostrarPeriodos()


            Dim idInt As Integer

            idInt = Convert.ToInt32(Session("user"))

        Catch ex As Exception
            lbError.Text = ex.ToString()
        End Try




    End Sub


    Protected Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click

        Try
            Dim periodo As String
            Dim anno As Integer

            periodo = lbPeriodo.SelectedValue()
            anno = lbAños.SelectedValue()

            Dim p As Integer
            Dim a As Integer
            p = Convert.ToInt32(periodo)
            a = Convert.ToInt32(anno)

            nego.CursosEstudiante(Convert.ToInt32(Session("user")), p, a)

            gvCursosSelec.DataSource = nego.TablaCursosEstudiantes1
            gvCursosSelec.DataBind()


        Catch ex As Exception
            lbError.Text = ex.ToString()
        End Try


    End Sub

    Protected Sub btnPlanEstudio_Click(sender As Object, e As EventArgs) Handles btnPlanEstudio.Click
        Try
            nego.verPlanEstudio(Convert.ToInt32(Session("user")))

            gvCursosSelec.DataSource = nego.TabPlanEstudio1
            gvCursosSelec.DataBind()

        Catch ex As Exception
            lbError.Text = ex.ToString()

        End Try
    End Sub


End Class