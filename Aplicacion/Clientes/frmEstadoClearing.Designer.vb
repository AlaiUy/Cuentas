<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoClearing
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbciudad = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbdireccion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbcancelaciones = New System.Windows.Forms.Label()
        Me.lbincumplimientos = New System.Windows.Forms.Label()
        Me.lbsegundoapellido = New System.Windows.Forms.Label()
        Me.lbapellido = New System.Windows.Forms.Label()
        Me.lbsegundonombre = New System.Windows.Forms.Label()
        Me.lbnombre = New System.Windows.Forms.Label()
        Me.lblcancelaciones = New System.Windows.Forms.Label()
        Me.lblincumplimientos = New System.Windows.Forms.Label()
        Me.lblape2 = New System.Windows.Forms.Label()
        Me.lblape1 = New System.Windows.Forms.Label()
        Me.lblSnombre = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 523)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbciudad)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.lbdireccion)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(20, 134)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(896, 90)
        Me.Panel5.TabIndex = 16
        '
        'lbciudad
        '
        Me.lbciudad.AutoSize = True
        Me.lbciudad.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbciudad.Location = New System.Drawing.Point(117, 46)
        Me.lbciudad.Name = "lbciudad"
        Me.lbciudad.Size = New System.Drawing.Size(67, 21)
        Me.lbciudad.TabIndex = 15
        Me.lbciudad.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Ciudad:"
        '
        'lbdireccion
        '
        Me.lbdireccion.AutoSize = True
        Me.lbdireccion.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdireccion.Location = New System.Drawing.Point(117, 15)
        Me.lbdireccion.Name = "lbdireccion"
        Me.lbdireccion.Size = New System.Drawing.Size(67, 21)
        Me.lbdireccion.TabIndex = 13
        Me.lbdireccion.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Direccion:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lbcancelaciones)
        Me.Panel4.Controls.Add(Me.lbincumplimientos)
        Me.Panel4.Controls.Add(Me.lbsegundoapellido)
        Me.Panel4.Controls.Add(Me.lbapellido)
        Me.Panel4.Controls.Add(Me.lbsegundonombre)
        Me.Panel4.Controls.Add(Me.lbnombre)
        Me.Panel4.Controls.Add(Me.lblcancelaciones)
        Me.Panel4.Controls.Add(Me.lblincumplimientos)
        Me.Panel4.Controls.Add(Me.lblape2)
        Me.Panel4.Controls.Add(Me.lblape1)
        Me.Panel4.Controls.Add(Me.lblSnombre)
        Me.Panel4.Controls.Add(Me.label)
        Me.Panel4.Location = New System.Drawing.Point(20, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(896, 64)
        Me.Panel4.TabIndex = 15
        '
        'lbcancelaciones
        '
        Me.lbcancelaciones.AutoSize = True
        Me.lbcancelaciones.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcancelaciones.Location = New System.Drawing.Point(790, 36)
        Me.lbcancelaciones.Name = "lbcancelaciones"
        Me.lbcancelaciones.Size = New System.Drawing.Size(67, 21)
        Me.lbcancelaciones.TabIndex = 24
        Me.lbcancelaciones.Text = "Label1"
        '
        'lbincumplimientos
        '
        Me.lbincumplimientos.AutoSize = True
        Me.lbincumplimientos.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbincumplimientos.Location = New System.Drawing.Point(790, 4)
        Me.lbincumplimientos.Name = "lbincumplimientos"
        Me.lbincumplimientos.Size = New System.Drawing.Size(67, 21)
        Me.lbincumplimientos.TabIndex = 23
        Me.lbincumplimientos.Text = "Label1"
        '
        'lbsegundoapellido
        '
        Me.lbsegundoapellido.AutoSize = True
        Me.lbsegundoapellido.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsegundoapellido.Location = New System.Drawing.Point(387, 36)
        Me.lbsegundoapellido.Name = "lbsegundoapellido"
        Me.lbsegundoapellido.Size = New System.Drawing.Size(67, 21)
        Me.lbsegundoapellido.TabIndex = 22
        Me.lbsegundoapellido.Text = "Label1"
        '
        'lbapellido
        '
        Me.lbapellido.AutoSize = True
        Me.lbapellido.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbapellido.Location = New System.Drawing.Point(387, 4)
        Me.lbapellido.Name = "lbapellido"
        Me.lbapellido.Size = New System.Drawing.Size(67, 21)
        Me.lbapellido.TabIndex = 21
        Me.lbapellido.Text = "Label1"
        '
        'lbsegundonombre
        '
        Me.lbsegundonombre.AutoSize = True
        Me.lbsegundonombre.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsegundonombre.Location = New System.Drawing.Point(110, 36)
        Me.lbsegundonombre.Name = "lbsegundonombre"
        Me.lbsegundonombre.Size = New System.Drawing.Size(67, 21)
        Me.lbsegundonombre.TabIndex = 20
        Me.lbsegundonombre.Text = "Label1"
        '
        'lbnombre
        '
        Me.lbnombre.AutoSize = True
        Me.lbnombre.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnombre.Location = New System.Drawing.Point(110, 4)
        Me.lbnombre.Name = "lbnombre"
        Me.lbnombre.Size = New System.Drawing.Size(67, 21)
        Me.lbnombre.TabIndex = 19
        Me.lbnombre.Text = "Label1"
        '
        'lblcancelaciones
        '
        Me.lblcancelaciones.AutoSize = True
        Me.lblcancelaciones.Location = New System.Drawing.Point(676, 40)
        Me.lblcancelaciones.Name = "lblcancelaciones"
        Me.lblcancelaciones.Size = New System.Drawing.Size(100, 17)
        Me.lblcancelaciones.TabIndex = 18
        Me.lblcancelaciones.Text = "Cancelaciones"
        '
        'lblincumplimientos
        '
        Me.lblincumplimientos.AutoSize = True
        Me.lblincumplimientos.Location = New System.Drawing.Point(676, 8)
        Me.lblincumplimientos.Name = "lblincumplimientos"
        Me.lblincumplimientos.Size = New System.Drawing.Size(108, 17)
        Me.lblincumplimientos.TabIndex = 17
        Me.lblincumplimientos.Text = "Incumplimientos"
        '
        'lblape2
        '
        Me.lblape2.AutoSize = True
        Me.lblape2.Location = New System.Drawing.Point(311, 40)
        Me.lblape2.Name = "lblape2"
        Me.lblape2.Size = New System.Drawing.Size(70, 17)
        Me.lblape2.TabIndex = 16
        Me.lblape2.Text = "Apellido 2"
        '
        'lblape1
        '
        Me.lblape1.AutoSize = True
        Me.lblape1.Location = New System.Drawing.Point(311, 8)
        Me.lblape1.Name = "lblape1"
        Me.lblape1.Size = New System.Drawing.Size(70, 17)
        Me.lblape1.TabIndex = 15
        Me.lblape1.Text = "Apellido 1"
        '
        'lblSnombre
        '
        Me.lblSnombre.AutoSize = True
        Me.lblSnombre.Location = New System.Drawing.Point(39, 40)
        Me.lblSnombre.Name = "lblSnombre"
        Me.lblSnombre.Size = New System.Drawing.Size(65, 17)
        Me.lblSnombre.TabIndex = 14
        Me.lblSnombre.Text = "Segundo"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(39, 8)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(62, 17)
        Me.label.TabIndex = 13
        Me.label.Text = "Nombre:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblRegistro)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(945, 58)
        Me.Panel2.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 230)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(933, 288)
        Me.DataGridView1.TabIndex = 0
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro.ForeColor = System.Drawing.Color.Blue
        Me.lblRegistro.Location = New System.Drawing.Point(14, 13)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(92, 29)
        Me.lblRegistro.TabIndex = 0
        Me.lblRegistro.Text = "Label1"
        '
        'frmEstadoClearing
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 531)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmEstadoClearing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEstadoClearing"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbciudad As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbdireccion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbcancelaciones As System.Windows.Forms.Label
    Friend WithEvents lbincumplimientos As System.Windows.Forms.Label
    Friend WithEvents lbsegundoapellido As System.Windows.Forms.Label
    Friend WithEvents lbapellido As System.Windows.Forms.Label
    Friend WithEvents lbsegundonombre As System.Windows.Forms.Label
    Friend WithEvents lbnombre As System.Windows.Forms.Label
    Friend WithEvents lblcancelaciones As System.Windows.Forms.Label
    Friend WithEvents lblincumplimientos As System.Windows.Forms.Label
    Friend WithEvents lblape2 As System.Windows.Forms.Label
    Friend WithEvents lblape1 As System.Windows.Forms.Label
    Friend WithEvents lblSnombre As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents lblRegistro As Windows.Forms.Label
End Class
