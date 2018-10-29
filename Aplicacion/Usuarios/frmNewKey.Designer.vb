<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewKey
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
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCambiar)
        Me.Panel1.Controls.Add(Me.txtpass)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 144)
        Me.Panel1.TabIndex = 0
        '
        'btnCambiar
        '
        Me.btnCambiar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiar.Location = New System.Drawing.Point(121, 87)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(95, 46)
        Me.btnCambiar.TabIndex = 5
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(121, 59)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(160, 22)
        Me.txtpass.TabIndex = 4
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(160, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'frmNewKey
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(311, 158)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmNewKey"
        Me.Text = "frmNewKey"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnCambiar As Windows.Forms.Button
    Friend WithEvents txtpass As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
