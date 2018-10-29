<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtaDiaMenu
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
        Me.btnVerFacturas = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnVerFacturas)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 393)
        Me.Panel1.TabIndex = 0
        '
        'btnVerFacturas
        '
        Me.btnVerFacturas.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnVerFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerFacturas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerFacturas.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.list
        Me.btnVerFacturas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVerFacturas.Location = New System.Drawing.Point(10, 10)
        Me.btnVerFacturas.Name = "btnVerFacturas"
        Me.btnVerFacturas.Size = New System.Drawing.Size(132, 74)
        Me.btnVerFacturas.TabIndex = 0
        Me.btnVerFacturas.Text = "Ver Facturas"
        Me.btnVerFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVerFacturas.UseVisualStyleBackColor = True
        '
        'frmCtaDiaMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 397)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCtaDiaMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCtaDiaMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnVerFacturas As Windows.Forms.Button
End Class
