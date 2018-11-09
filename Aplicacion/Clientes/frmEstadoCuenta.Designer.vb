<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoCuenta
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LinkPesos = New System.Windows.Forms.LinkLabel()
        Me.LinkDolares = New System.Windows.Forms.LinkLabel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.LinkLbPendientes = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkToPDF = New System.Windows.Forms.LinkLabel()
        Me.LinkReporte = New System.Windows.Forms.LinkLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtTotalDolares = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalPesos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtTotalParcial = New System.Windows.Forms.TextBox()
        Me.lbltotalparcial = New System.Windows.Forms.Label()
        Me.DGMovimientos = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.FechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.txtCuenta = New Aguinagalde.Controles.TextBoxNumerico()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TipPendiente = New System.Windows.Forms.ToolTip(Me.components)
        Me.FechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 599)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.DGMovimientos)
        Me.Panel4.Location = New System.Drawing.Point(13, 134)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(936, 462)
        Me.Panel4.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(936, 57)
        Me.Panel7.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.LinkPesos)
        Me.Panel8.Controls.Add(Me.LinkDolares)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(6, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(928, 52)
        Me.Panel8.TabIndex = 0
        '
        'LinkPesos
        '
        Me.LinkPesos.BackColor = System.Drawing.Color.White
        Me.LinkPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkPesos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkPesos.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.MonedaMuestra
        Me.LinkPesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkPesos.Location = New System.Drawing.Point(3, 3)
        Me.LinkPesos.Name = "LinkPesos"
        Me.LinkPesos.Size = New System.Drawing.Size(108, 41)
        Me.LinkPesos.TabIndex = 8
        Me.LinkPesos.TabStop = True
        Me.LinkPesos.Text = "Ver Pesos"
        Me.LinkPesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkDolares
        '
        Me.LinkDolares.BackColor = System.Drawing.Color.White
        Me.LinkDolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkDolares.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkDolares.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.MonedaMuestra
        Me.LinkDolares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkDolares.Location = New System.Drawing.Point(117, 3)
        Me.LinkDolares.Name = "LinkDolares"
        Me.LinkDolares.Size = New System.Drawing.Size(124, 41)
        Me.LinkDolares.TabIndex = 7
        Me.LinkDolares.TabStop = True
        Me.LinkDolares.Text = "Ver Dolares"
        Me.LinkDolares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.LinkLbPendientes)
        Me.Panel9.Controls.Add(Me.LinkLabel3)
        Me.Panel9.Controls.Add(Me.LinkToPDF)
        Me.Panel9.Controls.Add(Me.LinkReporte)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(347, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(579, 50)
        Me.Panel9.TabIndex = 6
        '
        'LinkLbPendientes
        '
        Me.LinkLbPendientes.BackColor = System.Drawing.Color.White
        Me.LinkLbPendientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLbPendientes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLbPendientes.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.ForPay
        Me.LinkLbPendientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLbPendientes.Location = New System.Drawing.Point(399, 3)
        Me.LinkLbPendientes.Name = "LinkLbPendientes"
        Me.LinkLbPendientes.Size = New System.Drawing.Size(175, 41)
        Me.LinkLbPendientes.TabIndex = 7
        Me.LinkLbPendientes.TabStop = True
        Me.LinkLbPendientes.Text = "Imprimir Pendientes"
        Me.LinkLbPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel3
        '
        Me.LinkLabel3.BackColor = System.Drawing.Color.White
        Me.LinkLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Email
        Me.LinkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel3.Location = New System.Drawing.Point(247, 3)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(146, 41)
        Me.LinkLabel3.TabIndex = 6
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Enviar por email"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkToPDF
        '
        Me.LinkToPDF.BackColor = System.Drawing.Color.White
        Me.LinkToPDF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkToPDF.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkToPDF.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.pdf
        Me.LinkToPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkToPDF.Location = New System.Drawing.Point(112, 3)
        Me.LinkToPDF.Name = "LinkToPDF"
        Me.LinkToPDF.Size = New System.Drawing.Size(129, 41)
        Me.LinkToPDF.TabIndex = 5
        Me.LinkToPDF.TabStop = True
        Me.LinkToPDF.Text = "Generar PDF"
        Me.LinkToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkReporte
        '
        Me.LinkReporte.BackColor = System.Drawing.Color.White
        Me.LinkReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkReporte.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkReporte.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.printer
        Me.LinkReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkReporte.Location = New System.Drawing.Point(3, 3)
        Me.LinkReporte.Name = "LinkReporte"
        Me.LinkReporte.Size = New System.Drawing.Size(103, 41)
        Me.LinkReporte.TabIndex = 4
        Me.LinkReporte.TabStop = True
        Me.LinkReporte.Text = "Imprimir"
        Me.LinkReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 382)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(936, 80)
        Me.Panel5.TabIndex = 1
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.txtTotalDolares)
        Me.Panel12.Controls.Add(Me.Label9)
        Me.Panel12.Controls.Add(Me.txtTotalPesos)
        Me.Panel12.Controls.Add(Me.Label5)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 41)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(934, 37)
        Me.Panel12.TabIndex = 1
        '
        'txtTotalDolares
        '
        Me.txtTotalDolares.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDolares.Location = New System.Drawing.Point(405, 5)
        Me.txtTotalDolares.Name = "txtTotalDolares"
        Me.txtTotalDolares.Size = New System.Drawing.Size(192, 27)
        Me.txtTotalDolares.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label9.Location = New System.Drawing.Point(295, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total U$S:"
        '
        'txtTotalPesos
        '
        Me.txtTotalPesos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPesos.Location = New System.Drawing.Point(95, 5)
        Me.txtTotalPesos.Name = "txtTotalPesos"
        Me.txtTotalPesos.Size = New System.Drawing.Size(194, 27)
        Me.txtTotalPesos.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total $:"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel14)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(934, 42)
        Me.Panel6.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.txtTotalParcial)
        Me.Panel14.Controls.Add(Me.lbltotalparcial)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(606, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(326, 40)
        Me.Panel14.TabIndex = 1
        '
        'txtTotalParcial
        '
        Me.txtTotalParcial.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalParcial.Location = New System.Drawing.Point(137, 5)
        Me.txtTotalParcial.Name = "txtTotalParcial"
        Me.txtTotalParcial.Size = New System.Drawing.Size(183, 27)
        Me.txtTotalParcial.TabIndex = 4
        '
        'lbltotalparcial
        '
        Me.lbltotalparcial.AutoSize = True
        Me.lbltotalparcial.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalparcial.ForeColor = System.Drawing.Color.Red
        Me.lbltotalparcial.Location = New System.Drawing.Point(5, 8)
        Me.lbltotalparcial.Margin = New System.Windows.Forms.Padding(0)
        Me.lbltotalparcial.Name = "lbltotalparcial"
        Me.lbltotalparcial.Size = New System.Drawing.Size(106, 19)
        Me.lbltotalparcial.TabIndex = 3
        Me.lbltotalparcial.Text = "Importe U$S:"
        '
        'DGMovimientos
        '
        Me.DGMovimientos.AllowUserToAddRows = False
        Me.DGMovimientos.AllowUserToDeleteRows = False
        Me.DGMovimientos.AllowUserToResizeRows = False
        Me.DGMovimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGMovimientos.BackgroundColor = System.Drawing.Color.White
        Me.DGMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMovimientos.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGMovimientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGMovimientos.EnableHeadersVisualStyles = False
        Me.DGMovimientos.Location = New System.Drawing.Point(6, 60)
        Me.DGMovimientos.Name = "DGMovimientos"
        Me.DGMovimientos.ReadOnly = True
        Me.DGMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGMovimientos.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGMovimientos.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DGMovimientos.RowTemplate.Height = 24
        Me.DGMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMovimientos.Size = New System.Drawing.Size(912, 316)
        Me.DGMovimientos.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(935, 121)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(935, 121)
        Me.Panel3.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel10)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(935, 121)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel10.Controls.Add(Me.FechaHasta)
        Me.Panel10.Controls.Add(Me.FechaDesde)
        Me.Panel10.Controls.Add(Me.txtCuenta)
        Me.Panel10.Controls.Add(Me.btnBuscar)
        Me.Panel10.Controls.Add(Me.txtDireccion)
        Me.Panel10.Controls.Add(Me.txtNombre)
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Controls.Add(Me.Label2)
        Me.Panel10.Controls.Add(Me.btnGenerar)
        Me.Panel10.Controls.Add(Me.Label1)
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Controls.Add(Me.Label7)
        Me.Panel10.Location = New System.Drawing.Point(6, 12)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(917, 97)
        Me.Panel10.TabIndex = 5
        '
        'FechaDesde
        '
        Me.FechaDesde.Location = New System.Drawing.Point(143, 45)
        Me.FechaDesde.Mask = "00/00/0000"
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(77, 20)
        Me.FechaDesde.TabIndex = 29
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(143, 6)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(161, 33)
        Me.txtCuenta.TabIndex = 28
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Search
        Me.btnBuscar.Location = New System.Drawing.Point(310, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 40)
        Me.btnBuscar.TabIndex = 27
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Location = New System.Drawing.Point(451, 35)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(461, 20)
        Me.txtDireccion.TabIndex = 26
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(451, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(461, 20)
        Me.txtNombre.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(380, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre:"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.DoIt
        Me.btnGenerar.Location = New System.Drawing.Point(310, 51)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(50, 41)
        Me.btnGenerar.TabIndex = 22
        Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Documento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(86, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Hasta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(82, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Desde:"
        '
        'FechaHasta
        '
        Me.FechaHasta.Location = New System.Drawing.Point(143, 73)
        Me.FechaHasta.Mask = "00/00/0000"
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(77, 20)
        Me.FechaHasta.TabIndex = 31
        '
        'frmEstadoCuenta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(966, 602)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmEstadoCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEstadoCuenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DGMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalDolares As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPesos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalParcial As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalparcial As System.Windows.Forms.Label
    Friend WithEvents Panel9 As Windows.Forms.Panel
    Friend WithEvents LinkLabel3 As Windows.Forms.LinkLabel
    Friend WithEvents LinkToPDF As Windows.Forms.LinkLabel
    Friend WithEvents LinkReporte As Windows.Forms.LinkLabel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents LinkDolares As Windows.Forms.LinkLabel
    Friend WithEvents LinkPesos As Windows.Forms.LinkLabel
    Friend WithEvents Panel10 As Windows.Forms.Panel
    Friend WithEvents TipPendiente As Windows.Forms.ToolTip
    Friend WithEvents LinkLbPendientes As Windows.Forms.LinkLabel
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents txtCuenta As Aguinagalde.Controles.TextBoxNumerico
    Friend WithEvents FechaDesde As Windows.Forms.MaskedTextBox
    Friend WithEvents FechaHasta As Windows.Forms.MaskedTextBox
End Class
