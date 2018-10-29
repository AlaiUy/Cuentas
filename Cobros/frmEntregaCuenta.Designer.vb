<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntregaCuenta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbSubCuentas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(107, 16)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(365, 27)
        Me.txtNombre.TabIndex = 1
        '
        'cmbSubCuentas
        '
        Me.cmbSubCuentas.FormattingEnabled = True
        Me.cmbSubCuentas.Location = New System.Drawing.Point(107, 65)
        Me.cmbSubCuentas.Name = "cmbSubCuentas"
        Me.cmbSubCuentas.Size = New System.Drawing.Size(365, 24)
        Me.cmbSubCuentas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SubCuenta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Importe:"
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(107, 157)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(365, 27)
        Me.txtImporte.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Moneda:"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(107, 112)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(365, 24)
        Me.cmbMoneda.TabIndex = 6
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(107, 193)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(75, 51)
        Me.btnEntregar.TabIndex = 8
        Me.btnEntregar.Text = "Generar Entrega"
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'frmEntregaCuenta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(498, 253)
        Me.Controls.Add(Me.btnEntregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbMoneda)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSubCuentas)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEntregaCuenta"
        Me.Text = "frmEntregaCuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmbSubCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents btnEntregar As System.Windows.Forms.Button
End Class
