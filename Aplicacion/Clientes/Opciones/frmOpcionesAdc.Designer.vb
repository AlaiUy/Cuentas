<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionesAdc
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.btnLlamada = New System.Windows.Forms.Button()
        Me.btnEC = New System.Windows.Forms.Button()
        Me.btnClearing = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 390)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnLlamada)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEC)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClearing)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 45)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(352, 343)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtComentario)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 139)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comentario:"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(8, 40)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(330, 91)
        Me.txtComentario.TabIndex = 0
        '
        'btnLlamada
        '
        Me.btnLlamada.BackColor = System.Drawing.Color.White
        Me.btnLlamada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLlamada.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLlamada.Location = New System.Drawing.Point(3, 148)
        Me.btnLlamada.Name = "btnLlamada"
        Me.btnLlamada.Size = New System.Drawing.Size(346, 38)
        Me.btnLlamada.TabIndex = 0
        Me.btnLlamada.Text = "Llamada "
        Me.btnLlamada.UseVisualStyleBackColor = False
        '
        'btnEC
        '
        Me.btnEC.BackColor = System.Drawing.Color.White
        Me.btnEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEC.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEC.Location = New System.Drawing.Point(3, 192)
        Me.btnEC.Name = "btnEC"
        Me.btnEC.Size = New System.Drawing.Size(346, 38)
        Me.btnEC.TabIndex = 1
        Me.btnEC.Text = "Estado Cuenta U/M"
        Me.btnEC.UseVisualStyleBackColor = False
        '
        'btnClearing
        '
        Me.btnClearing.BackColor = System.Drawing.Color.White
        Me.btnClearing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearing.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearing.Location = New System.Drawing.Point(3, 236)
        Me.btnClearing.Name = "btnClearing"
        Me.btnClearing.Size = New System.Drawing.Size(346, 38)
        Me.btnClearing.TabIndex = 3
        Me.btnClearing.Text = "Clearing"
        Me.btnClearing.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 45)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Opciones Adicionales"
        '
        'frmOpcionesAdc
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(354, 390)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmOpcionesAdc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOpcionesAdc"
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnLlamada As Windows.Forms.Button
    Friend WithEvents btnEC As Windows.Forms.Button
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtComentario As Windows.Forms.TextBox
    Friend WithEvents btnClearing As Windows.Forms.Button
End Class
