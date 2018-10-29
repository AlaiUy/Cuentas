<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvioEmail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuerpo = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTextAdjunto = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Destinatario:"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailCliente.Location = New System.Drawing.Point(132, 67)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(546, 27)
        Me.txtEmailCliente.TabIndex = 2
        '
        'txtAsunto
        '
        Me.txtAsunto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsunto.Location = New System.Drawing.Point(132, 103)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(546, 27)
        Me.txtAsunto.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Asunto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contenido:"
        '
        'txtCuerpo
        '
        Me.txtCuerpo.Location = New System.Drawing.Point(132, 149)
        Me.txtCuerpo.Name = "txtCuerpo"
        Me.txtCuerpo.Size = New System.Drawing.Size(546, 154)
        Me.txtCuerpo.TabIndex = 6
        Me.txtCuerpo.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Adjunto: "
        '
        'lblTextAdjunto
        '
        Me.lblTextAdjunto.BackColor = System.Drawing.Color.White
        Me.lblTextAdjunto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextAdjunto.Location = New System.Drawing.Point(132, 320)
        Me.lblTextAdjunto.Name = "lblTextAdjunto"
        Me.lblTextAdjunto.Size = New System.Drawing.Size(426, 19)
        Me.lblTextAdjunto.TabIndex = 9
        Me.lblTextAdjunto.Text = "-"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.White
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Image = Global.UI.My.Resources.Resources.mail
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(603, 309)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 42)
        Me.btnEnviar.TabIndex = 10
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.UI.My.Resources.Resources.EmailEC
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 53)
        Me.Panel1.TabIndex = 0
        '
        'frmEnvioEmail
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(711, 354)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lblTextAdjunto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCuerpo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmailCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "frmEnvioEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar estado de cuenta via e-Mail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCuerpo As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTextAdjunto As Label
    Friend WithEvents btnEnviar As Button
End Class
