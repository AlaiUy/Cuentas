<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenesCompra
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNumOrden = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSubCuentas = New System.Windows.Forms.ComboBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 487)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtNumOrden)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(13, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(752, 48)
        Me.Panel3.TabIndex = 8
        '
        'txtNumOrden
        '
        Me.txtNumOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumOrden.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOrden.Location = New System.Drawing.Point(185, 6)
        Me.txtNumOrden.Name = "txtNumOrden"
        Me.txtNumOrden.Size = New System.Drawing.Size(562, 32)
        Me.txtNumOrden.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Numero de orden:"
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(667, 440)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(98, 41)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cbSubCuentas)
        Me.Panel2.Controls.Add(Me.txtCliente)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(13, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 50)
        Me.Panel2.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Search
        Me.Button1.Location = New System.Drawing.Point(253, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 41)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "SubCuenta:"
        '
        'cbSubCuentas
        '
        Me.cbSubCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCuentas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubCuentas.FormattingEnabled = True
        Me.cbSubCuentas.Location = New System.Drawing.Point(419, 8)
        Me.cbSubCuentas.Name = "cbSubCuentas"
        Me.cbSubCuentas.Size = New System.Drawing.Size(328, 32)
        Me.cbSubCuentas.TabIndex = 9
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtCliente.Location = New System.Drawing.Point(80, 8)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(169, 32)
        Me.txtCliente.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(13, 141)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(752, 293)
        Me.txtDescripcion.TabIndex = 4
        '
        'frmOrdenesCompra
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 494)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmOrdenesCompra"
        Me.Text = "frmOrdenesCompra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbSubCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtNumOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
