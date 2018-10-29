<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.body = New System.Windows.Forms.Panel()
        Me.GridMPendientes = New System.Windows.Forms.DataGridView()
        Me.footer = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.txtPagarDolares = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPagarPesos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkMora = New System.Windows.Forms.CheckBox()
        Me.RDDolares = New System.Windows.Forms.RadioButton()
        Me.RDPesos = New System.Windows.Forms.RadioButton()
        Me.RDMulti = New System.Windows.Forms.RadioButton()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnEC = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotalDolares = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTotalPesos = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtMoraDolares = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMoraPesos = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSaldoDolares = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSaldoPesos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.txtClienteTelefono = New System.Windows.Forms.TextBox()
        Me.txtClienteDireccion = New System.Windows.Forms.TextBox()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.body.SuspendLayout()
        CType(Me.GridMPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.footer.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.header.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 721)
        Me.Panel1.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1006, 721)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel16)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(998, 692)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.body)
        Me.Panel16.Controls.Add(Me.footer)
        Me.Panel16.Controls.Add(Me.header)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(992, 686)
        Me.Panel16.TabIndex = 0
        '
        'body
        '
        Me.body.Controls.Add(Me.GridMPendientes)
        Me.body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.body.Location = New System.Drawing.Point(0, 212)
        Me.body.Name = "body"
        Me.body.Size = New System.Drawing.Size(992, 383)
        Me.body.TabIndex = 2
        '
        'GridMPendientes
        '
        Me.GridMPendientes.AllowUserToAddRows = False
        Me.GridMPendientes.AllowUserToDeleteRows = False
        Me.GridMPendientes.AllowUserToResizeRows = False
        Me.GridMPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GridMPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMPendientes.Location = New System.Drawing.Point(0, 0)
        Me.GridMPendientes.MultiSelect = False
        Me.GridMPendientes.Name = "GridMPendientes"
        Me.GridMPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GridMPendientes.RowHeadersVisible = False
        Me.GridMPendientes.RowTemplate.Height = 24
        Me.GridMPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridMPendientes.ShowCellErrors = False
        Me.GridMPendientes.ShowCellToolTips = False
        Me.GridMPendientes.ShowEditingIcon = False
        Me.GridMPendientes.ShowRowErrors = False
        Me.GridMPendientes.Size = New System.Drawing.Size(992, 383)
        Me.GridMPendientes.TabIndex = 0
        '
        'footer
        '
        Me.footer.Controls.Add(Me.Panel21)
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 595)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(992, 91)
        Me.footer.TabIndex = 1
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.Button2)
        Me.Panel21.Controls.Add(Me.btnPagar)
        Me.Panel21.Controls.Add(Me.Panel22)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel21.Location = New System.Drawing.Point(0, 6)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(992, 85)
        Me.Panel21.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(157, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(10, 6)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(87, 74)
        Me.btnPagar.TabIndex = 1
        Me.btnPagar.Text = "Button1"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.txtPagarDolares)
        Me.Panel22.Controls.Add(Me.Label1)
        Me.Panel22.Controls.Add(Me.txtPagarPesos)
        Me.Panel22.Controls.Add(Me.Label6)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel22.Location = New System.Drawing.Point(656, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(336, 85)
        Me.Panel22.TabIndex = 0
        '
        'txtPagarDolares
        '
        Me.txtPagarDolares.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagarDolares.Location = New System.Drawing.Point(127, 51)
        Me.txtPagarDolares.Name = "txtPagarDolares"
        Me.txtPagarDolares.Size = New System.Drawing.Size(203, 28)
        Me.txtPagarDolares.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "a pagar U$S:"
        '
        'txtPagarPesos
        '
        Me.txtPagarPesos.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagarPesos.Location = New System.Drawing.Point(127, 6)
        Me.txtPagarPesos.Name = "txtPagarPesos"
        Me.txtPagarPesos.Size = New System.Drawing.Size(203, 28)
        Me.txtPagarPesos.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 21)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "a pagar $:"
        '
        'header
        '
        Me.header.Controls.Add(Me.Panel18)
        Me.header.Controls.Add(Me.Panel17)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(992, 212)
        Me.header.TabIndex = 0
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.GroupBox4)
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Controls.Add(Me.GroupBox3)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(563, 212)
        Me.Panel18.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkMora)
        Me.GroupBox4.Controls.Add(Me.RDDolares)
        Me.GroupBox4.Controls.Add(Me.RDPesos)
        Me.GroupBox4.Controls.Add(Me.RDMulti)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 101)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 102)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtro"
        '
        'chkMora
        '
        Me.chkMora.AutoSize = True
        Me.chkMora.Location = New System.Drawing.Point(123, 21)
        Me.chkMora.Name = "chkMora"
        Me.chkMora.Size = New System.Drawing.Size(62, 21)
        Me.chkMora.TabIndex = 7
        Me.chkMora.Text = "Mora"
        Me.chkMora.UseVisualStyleBackColor = True
        '
        'RDDolares
        '
        Me.RDDolares.AutoSize = True
        Me.RDDolares.Location = New System.Drawing.Point(8, 75)
        Me.RDDolares.Name = "RDDolares"
        Me.RDDolares.Size = New System.Drawing.Size(78, 21)
        Me.RDDolares.TabIndex = 6
        Me.RDDolares.TabStop = True
        Me.RDDolares.Text = "Dolares"
        Me.RDDolares.UseVisualStyleBackColor = True
        '
        'RDPesos
        '
        Me.RDPesos.AutoSize = True
        Me.RDPesos.Location = New System.Drawing.Point(8, 47)
        Me.RDPesos.Name = "RDPesos"
        Me.RDPesos.Size = New System.Drawing.Size(68, 21)
        Me.RDPesos.TabIndex = 5
        Me.RDPesos.TabStop = True
        Me.RDPesos.Text = "Pesos"
        Me.RDPesos.UseVisualStyleBackColor = True
        '
        'RDMulti
        '
        Me.RDMulti.AutoSize = True
        Me.RDMulti.Location = New System.Drawing.Point(8, 21)
        Me.RDMulti.Name = "RDMulti"
        Me.RDMulti.Size = New System.Drawing.Size(109, 21)
        Me.RDMulti.TabIndex = 4
        Me.RDMulti.TabStop = True
        Me.RDMulti.Text = "Multimoneda"
        Me.RDMulti.UseVisualStyleBackColor = True
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Button1)
        Me.Panel19.Controls.Add(Me.Button4)
        Me.Panel19.Controls.Add(Me.btnEC)
        Me.Panel19.Location = New System.Drawing.Point(5, 99)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(551, 107)
        Me.Panel19.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(422, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 89)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Adjudicar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(322, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 89)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Bonificacion"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnEC
        '
        Me.btnEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEC.Location = New System.Drawing.Point(233, 12)
        Me.btnEC.Name = "btnEC"
        Me.btnEC.Size = New System.Drawing.Size(83, 89)
        Me.btnEC.TabIndex = 1
        Me.btnEC.Text = "Entrega a Cuenta"
        Me.btnEC.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTotalDolares)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtTotalPesos)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtMoraDolares)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtMoraPesos)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtSaldoDolares)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtSaldoPesos)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(551, 89)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'txtTotalDolares
        '
        Me.txtTotalDolares.Location = New System.Drawing.Point(410, 55)
        Me.txtTotalDolares.Name = "txtTotalDolares"
        Me.txtTotalDolares.Size = New System.Drawing.Size(132, 22)
        Me.txtTotalDolares.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(360, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 17)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Total:"
        '
        'txtTotalPesos
        '
        Me.txtTotalPesos.Location = New System.Drawing.Point(410, 21)
        Me.txtTotalPesos.Name = "txtTotalPesos"
        Me.txtTotalPesos.Size = New System.Drawing.Size(132, 22)
        Me.txtTotalPesos.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(360, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 17)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Total:"
        '
        'txtMoraDolares
        '
        Me.txtMoraDolares.Location = New System.Drawing.Point(243, 55)
        Me.txtMoraDolares.Name = "txtMoraDolares"
        Me.txtMoraDolares.Size = New System.Drawing.Size(113, 22)
        Me.txtMoraDolares.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(193, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 17)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Mora:"
        '
        'txtMoraPesos
        '
        Me.txtMoraPesos.Location = New System.Drawing.Point(243, 21)
        Me.txtMoraPesos.Name = "txtMoraPesos"
        Me.txtMoraPesos.Size = New System.Drawing.Size(113, 22)
        Me.txtMoraPesos.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(193, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 17)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Mora:"
        '
        'txtSaldoDolares
        '
        Me.txtSaldoDolares.Location = New System.Drawing.Point(69, 55)
        Me.txtSaldoDolares.Name = "txtSaldoDolares"
        Me.txtSaldoDolares.Size = New System.Drawing.Size(122, 22)
        Me.txtSaldoDolares.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 17)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Dolares:"
        '
        'txtSaldoPesos
        '
        Me.txtSaldoPesos.Location = New System.Drawing.Point(69, 21)
        Me.txtSaldoPesos.Name = "txtSaldoPesos"
        Me.txtSaldoPesos.Size = New System.Drawing.Size(122, 22)
        Me.txtSaldoPesos.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 17)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Pesos:"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Panel20)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel17.Location = New System.Drawing.Point(529, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(463, 212)
        Me.Panel17.TabIndex = 0
        '
        'Panel20
        '
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.txtClienteTelefono)
        Me.Panel20.Controls.Add(Me.txtClienteDireccion)
        Me.Panel20.Controls.Add(Me.txtClienteNombre)
        Me.Panel20.Controls.Add(Me.txtCodCliente)
        Me.Panel20.Controls.Add(Me.Label4)
        Me.Panel20.Controls.Add(Me.Label5)
        Me.Panel20.Controls.Add(Me.Label16)
        Me.Panel20.Controls.Add(Me.LinkLabel2)
        Me.Panel20.Location = New System.Drawing.Point(40, 3)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(417, 151)
        Me.Panel20.TabIndex = 0
        '
        'txtClienteTelefono
        '
        Me.txtClienteTelefono.Location = New System.Drawing.Point(75, 121)
        Me.txtClienteTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClienteTelefono.Name = "txtClienteTelefono"
        Me.txtClienteTelefono.ReadOnly = True
        Me.txtClienteTelefono.Size = New System.Drawing.Size(132, 22)
        Me.txtClienteTelefono.TabIndex = 25
        '
        'txtClienteDireccion
        '
        Me.txtClienteDireccion.Location = New System.Drawing.Point(75, 77)
        Me.txtClienteDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClienteDireccion.Multiline = True
        Me.txtClienteDireccion.Name = "txtClienteDireccion"
        Me.txtClienteDireccion.ReadOnly = True
        Me.txtClienteDireccion.Size = New System.Drawing.Size(336, 36)
        Me.txtClienteDireccion.TabIndex = 24
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Location = New System.Drawing.Point(75, 32)
        Me.txtClienteNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClienteNombre.Multiline = True
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.ReadOnly = True
        Me.txtClienteNombre.Size = New System.Drawing.Size(336, 38)
        Me.txtClienteNombre.TabIndex = 23
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(75, 6)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(158, 22)
        Me.txtCodCliente.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 77)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Direccion"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 32)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 17)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Nombre"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(9, 6)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(37, 17)
        Me.LinkLabel2.TabIndex = 18
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Cod."
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.body.ResumeLayout(False)
        CType(Me.GridMPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.footer.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.header.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents body As System.Windows.Forms.Panel
    Friend WithEvents GridMPendientes As System.Windows.Forms.DataGridView
    Friend WithEvents footer As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents txtPagarPesos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RDDolares As System.Windows.Forms.RadioButton
    Friend WithEvents RDPesos As System.Windows.Forms.RadioButton
    Friend WithEvents RDMulti As System.Windows.Forms.RadioButton
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalDolares As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPesos As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtMoraDolares As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMoraPesos As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDolares As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoPesos As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents txtClienteTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents chkMora As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnEC As System.Windows.Forms.Button
    Friend WithEvents txtPagarDolares As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
