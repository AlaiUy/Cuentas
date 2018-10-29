<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verDetalleBoleta
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
        Me.DGDetalle = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DGDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DGDetalle)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 594)
        Me.Panel1.TabIndex = 0
        '
        'DGDetalle
        '
        Me.DGDetalle.AllowUserToAddRows = False
        Me.DGDetalle.AllowUserToDeleteRows = False
        Me.DGDetalle.AllowUserToResizeRows = False
        Me.DGDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGDetalle.BackgroundColor = System.Drawing.Color.White
        Me.DGDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGDetalle.Location = New System.Drawing.Point(0, 0)
        Me.DGDetalle.Name = "DGDetalle"
        Me.DGDetalle.ReadOnly = True
        Me.DGDetalle.RowHeadersVisible = False
        Me.DGDetalle.RowTemplate.Height = 24
        Me.DGDetalle.Size = New System.Drawing.Size(793, 594)
        Me.DGDetalle.TabIndex = 1
        '
        'verDetalleBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "verDetalleBoleta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "verDetalleBoleta"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents DGDetalle As Windows.Forms.DataGridView
End Class
