
Public Class Formulario_web13
    Inherits System.Web.UI.Page
    Dim nego As New ClaseNego
    Dim myrow As DataRow
    Dim mydatatable As New DataTable
    Dim tabla2 As New DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Me.IsPostBack Then

                nego.CursosEstudiantePuede(Convert.ToInt32(Session("user")))



                gvCursos.DataSource = nego.TablaCursosDispo1
                gvCursos.DataBind()

            Else
                mydatatable.Columns.Add("Curso", Type.GetType("System.String"))
                mydatatable.Columns.Add("Nombre", Type.GetType("System.String"))
                mydatatable.Columns.Add("Horario", Type.GetType("System.String"))
                mydatatable.Columns.Add("Cupos", Type.GetType("System.String"))


                tabla2.Columns.Add("Curso", Type.GetType("System.String"))
                tabla2.Columns.Add("Nombre", Type.GetType("System.String"))
                tabla2.Columns.Add("Horario", Type.GetType("System.String"))
                tabla2.Columns.Add("Cupos", Type.GetType("System.String"))
                Me.tablamatri()
            End If

            ' Declare row
        Catch ex As Exception
            lbErrores.Text = ex.ToString()
        End Try


    End Sub

    Protected Sub tablamatri()
        Dim tabla As New DataTable

        Dim i As Integer = 0
        tabla = mydatatable
        Dim filas As Integer = Session("TabalaMatriculados").Rows.Count

        If filas = 0 Then

        Else
            For i = 0 To filas - 1
                Dim idcurso As String
                Dim Nombre As String
                Dim Horario As String
                Dim cupos As String
                idcurso = Session("TabalaMatriculados").Rows(i)(0).ToString()
                Nombre = Session("TabalaMatriculados").Rows(i)(1).ToString()
                Horario = Session("TabalaMatriculados").Rows(i)(2).ToString()
                cupos = Session("TabalaMatriculados").Rows(i)(3).ToString()

                myrow = tabla.NewRow
                myrow("Curso") = idcurso
                myrow("Nombre") = Nombre.ToString()
                myrow("Horario") = Horario
                myrow("Cupos") = cupos
                tabla.Rows.Add(myrow)
                mydatatable = tabla

            Next
        End If
        Session("TabalaMatriculados") = mydatatable


    End Sub

    Protected Sub btnMatricular_Click(sender As Object, e As EventArgs) Handles btnMatricular.Click
        Try
            Dim filas As Integer = Session("TabalaMatriculados").Rows.Count

            For i = 0 To filas - 1

                Dim idcurso As Integer = Session("TabalaMatriculados").Rows(i)(0).ToString()
                nego.agregarMatricula(Convert.ToInt32(Session("user")), idcurso)

            Next

            nego.crearFactura(Convert.ToInt32(Session("user")))
                Response.Redirect("PaginaFactura.aspx")
        Catch ex As Exception
            lbErrores.Text = ex.ToString()
        End Try


    End Sub

    Protected Sub gvCursos_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvCursos.RowCommand

        Dim idcurso As String
        Dim Nombre As String
        Dim Horario As String
        Dim cupos As String
        Dim crow As Integer
        Try

            If e.CommandName = "MatriBoton" Then

                Dim n As Integer = 0
                crow = Convert.ToInt32(e.CommandArgument.ToString())
                idcurso = gvCursos.Rows(crow).Cells(1).Text
                Nombre = gvCursos.Rows(crow).Cells(2).Text
                Horario = gvCursos.Rows(crow).Cells(3).Text
                cupos = gvCursos.Rows(crow).Cells(4).Text

                ' Create columns

                ' create new row
                myrow = mydatatable.NewRow
                myrow("Curso") = idcurso
                myrow("Nombre") = Nombre.ToString()
                myrow("Horario") = Horario
                myrow("Cupos") = cupos
                mydatatable.Rows.Add(myrow)

                dvCursosMatriccular.DataSource = mydatatable
                dvCursosMatriccular.DataBind()
                Session("TabalaMatriculados") = mydatatable


                'nego.VerMtriculasEstudiante(Convert.ToInt32(Session("user")))


            End If
        Catch ex As Exception
            lbErrores.Text = ex.ToString()
        End Try



    End Sub

    Protected Sub dvCursosMatriccular_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles dvCursosMatriccular.RowCommand
        Try

            Dim idcurso As String
            Dim crow As Integer


            If e.CommandName = "Eliminar" Then
                crow = Convert.ToInt32(e.CommandArgument.ToString())

                Dim filas As Integer = Session("TabalaMatriculados").Rows.Count
                idcurso = dvCursosMatriccular.Rows(crow).Cells(1).Text


                For i = 0 To filas - 1
                    If idcurso.Equals(Session("TabalaMatriculados").Rows(i)(0).ToString()) Then

                        Dim dr As DataRow
                        dr = Session("TabalaMatriculados").Rows(i)
                        dr.Delete()

                    Else
                        Dim Nombre As String
                        Dim Horario As String
                        Dim cupos As String
                        Dim curso As String
                        curso = Session("TabalaMatriculados").Rows(i)(0).ToString()
                        Nombre = Session("TabalaMatriculados").Rows(i)(1).ToString()
                        Horario = Session("TabalaMatriculados").Rows(i)(2).ToString()
                        cupos = Session("TabalaMatriculados").Rows(i)(3).ToString()

                        myrow = tabla2.NewRow
                        myrow("Curso") = curso
                        myrow("Nombre") = Nombre.ToString()
                        myrow("Horario") = Horario
                        myrow("Cupos") = cupos
                        tabla2.Rows.Add(myrow)

                    End If


                Next
                mydatatable = tabla2
            End If

            dvCursosMatriccular.DataSource = mydatatable
            dvCursosMatriccular.DataBind()


        Catch ex As Exception
            lbErrores.Text = "Eliminar"
        End Try

    End Sub
End Class