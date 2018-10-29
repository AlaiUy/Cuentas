<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MainContainer = New System.Windows.Forms.Panel()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.lblFrases = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnDocs = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCtaDia = New System.Windows.Forms.Button()
        Me.btnIncos = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainHeader = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnChangeLog = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnCpanel = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MainContainer.SuspendLayout()
        Me.PanelCentral.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.MainHeader.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainContainer
        '
        Me.MainContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainContainer.Controls.Add(Me.PanelCentral)
        Me.MainContainer.Controls.Add(Me.Panel3)
        Me.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainContainer.Location = New System.Drawing.Point(0, 90)
        Me.MainContainer.Name = "MainContainer"
        Me.MainContainer.Size = New System.Drawing.Size(993, 532)
        Me.MainContainer.TabIndex = 0
        '
        'PanelCentral
        '
        Me.PanelCentral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCentral.BackColor = System.Drawing.Color.White
        Me.PanelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelCentral.Controls.Add(Me.lblFrases)
        Me.PanelCentral.Location = New System.Drawing.Point(3, 139)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Size = New System.Drawing.Size(985, 384)
        Me.PanelCentral.TabIndex = 6
        '
        'lblFrases
        '
        Me.lblFrases.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblFrases.Font = New System.Drawing.Font("Cooper Black", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrases.ForeColor = System.Drawing.Color.Gray
        Me.lblFrases.Location = New System.Drawing.Point(0, 314)
        Me.lblFrases.Name = "lblFrases"
        Me.lblFrases.Size = New System.Drawing.Size(985, 70)
        Me.lblFrases.TabIndex = 0
        Me.lblFrases.Text = """Recuerda que tienes muchas personas que te quieren, sigue adelante y olvida las " &
    "dificultades que siempre existen."""
        Me.lblFrases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(2, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(985, 128)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 49)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(985, 79)
        Me.Panel5.TabIndex = 5
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClientes)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnDocs)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnCtaDia)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnIncos)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(985, 79)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClientes.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Persona
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.Location = New System.Drawing.Point(0, 5)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(83, 70)
        Me.btnClientes.TabIndex = 4
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnDocs
        '
        Me.btnDocs.BackColor = System.Drawing.Color.Transparent
        Me.btnDocs.FlatAppearance.BorderSize = 0
        Me.btnDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDocs.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Files
        Me.btnDocs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDocs.Location = New System.Drawing.Point(83, 5)
        Me.btnDocs.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.btnDocs.Name = "btnDocs"
        Me.btnDocs.Size = New System.Drawing.Size(118, 70)
        Me.btnDocs.TabIndex = 5
        Me.btnDocs.Text = "Documentos"
        Me.btnDocs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDocs.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(201, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 70)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Informes"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btnCtaDia
        '
        Me.btnCtaDia.BackColor = System.Drawing.Color.Transparent
        Me.btnCtaDia.Enabled = False
        Me.btnCtaDia.FlatAppearance.BorderSize = 0
        Me.btnCtaDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtaDia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtaDia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCtaDia.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.coin
        Me.btnCtaDia.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCtaDia.Location = New System.Drawing.Point(319, 5)
        Me.btnCtaDia.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.btnCtaDia.Name = "btnCtaDia"
        Me.btnCtaDia.Size = New System.Drawing.Size(157, 69)
        Me.btnCtaDia.TabIndex = 7
        Me.btnCtaDia.Text = "Contados Pendientes"
        Me.btnCtaDia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCtaDia.UseVisualStyleBackColor = False
        Me.btnCtaDia.Visible = False
        '
        'btnIncos
        '
        Me.btnIncos.BackColor = System.Drawing.Color.Transparent
        Me.btnIncos.FlatAppearance.BorderSize = 0
        Me.btnIncos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnIncos.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Incos
        Me.btnIncos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIncos.Location = New System.Drawing.Point(476, 5)
        Me.btnIncos.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.btnIncos.Name = "btnIncos"
        Me.btnIncos.Size = New System.Drawing.Size(132, 70)
        Me.btnIncos.TabIndex = 8
        Me.btnIncos.Text = "Incobrables"
        Me.btnIncos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIncos.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(985, 49)
        Me.Panel4.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "- General"
        '
        'MainHeader
        '
        Me.MainHeader.BackColor = System.Drawing.Color.White
        Me.MainHeader.Controls.Add(Me.Panel6)
        Me.MainHeader.Controls.Add(Me.lblTitulo)
        Me.MainHeader.Controls.Add(Me.Panel1)
        Me.MainHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainHeader.Location = New System.Drawing.Point(0, 0)
        Me.MainHeader.Name = "MainHeader"
        Me.MainHeader.Size = New System.Drawing.Size(993, 90)
        Me.MainHeader.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnChangeLog)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(741, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(252, 90)
        Me.Panel6.TabIndex = 2
        '
        'btnChangeLog
        '
        Me.btnChangeLog.BackColor = System.Drawing.Color.Transparent
        Me.btnChangeLog.FlatAppearance.BorderSize = 0
        Me.btnChangeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeLog.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChangeLog.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Info
        Me.btnChangeLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChangeLog.Location = New System.Drawing.Point(144, 5)
        Me.btnChangeLog.Margin = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnChangeLog.Name = "btnChangeLog"
        Me.btnChangeLog.Size = New System.Drawing.Size(97, 72)
        Me.btnChangeLog.TabIndex = 10
        Me.btnChangeLog.Text = "Cambios"
        Me.btnChangeLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnChangeLog.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnCpanel)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(126, 90)
        Me.Panel7.TabIndex = 0
        '
        'btnCpanel
        '
        Me.btnCpanel.BackColor = System.Drawing.Color.Transparent
        Me.btnCpanel.FlatAppearance.BorderSize = 0
        Me.btnCpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCpanel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCpanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCpanel.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Settings
        Me.btnCpanel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCpanel.Location = New System.Drawing.Point(6, 4)
        Me.btnCpanel.Margin = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnCpanel.Name = "btnCpanel"
        Me.btnCpanel.Size = New System.Drawing.Size(115, 84)
        Me.btnCpanel.TabIndex = 11
        Me.btnCpanel.Text = "Panel de Control"
        Me.btnCpanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCpanel.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitulo.Location = New System.Drawing.Point(130, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(224, 26)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Cuentas Corrientes:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 74)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(1, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 69)
        Me.Label3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MainContainer)
        Me.Panel2.Controls.Add(Me.MainHeader)
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(993, 622)
        Me.Panel2.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 630)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainContainer.ResumeLayout(False)
        Me.PanelCentral.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MainHeader.ResumeLayout(False)
        Me.MainHeader.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainContainer As System.Windows.Forms.Panel
    Friend WithEvents MainHeader As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PanelCentral As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnDocs As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnChangeLog As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCpanel As Windows.Forms.Button
    Friend WithEvents lblFrases As Windows.Forms.Label
    Friend WithEvents btnCtaDia As Windows.Forms.Button
    Friend WithEvents btnIncos As Windows.Forms.Button
End Class
