Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient
Imports System.IO



Public Class busqueda
    Implements DPFP.Capture.EventHandler
    Private template As DPFP.Template
    Private captura As DPFP.Capture.Capture
    Private verificador As DPFP.Verification.Verification
    Protected Overridable Sub Init()
        Try
            captura = New Capture
            If Not captura Is Nothing Then
                captura.EventHandler = Me
                verificador = New Verification.Verification()
                template = New Template()
            Else
                MessageBox.Show("No se pudo instanciar la captura")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo inicializar la captura")
        End Try
    End Sub
    Protected Sub iniciarCaptura()
        If Not captura Is Nothing Then
            Try
                captura.StartCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo iniciar la captura")
            End Try
        End If
    End Sub
    Protected Sub pararCaptura()
        If Not captura Is Nothing Then
            Try
                captura.StopCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo detener la captura")
            End Try
        End If
    End Sub
    Private Sub ponerImagen(ByVal bmp)
        imagenHuella.image = bmp
    End Sub
    Protected Function convetirSampleMapaBits(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion()
        Dim mapaBits As Bitmap = Nothing
        convertidor.convertToPicture(Sample, mapaBits)
        Return mapaBits
    End Function
    Protected Function extraerCaracteristicas(ByVal Sample As DPFP.Sample, ByVal Porpuse As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim alimentacion As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim caracteristicas As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Porpuse, alimentacion, caracteristicas)
        If (alimentacion = DPFP.Capture.CaptureFeedback.Good) Then
            Return caracteristicas
        Else
            Return Nothing
        End If
    End Function
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        ponerImagen(convetirSampleMapaBits(Sample))
        Dim caracteristicas As DPFP.FeatureSet = extraerCaracteristicas(Sample, DPFP.Processing.DataPurpose.Verification)
        If Not caracteristicas Is Nothing Then
            Dim result As New DPFP.Verification.Verification.Result()
            Dim builderconex As New MySqlConnectionStringBuilder()
            builderconex.Server = "localhost"
            builderconex.UserID = "root"
            builderconex.Password = "root"
            builderconex.Database = "personas"
            Dim conexion As New MySqlConnection(builderconex.ToString())
            conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd = conexion.CreateCommand
            cmd.CommandText = "SELECT * FROM nombres"
            Dim read As MySqlDataReader
            read = cmd.ExecuteReader()
            Dim verificado As Boolean = False
            Dim nombre As String = ""
            While (read.Read())
                Dim memoria As New MemoryStream(CType(read("huella"), Byte()))
                template.DeSerialize(memoria.ToArray())
                verificador.Verify(caracteristicas, template, result)
                If (result.Verified) Then
                    nombre = read("nombre")
                    verificado = True
                    Exit While
                End If
            End While
            If (verificado) Then
                MessageBox.Show(nombre)
            Else
                MessageBox.Show("No se encontro ningun registro")
            End If
            read.Dispose()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
        End If
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub
    Private Sub busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        iniciarCaptura()

    End Sub

    Private Sub busqueda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pararCaptura()
    End Sub
End Class