<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentasInactivas
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ftnBorrarFiltro = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 488)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DG)
        Me.Panel3.Location = New System.Drawing.Point(9, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(958, 419)
        Me.Panel3.TabIndex = 1
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.AllowUserToResizeRows = False
        Me.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG.Location = New System.Drawing.Point(0, 0)
        Me.DG.Name = "DG"
        Me.DG.RowHeadersVisible = False
        Me.DG.RowTemplate.Height = 24
        Me.DG.Size = New System.Drawing.Size(958, 419)
        Me.DG.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ftnBorrarFiltro)
        Me.Panel2.Controls.Add(Me.txtFiltro)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(8, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(959, 48)
        Me.Panel2.TabIndex = 0
        '
        'ftnBorrarFiltro
        '
        Me.ftnBorrarFiltro.BackColor = System.Drawing.Color.White
        Me.ftnBorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ftnBorrarFiltro.Location = New System.Drawing.Point(387, 7)
        Me.ftnBorrarFiltro.Name = "ftnBorrarFiltro"
        Me.ftnBorrarFiltro.Size = New System.Drawing.Size(94, 32)
        Me.ftnBorrarFiltro.TabIndex = 1
        Me.ftnBorrarFiltro.Text = "&Quitar filtro"
        Me.ftnBorrarFiltro.UseVisualStyleBackColor = False
        '
        'txtFiltro
        '
        Me.txtFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(79, 9)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(291, 27)
        Me.txtFiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtrar:"
        '
        'frmCuentasInactivas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 494)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCuentasInactivas"
        Me.Text = "frmCuentasInactivas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents ftnBorrarFiltro As System.Windows.Forms.Button
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
