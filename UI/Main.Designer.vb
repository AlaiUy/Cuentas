<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.Contenedor = New System.Windows.Forms.Panel()
        Me.TimerFecha = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnIncobrables = New System.Windows.Forms.Button()
        Me.btnCdoPendiente = New System.Windows.Forms.Button()
        Me.btnDocumentos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.ToolInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblfecha)
        Me.Panel2.Controls.Add(Me.lblBienvenida)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(141, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(659, 24)
        Me.Panel2.TabIndex = 0
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(495, 4)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(134, 16)
        Me.lblfecha.TabIndex = 1
        Me.lblfecha.Text = "11/10/18 11:10:50"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(15, 4)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(88, 16)
        Me.lblBienvenida.TabIndex = 0
        Me.lblBienvenida.Text = "Hola Usuario"
        '
        'Contenedor
        '
        Me.Contenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.Location = New System.Drawing.Point(141, 24)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(659, 576)
        Me.Contenedor.TabIndex = 0
        '
        'TimerFecha
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.btnIncobrables)
        Me.Panel1.Controls.Add(Me.btnCdoPendiente)
        Me.Panel1.Controls.Add(Me.btnDocumentos)
        Me.Panel1.Controls.Add(Me.btnClientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 600)
        Me.Panel1.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(41, 582)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(51, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "- 2018 -"
        '
        'btnIncobrables
        '
        Me.btnIncobrables.FlatAppearance.BorderSize = 0
        Me.btnIncobrables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncobrables.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncobrables.Image = Global.UI.My.Resources.Resources.wrong24
        Me.btnIncobrables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncobrables.Location = New System.Drawing.Point(0, 294)
        Me.btnIncobrables.Name = "btnIncobrables"
        Me.btnIncobrables.Size = New System.Drawing.Size(140, 52)
        Me.btnIncobrables.TabIndex = 3
        Me.btnIncobrables.Text = "       Incobrables"
        Me.ToolInfo.SetToolTip(Me.btnIncobrables, "Informacion sobre cuentas incobrables")
        Me.btnIncobrables.UseCompatibleTextRendering = True
        Me.btnIncobrables.UseVisualStyleBackColor = True
        '
        'btnCdoPendiente
        '
        Me.btnCdoPendiente.FlatAppearance.BorderSize = 0
        Me.btnCdoPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCdoPendiente.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCdoPendiente.Image = Global.UI.My.Resources.Resources.payment24
        Me.btnCdoPendiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCdoPendiente.Location = New System.Drawing.Point(0, 241)
        Me.btnCdoPendiente.Name = "btnCdoPendiente"
        Me.btnCdoPendiente.Size = New System.Drawing.Size(140, 52)
        Me.btnCdoPendiente.TabIndex = 2
        Me.btnCdoPendiente.Text = "      Contados P."
        Me.ToolInfo.SetToolTip(Me.btnCdoPendiente, "Menu para trabajar con los contados pendientes")
        Me.btnCdoPendiente.UseCompatibleTextRendering = True
        Me.btnCdoPendiente.UseVisualStyleBackColor = True
        '
        'btnDocumentos
        '
        Me.btnDocumentos.FlatAppearance.BorderSize = 0
        Me.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocumentos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumentos.Image = Global.UI.My.Resources.Resources.settings24
        Me.btnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocumentos.Location = New System.Drawing.Point(0, 188)
        Me.btnDocumentos.Name = "btnDocumentos"
        Me.btnDocumentos.Size = New System.Drawing.Size(140, 52)
        Me.btnDocumentos.TabIndex = 1
        Me.btnDocumentos.Text = "      Documentos"
        Me.ToolInfo.SetToolTip(Me.btnDocumentos, "Opciones para crear debitos y notas de credito")
        Me.btnDocumentos.UseCompatibleTextRendering = True
        Me.btnDocumentos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = Global.UI.My.Resources.Resources.team24
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 135)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(140, 52)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.ToolInfo.SetToolTip(Me.btnClientes, "Opciones de clientes/cuentas")
        Me.btnClientes.UseCompatibleTextRendering = True
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'ToolInfo
        '
        Me.ToolInfo.AutomaticDelay = 200
        Me.ToolInfo.AutoPopDelay = 1000
        Me.ToolInfo.InitialDelay = 200
        Me.ToolInfo.IsBalloon = True
        Me.ToolInfo.ReshowDelay = 40
        Me.ToolInfo.ShowAlways = True
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Contenedor As Panel
    Friend WithEvents btnIncobrables As Button
    Friend WithEvents btnCdoPendiente As Button
    Friend WithEvents btnDocumentos As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents TimerFecha As Timer
    Friend WithEvents ToolInfo As ToolTip
End Class
