<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDebito
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtLinea = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
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
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 548)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(202, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(419, 71)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nota de debito"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtLinea)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtComentario)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 448)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(777, 100)
        Me.Panel3.TabIndex = 3
        '
        'txtLinea
        '
        Me.txtLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLinea.Location = New System.Drawing.Point(129, 55)
        Me.txtLinea.Multiline = True
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.Size = New System.Drawing.Size(634, 42)
        Me.txtLinea.TabIndex = 3
        Me.txtLinea.Text = "DIFERENCIA DE VENTAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Linea"
        '
        'txtComentario
        '
        Me.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComentario.Location = New System.Drawing.Point(129, 9)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(634, 42)
        Me.txtComentario.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Comentario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBonifGlobal)
        Me.GroupBox1.Controls.Add(Me.cbMonedas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbimporte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 55)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnBonifGlobal
        '
        Me.btnBonifGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBonifGlobal.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.DoIt
        Me.btnBonifGlobal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBonifGlobal.Location = New System.Drawing.Point(253, 8)
        Me.btnBonifGlobal.Name = "btnBonifGlobal"
        Me.btnBonifGlobal.Size = New System.Drawing.Size(96, 44)
        Me.btnBonifGlobal.TabIndex = 2
        Me.btnBonifGlobal.Text = "Global"
        Me.btnBonifGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBonifGlobal.UseVisualStyleBackColor = True
        '
        'cbMonedas
        '
        Me.cbMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedas.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cbMonedas.FormattingEnabled = True
        Me.cbMonedas.Location = New System.Drawing.Point(514, 15)
        Me.cbMonedas.Name = "cbMonedas"
        Me.cbMonedas.Size = New System.Drawing.Size(246, 32)
        Me.cbMonedas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(412, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MONEDA:"
        '
        'tbimporte
        '
        Me.tbimporte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbimporte.Location = New System.Drawing.Point(114, 14)
        Me.tbimporte.Name = "tbimporte"
        Me.tbimporte.Size = New System.Drawing.Size(126, 32)
        Me.tbimporte.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
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
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(771, 107)
        Me.Panel2.TabIndex = 1
        '
        'chkImprimir
        '
        Me.chkImprimir.AutoSize = True
        Me.chkImprimir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImprimir.ForeColor = System.Drawing.Color.Red
        Me.chkImprimir.Location = New System.Drawing.Point(515, 5)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(244, 28)
        Me.chkImprimir.TabIndex = 11
        Me.chkImprimir.Text = "Imprimir Documento"
        Me.chkImprimir.UseVisualStyleBackColor = False
        '
        'cbSubCuenta
        '
        Me.cbSubCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCuenta.FormattingEnabled = True
        Me.cbSubCuenta.Location = New System.Drawing.Point(252, 6)
        Me.cbSubCuenta.Name = "cbSubCuenta"
        Me.cbSubCuenta.Size = New System.Drawing.Size(171, 24)
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
        Me.txtDireccion.Size = New System.Drawing.Size(754, 26)
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
        Me.txtNombre.Size = New System.Drawing.Size(754, 26)
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
        'frmDebito
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmDebito"
        Me.Text = "frmDebito"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbSubCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBonifGlobal As System.Windows.Forms.Button
    Friend WithEvents cbMonedas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbimporte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkImprimir As Windows.Forms.CheckBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtLinea As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
