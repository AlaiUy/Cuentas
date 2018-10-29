<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsociadosModificar
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.chkDescatalogada = New System.Windows.Forms.CheckBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(5, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 417)
        Me.Panel1.TabIndex = 0
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
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel9)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel10)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(552, 417)
        Me.FlowLayoutPanel1.TabIndex = 60
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtAutorizadoDoc)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 41)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Documento:"
        '
        'txtAutorizadoDoc
        '
        Me.txtAutorizadoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorizadoDoc.Location = New System.Drawing.Point(112, 4)
        Me.txtAutorizadoDoc.Name = "txtAutorizadoDoc"
        Me.txtAutorizadoDoc.Size = New System.Drawing.Size(420, 28)
        Me.txtAutorizadoDoc.TabIndex = 58
        Me.txtAutorizadoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtAutorizadoNombre)
        Me.Panel3.Controls.Add(Me.Label39)
        Me.Panel3.Location = New System.Drawing.Point(3, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(535, 36)
        Me.Panel3.TabIndex = 60
        '
        'txtAutorizadoNombre
        '
        Me.txtAutorizadoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorizadoNombre.Location = New System.Drawing.Point(112, 4)
        Me.txtAutorizadoNombre.Name = "txtAutorizadoNombre"
        Me.txtAutorizadoNombre.Size = New System.Drawing.Size(420, 28)
        Me.txtAutorizadoNombre.TabIndex = 43
        Me.txtAutorizadoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(33, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(73, 20)
        Me.Label39.TabIndex = 42
        Me.Label39.Text = "Nombre:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtAutorizadoDireccion)
        Me.Panel4.Controls.Add(Me.Label41)
        Me.Panel4.Location = New System.Drawing.Point(3, 92)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(535, 37)
        Me.Panel4.TabIndex = 61
        '
        'txtAutorizadoDireccion
        '
        Me.txtAutorizadoDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorizadoDireccion.Location = New System.Drawing.Point(112, 4)
        Me.txtAutorizadoDireccion.Name = "txtAutorizadoDireccion"
        Me.txtAutorizadoDireccion.Size = New System.Drawing.Size(417, 28)
        Me.txtAutorizadoDireccion.TabIndex = 45
        Me.txtAutorizadoDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(20, 9)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(86, 20)
        Me.Label41.TabIndex = 44
        Me.Label41.Text = "Direccion:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtAutorizadoCelular)
        Me.Panel5.Controls.Add(Me.Label44)
        Me.Panel5.Location = New System.Drawing.Point(3, 135)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(535, 37)
        Me.Panel5.TabIndex = 62
        '
        'txtAutorizadoCelular
        '
        Me.txtAutorizadoCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorizadoCelular.Location = New System.Drawing.Point(112, 4)
        Me.txtAutorizadoCelular.Name = "txtAutorizadoCelular"
        Me.txtAutorizadoCelular.Size = New System.Drawing.Size(417, 28)
        Me.txtAutorizadoCelular.TabIndex = 50
        Me.txtAutorizadoCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(39, 9)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(67, 20)
        Me.Label44.TabIndex = 49
        Me.Label44.Text = "Celular:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label43)
        Me.Panel6.Controls.Add(Me.AutorizadoHasta)
        Me.Panel6.Location = New System.Drawing.Point(3, 178)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(535, 35)
        Me.Panel6.TabIndex = 64
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(18, 9)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 20)
        Me.Label43.TabIndex = 48
        Me.Label43.Text = "Fecha Fin:"
        '
        'AutorizadoHasta
        '
        Me.AutorizadoHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorizadoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AutorizadoHasta.Location = New System.Drawing.Point(112, 3)
        Me.AutorizadoHasta.Name = "AutorizadoHasta"
        Me.AutorizadoHasta.Size = New System.Drawing.Size(417, 28)
        Me.AutorizadoHasta.TabIndex = 47
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtAutorizadoTelefono)
        Me.Panel7.Controls.Add(Me.Label42)
        Me.Panel7.Location = New System.Drawing.Point(3, 219)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(535, 35)
        Me.Panel7.TabIndex = 65
        '
        'txtAutorizadoTelefono
        '
        Me.txtAutorizadoTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorizadoTelefono.Location = New System.Drawing.Point(112, 3)
        Me.txtAutorizadoTelefono.Name = "txtAutorizadoTelefono"
        Me.txtAutorizadoTelefono.Size = New System.Drawing.Size(417, 28)
        Me.txtAutorizadoTelefono.TabIndex = 46
        Me.txtAutorizadoTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(28, 9)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(78, 20)
        Me.Label42.TabIndex = 45
        Me.Label42.Text = "Telefono:"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtAutorizadoEmail)
        Me.Panel8.Controls.Add(Me.Label45)
        Me.Panel8.Location = New System.Drawing.Point(3, 260)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(535, 37)
        Me.Panel8.TabIndex = 66
        '
        'txtAutorizadoEmail
        '
        Me.txtAutorizadoEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorizadoEmail.Location = New System.Drawing.Point(112, 4)
        Me.txtAutorizadoEmail.Name = "txtAutorizadoEmail"
        Me.txtAutorizadoEmail.Size = New System.Drawing.Size(417, 28)
        Me.txtAutorizadoEmail.TabIndex = 52
        Me.txtAutorizadoEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(50, 9)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(56, 20)
        Me.Label45.TabIndex = 51
        Me.Label45.Text = "Email:"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.chkDescatalogada)
        Me.Panel9.Location = New System.Drawing.Point(3, 303)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(535, 33)
        Me.Panel9.TabIndex = 67
        '
        'chkDescatalogada
        '
        Me.chkDescatalogada.AutoSize = True
        Me.chkDescatalogada.Location = New System.Drawing.Point(112, 7)
        Me.chkDescatalogada.Name = "chkDescatalogada"
        Me.chkDescatalogada.Size = New System.Drawing.Size(125, 21)
        Me.chkDescatalogada.TabIndex = 0
        Me.chkDescatalogada.Text = "Descatalogada"
        Me.chkDescatalogada.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnGuardar)
        Me.Panel10.Location = New System.Drawing.Point(3, 342)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(535, 58)
        Me.Panel10.TabIndex = 68
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.DoIt
        Me.btnGuardar.Location = New System.Drawing.Point(3, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(50, 51)
        Me.btnGuardar.TabIndex = 72
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmAsociadosModificar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(562, 425)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmAsociadosModificar"
        Me.Text = "AsociadosModificar"
        Me.Panel1.ResumeLayout(False)
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
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents chkDescatalogada As System.Windows.Forms.CheckBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
