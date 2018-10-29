<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pMain = New System.Windows.Forms.Panel()
        Me.DGParametros = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pMain.SuspendLayout()
        CType(Me.DGParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pMain
        '
        Me.pMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMain.BackColor = System.Drawing.Color.White
        Me.pMain.Controls.Add(Me.DGParametros)
        Me.pMain.Controls.Add(Me.Panel2)
        Me.pMain.Controls.Add(Me.Panel1)
        Me.pMain.Location = New System.Drawing.Point(2, 2)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(595, 483)
        Me.pMain.TabIndex = 1
        '
        'DGParametros
        '
        Me.DGParametros.AllowUserToResizeColumns = False
        Me.DGParametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGParametros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGParametros.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGParametros.Location = New System.Drawing.Point(0, 48)
        Me.DGParametros.Name = "DGParametros"
        Me.DGParametros.RowHeadersVisible = False
        Me.DGParametros.Size = New System.Drawing.Size(595, 397)
        Me.DGParametros.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_Update)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 38)
        Me.Panel2.TabIndex = 1
        '
        'btn_Update
        '
        Me.btn_Update.Location = New System.Drawing.Point(510, 6)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(75, 23)
        Me.btn_Update.TabIndex = 0
        Me.btn_Update.Text = "Do It!"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 48)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(131, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONFIGURACION DE PARAMETROS"
        '
        'frmParametros
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(599, 486)
        Me.Controls.Add(Me.pMain)
        Me.KeyPreview = True
        Me.Name = "frmParametros"
        Me.Text = "frmParametros"
        Me.pMain.ResumeLayout(False)
        CType(Me.DGParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pMain As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents btn_Update As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents DGParametros As Windows.Forms.DataGridView
End Class
