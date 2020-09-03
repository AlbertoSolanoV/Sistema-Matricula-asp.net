Imports ClaseDatos
Public Class ClaseNego
    Dim ClasBD As New ClaseBD
    Dim listaPeri As New List(Of String)
    Dim listaCarrera As New List(Of String)
    Dim sino As String
    Dim idPM As String
    Dim nombrePM As String
    Dim errores As String
    Dim rango As String
    'Variables para matriculaEstudiantes'
    Dim correo As String
    Dim dire As String
    Dim tele As Integer
    Dim idEstudiante As Integer
    Dim tablaCursosDispo As New DataTable("CursosDisponibles")
    Dim tablaMatriculasEstu As New DataTable("MatriculasEstudiante")
    'Facturacion'
    Dim tablaFacturasEstudiante As New DataTable("Facturas")
    'Estudiantes Cursos Info'
    Dim tablaCursosEstudiantes As New DataTable("Info")
    'Ajustes'
    Dim tablacarreras As New DataTable("carreras")
    Dim tablaRoles As New DataTable("roles")
    Dim tablaPuestos As New DataTable("puestos")


    'Propiedadaes'
#Region "Propiedades"
    Public Property ListaPeri1 As List(Of String)
        Get
            Return listaPeri
        End Get
        Set(value As List(Of String))
            listaPeri = value
        End Set
    End Property

    Public Property Sino1 As String
        Get
            Return sino
        End Get
        Set(value As String)
            sino = value
        End Set
    End Property

    Public Property IdPM1 As String
        Get
            Return idPM
        End Get
        Set(value As String)
            idPM = value
        End Set
    End Property

    Public Property NombrePM1 As String
        Get
            Return nombrePM
        End Get
        Set(value As String)
            nombrePM = value
        End Set
    End Property

    Public Property ListaCarrera1 As List(Of String)
        Get
            Return listaCarrera
        End Get
        Set(value As List(Of String))
            listaCarrera = value
        End Set
    End Property
#End Region

#Region "Propiedades Estudiante Matricula"
    Public Property Correo1 As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Property Dire1 As String
        Get
            Return dire
        End Get
        Set(value As String)
            dire = value
        End Set
    End Property

    Public Property Tele1 As Integer
        Get
            Return tele
        End Get
        Set(value As Integer)
            tele = value
        End Set
    End Property

    Public Property IdEstudiante1 As Integer
        Get
            Return idEstudiante
        End Get
        Set(value As Integer)
            idEstudiante = value
        End Set
    End Property

    Public Property Errores1 As String
        Get
            Return errores
        End Get
        Set(value As String)
            errores = value
        End Set
    End Property

    Public Property Rango1 As String
        Get
            Return rango
        End Get
        Set(value As String)
            rango = value
        End Set
    End Property

    Public Property TablaCursosDispo1 As DataTable
        Get
            Return tablaCursosDispo
        End Get
        Set(value As DataTable)
            tablaCursosDispo = value
        End Set
    End Property

    Public Property TablaMatriculasEstu1 As DataTable
        Get
            Return tablaMatriculasEstu
        End Get
        Set(value As DataTable)
            tablaMatriculasEstu = value
        End Set
    End Property

    Public Property TablaFacturasEstudiante1 As DataTable
        Get
            Return tablaFacturasEstudiante
        End Get
        Set(value As DataTable)
            tablaFacturasEstudiante = value
        End Set
    End Property

    Public Property TablaCursosEstudiantes1 As DataTable
        Get
            Return tablaCursosEstudiantes
        End Get
        Set(value As DataTable)
            tablaCursosEstudiantes = value
        End Set
    End Property

    Public Property Tablacarreras1 As DataTable
        Get
            Return tablacarreras
        End Get
        Set(value As DataTable)
            tablacarreras = value
        End Set
    End Property

    Public Property TablaRoles1 As DataTable
        Get
            Return tablaRoles
        End Get
        Set(value As DataTable)
            tablaRoles = value
        End Set
    End Property

    Public Property TablaPuestos1 As DataTable
        Get
            Return tablaPuestos
        End Get
        Set(value As DataTable)
            tablaPuestos = value
        End Set
    End Property


#End Region



#Region "Metodos MenuEstudiante"

    Sub MostrarPeriodos()

        Try
            ClasBD.TraerListaPeriodo()


            Dim i As Integer = 0
            'Devuelve los valores de solamnete una fila
            For i = 0 To ClasBD.TablaPeri1.Rows.Count - 1

                Dim cuatri As String

                cuatri = ClasBD.TablaPeri1.Rows(i)(0).ToString()
                If (cuatri = "1") Then

                    cuatri = "Primer Cuatrimestre"

                End If
                If (cuatri = "2") Then

                    cuatri = "Segundo Cuatrimestre"

                End If
                If (cuatri = "3") Then

                    cuatri = "Tercer Cuatrimestre"

                End If
                If (cuatri = "4") Then

                    cuatri = "Cuarto Cuatrimestre"

                End If


                ListaPeri1.Add(cuatri)

            Next
        Catch ex As Exception
            errores = ex.ToString()
        End Try


    End Sub

    Sub ListaCarreras(id As Integer)

        Try
            ClasBD.TraerListaCarrerasEstudiante(id)


            Dim i As Integer = 0
            'Devuelve los valores de solamnete una fila
            For i = 0 To ClasBD.TablaCarreraEstudiantes1.Rows.Count - 1

                Dim carre As String

                carre = ClasBD.TablaCarreraEstudiantes1.Rows(i)(0).ToString()
                listaCarrera.Add(carre)

            Next
        Catch ex As Exception
            errores = ex.ToString()
        End Try


    End Sub


#End Region

#Region "Login"

    Sub activarcuenta(id As String, contra As String, contra2 As String)
        Try
            If contra.CompareTo(contra2) Then
                errores = "La contraseña no coinciden"

            Else

                ClasBD.activacioncuenta(Convert.ToInt32(id), contra)
                errores = "La contraseña cambiada correctamente"
            End If
        Catch ex As Exception
            errores = ex.ToString
        End Try



    End Sub

    Sub Login(id As Integer, contra As String)
        Try
            ClasBD.Login(id, contra)
            sino = ClasBD.Valor1
            ClasBD.NombreUserProce(id)
            nombrePM = ClasBD.NombreUser1

        Catch ex As Exception
            errores = ex.ToString()
        End Try


    End Sub

    Sub rangopro(id As Integer)

        Try

            ClasBD.RangoUserPro(id)
            rango = ClasBD.RangoUser1

        Catch ex As Exception
            errores = ex.ToString()
        End Try

    End Sub

#End Region

#Region "Matricula"

    Sub DatosEstudiante(id As Integer)

        Try
            ClasBD.verEstudianteDatos(id)
            correo = ClasBD.TablaDatosEstudiantes1.Rows(0)(0).ToString()
            tele = Convert.ToInt32(ClasBD.TablaDatosEstudiantes1.Rows(0)(1).ToString())
            dire = ClasBD.TablaDatosEstudiantes1.Rows(0)(2).ToString()
        Catch ex As Exception
            errores = ex.ToString()
        End Try

    End Sub
    Sub modificarEstudiante(id As Integer, tele As Integer, correo As String, dire As String)
        Try
            ClasBD.verEstudianteDatos(id)
            If tele = "" Then

                tele = Convert.ToInt32(ClasBD.TablaDatosEstudiantes1.Rows(0)(1).ToString())

            End If
            If correo = "" Then

                correo = ClasBD.TablaDatosEstudiantes1.Rows(0)(0).ToString()
            End If
            If dire = "" Then

                dire = ClasBD.TablaDatosEstudiantes1.Rows(0)(2).ToString()
            End If

            ClasBD.ModificarEstudiante(id, tele, correo, dire)
        Catch ex As Exception
            errores = ex.ToString()
        End Try


    End Sub
    Sub CursosEstudiantePuede(id As Integer)

        Try
            ClasBD.CursosEstudianteMatriculaPuede(id)
            tablaCursosDispo = ClasBD.TablaCursosPuede1
        Catch ex As Exception
            errores = ex.ToString()
        End Try


    End Sub

    Sub agregarMatricula(id As Integer, cod As Integer)

        Try
            ClasBD.Matricular(id, cod)


        Catch ex As Exception
            errores = ex.ToString()
        End Try

    End Sub

    Sub EliminarMatriculaEstu(cod As Integer)

        Try
            ClasBD.EliminarMatricula(cod)
        Catch ex As Exception
            errores = ex.ToString()
        End Try

    End Sub

    Sub VerMtriculasEstudiante(id As Integer)

        Try
            ClasBD.verMatriculas(id)
            tablaMatriculasEstu = ClasBD.Tablamatriculados1
        Catch ex As Exception
            errores = ex.ToString()
        End Try
    End Sub


#End Region

#Region "Facturacion"

    Sub crearFactura(id As Integer)

        Try
            ClasBD.CrearFactura(id)
        Catch ex As Exception
            errores = ex.ToString()

        End Try

    End Sub

    Sub VerFacturas(id As Integer)

        Try
            ClasBD.verFacturas(id)
            tablaFacturasEstudiante = ClasBD.TablaFacturas1

        Catch ex As Exception
            errores = ex.ToString()

        End Try

    End Sub

#End Region

#Region "Estudiates Cursos Info"

    Sub CursosEstudiante(id As Integer, peri As Integer, anno As Integer)

        Try
            ClasBD.verCursosEstudiante(id, peri, anno)
            tablaCursosEstudiantes = ClasBD.TablaCursosEstudiante1

        Catch ex As Exception
            errores = ex.ToString()
        End Try


    End Sub


#End Region

#Region "Ajustes"

    Sub vercarreras()

        Try
            ClasBD.verCarreras()

            tablacarreras = ClasBD.TablaCarreras1

        Catch ex As Exception

        End Try


    End Sub
    Sub AgregarEstudiante(id As Integer, nombre As String, tel As Integer, dire As String, corre As String, idcarre As Integer)
        Try
            ClasBD.AgregarEstudiante(id, nombre, tel, dire, corre, idcarre)
        Catch ex As Exception
            errores = ex.ToString()

        End Try

    End Sub

    Sub AgregarProfesor(id As Integer, nombre As String, tel As Integer, corre As String, idcarre As Integer)
        Try

            ClasBD.AgregarProfesor(id, nombre, tel, corre, idcarre)

        Catch ex As Exception
            errores = ex.ToString()
        End Try
    End Sub
    Sub AgregarAdmnistrativo(id As Integer, nombre As String, tel As Integer, corre As String, dire As String, pues As Integer, rol As Integer)
        Try

            ClasBD.AgregarAdmnistrativo(id, nombre, tel, corre, dire, pues, rol)

        Catch ex As Exception
            errores = ex.ToString()
        End Try
    End Sub
    Sub verRoles()
        Try
            ClasBD.VerRoles()

            tablaRoles = ClasBD.TablaRoles1


        Catch ex As Exception
            errores = ex.ToString()
        End Try
    End Sub
    Sub verPuestos()
        Try
            ClasBD.verPuestos()

            tablaPuestos = ClasBD.TablaPuestos1
        Catch ex As Exception
            errores = ex.ToString()
        End Try
    End Sub

    Sub agregarRol(desc As String)
        Try
            ClasBD.agregarRol(desc)


        Catch ex As Exception
            errores = ex.ToString()
        End Try
    End Sub

    Sub agregarPuesto(nom As String, desc As String)
        Try
            ClasBD.agregarPuesto(nom, desc)


        Catch ex As Exception
            errores = ex.ToString()
        End Try
    End Sub
#End Region
End Class
