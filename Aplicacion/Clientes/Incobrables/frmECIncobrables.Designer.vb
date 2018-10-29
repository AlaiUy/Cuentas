<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmECIncobrables
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LinkPesos = New System.Windows.Forms.LinkLabel()
        Me.LinkDolares = New System.Windows.Forms.LinkLabel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.LinkReporte = New System.Windows.Forms.LinkLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtTotalDolares = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalPesos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtTotalParcial = New System.Windows.Forms.TextBox()
        Me.lbltotalparcial = New System.Windows.Forms.Label()
        Me.DGMovimientos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 563)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(932, 100)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtDireccion)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtNombre)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(355, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(573, 94)
        Me.Panel4.TabIndex = 24
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(77, 47)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(490, 26)
        Me.txtDireccion.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(77, 17)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(490, 26)
        Me.txtNombre.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnGenerar)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.DateHasta)
        Me.Panel3.Controls.Add(Me.DateDesde)
        Me.Panel3.Controls.Add(Me.txtCuenta)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 94)
        Me.Panel3.TabIndex = 0
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.DoIt
        Me.btnGenerar.Location = New System.Drawing.Point(294, 18)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(50, 43)
        Me.btnGenerar.TabIndex = 23
        Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desde:"
        '
        'DateHasta
        '
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(97, 63)
        Me.DateHasta.Margin = New System.Windows.Forms.Padding(0)
        Me.DateHasta.MinDate = New Date(2005, 1, 1, 0, 0, 0, 0)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(192, 26)
        Me.DateHasta.TabIndex = 3
        '
        'DateDesde
        '
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(97, 32)
        Me.DateDesde.Margin = New System.Windows.Forms.Padding(0)
        Me.DateDesde.MinDate = New Date(2005, 1, 1, 0, 0, 0, 0)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(192, 26)
        Me.DateDesde.TabIndex = 1
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(97, 3)
        Me.txtCuenta.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(192, 26)
        Me.txtCuenta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documento:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.DGMovimientos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(932, 463)
        Me.Panel5.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(932, 57)
        Me.Panel7.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.Silver
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.LinkPesos)
        Me.Panel8.Controls.Add(Me.LinkDolares)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(6, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(924, 52)
        Me.Panel8.TabIndex = 0
        '
        'LinkPesos
        '
        Me.LinkPesos.BackColor = System.Drawing.Color.White
        Me.LinkPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkPesos.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkPesos.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.MonedaMuestra
        Me.LinkPesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkPesos.Location = New System.Drawing.Point(7, 3)
        Me.LinkPesos.Name = "LinkPesos"
        Me.LinkPesos.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.LinkPesos.Size = New System.Drawing.Size(140, 41)
        Me.LinkPesos.TabIndex = 8
        Me.LinkPesos.TabStop = True
        Me.LinkPesos.Text = "Ver Pesos"
        Me.LinkPesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkDolares
        '
        Me.LinkDolares.BackColor = System.Drawing.Color.White
        Me.LinkDolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkDolares.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkDolares.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.MonedaMuestra
        Me.LinkDolares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkDolares.Location = New System.Drawing.Point(167, 3)
        Me.LinkDolares.Name = "LinkDolares"
        Me.LinkDolares.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.LinkDolares.Size = New System.Drawing.Size(149, 41)
        Me.LinkDolares.TabIndex = 7
        Me.LinkDolares.TabStop = True
        Me.LinkDolares.Text = "Ver Dolares"
        Me.LinkDolares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.LinkReporte)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(403, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(519, 50)
        Me.Panel9.TabIndex = 6
        '
        'LinkReporte
        '
        Me.LinkReporte.BackColor = System.Drawing.Color.White
        Me.LinkReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkReporte.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkReporte.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.printer
        Me.LinkReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkReporte.Location = New System.Drawing.Point(3, 3)
        Me.LinkReporte.Name = "LinkReporte"
        Me.LinkReporte.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.LinkReporte.Size = New System.Drawing.Size(132, 41)
        Me.LinkReporte.TabIndex = 4
        Me.LinkReporte.TabStop = True
        Me.LinkReporte.Text = "Imprimir"
        Me.LinkReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel12)
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 383)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(932, 80)
        Me.Panel6.TabIndex = 1
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
        Me.Panel12.Size = New System.Drawing.Size(930, 37)
        Me.Panel12.TabIndex = 1
        '
        'txtTotalDolares
        '
        Me.txtTotalDolares.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDolares.Location = New System.Drawing.Point(405, 2)
        Me.txtTotalDolares.Name = "txtTotalDolares"
        Me.txtTotalDolares.Size = New System.Drawing.Size(192, 32)
        Me.txtTotalDolares.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label9.Location = New System.Drawing.Point(295, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 24)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total U$S:"
        '
        'txtTotalPesos
        '
        Me.txtTotalPesos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPesos.Location = New System.Drawing.Point(95, 2)
        Me.txtTotalPesos.Name = "txtTotalPesos"
        Me.txtTotalPesos.Size = New System.Drawing.Size(194, 32)
        Me.txtTotalPesos.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total $:"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Panel14)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(930, 42)
        Me.Panel10.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.txtTotalParcial)
        Me.Panel14.Controls.Add(Me.lbltotalparcial)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(602, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(326, 40)
        Me.Panel14.TabIndex = 1
        '
        'txtTotalParcial
        '
        Me.txtTotalParcial.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalParcial.Location = New System.Drawing.Point(137, 5)
        Me.txtTotalParcial.Name = "txtTotalParcial"
        Me.txtTotalParcial.Size = New System.Drawing.Size(183, 32)
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
        Me.lbltotalparcial.Size = New System.Drawing.Size(129, 24)
        Me.lbltotalparcial.TabIndex = 3
        Me.lbltotalparcial.Text = "Importe U$S:"
        '
        'DGMovimientos
        '
        Me.DGMovimientos.AllowUserToAddRows = False
        Me.DGMovimientos.AllowUserToDeleteRows = False
        Me.DGMovimientos.AllowUserToResizeRows = False
        Me.DGMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGMovimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGMovimientos.BackgroundColor = System.Drawing.Color.White
        Me.DGMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMovimientos.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGMovimientos.Location = New System.Drawing.Point(4, 58)
        Me.DGMovimientos.Name = "DGMovimientos"
        Me.DGMovimientos.ReadOnly = True
        Me.DGMovimientos.RowHeadersVisible = False
        Me.DGMovimientos.RowTemplate.Height = 24
        Me.DGMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMovimientos.Size = New System.Drawing.Size(926, 326)
        Me.DGMovimientos.TabIndex = 0
        '
        'frmECIncobrables
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(937, 568)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmECIncobrables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmECIncobrables"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents DateHasta As Windows.Forms.DateTimePicker
    Friend WithEvents DateDesde As Windows.Forms.DateTimePicker
    Friend WithEvents txtCuenta As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnGenerar As Windows.Forms.Button
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents txtDireccion As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtNombre As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Panel5 As Windows.Forms.Panel
    Friend WithEvents Panel7 As Windows.Forms.Panel
    Friend WithEvents Panel8 As Windows.Forms.Panel
    Friend WithEvents LinkPesos As Windows.Forms.LinkLabel
    Friend WithEvents LinkDolares As Windows.Forms.LinkLabel
    Friend WithEvents Panel9 As Windows.Forms.Panel
    Friend WithEvents LinkReporte As Windows.Forms.LinkLabel
    Friend WithEvents Panel6 As Windows.Forms.Panel
    Friend WithEvents Panel12 As Windows.Forms.Panel
    Friend WithEvents txtTotalDolares As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents txtTotalPesos As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Panel10 As Windows.Forms.Panel
    Friend WithEvents Panel14 As Windows.Forms.Panel
    Friend WithEvents txtTotalParcial As Windows.Forms.TextBox
    Friend WithEvents lbltotalparcial As Windows.Forms.Label
    Friend WithEvents DGMovimientos As Windows.Forms.DataGridView
End Class
