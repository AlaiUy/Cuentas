<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEC
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnEnvioMail = New System.Windows.Forms.Button()
        Me.btn_GenPDF = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGMovimientos = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_D30 = New System.Windows.Forms.Label()
        Me.lbl_D60 = New System.Windows.Forms.Label()
        Me.lbl_D90 = New System.Windows.Forms.Label()
        Me.lbl_P30 = New System.Windows.Forms.Label()
        Me.lbl_P60 = New System.Windows.Forms.Label()
        Me.lbl_P90 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCliente = New Aguinagalde.Controles.TextBoxNumerico()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMostrarDolares = New System.Windows.Forms.Button()
        Me.btnMostrarPesos = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 573)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.UI.My.Resources.Resources.menu
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnEnvioMail)
        Me.Panel6.Controls.Add(Me.btn_GenPDF)
        Me.Panel6.Controls.Add(Me.btnClientes)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(651, 98)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(141, 395)
        Me.Panel6.TabIndex = 2
        '
        'btnEnvioMail
        '
        Me.btnEnvioMail.FlatAppearance.BorderSize = 0
        Me.btnEnvioMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnvioMail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnvioMail.Image = Global.UI.My.Resources.Resources.email24
        Me.btnEnvioMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnvioMail.Location = New System.Drawing.Point(0, 261)
        Me.btnEnvioMail.Name = "btnEnvioMail"
        Me.btnEnvioMail.Size = New System.Drawing.Size(140, 52)
        Me.btnEnvioMail.TabIndex = 3
        Me.btnEnvioMail.Text = "         Enviar E-mail"
        Me.btnEnvioMail.UseCompatibleTextRendering = True
        Me.btnEnvioMail.UseVisualStyleBackColor = True
        '
        'btn_GenPDF
        '
        Me.btn_GenPDF.FlatAppearance.BorderSize = 0
        Me.btn_GenPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_GenPDF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GenPDF.Image = Global.UI.My.Resources.Resources.pdf24
        Me.btn_GenPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_GenPDF.Location = New System.Drawing.Point(0, 199)
        Me.btn_GenPDF.Name = "btn_GenPDF"
        Me.btn_GenPDF.Size = New System.Drawing.Size(140, 52)
        Me.btn_GenPDF.TabIndex = 2
        Me.btn_GenPDF.Text = "       Generar PDF"
        Me.btn_GenPDF.UseCompatibleTextRendering = True
        Me.btn_GenPDF.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = Global.UI.My.Resources.Resources.print24
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 137)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(140, 52)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Imprimir"
        Me.btnClientes.UseCompatibleTextRendering = True
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DGMovimientos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(650, 395)
        Me.Panel3.TabIndex = 3
        '
        'DGMovimientos
        '
        Me.DGMovimientos.AllowUserToAddRows = False
        Me.DGMovimientos.AllowUserToDeleteRows = False
        Me.DGMovimientos.AllowUserToResizeColumns = False
        Me.DGMovimientos.AllowUserToResizeRows = False
        Me.DGMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGMovimientos.BackgroundColor = System.Drawing.Color.White
        Me.DGMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMovimientos.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGMovimientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGMovimientos.EnableHeadersVisualStyles = False
        Me.DGMovimientos.GridColor = System.Drawing.Color.White
        Me.DGMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.DGMovimientos.Name = "DGMovimientos"
        Me.DGMovimientos.RowHeadersVisible = False
        Me.DGMovimientos.Size = New System.Drawing.Size(648, 393)
        Me.DGMovimientos.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.lbl_D30)
        Me.Panel4.Controls.Add(Me.lbl_D60)
        Me.Panel4.Controls.Add(Me.lbl_D90)
        Me.Panel4.Controls.Add(Me.lbl_P30)
        Me.Panel4.Controls.Add(Me.lbl_P60)
        Me.Panel4.Controls.Add(Me.lbl_P90)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 493)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(792, 80)
        Me.Panel4.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(88, 55)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 13)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "U$S"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(105, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "$"
        '
        'lbl_D30
        '
        Me.lbl_D30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_D30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_D30.Location = New System.Drawing.Point(348, 53)
        Me.lbl_D30.Name = "lbl_D30"
        Me.lbl_D30.Size = New System.Drawing.Size(100, 17)
        Me.lbl_D30.TabIndex = 14
        Me.lbl_D30.Text = "-"
        Me.lbl_D30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_D60
        '
        Me.lbl_D60.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_D60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_D60.Location = New System.Drawing.Point(243, 53)
        Me.lbl_D60.Name = "lbl_D60"
        Me.lbl_D60.Size = New System.Drawing.Size(100, 17)
        Me.lbl_D60.TabIndex = 13
        Me.lbl_D60.Text = "-"
        Me.lbl_D60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_D90
        '
        Me.lbl_D90.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_D90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_D90.Location = New System.Drawing.Point(138, 53)
        Me.lbl_D90.Name = "lbl_D90"
        Me.lbl_D90.Size = New System.Drawing.Size(100, 17)
        Me.lbl_D90.TabIndex = 12
        Me.lbl_D90.Text = "-"
        Me.lbl_D90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_P30
        '
        Me.lbl_P30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_P30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_P30.Location = New System.Drawing.Point(348, 27)
        Me.lbl_P30.Name = "lbl_P30"
        Me.lbl_P30.Size = New System.Drawing.Size(100, 17)
        Me.lbl_P30.TabIndex = 9
        Me.lbl_P30.Text = "-"
        Me.lbl_P30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_P60
        '
        Me.lbl_P60.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_P60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_P60.Location = New System.Drawing.Point(243, 27)
        Me.lbl_P60.Name = "lbl_P60"
        Me.lbl_P60.Size = New System.Drawing.Size(100, 17)
        Me.lbl_P60.TabIndex = 8
        Me.lbl_P60.Text = "-"
        Me.lbl_P60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_P90
        '
        Me.lbl_P90.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_P90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_P90.Location = New System.Drawing.Point(138, 27)
        Me.lbl_P90.Name = "lbl_P90"
        Me.lbl_P90.Size = New System.Drawing.Size(100, 17)
        Me.lbl_P90.TabIndex = 7
        Me.lbl_P90.Text = "-"
        Me.lbl_P90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(348, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "30"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(243, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "60"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(138, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "90"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Detalles de saldos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = Global.UI.My.Resources.Resources.MenuEC
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblDireccion)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtCliente)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnMostrarDolares)
        Me.Panel2.Controls.Add(Me.btnMostrarPesos)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 98)
        Me.Panel2.TabIndex = 0
        '
        'lblDireccion
        '
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(230, 67)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(525, 20)
        Me.lblDireccion.TabIndex = 18
        Me.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(230, 41)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(525, 20)
        Me.lblNombre.TabIndex = 17
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(77, 68)
        Me.txtDate.Mask = "00/00/0000"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(116, 20)
        Me.txtDate.TabIndex = 16
        Me.txtDate.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Desde:"
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(78, 40)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(115, 20)
        Me.txtCliente.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cliente:"
        '
        'btnMostrarDolares
        '
        Me.btnMostrarDolares.BackColor = System.Drawing.Color.Red
        Me.btnMostrarDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarDolares.Location = New System.Drawing.Point(111, 6)
        Me.btnMostrarDolares.Name = "btnMostrarDolares"
        Me.btnMostrarDolares.Size = New System.Drawing.Size(45, 23)
        Me.btnMostrarDolares.TabIndex = 4
        Me.btnMostrarDolares.Text = "U$S"
        Me.btnMostrarDolares.UseVisualStyleBackColor = False
        '
        'btnMostrarPesos
        '
        Me.btnMostrarPesos.BackColor = System.Drawing.Color.Red
        Me.btnMostrarPesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarPesos.Location = New System.Drawing.Point(60, 6)
        Me.btnMostrarPesos.Name = "btnMostrarPesos"
        Me.btnMostrarPesos.Size = New System.Drawing.Size(45, 23)
        Me.btnMostrarPesos.TabIndex = 3
        Me.btnMostrarPesos.Text = "$"
        Me.btnMostrarPesos.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Vista"
        '
        'frmEC
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "frmEC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de cuenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DGMovimientos As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_D30 As Label
    Friend WithEvents lbl_D60 As Label
    Friend WithEvents lbl_D90 As Label
    Friend WithEvents lbl_P30 As Label
    Friend WithEvents lbl_P60 As Label
    Friend WithEvents lbl_P90 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btn_GenPDF As Button
    Friend WithEvents btnEnvioMail As Button
    Friend WithEvents btnMostrarDolares As Button
    Friend WithEvents btnMostrarPesos As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtDate As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCliente As Aguinagalde.Controles.TextBoxNumerico
    Friend WithEvents Label2 As Label
End Class
