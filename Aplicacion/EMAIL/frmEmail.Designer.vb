<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmail
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAdjunto = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReceptor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnEnviarEmail = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 460)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblAdjunto)
        Me.Panel2.Controls.Add(Me.txtMensaje)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtAsunto)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtReceptor)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(9, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 444)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Envio de estado de cuenta:"
        '
        'lblAdjunto
        '
        Me.lblAdjunto.AutoSize = True
        Me.lblAdjunto.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjunto.Location = New System.Drawing.Point(94, 405)
        Me.lblAdjunto.Name = "lblAdjunto"
        Me.lblAdjunto.Size = New System.Drawing.Size(0, 21)
        Me.lblAdjunto.TabIndex = 8
        '
        'txtMensaje
        '
        Me.txtMensaje.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(98, 179)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(620, 185)
        Me.txtMensaje.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Mensaje:"
        '
        'txtAsunto
        '
        Me.txtAsunto.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsunto.Location = New System.Drawing.Point(98, 134)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(620, 28)
        Me.txtAsunto.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Asunto:"
        '
        'txtReceptor
        '
        Me.txtReceptor.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceptor.Location = New System.Drawing.Point(98, 83)
        Me.txtReceptor.Name = "txtReceptor"
        Me.txtReceptor.Size = New System.Drawing.Size(620, 28)
        Me.txtReceptor.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Para:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 370)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(726, 72)
        Me.Panel3.TabIndex = 16
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnEnviarEmail)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(669, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(57, 72)
        Me.Panel4.TabIndex = 0
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarEmail.Image = Global.Aguiñagalde.Aplicacion.My.Resources.AguiResources.Email
        Me.btnEnviarEmail.Location = New System.Drawing.Point(3, 3)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(46, 42)
        Me.btnEnviarEmail.TabIndex = 15
        Me.btnEnviarEmail.UseVisualStyleBackColor = True
        '
        'frmEmail
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 468)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents lblAdjunto As Windows.Forms.Label
    Friend WithEvents txtMensaje As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtAsunto As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtReceptor As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents btnEnviarEmail As Windows.Forms.Button
End Class
