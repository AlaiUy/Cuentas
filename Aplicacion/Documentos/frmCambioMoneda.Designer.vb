<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioMoneda
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtImporteDestino = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImporteOrigen = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbMonedaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtClienteOrigen = New System.Windows.Forms.TextBox()
        Me.btnBuscarClienteOrigen = New System.Windows.Forms.Button()
        Me.txtNombreOrigen = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.cbMonedaDestino = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtClienteDestino = New System.Windows.Forms.TextBox()
        Me.btnBuscarClienteDestino = New System.Windows.Forms.Button()
        Me.txtNombreDestino = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnDoIt = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.dgMovimientos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 164)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1008, 136)
        Me.Panel3.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox3)
        Me.Panel6.Location = New System.Drawing.Point(347, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(311, 136)
        Me.Panel6.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtImporteDestino)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtImporteOrigen)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de conversion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(177, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Importe destino"
        '
        'txtImporteDestino
        '
        Me.txtImporteDestino.Location = New System.Drawing.Point(177, 60)
        Me.txtImporteDestino.Name = "txtImporteDestino"
        Me.txtImporteDestino.Size = New System.Drawing.Size(100, 23)
        Me.txtImporteDestino.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Importe origen"
        '
        'txtImporteOrigen
        '
        Me.txtImporteOrigen.Location = New System.Drawing.Point(15, 60)
        Me.txtImporteOrigen.Name = "txtImporteOrigen"
        Me.txtImporteOrigen.Size = New System.Drawing.Size(100, 23)
        Me.txtImporteOrigen.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cbMonedaOrigen)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(347, 136)
        Me.Panel5.TabIndex = 2
        '
        'cbMonedaOrigen
        '
        Me.cbMonedaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaOrigen.FormattingEnabled = True
        Me.cbMonedaOrigen.Location = New System.Drawing.Point(190, 109)
        Me.cbMonedaOrigen.Name = "cbMonedaOrigen"
        Me.cbMonedaOrigen.Size = New System.Drawing.Size(145, 24)
        Me.cbMonedaOrigen.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mostrar movimientos en:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClienteOrigen)
        Me.GroupBox1.Controls.Add(Me.btnBuscarClienteOrigen)
        Me.GroupBox1.Controls.Add(Me.txtNombreOrigen)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta origen"
        '
        'txtClienteOrigen
        '
        Me.txtClienteOrigen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteOrigen.Location = New System.Drawing.Point(85, 34)
        Me.txtClienteOrigen.Name = "txtClienteOrigen"
        Me.txtClienteOrigen.Size = New System.Drawing.Size(157, 22)
        Me.txtClienteOrigen.TabIndex = 9
        '
        'btnBuscarClienteOrigen
        '
        Me.btnBuscarClienteOrigen.FlatAppearance.BorderSize = 0
        Me.btnBuscarClienteOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarClienteOrigen.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Search
        Me.btnBuscarClienteOrigen.Location = New System.Drawing.Point(248, 21)
        Me.btnBuscarClienteOrigen.Name = "btnBuscarClienteOrigen"
        Me.btnBuscarClienteOrigen.Size = New System.Drawing.Size(43, 43)
        Me.btnBuscarClienteOrigen.TabIndex = 8
        Me.btnBuscarClienteOrigen.UseVisualStyleBackColor = True
        '
        'txtNombreOrigen
        '
        Me.txtNombreOrigen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreOrigen.Location = New System.Drawing.Point(9, 65)
        Me.txtNombreOrigen.Name = "txtNombreOrigen"
        Me.txtNombreOrigen.Size = New System.Drawing.Size(308, 22)
        Me.txtNombreOrigen.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cuenta Nº"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Location = New System.Drawing.Point(658, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(350, 136)
        Me.Panel4.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.cbMonedaDestino)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.GroupBox2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(350, 136)
        Me.Panel9.TabIndex = 0
        '
        'cbMonedaDestino
        '
        Me.cbMonedaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaDestino.FormattingEnabled = True
        Me.cbMonedaDestino.Location = New System.Drawing.Point(84, 107)
        Me.cbMonedaDestino.Name = "cbMonedaDestino"
        Me.cbMonedaDestino.Size = New System.Drawing.Size(145, 24)
        Me.cbMonedaDestino.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pasar a:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtClienteDestino)
        Me.GroupBox2.Controls.Add(Me.btnBuscarClienteDestino)
        Me.GroupBox2.Controls.Add(Me.txtNombreDestino)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cuenta destino"
        '
        'txtClienteDestino
        '
        Me.txtClienteDestino.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteDestino.Location = New System.Drawing.Point(89, 33)
        Me.txtClienteDestino.Name = "txtClienteDestino"
        Me.txtClienteDestino.Size = New System.Drawing.Size(157, 22)
        Me.txtClienteDestino.TabIndex = 10
        '
        'btnBuscarClienteDestino
        '
        Me.btnBuscarClienteDestino.FlatAppearance.BorderSize = 0
        Me.btnBuscarClienteDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarClienteDestino.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Search
        Me.btnBuscarClienteDestino.Location = New System.Drawing.Point(252, 23)
        Me.btnBuscarClienteDestino.Name = "btnBuscarClienteDestino"
        Me.btnBuscarClienteDestino.Size = New System.Drawing.Size(43, 42)
        Me.btnBuscarClienteDestino.TabIndex = 9
        Me.btnBuscarClienteDestino.UseVisualStyleBackColor = True
        '
        'txtNombreDestino
        '
        Me.txtNombreDestino.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreDestino.Location = New System.Drawing.Point(13, 67)
        Me.txtNombreDestino.Name = "txtNombreDestino"
        Me.txtNombreDestino.Size = New System.Drawing.Size(308, 22)
        Me.txtNombreDestino.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Cuenta Nº"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 30)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Realizar un cambio de moneda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cuenta Nº"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cuenta Nº"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 681)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1008, 53)
        Me.Panel7.TabIndex = 2
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnDoIt)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(959, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(49, 53)
        Me.Panel10.TabIndex = 0
        '
        'btnDoIt
        '
        Me.btnDoIt.FlatAppearance.BorderSize = 0
        Me.btnDoIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoIt.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Transfer
        Me.btnDoIt.Location = New System.Drawing.Point(3, 6)
        Me.btnDoIt.Name = "btnDoIt"
        Me.btnDoIt.Size = New System.Drawing.Size(39, 41)
        Me.btnDoIt.TabIndex = 1
        Me.btnDoIt.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.dgMovimientos)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 164)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1008, 517)
        Me.Panel8.TabIndex = 3
        '
        'dgMovimientos
        '
        Me.dgMovimientos.AllowUserToAddRows = False
        Me.dgMovimientos.AllowUserToDeleteRows = False
        Me.dgMovimientos.AllowUserToResizeColumns = False
        Me.dgMovimientos.AllowUserToResizeRows = False
        Me.dgMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgMovimientos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMovimientos.ColumnHeadersHeight = 30
        Me.dgMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMovimientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgMovimientos.EnableHeadersVisualStyles = False
        Me.dgMovimientos.GridColor = System.Drawing.Color.Black
        Me.dgMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.dgMovimientos.MultiSelect = False
        Me.dgMovimientos.Name = "dgMovimientos"
        Me.dgMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgMovimientos.RowHeadersVisible = False
        Me.dgMovimientos.RowTemplate.Height = 30
        Me.dgMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMovimientos.Size = New System.Drawing.Size(1008, 517)
        Me.dgMovimientos.TabIndex = 1
        '
        'frmCambioMoneda
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 734)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "frmCambioMoneda"
        Me.Text = "Cambiar moneda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents Panel6 As Windows.Forms.Panel
    Friend WithEvents Panel5 As Windows.Forms.Panel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox

    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel7 As Windows.Forms.Panel
    Friend WithEvents Panel8 As Windows.Forms.Panel
    Friend WithEvents dgMovimientos As Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtImporteDestino As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtImporteOrigen As Windows.Forms.TextBox
    Friend WithEvents cbMonedaOrigen As Windows.Forms.ComboBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Panel9 As Windows.Forms.Panel
    Friend WithEvents cbMonedaDestino As Windows.Forms.ComboBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Panel10 As Windows.Forms.Panel
    Friend WithEvents btnDoIt As Windows.Forms.Button
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtNombreOrigen As Windows.Forms.TextBox
    Friend WithEvents txtNombreDestino As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents btnBuscarClienteOrigen As Windows.Forms.Button
    Friend WithEvents btnBuscarClienteDestino As Windows.Forms.Button
    Friend WithEvents txtClienteOrigen As Windows.Forms.TextBox
    Friend WithEvents txtClienteDestino As Windows.Forms.TextBox
End Class
