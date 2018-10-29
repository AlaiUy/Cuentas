<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBonifXML
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBonifGlobal = New System.Windows.Forms.Button()
        Me.cbMonedas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbimporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 572)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtSerie)
        Me.Panel4.Controls.Add(Me.txtNumero)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 485)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(778, 87)
        Me.Panel4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Serie:"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(69, 18)
        Me.txtSerie.Multiline = True
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(166, 25)
        Me.txtSerie.TabIndex = 2
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.Red
        Me.txtNumero.Location = New System.Drawing.Point(349, 14)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(172, 30)
        Me.txtNumero.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Numero:"
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
        Me.cbMonedas.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cbMonedas.FormattingEnabled = True
        Me.cbMonedas.Location = New System.Drawing.Point(400, 25)
        Me.cbMonedas.Name = "cbMonedas"
        Me.cbMonedas.Size = New System.Drawing.Size(343, 32)
        Me.cbMonedas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MONEDA:"
        '
        'tbimporte
        '
        Me.tbimporte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbimporte.Location = New System.Drawing.Point(75, 25)
        Me.tbimporte.Name = "tbimporte"
        Me.tbimporte.Size = New System.Drawing.Size(171, 32)
        Me.tbimporte.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "IMPORTE:"
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
        Me.chkImprimir.Size = New System.Drawing.Size(244, 28)
        Me.chkImprimir.TabIndex = 10
        Me.chkImprimir.Text = "Imprimir Documento"
        Me.chkImprimir.UseVisualStyleBackColor = False
        '
        'cbSubCuenta
        '
        Me.cbSubCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCuenta.FormattingEnabled = True
        Me.cbSubCuenta.Location = New System.Drawing.Point(252, 6)
        Me.cbSubCuenta.Name = "cbSubCuenta"
        Me.cbSubCuenta.Size = New System.Drawing.Size(234, 24)
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
        Me.txtDireccion.Size = New System.Drawing.Size(751, 26)
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
        Me.txtNombre.Size = New System.Drawing.Size(751, 26)
        Me.txtNombre.TabIndex = 8
        Me.txtNombre.Text = "Nombre..."
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(80, 5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(150, 26)
        Me.txtCliente.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente"
        '
        'frmBonifXML
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(786, 580)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmBonifXML"
        Me.Text = "frmBonifXML"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtSerie As Windows.Forms.TextBox
    Friend WithEvents txtNumero As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnBonifGlobal As Windows.Forms.Button
    Friend WithEvents cbMonedas As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents tbimporte As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents chkImprimir As Windows.Forms.CheckBox
    Friend WithEvents cbSubCuenta As Windows.Forms.ComboBox
    Friend WithEvents txtDireccion As Windows.Forms.TextBox
    Friend WithEvents txtNombre As Windows.Forms.TextBox
    Friend WithEvents txtCliente As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
