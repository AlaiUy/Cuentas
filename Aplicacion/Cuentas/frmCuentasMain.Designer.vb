<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentasMain
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LinkNuevo = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GridCuentas = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GridCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 493)
        Me.Panel1.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.LinkNuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.LinkLabel1)
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 121)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(680, 40)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'LinkNuevo
        '
        Me.LinkNuevo.AutoSize = True
        Me.LinkNuevo.Location = New System.Drawing.Point(10, 10)
        Me.LinkNuevo.Margin = New System.Windows.Forms.Padding(10)
        Me.LinkNuevo.Name = "LinkNuevo"
        Me.LinkNuevo.Size = New System.Drawing.Size(56, 20)
        Me.LinkNuevo.TabIndex = 0
        Me.LinkNuevo.TabStop = True
        Me.LinkNuevo.Text = "Nuevo"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(86, 10)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(78, 20)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Modificar"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.GridCuentas)
        Me.Panel4.Location = New System.Drawing.Point(6, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(680, 320)
        Me.Panel4.TabIndex = 4
        '
        'GridCuentas
        '
        Me.GridCuentas.AllowUserToAddRows = False
        Me.GridCuentas.AllowUserToDeleteRows = False
        Me.GridCuentas.AllowUserToResizeRows = False
        Me.GridCuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridCuentas.BackgroundColor = System.Drawing.Color.White
        Me.GridCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCuentas.Location = New System.Drawing.Point(0, 3)
        Me.GridCuentas.Name = "GridCuentas"
        Me.GridCuentas.ReadOnly = True
        Me.GridCuentas.RowHeadersVisible = False
        Me.GridCuentas.RowTemplate.Height = 24
        Me.GridCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridCuentas.Size = New System.Drawing.Size(677, 314)
        Me.GridCuentas.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtdireccion)
        Me.Panel2.Controls.Add(Me.txtnombre)
        Me.Panel2.Controls.Add(Me.lblDireccion)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.btnCargar)
        Me.Panel2.Controls.Add(Me.txtCuenta)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(680, 110)
        Me.Panel2.TabIndex = 0
        '
        'txtdireccion
        '
        Me.txtdireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdireccion.Location = New System.Drawing.Point(155, 79)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(520, 28)
        Me.txtdireccion.TabIndex = 8
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombre.Location = New System.Drawing.Point(155, 48)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(520, 28)
        Me.txtnombre.TabIndex = 7
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(13, 84)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(86, 20)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(13, 52)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 20)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre:"
        '
        'btnCargar
        '
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Update
        Me.btnCargar.Location = New System.Drawing.Point(332, 2)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(44, 45)
        Me.btnCargar.TabIndex = 3
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(155, 6)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(171, 28)
        Me.txtCuenta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Documento/Cta:"
        '
        'frmCuentasMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(698, 501)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCuentasMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CuentasMain"
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GridCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LinkNuevo As System.Windows.Forms.LinkLabel
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
