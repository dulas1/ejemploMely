<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.imagenHuella = New System.Windows.Forms.PictureBox()
        Me.vecesDedo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMovil = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFijo = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtInterior = New System.Windows.Forms.TextBox()
        Me.txtExterior = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        CType(Me.imagenHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imagenHuella
        '
        Me.imagenHuella.Location = New System.Drawing.Point(12, 12)
        Me.imagenHuella.Name = "imagenHuella"
        Me.imagenHuella.Size = New System.Drawing.Size(253, 272)
        Me.imagenHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenHuella.TabIndex = 0
        Me.imagenHuella.TabStop = False
        '
        'vecesDedo
        '
        Me.vecesDedo.AutoSize = True
        Me.vecesDedo.Location = New System.Drawing.Point(9, 415)
        Me.vecesDedo.Name = "vecesDedo"
        Me.vecesDedo.Size = New System.Drawing.Size(72, 13)
        Me.vecesDedo.TabIndex = 1
        Me.vecesDedo.Text = "Pasa El Dedo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre (s):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido Materno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Calle:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "No. Interior:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(473, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "No. Exterioir:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(319, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Colonia:"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(322, 28)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(254, 20)
        Me.txtNombre.TabIndex = 10
        '
        'txtPaterno
        '
        Me.txtPaterno.Enabled = False
        Me.txtPaterno.Location = New System.Drawing.Point(322, 67)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(254, 20)
        Me.txtPaterno.TabIndex = 11
        '
        'txtMaterno
        '
        Me.txtMaterno.Enabled = False
        Me.txtMaterno.Location = New System.Drawing.Point(322, 106)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(254, 20)
        Me.txtMaterno.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(319, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Teléfono Móvil:"
        '
        'txtMovil
        '
        Me.txtMovil.Enabled = False
        Me.txtMovil.Location = New System.Drawing.Point(322, 145)
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(254, 20)
        Me.txtMovil.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(319, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Teléfono Fijo:"
        '
        'txtFijo
        '
        Me.txtFijo.Enabled = False
        Me.txtFijo.Location = New System.Drawing.Point(322, 184)
        Me.txtFijo.Name = "txtFijo"
        Me.txtFijo.Size = New System.Drawing.Size(254, 20)
        Me.txtFijo.TabIndex = 16
        '
        'txtCalle
        '
        Me.txtCalle.Enabled = False
        Me.txtCalle.Location = New System.Drawing.Point(322, 300)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(254, 20)
        Me.txtCalle.TabIndex = 17
        '
        'txtInterior
        '
        Me.txtInterior.Enabled = False
        Me.txtInterior.Location = New System.Drawing.Point(322, 339)
        Me.txtInterior.Name = "txtInterior"
        Me.txtInterior.Size = New System.Drawing.Size(100, 20)
        Me.txtInterior.TabIndex = 18
        '
        'txtExterior
        '
        Me.txtExterior.Enabled = False
        Me.txtExterior.Location = New System.Drawing.Point(476, 339)
        Me.txtExterior.Name = "txtExterior"
        Me.txtExterior.Size = New System.Drawing.Size(100, 20)
        Me.txtExterior.TabIndex = 19
        '
        'txtColonia
        '
        Me.txtColonia.Enabled = False
        Me.txtColonia.Location = New System.Drawing.Point(322, 378)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(254, 20)
        Me.txtColonia.TabIndex = 20
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(607, 402)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(319, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Correo Electrónico:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Location = New System.Drawing.Point(322, 223)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(254, 20)
        Me.txtCorreo.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 437)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtExterior)
        Me.Controls.Add(Me.txtInterior)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtFijo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMovil)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMaterno)
        Me.Controls.Add(Me.txtPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vecesDedo)
        Me.Controls.Add(Me.imagenHuella)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imagenHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imagenHuella As PictureBox
    Friend WithEvents vecesDedo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMovil As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFijo As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtInterior As TextBox
    Friend WithEvents txtExterior As TextBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCorreo As TextBox
End Class
