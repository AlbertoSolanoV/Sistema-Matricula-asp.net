Public Class Formulario_web19
    Inherits System.Web.UI.Page
    Dim nego As New ClaseBD
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            nego.verAulas()
            gvAulas.DataSource = nego.TablaAulas1
            gvAulas.DataBind()

            nego.verCarreras()
            gvCarreras.DataSource = nego.TablaCarreras1
            gvCarreras.DataBind()

            nego.verPeriodo()
            gvPeriodos.DataSource = nego.TabPeriodo1
            gvPeriodos.DataBind()

            nego.verProfesores()
            gvProfesore.DataSource = nego.TabProfes1
            gvProfesore.DataBind()

            nego.verHorario()
            gvDias.DataSource = nego.TabHorario1
            gvDias.DataBind()

            nego.verCursos()
            gvCursos.DataSource = nego.TabCursos1
            gvCursos.DataBind()

        Catch ex As Exception
            lbMensaje.Text = ex.ToString()

        End Try

    End Sub

    Protected Sub btnAgregarAula_Click(sender As Object, e As EventArgs) Handles btnAgregarAula.Click
        Try
            nego.agregarAula(txtUbicaAULAS.Text, Convert.ToInt32(txtCupoAula.Text))


        Catch ex As Exception
            lbMensaje.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub btnCarrera_Click(sender As Object, e As EventArgs) Handles btnCarrera.Click
        Try
            nego.agregarCarrera(txtNombreCarrera.Text, txtDescripcionCarera.Text)


        Catch ex As Exception
            lbMensaje.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub btnCurso_Click(sender As Object, e As EventArgs) Handles btnCurso.Click
        Try

            nego.agregarCursos(txtNombreCurso.Text, txtDesripcionCurso.Text, txtCostoCurso.Text, txtCreditosCurso.Text,
Convert.ToInt32(txtRequisitos.Text), Convert.ToInt32(txtIdCarreraCurso.Text), Convert.ToInt32(txtPeriodoCurso.Text))

        Catch ex As Exception
            lbMensaje.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            nego.agregarDistribu(Convert.ToInt32(txtIdCursoDistri.Text), Convert.ToInt32(txtidAulaDistri.Text),
Convert.ToInt32(txtidProfeDistri.Text), Convert.ToInt32(txtidDiaDistri.Text), Convert.ToInt32(txtidPeriodo.Text))
        Catch ex As Exception
            lbMensaje.Text = ex.ToString()
        End Try
    End Sub
End Class