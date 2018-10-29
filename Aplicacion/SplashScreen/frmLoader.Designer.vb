<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoader
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
        Me.txtInformacion = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtInformacion
        '
        Me.txtInformacion.AutoSize = True
        Me.txtInformacion.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInformacion.Location = New System.Drawing.Point(205, 217)
        Me.txtInformacion.Name = "txtInformacion"
        Me.txtInformacion.Size = New System.Drawing.Size(0, 23)
        Me.txtInformacion.TabIndex = 5
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.Color.White
        Me.btn_OK.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_OK.Location = New System.Drawing.Point(551, 215)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(78, 23)
        Me.btn_OK.TabIndex = 6
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(346, 163)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtPassword.Size = New System.Drawing.Size(252, 28)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(346, 98)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(252, 28)
        Me.txtUser.TabIndex = 7
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmLoader
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.loginbox1
        Me.ClientSize = New System.Drawing.Size(641, 249)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtInformacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "frmLoader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Box -"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInformacion As Windows.Forms.Label
    Friend WithEvents btn_OK As Windows.Forms.Button
    Friend WithEvents txtPassword As Windows.Forms.TextBox
    Friend WithEvents txtUser As Windows.Forms.TextBox
End Class
