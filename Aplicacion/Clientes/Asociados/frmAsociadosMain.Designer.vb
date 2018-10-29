<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsociadosMain
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
        Me.GridAutorizadas = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LinkNuevo = New System.Windows.Forms.LinkLabel()
        Me.LinkModificar = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GTitular = New System.Windows.Forms.GroupBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txttelefonotitular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdirecciontitular = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombretitular = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.GridAutorizadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GTitular.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GridAutorizadas)
        Me.Panel1.Location = New System.Drawing.Point(17, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 312)
        Me.Panel1.TabIndex = 3
        '
        'GridAutorizadas
        '
        Me.GridAutorizadas.AllowUserToAddRows = False
        Me.GridAutorizadas.AllowUserToDeleteRows = False
        Me.GridAutorizadas.AllowUserToResizeRows = False
        Me.GridAutorizadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridAutorizadas.BackgroundColor = System.Drawing.Color.White
        Me.GridAutorizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAutorizadas.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridAutorizadas.Location = New System.Drawing.Point(0, 0)
        Me.GridAutorizadas.Name = "GridAutorizadas"
        Me.GridAutorizadas.ReadOnly = True
        Me.GridAutorizadas.RowHeadersVisible = False
        Me.GridAutorizadas.RowTemplate.Height = 24
        Me.GridAutorizadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridAutorizadas.Size = New System.Drawing.Size(794, 309)
        Me.GridAutorizadas.TabIndex = 9
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.LinkNuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.LinkModificar)
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(17, 167)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(795, 28)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'LinkNuevo
        '
        Me.LinkNuevo.AutoSize = True
        Me.LinkNuevo.Location = New System.Drawing.Point(3, 3)
        Me.LinkNuevo.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkNuevo.Name = "LinkNuevo"
        Me.LinkNuevo.Size = New System.Drawing.Size(56, 20)
        Me.LinkNuevo.TabIndex = 0
        Me.LinkNuevo.TabStop = True
        Me.LinkNuevo.Text = "Nuevo"
        '
        'LinkModificar
        '
        Me.LinkModificar.AutoSize = True
        Me.LinkModificar.Location = New System.Drawing.Point(65, 3)
        Me.LinkModificar.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkModificar.Name = "LinkModificar"
        Me.LinkModificar.Size = New System.Drawing.Size(78, 20)
        Me.LinkModificar.TabIndex = 1
        Me.LinkModificar.TabStop = True
        Me.LinkModificar.Text = "Modificar"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GTitular)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(8, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(826, 517)
        Me.Panel2.TabIndex = 5
        '
        'GTitular
        '
        Me.GTitular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GTitular.BackColor = System.Drawing.Color.Transparent
        Me.GTitular.Controls.Add(Me.btnCargar)
        Me.GTitular.Controls.Add(Me.txttelefonotitular)
        Me.GTitular.Controls.Add(Me.Label4)
        Me.GTitular.Controls.Add(Me.Label1)
        Me.GTitular.Controls.Add(Me.txtdirecciontitular)
        Me.GTitular.Controls.Add(Me.txtCuenta)
        Me.GTitular.Controls.Add(Me.Label3)
        Me.GTitular.Controls.Add(Me.txtNombretitular)
        Me.GTitular.Controls.Add(Me.Label2)
        Me.GTitular.Location = New System.Drawing.Point(17, 5)
        Me.GTitular.Name = "GTitular"
        Me.GTitular.Size = New System.Drawing.Size(795, 160)
        Me.GTitular.TabIndex = 2
        Me.GTitular.TabStop = False
        Me.GTitular.Text = "Cuenta - C.I.:"
        '
        'btnCargar
        '
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Update
        Me.btnCargar.Location = New System.Drawing.Point(366, 13)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(44, 43)
        Me.btnCargar.TabIndex = 9
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txttelefonotitular
        '
        Me.txttelefonotitular.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefonotitular.Location = New System.Drawing.Point(177, 128)
        Me.txttelefonotitular.Name = "txttelefonotitular"
        Me.txttelefonotitular.Size = New System.Drawing.Size(138, 28)
        Me.txttelefonotitular.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de cuenta.:"
        '
        'txtdirecciontitular
        '
        Me.txtdirecciontitular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdirecciontitular.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirecciontitular.Location = New System.Drawing.Point(177, 94)
        Me.txtdirecciontitular.Name = "txtdirecciontitular"
        Me.txtdirecciontitular.Size = New System.Drawing.Size(601, 28)
        Me.txtdirecciontitular.TabIndex = 6
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(177, 19)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(183, 28)
        Me.txtCuenta.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Direccion:"
        '
        'txtNombretitular
        '
        Me.txtNombretitular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombretitular.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombretitular.Location = New System.Drawing.Point(177, 60)
        Me.txtNombretitular.Name = "txtNombretitular"
        Me.txtNombretitular.Size = New System.Drawing.Size(601, 28)
        Me.txtNombretitular.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'frmAsociadosMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 533)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmAsociadosMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_Asociar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridAutorizadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GTitular.ResumeLayout(False)
        Me.GTitular.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridAutorizadas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LinkNuevo As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GTitular As System.Windows.Forms.GroupBox
    Friend WithEvents txttelefonotitular As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdirecciontitular As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombretitular As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents LinkModificar As System.Windows.Forms.LinkLabel
End Class
