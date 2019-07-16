<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuListados
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
        Me.Container = New System.Windows.Forms.Panel()
        Me.btnListarInco = New System.Windows.Forms.Button()
        Me.Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Container
        '
        Me.Container.Controls.Add(Me.btnListarInco)
        Me.Container.Location = New System.Drawing.Point(3, 4)
        Me.Container.Name = "Container"
        Me.Container.Size = New System.Drawing.Size(544, 363)
        Me.Container.TabIndex = 0
        '
        'btnListarInco
        '
        Me.btnListarInco.Location = New System.Drawing.Point(9, 8)
        Me.btnListarInco.Name = "btnListarInco"
        Me.btnListarInco.Size = New System.Drawing.Size(113, 56)
        Me.btnListarInco.TabIndex = 0
        Me.btnListarInco.Text = "Listar Incobrables"
        Me.btnListarInco.UseVisualStyleBackColor = True
        '
        'frmMenuListados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(549, 370)
        Me.Controls.Add(Me.Container)
        Me.KeyPreview = True
        Me.Name = "frmMenuListados"
        Me.Text = "frmMenuListados"
        Me.Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Container As Windows.Forms.Panel
    Friend WithEvents btnListarInco As Windows.Forms.Button
End Class
