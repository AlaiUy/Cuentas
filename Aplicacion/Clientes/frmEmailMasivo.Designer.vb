<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailMasivo
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
        Me.btnFiltro = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.btngetClientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblCantidad)
        Me.Panel1.Controls.Add(Me.btnFiltro)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btngetClientes)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 446)
        Me.Panel1.TabIndex = 0
        '
        'btnFiltro
        '
        Me.btnFiltro.Location = New System.Drawing.Point(244, 9)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltro.TabIndex = 4
        Me.btnFiltro.Text = "Filtrar"
        Me.btnFiltro.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.dgClientes)
        Me.Panel2.Location = New System.Drawing.Point(4, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1030, 365)
        Me.Panel2.TabIndex = 3
        '
        'dgClientes
        '
        Me.dgClientes.AllowUserToAddRows = False
        Me.dgClientes.AllowUserToDeleteRows = False
        Me.dgClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgClientes.Location = New System.Drawing.Point(0, 0)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.RowHeadersVisible = False
        Me.dgClientes.Size = New System.Drawing.Size(1030, 365)
        Me.dgClientes.TabIndex = 0
        '
        'btngetClientes
        '
        Me.btngetClientes.Location = New System.Drawing.Point(129, 8)
        Me.btngetClientes.Name = "btngetClientes"
        Me.btngetClientes.Size = New System.Drawing.Size(75, 23)
        Me.btngetClientes.TabIndex = 2
        Me.btngetClientes.Text = "Buscar"
        Me.btngetClientes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Obtener Clientes"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(486, 14)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(39, 13)
        Me.lblCantidad.TabIndex = 1
        Me.lblCantidad.Text = "Label2"
        '
        'frmEmailMasivo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1043, 453)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmEmailMasivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmailMasivo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btngetClientes As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnFiltro As Windows.Forms.Button
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents dgClientes As Windows.Forms.DataGridView
    Friend WithEvents lblCantidad As Windows.Forms.Label
End Class
