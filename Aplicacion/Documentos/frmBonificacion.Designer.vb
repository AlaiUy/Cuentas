<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBonificacion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.txtImporteBonificar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBonificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBonifGlobal = New System.Windows.Forms.Button()
        Me.cbMonedas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbimporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGMovimientos = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkImprimir = New System.Windows.Forms.CheckBox()
        Me.cbSubCuenta = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 603)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtComentario)
        Me.Panel4.Controls.Add(Me.txtImporteBonificar)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.btnBonificar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 516)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(778, 87)
        Me.Panel4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Comentarios"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(6, 22)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(319, 59)
        Me.txtComentario.TabIndex = 2
        '
        'txtImporteBonificar
        '
        Me.txtImporteBonificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporteBonificar.Enabled = False
        Me.txtImporteBonificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteBonificar.ForeColor = System.Drawing.Color.Red
        Me.txtImporteBonificar.Location = New System.Drawing.Point(336, 50)
        Me.txtImporteBonificar.Name = "txtImporteBonificar"
        Me.txtImporteBonificar.Size = New System.Drawing.Size(172, 26)
        Me.txtImporteBonificar.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(333, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Importe a bonificar:"
        '
        'btnBonificar
        '
        Me.btnBonificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBonificar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.DoIt
        Me.btnBonificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBonificar.Location = New System.Drawing.Point(690, 17)
        Me.btnBonificar.Name = "btnBonificar"
        Me.btnBonificar.Size = New System.Drawing.Size(75, 64)
        Me.btnBonificar.TabIndex = 1
        Me.btnBonificar.Text = "Bonificar"
        Me.btnBonificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBonificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBonifGlobal)
        Me.GroupBox1.Controls.Add(Me.cbMonedas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbimporte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnBonifGlobal
        '
        Me.btnBonifGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBonifGlobal.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.DoIt
        Me.btnBonifGlobal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBonifGlobal.Location = New System.Drawing.Point(252, 16)
        Me.btnBonifGlobal.Name = "btnBonifGlobal"
        Me.btnBonifGlobal.Size = New System.Drawing.Size(65, 58)
        Me.btnBonifGlobal.TabIndex = 2
        Me.btnBonifGlobal.Text = "Global."
        Me.btnBonifGlobal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBonifGlobal.UseVisualStyleBackColor = True
        '
        'cbMonedas
        '
        Me.cbMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMonedas.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cbMonedas.FormattingEnabled = True
        Me.cbMonedas.Location = New System.Drawing.Point(400, 25)
        Me.cbMonedas.Name = "cbMonedas"
        Me.cbMonedas.Size = New System.Drawing.Size(343, 27)
        Me.cbMonedas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MONEDA:"
        '
        'tbimporte
        '
        Me.tbimporte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbimporte.Location = New System.Drawing.Point(75, 25)
        Me.tbimporte.Name = "tbimporte"
        Me.tbimporte.Size = New System.Drawing.Size(171, 27)
        Me.tbimporte.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "IMPORTE:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGMovimientos)
        Me.Panel3.Location = New System.Drawing.Point(6, 203)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(765, 307)
        Me.Panel3.TabIndex = 10
        '
        'DGMovimientos
        '
        Me.DGMovimientos.AllowUserToAddRows = False
        Me.DGMovimientos.AllowUserToDeleteRows = False
        Me.DGMovimientos.AllowUserToResizeColumns = False
        Me.DGMovimientos.AllowUserToResizeRows = False
        Me.DGMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMovimientos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.DGMovimientos.MultiSelect = False
        Me.DGMovimientos.Name = "DGMovimientos"
        Me.DGMovimientos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMovimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGMovimientos.RowHeadersVisible = False
        Me.DGMovimientos.RowTemplate.Height = 24
        Me.DGMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMovimientos.Size = New System.Drawing.Size(765, 307)
        Me.DGMovimientos.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.chkImprimir)
        Me.Panel2.Controls.Add(Me.cbSubCuenta)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.txtCliente)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(8, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(761, 110)
        Me.Panel2.TabIndex = 0
        '
        'chkImprimir
        '
        Me.chkImprimir.AutoSize = True
        Me.chkImprimir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImprimir.ForeColor = System.Drawing.Color.Red
        Me.chkImprimir.Location = New System.Drawing.Point(509, 4)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(196, 23)
        Me.chkImprimir.TabIndex = 10
        Me.chkImprimir.Text = "Imprimir Documento"
        Me.chkImprimir.UseVisualStyleBackColor = False
        '
        'cbSubCuenta
        '
        Me.cbSubCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSubCuenta.FormattingEnabled = True
        Me.cbSubCuenta.Location = New System.Drawing.Point(252, 6)
        Me.cbSubCuenta.Name = "cbSubCuenta"
        Me.cbSubCuenta.Size = New System.Drawing.Size(234, 21)
        Me.cbSubCuenta.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.Silver
        Me.txtDireccion.Location = New System.Drawing.Point(5, 72)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(751, 22)
        Me.txtDireccion.TabIndex = 9
        Me.txtDireccion.Text = "Direccion..."
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Silver
        Me.txtNombre.Location = New System.Drawing.Point(5, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(751, 22)
        Me.txtNombre.TabIndex = 8
        Me.txtNombre.Text = "Nombre..."
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(80, 5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(150, 22)
        Me.txtCliente.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente"
        '
        'frmBonificacion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 627)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmBonificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBonificacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbimporte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cbMonedas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DGMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnBonificar As System.Windows.Forms.Button
    Friend WithEvents btnBonifGlobal As System.Windows.Forms.Button
    Friend WithEvents cbSubCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImporteBonificar As System.Windows.Forms.TextBox
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents chkImprimir As Windows.Forms.CheckBox
End Class
