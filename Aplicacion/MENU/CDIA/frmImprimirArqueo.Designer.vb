<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirArqueo
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
        Me.txtNumeroArqueo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtNumeroArqueo)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 29)
        Me.Panel1.TabIndex = 0
        '
        'txtNumeroArqueo
        '
        Me.txtNumeroArqueo.Location = New System.Drawing.Point(5, 3)
        Me.txtNumeroArqueo.Name = "txtNumeroArqueo"
        Me.txtNumeroArqueo.Size = New System.Drawing.Size(190, 22)
        Me.txtNumeroArqueo.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(209, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(86, 42)
        Me.Panel2.TabIndex = 1
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(6, 10)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Do It!"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmImprimirArqueo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(295, 42)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmImprimirArqueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmImprimirArqueo"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents txtNumeroArqueo As Windows.Forms.TextBox
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents btnImprimir As Windows.Forms.Button
End Class
