Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class ClaseBD

    'Variables de trabajo
    Dim Conexion As New SqlConnection
    Dim cn As String
    Dim miDataSet As New DataSet
    'Variables del encabezado
    Dim tablaPeri As New DataTable("Peridos")
    Dim tablaCarreraEstudiantes As New DataTable("CarrerasEstu")

    'Login'
    Dim valor As String
    Dim nombreUser As String
    Dim RangoUser As String

    'Matricula Estudiantes'
    Dim tablaDatosEstudiantes As New DataTable("Datos")
    Dim tablaCursosPuede As New DataTable("CursosPuede")
    Dim tablamatriculados As New DataTable("Matriculados")
    'Facturacion'
    Dim tablaFacturas As New DataTable("Facturas")
    'Estudiante Cursos Info'
    Dim tablaCursosEstudiante As New DataTable("Cursos")

    'Ajustes'
    Dim tablaCarreras As New DataTable("carreras")
    Dim tablaRoles As New DataTable("roles")
    Dim tablaPuestos As New DataTable("puestos")
    'Propiedades'
#Region "Propiedades"
    Public Property TablaPeri1 As DataTable
        Get
            Return tablaPeri
        End Get
        Set(value As DataTable)
            tablaPeri = value
        End Set
    End Property

    Public Property TablaCarreraEstudiantes1 As DataTable
        Get
            Return tablaCarreraEstudiantes
        End Get
        Set(value As DataTable)
            tablaCarreraEstudiantes = value
        End Set
    End Property

    Public Property Valor1 As String
        Get
            Return valor
        End Get
        Set(value As String)
            valor = value
        End Set
    End Property

    Public Property RangoUser1 As String
        Get
            Return RangoUser
        End Get
        Set(value As String)
            RangoUser = value
        End Set
    End Property

    Public Property NombreUser1 As String
        Get
            Return nombreUser
        End Get
        Set(value As String)
            nombreUser = value
        End Set
    End Property

    Public Property TablaDatosEstudiantes1 As DataTable
        Get
            Return tablaDatosEstudiantes
        End Get
        Set(value As DataTable)
            tablaDatosEstudiantes = value
        End Set
    End Property

    Public Property TablaCursosPuede1 As DataTable
        Get
            Return tablaCursosPuede
        End Get
        Set(value As DataTable)
            tablaCursosPuede = value
        End Set
    End Property

    Public Property Tablamatriculados1 As DataTable
        Get
            Return tablamatriculados
        End Get
        Set(value As DataTable)
            tablamatriculados = value
        End Set
    End Property

    Public Property TablaFacturas1 As DataTable
        Get
            Return tablaFacturas
        End Get
        Set(value As DataTable)
            tablaFacturas = value
        End Set
    End Property

    Public Property TablaCursosEstudiante1 As DataTable
        Get
            Return tablaCursosEstudiante
        End Get
        Set(value As DataTable)
            tablaCursosEstudiante = value
        End Set
    End Property

    Public Property TablaCarreras1 As DataTable
        Get
            Return tablaCarreras
        End Get
        Set(value As DataTable)
            tablaCarreras = value
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


    'Fin de Propiedades'

#Region "ConexionBD"

    Sub Conectar()
        Conexion = New SqlConnection("Data Source=DESKTOP-FMDDBT7\SQLEXPRESS;Initial Catalog=MatriculaAvatar;Persist Security Info=True;User ID=sa;Password=1234")

        'Abre la conexion
        Conexion.Open()

        If Conexion.State = ConnectionState.Closed Then
            Conexion.Open()

        End If
    End Sub

#End Region
#Region "Periodo"

    Sub TraerListaPeriodo()

        Try
            'Abre el metodo de conexion
            Conectar()

            Dim sqlInstruccion As New SqlCommand


            'Operacion Consulta'
            sqlInstruccion = New SqlClient.SqlCommand("VerPeriodo ", Conexion)
            Dim adapter As New SqlDataAdapter(sqlInstruccion)
            adapter.Fill(TablaPeri1)


        Catch ex As Exception

            Throw New System.Exception("Error, al Pedir lista de Periodos")

        End Try

        Conexion.Close()


    End Sub
#End Region

#Region "CarreraEstudiante"

    Sub TraerListaCarrerasEstudiante(id As Integer)

        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("CarrerasEstudiante", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tablaCarreraEstudiantes)


        Catch ex As Exception

            Throw New System.Exception("Error, al Pedir lista de Carreras del estudiante")

        End Try

        Conexion.Close()


    End Sub

#End Region
#Region "Login"

    Sub Login(id As Integer, contra As String)

        Try
            'Abre el metodo de conexion
            Conectar()

            Dim cmd As New SqlCommand
            Dim salidaDatos1 As New SqlParameter
            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("LoginUsuario", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ID", id)
            cmd.Parameters.AddWithValue("@Pass", contra)
            salidaDatos1 = New SqlParameter()

            salidaDatos1.ParameterName = "@Result"
            salidaDatos1.SqlDbType = System.Data.SqlDbType.Int
            salidaDatos1.Direction = System.Data.ParameterDirection.Output
            cmd.Parameters.Add(salidaDatos1)


            cmd.ExecuteNonQuery()

            Valor1 = salidaDatos1.Value.ToString()


        Catch ex As Exception

            Throw New System.Exception("Error, al Comprobar Usuario")

        End Try

        Conexion.Close()


    End Sub

    Sub activacioncuenta(id As Integer, contra As String)

        Try
            'Abre el metodo de conexion
            Conectar()

            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("InsetarContraseña", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@contra", contra)
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable("tabla")

        Catch ex As Exception

            Throw New System.Exception("Error, al insertar nueva contraseña")

        End Try

        Conexion.Close()

    End Sub

    Sub NombreUserProce(id As Integer)

        Try
            'Abre el metodo de conexion
            Conectar()

            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("idnombre", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable("tabla")
            adapter.Fill(tabla)
            nombreUser = tabla.Rows(0)(0).ToString()



        Catch ex As Exception

            Throw New System.Exception("Error, al recuperar nombre de Usuario")

        End Try

        Conexion.Close()

    End Sub

    Sub RangoUserPro(id As Integer)

        Try
            'Abre el metodo de conexion
            Conectar()

            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("VerRangoUser", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable("tabla")
            adapter.Fill(tabla)
            RangoUser = tabla.Rows(0)(0).ToString()



        Catch ex As Exception

            Throw New System.Exception("Error, al recuperar nombre de Usuario")

        End Try

        Conexion.Close()


    End Sub

#End Region
#Region "Estudiante"



    Sub verEstudianteDatos(id As Integer)

        Try
            'Abre el metodo de conexion
            Conectar()

            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("VerEstudianteDatos", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable("tabla")
            adapter.Fill(tablaDatosEstudiantes)


        Catch ex As Exception

            Throw New System.Exception("Error, al recuperar nombre de Usuario")

        End Try

        Conexion.Close()

    End Sub

    Sub ModificarEstudiante(id As Integer, telefono As Integer, correo As String, dire As String)

        Try
            'Abre el metodo de conexion
            Conectar()

            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("ModificarEstudiante", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@Correo", correo)
            cmd.Parameters.AddWithValue("@telefo", telefono)
            cmd.Parameters.AddWithValue("@dire", dire)

            cmd.ExecuteNonQuery()





        Catch ex As Exception

            Throw New System.Exception("Error, al modificar datos de estudiante")

        End Try

        Conexion.Close()

    End Sub

#End Region
#Region "Matricula"

    Sub CursosEstudianteMatriculaPuede(id As Integer)


        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("CursosMatriculaEstudiante", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tablaCursosPuede)


        Catch ex As Exception

            Throw New System.Exception("Error, al Pedir lista de cursos del estudiante para matricular")

        End Try

        Conexion.Close()

    End Sub

    Sub Matricular(id As Integer, cod As Integer)

        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("AgregarMatricula", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idestu", id)
            cmd.Parameters.AddWithValue("@codDistri", cod)
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw New System.Exception("Error, al inserttar matricula de estudiante")

        End Try

        Conexion.Close()

    End Sub

    Sub EliminarMatricula(cod As Integer)

        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("EliminarMatricula", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Cod", cod)
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw New System.Exception("Error, al insertar matricula de estudiante")

        End Try

        Conexion.Close()
    End Sub

    Sub verMatriculas(id As Integer)
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("VerMatriculas", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tablamatriculados)

        Catch ex As Exception

            Throw New System.Exception("Error, al ver matriculas del estudiante")

        End Try

        Conexion.Close()

    End Sub


#End Region
#Region "Facturacion"

    Sub CrearFactura(id As Integer)
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("CrearFactura", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw New System.Exception("Error, al crear Factura de matricula de estudiante")

        End Try

        Conexion.Close()
    End Sub


    Sub verFacturas(id As Integer)

        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("verFacturas", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tablaFacturas)

        Catch ex As Exception

            Throw New System.Exception("Error, al ver Factura de matricula de estudiante")

        End Try

        Conexion.Close()

    End Sub

#End Region
#Region "InfoEstudiante"
    Sub verCursosEstudiante(id As Integer, periodo As Integer, anno As Integer)
        Try
            'Abre el metodo de conexion
            Conectar()

            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("VerCursosEstudiante", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@Periodo", periodo)
            cmd.Parameters.AddWithValue("@anno", anno)
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable("tabla")
            adapter.Fill(tablaCursosEstudiante)


        Catch ex As Exception

            Throw New System.Exception("Error, al recuperar cursos de estudiante")

        End Try

        Conexion.Close()

    End Sub



#End Region
#Region "Ajustes"

    Sub verCarreras()
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("verCarreras", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tablaCarreras)


        Catch ex As Exception

            Throw New System.Exception("Error, al Pedir lista de Carreras del estudiante")

        End Try

        Conexion.Close()

    End Sub

    Sub AgregarEstudiante(id As Integer, nombre As String, tel As Integer, dire As String, corre As String, idcarre As Integer)
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("IngresoEstudiantes", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nomb", nombre)
            cmd.Parameters.AddWithValue("@@telefono", tel)
            cmd.Parameters.AddWithValue("@dire", dire)
            cmd.Parameters.AddWithValue("@correo", corre)
            cmd.Parameters.AddWithValue("@IDCarrera", idcarre)
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw New System.Exception("Error, al ingresar Estudiante")

        End Try

        Conexion.Close()

    End Sub

    Sub AgregarProfesor(id As Integer, nombre As String, tel As Integer, corre As String, idcarre As Integer)
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("IngresoProfesor", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nomb", nombre)
            cmd.Parameters.AddWithValue("@@telefono", tel)
            cmd.Parameters.AddWithValue("@correo", corre)
            cmd.Parameters.AddWithValue("@IDCarrera", idcarre)
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw New System.Exception("Error, al ingresar Estudiante")

        End Try

        Conexion.Close()

    End Sub

    Sub AgregarAdmnistrativo(id As Integer, nombre As String, tel As Integer, corre As String, dire As String, pues As Integer, rol As Integer)
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("IngresoUsuarioAdmi", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nomb", nombre)
            cmd.Parameters.AddWithValue("@@telefono", tel)
            cmd.Parameters.AddWithValue("@correo", corre)
            cmd.Parameters.AddWithValue("@puesto", pues)
            cmd.Parameters.AddWithValue("@rol", rol)
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw New System.Exception("Error, al ingresar Estudiante")

        End Try

        Conexion.Close()

    End Sub


    Sub VerRoles()
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("verRoles", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tablaRoles)


        Catch ex As Exception

            Throw New System.Exception("Error, al Pedir lista de Carreras del estudiante")

        End Try

        Conexion.Close()

    End Sub
    Sub verPuestos()
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("verPuestos", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tablaPuestos)


        Catch ex As Exception

            Throw New System.Exception("Error, al Pedir lista de Carreras del estudiante")

        End Try

        Conexion.Close()

    End Sub
    Sub agregarRol(descrip As String)
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("agregarRoles", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@descri", descrip)
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw New System.Exception("Error, al ingresar Rol")

        End Try

        Conexion.Close()
    End Sub
    Sub agregarPuesto(nom As String, descrip As String)
        Try
            'Abre el metodo de conexion
            Conectar()
            Dim cmd As New SqlCommand


            'Operacion Consulta'
            cmd = New SqlClient.SqlCommand("agregarPuestos", Conexion)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", nom)
            cmd.Parameters.AddWithValue("@descri", descrip)
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw New System.Exception("Error, al ingresar Puesto")

        End Try

        Conexion.Close()
    End Sub
#End Region
End Class