<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImprimirFacturas
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabFacturas = New System.Windows.Forms.TabControl()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnBuscar)
        Me.Panel2.Controls.Add(Me.txtNumero)
        Me.Panel2.Controls.Add(Me.txtSerie)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 81)
        Me.Panel2.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Search
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(208, 7)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 61)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(97, 41)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 3
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(97, 12)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtSerie.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NUMERO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SERIE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TabFacturas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 363)
        Me.Panel1.TabIndex = 3
        '
        'TabFacturas
        '
        Me.TabFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFacturas.Font = New System.Drawing.Font("Tahoma", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabFacturas.Location = New System.Drawing.Point(0, 0)
        Me.TabFacturas.Name = "TabFacturas"
        Me.TabFacturas.SelectedIndex = 0
        Me.TabFacturas.Size = New System.Drawing.Size(584, 363)
        Me.TabFacturas.TabIndex = 0
        '
        'frmImprimirFacturas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(584, 444)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmImprimirFacturas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents TabFacturas As Windows.Forms.TabControl
End Class
