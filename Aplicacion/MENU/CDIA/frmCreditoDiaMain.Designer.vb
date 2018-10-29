<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreditoDiaMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtTotalD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridMain = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GridMain)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(861, 497)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnConfirmar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(654, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(207, 399)
        Me.Panel3.TabIndex = 4
        '
        'btnConfirmar
        '
        Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(4, 3)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(199, 49)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "Confirmar Pago"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 399)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(861, 98)
        Me.Panel2.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtTotalD)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtTotalP)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(339, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(518, 94)
        Me.Panel4.TabIndex = 0
        '
        'txtTotalD
        '
        Me.txtTotalD.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalD.ForeColor = System.Drawing.Color.Black
        Me.txtTotalD.Location = New System.Drawing.Point(298, 58)
        Me.txtTotalD.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTotalD.Name = "txtTotalD"
        Me.txtTotalD.ReadOnly = True
        Me.txtTotalD.Size = New System.Drawing.Size(212, 32)
        Me.txtTotalD.TabIndex = 10
        Me.txtTotalD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Total Seleccionado Dolares:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalP
        '
        Me.txtTotalP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalP.ForeColor = System.Drawing.Color.Black
        Me.txtTotalP.Location = New System.Drawing.Point(298, 6)
        Me.txtTotalP.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTotalP.Name = "txtTotalP"
        Me.txtTotalP.ReadOnly = True
        Me.txtTotalP.Size = New System.Drawing.Size(212, 32)
        Me.txtTotalP.TabIndex = 8
        Me.txtTotalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total Seleccionado Pesos:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridMain
        '
        Me.GridMain.AllowUserToAddRows = False
        Me.GridMain.AllowUserToDeleteRows = False
        Me.GridMain.AllowUserToResizeRows = False
        Me.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridMain.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridMain.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridMain.Location = New System.Drawing.Point(3, 3)
        Me.GridMain.Name = "GridMain"
        Me.GridMain.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridMain.RowHeadersVisible = False
        Me.GridMain.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GridMain.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridMain.RowTemplate.Height = 24
        Me.GridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridMain.Size = New System.Drawing.Size(645, 394)
        Me.GridMain.TabIndex = 1
        '
        'frmCreditoDiaMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(865, 503)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "frmCreditoDiaMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista contados pendientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents GridMain As Windows.Forms.DataGridView
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents btnConfirmar As Windows.Forms.Button
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents txtTotalD As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtTotalP As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
