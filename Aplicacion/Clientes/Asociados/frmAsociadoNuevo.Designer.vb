<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsociadoNuevo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Asociadas = New System.Windows.Forms.ListBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAsociarLista = New System.Windows.Forms.Button()
        Me.Cuentas = New System.Windows.Forms.ListBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkDocumento = New System.Windows.Forms.LinkLabel()
        Me.txtAutorizadoDoc = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtAutorizadoNombre = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAutorizadoDireccion = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtAutorizadoCelular = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.AutorizadoHasta = New System.Windows.Forms.DateTimePicker()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtAutorizadoTelefono = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtAutorizadoEmail = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 461)
        Me.Panel1.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.Asociadas)
        Me.Panel10.Controls.Add(Me.Panel12)
        Me.Panel10.Controls.Add(Me.Cuentas)
        Me.Panel10.Controls.Add(Me.btnGuardar)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 190)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(568, 271)
        Me.Panel10.TabIndex = 62
        '
        'Asociadas
        '
        Me.Asociadas.FormattingEnabled = True
        Me.Asociadas.ItemHeight = 16
        Me.Asociadas.Location = New System.Drawing.Point(331, 8)
        Me.Asociadas.Name = "Asociadas"
        Me.Asociadas.ScrollAlwaysVisible = True
        Me.Asociadas.Size = New System.Drawing.Size(226, 196)
        Me.Asociadas.TabIndex = 74
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Button1)
        Me.Panel12.Controls.Add(Me.btnAsociarLista)
        Me.Panel12.Location = New System.Drawing.Point(247, 8)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(71, 63)
        Me.Panel12.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAsociarLista
        '
        Me.btnAsociarLista.Location = New System.Drawing.Point(3, 3)
        Me.btnAsociarLista.Name = "btnAsociarLista"
        Me.btnAsociarLista.Size = New System.Drawing.Size(61, 23)
        Me.btnAsociarLista.TabIndex = 69
        Me.btnAsociarLista.Text = ">>"
        Me.btnAsociarLista.UseVisualStyleBackColor = True
        '
        'Cuentas
        '
        Me.Cuentas.FormattingEnabled = True
        Me.Cuentas.ItemHeight = 16
        Me.Cuentas.Location = New System.Drawing.Point(12, 8)
        Me.Cuentas.Name = "Cuentas"
        Me.Cuentas.ScrollAlwaysVisible = True
        Me.Cuentas.Size = New System.Drawing.Size(219, 196)
        Me.Cuentas.TabIndex = 72
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.DoIt
        Me.btnGuardar.Location = New System.Drawing.Point(12, 210)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(50, 51)
        Me.btnGuardar.TabIndex = 71
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel7)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel8)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(568, 190)
        Me.FlowLayoutPanel1.TabIndex = 61
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LinkDocumento)
        Me.Panel2.Controls.Add(Me.txtAutorizadoDoc)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 57)
        Me.Panel2.TabIndex = 0
        '
        'LinkDocumento
        '
        Me.LinkDocumento.AutoSize = True
        Me.LinkDocumento.Location = New System.Drawing.Point(30, 7)
        Me.LinkDocumento.Name = "LinkDocumento"
        Me.LinkDocumento.Size = New System.Drawing.Size(84, 17)
        Me.LinkDocumento.TabIndex = 59
        Me.LinkDocumento.TabStop = True
        Me.LinkDocumento.Text = "Documento:"
        '
        'txtAutorizadoDoc
        '
        Me.txtAutorizadoDoc.Location = New System.Drawing.Point(3, 29)
        Me.txtAutorizadoDoc.Name = "txtAutorizadoDoc"
        Me.txtAutorizadoDoc.Size = New System.Drawing.Size(269, 22)
        Me.txtAutorizadoDoc.TabIndex = 58
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtAutorizadoNombre)
        Me.Panel3.Controls.Add(Me.Label39)
        Me.Panel3.Location = New System.Drawing.Point(286, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(277, 57)
        Me.Panel3.TabIndex = 60
        '
        'txtAutorizadoNombre
        '
        Me.txtAutorizadoNombre.Location = New System.Drawing.Point(4, 27)
        Me.txtAutorizadoNombre.Name = "txtAutorizadoNombre"
        Me.txtAutorizadoNombre.Size = New System.Drawing.Size(269, 22)
        Me.txtAutorizadoNombre.TabIndex = 43
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(40, 7)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(62, 17)
        Me.Label39.TabIndex = 42
        Me.Label39.Text = "Nombre:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtAutorizadoDireccion)
        Me.Panel4.Controls.Add(Me.Label41)
        Me.Panel4.Location = New System.Drawing.Point(3, 66)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(277, 57)
        Me.Panel4.TabIndex = 61
        '
        'txtAutorizadoDireccion
        '
        Me.txtAutorizadoDireccion.Location = New System.Drawing.Point(4, 29)
        Me.txtAutorizadoDireccion.Name = "txtAutorizadoDireccion"
        Me.txtAutorizadoDireccion.Size = New System.Drawing.Size(269, 22)
        Me.txtAutorizadoDireccion.TabIndex = 45
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(40, 6)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(71, 17)
        Me.Label41.TabIndex = 44
        Me.Label41.Text = "Direccion:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtAutorizadoCelular)
        Me.Panel5.Controls.Add(Me.Label44)
        Me.Panel5.Location = New System.Drawing.Point(286, 66)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(277, 57)
        Me.Panel5.TabIndex = 62
        '
        'txtAutorizadoCelular
        '
        Me.txtAutorizadoCelular.Location = New System.Drawing.Point(4, 28)
        Me.txtAutorizadoCelular.Name = "txtAutorizadoCelular"
        Me.txtAutorizadoCelular.Size = New System.Drawing.Size(269, 22)
        Me.txtAutorizadoCelular.TabIndex = 50
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(40, 7)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 17)
        Me.Label44.TabIndex = 49
        Me.Label44.Text = "Celular:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label43)
        Me.Panel6.Controls.Add(Me.AutorizadoHasta)
        Me.Panel6.Location = New System.Drawing.Point(3, 129)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(277, 57)
        Me.Panel6.TabIndex = 64
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(40, 7)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(74, 17)
        Me.Label43.TabIndex = 48
        Me.Label43.Text = "Fecha Fin:"
        '
        'AutorizadoHasta
        '
        Me.AutorizadoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AutorizadoHasta.Location = New System.Drawing.Point(4, 28)
        Me.AutorizadoHasta.Name = "AutorizadoHasta"
        Me.AutorizadoHasta.Size = New System.Drawing.Size(269, 22)
        Me.AutorizadoHasta.TabIndex = 47
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtAutorizadoTelefono)
        Me.Panel7.Controls.Add(Me.Label42)
        Me.Panel7.Location = New System.Drawing.Point(286, 129)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(277, 57)
        Me.Panel7.TabIndex = 65
        '
        'txtAutorizadoTelefono
        '
        Me.txtAutorizadoTelefono.Location = New System.Drawing.Point(4, 27)
        Me.txtAutorizadoTelefono.Name = "txtAutorizadoTelefono"
        Me.txtAutorizadoTelefono.Size = New System.Drawing.Size(269, 22)
        Me.txtAutorizadoTelefono.TabIndex = 46
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(40, 7)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(68, 17)
        Me.Label42.TabIndex = 45
        Me.Label42.Text = "Telefono:"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtAutorizadoEmail)
        Me.Panel8.Controls.Add(Me.Label45)
        Me.Panel8.Location = New System.Drawing.Point(3, 192)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(277, 57)
        Me.Panel8.TabIndex = 66
        '
        'txtAutorizadoEmail
        '
        Me.txtAutorizadoEmail.Location = New System.Drawing.Point(4, 27)
        Me.txtAutorizadoEmail.Name = "txtAutorizadoEmail"
        Me.txtAutorizadoEmail.Size = New System.Drawing.Size(269, 22)
        Me.txtAutorizadoEmail.TabIndex = 52
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(40, 7)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(46, 17)
        Me.Label45.TabIndex = 51
        Me.Label45.Text = "Email:"
        '
        'frmAsociadoNuevo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 473)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmAsociadoNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AsociadoNuevo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Asociadas As System.Windows.Forms.ListBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAsociarLista As System.Windows.Forms.Button
    Friend WithEvents Cuentas As System.Windows.Forms.ListBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkDocumento As System.Windows.Forms.LinkLabel
    Friend WithEvents txtAutorizadoDoc As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtAutorizadoNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtAutorizadoDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtAutorizadoCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents AutorizadoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtAutorizadoTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtAutorizadoEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
End Class
