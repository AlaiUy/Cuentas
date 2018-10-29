<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubCuentaMod
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreCta = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDireccionCta = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefonoCta = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRutCta = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.chkDescatalogada = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 318)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 258)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(539, 58)
        Me.Panel3.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.DoIt
        Me.btnGuardar.Location = New System.Drawing.Point(9, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(50, 51)
        Me.btnGuardar.TabIndex = 71
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(539, 246)
        Me.Panel2.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel7)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel8)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel9)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(522, 246)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtNombreCta)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(513, 33)
        Me.Panel4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'txtNombreCta
        '
        Me.txtNombreCta.Location = New System.Drawing.Point(75, 5)
        Me.txtNombreCta.Name = "txtNombreCta"
        Me.txtNombreCta.Size = New System.Drawing.Size(435, 22)
        Me.txtNombreCta.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.txtDireccionCta)
        Me.Panel5.Location = New System.Drawing.Point(3, 42)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(513, 33)
        Me.Panel5.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Direccion:"
        '
        'txtDireccionCta
        '
        Me.txtDireccionCta.Location = New System.Drawing.Point(79, 7)
        Me.txtDireccionCta.Name = "txtDireccionCta"
        Me.txtDireccionCta.Size = New System.Drawing.Size(431, 22)
        Me.txtDireccionCta.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.txtTelefonoCta)
        Me.Panel6.Location = New System.Drawing.Point(3, 81)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(513, 33)
        Me.Panel6.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono:"
        '
        'txtTelefonoCta
        '
        Me.txtTelefonoCta.Location = New System.Drawing.Point(81, 7)
        Me.txtTelefonoCta.Name = "txtTelefonoCta"
        Me.txtTelefonoCta.Size = New System.Drawing.Size(429, 22)
        Me.txtTelefonoCta.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.cbTipo)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Location = New System.Drawing.Point(3, 120)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(513, 33)
        Me.Panel7.TabIndex = 6
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(75, 4)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(435, 24)
        Me.cbTipo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo:"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.txtRutCta)
        Me.Panel8.Location = New System.Drawing.Point(3, 159)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(513, 33)
        Me.Panel8.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Rut:"
        '
        'txtRutCta
        '
        Me.txtRutCta.Location = New System.Drawing.Point(78, 5)
        Me.txtRutCta.Name = "txtRutCta"
        Me.txtRutCta.Size = New System.Drawing.Size(432, 22)
        Me.txtRutCta.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.chkDescatalogada)
        Me.Panel9.Location = New System.Drawing.Point(3, 198)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(513, 33)
        Me.Panel9.TabIndex = 8
        '
        'chkDescatalogada
        '
        Me.chkDescatalogada.AutoSize = True
        Me.chkDescatalogada.Location = New System.Drawing.Point(10, 6)
        Me.chkDescatalogada.Name = "chkDescatalogada"
        Me.chkDescatalogada.Size = New System.Drawing.Size(125, 21)
        Me.chkDescatalogada.TabIndex = 0
        Me.chkDescatalogada.Text = "Descatalogada"
        Me.chkDescatalogada.UseVisualStyleBackColor = True
        '
        'frmSubCuentaMod
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 333)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmSubCuentaMod"
        Me.Text = "frmSubCuentaMod"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCta As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionCta As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoCta As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRutCta As System.Windows.Forms.TextBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents chkDescatalogada As System.Windows.Forms.CheckBox
End Class
