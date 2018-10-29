<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuClientes
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.btnEC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.UI.My.Resources.Resources.coins
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(288, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 73)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Modificar limite"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.UI.My.Resources.Resources.user
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(196, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 73)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Modificar cliente"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCliente.Image = Global.UI.My.Resources.Resources.adduser
        Me.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevoCliente.Location = New System.Drawing.Point(104, 12)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(86, 73)
        Me.btnNuevoCliente.TabIndex = 1
        Me.btnNuevoCliente.Text = "Crear cliente"
        Me.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'btnEC
        '
        Me.btnEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEC.Image = Global.UI.My.Resources.Resources.accounting
        Me.btnEC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEC.Location = New System.Drawing.Point(12, 12)
        Me.btnEC.Name = "btnEC"
        Me.btnEC.Size = New System.Drawing.Size(86, 73)
        Me.btnEC.TabIndex = 0
        Me.btnEC.Text = "Estado de cuenta"
        Me.btnEC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEC.UseVisualStyleBackColor = True
        '
        'frmMenuClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 576)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnNuevoCliente)
        Me.Controls.Add(Me.btnEC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenuClientes"
        Me.Text = "frmMenuClientes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEC As Button
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
