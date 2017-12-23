Imports System.Data.SqlClient
Imports MySql.Data
Imports MySql.Data.MySqlClient
Module ConexionDB
    Public conexion As New MySqlConnection
    Public sql As String
    Public cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Sub conecta()
        Try
            conexion.Close()
            conexion.ConnectionString = "server = localhost; User = root; Password = root; database = personas;  port = 3306"
            conexion.Open()

        Catch ex As Exception
            MsgBox("No se pudo conectar con la base de datos" & ex.Message)
        End Try
    End Sub
    Sub desconecta()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
            conexion.Dispose()
        End If
    End Sub
    Sub inserta(ByRef SQL As String)
        conecta()
        Try
            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Operación Realizada Correctamente")
        Catch ex As Exception
            MsgBox("Operación Fallida")
        End Try
        desconecta()
    End Sub
    Public Function existe(ByRef SQL As String) As Integer
        conecta()
        Try
            Dim cmd As New MySqlCommand(SQL, conexion)
            reader = cmd.ExecuteReader
            While reader.Read()
                existe = Integer.Parse(reader("id"))
                Exit While
            End While
            reader.Close()
            Return existe
        Catch ex As Exception
            Return Nothing
            MsgBox("Persona ya Registrada Dentro de la Base de Datos")
        End Try
        desconecta()
    End Function

End Module
