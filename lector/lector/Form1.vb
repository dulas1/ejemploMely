Imports DPFP
Imports DPFP.Capture
Imports System.Text
Imports System.IO
Public Class Form1

    Implements DPFP.Capture.EventHandler
    Private captura As DPFP.Capture.Capture
    Private Enroller As DPFP.Processing.Enrollment
    Private Delegate Sub _delegadoMuestra(ByVal text As String)
    Private Delegate Sub _delegadoControl()
    Private template As DPFP.Template
    Private Sub mostrarVeces(ByVal texto As String)
        If (vecesDedo.InvokeRequired) Then
            Dim deleg As New _delegadoMuestra(AddressOf mostrarVeces)
            Me.Invoke(deleg, New Object() {texto})
        Else
            vecesDedo.Text = texto
        End If
    End Sub

    Private Sub modificarControles()
        If (btnGuardar.InvokeRequired) Then
            Dim deleg As New _delegadoControl(AddressOf modificarControles)
            Me.Invoke(deleg, New Object() {})
        Else
            btnGuardar.Enabled = True
            txtNombre.Enabled = True
        End If
    End Sub

    Protected Overridable Sub Init()
        Try
            captura = New Capture()
            If Not captura Is Nothing Then
                captura.EventHandler = Me
                Enroller = New DPFP.Processing.Enrollment()
                Dim text As New StringBuilder()
                text.AppendFormat("Pasa El Dedo {0} veces", Enroller.FeaturesNeeded)
                vecesDedo.Text = text.ToString()

            Else
                MessageBox.Show("No se pudo instanciar la consulta")
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
    Protected Sub paraCaptura()
        If Not captura Is Nothing Then
            Try
                captura.StopCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo detener la captura")
            End Try
        End If
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        ponerImagen(convertirSampleMapaBits(Sample))
        procesar(Sample)
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        iniciarCaptura()

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        paraCaptura()

    End Sub
    Protected Function convertirSampleMapaBits(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertirdor As New DPFP.Capture.SampleConversion
        Dim mapaBits As Bitmap = Nothing
        convertirdor.ConvertToPicture(Sample, mapaBits)
        Return mapaBits
    End Function
    Private Sub ponerImagen(ByVal bmp)
        imagenHuella.Image = bmp

    End Sub
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
    Protected Sub procesar(ByVal Sample As DPFP.Sample)
        Dim caracteristicas As DPFP.FeatureSet = extraerCaracteristicas(Sample, DPFP.Processing.DataPurpose.Enrollment)
        If (Not caracteristicas Is Nothing) Then
            Try
                Enroller.AddFeatures(caracteristicas)
            Finally
                Dim text As New StringBuilder()
                text.AppendFormat("Pasa El Dedo {0} veces", Enroller.FeaturesNeeded)
                mostrarVeces(text.ToString())
                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready
                        template = Enroller.Template
                        paraCaptura()
                        btnGuardar.Enabled = True
                        txtNombre.Enabled = True
                    Case DPFP.Processing.Enrollment.Status.Failed
                        Enroller.Clear()
                        paraCaptura()
                        iniciarCaptura()
                End Select
            End Try
        End If
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        conecta()

        sql = "SELECT id FROM nombres WHERE id ='" & txtNombre.Text & "'"
        Dim siExiste As Integer = existe(sql)
        If siExiste >= 1 Then
            MsgBox("Persona ya Registrada")
        Else
            cmd.CommandText = "INSERT INTO nombres(huella,nombre) VALUES(?,?)"
            Using fm As New MemoryStream(template.Bytes)
                cmd.Parameters.AddWithValue("huella", fm.ToArray())
            End Using
            cmd.Parameters.AddWithValue("nombre", txtNombre.Text.ToString)

            inserta(sql)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
            MessageBox.Show("¡Hecho!")
            txtNombre.Text = ""
            btnGuardar.Enabled = False
            txtNombre.Enabled = False
            Enroller.Clear()
            paraCaptura()
            iniciarCaptura()
        End If
        desconecta()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        paraCaptura()
        Dim ventanaBuscar As New busqueda()
        ventanaBuscar.ShowDialog()
    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        paraCaptura()
    End Sub


End Class
