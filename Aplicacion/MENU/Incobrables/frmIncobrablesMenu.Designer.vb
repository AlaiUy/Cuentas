<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncobrablesMenu
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
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Main_Container = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnECInco = New System.Windows.Forms.Button()
        Me.btnPasajeInco = New System.Windows.Forms.Button()
        Me.btnBonifInco = New System.Windows.Forms.Button()
        Me.Panel_Main.SuspendLayout()
        Me.Main_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Main
        '
        Me.Panel_Main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Main.BackColor = System.Drawing.Color.Red
        Me.Panel_Main.Controls.Add(Me.Main_Container)
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(532, 405)
        Me.Panel_Main.TabIndex = 0
        '
        'Main_Container
        '
        Me.Main_Container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Main_Container.BackColor = System.Drawing.Color.White
        Me.Main_Container.Controls.Add(Me.btnECInco)
        Me.Main_Container.Controls.Add(Me.btnPasajeInco)
        Me.Main_Container.Controls.Add(Me.btnBonifInco)
        Me.Main_Container.Location = New System.Drawing.Point(3, 3)
        Me.Main_Container.Name = "Main_Container"
        Me.Main_Container.Size = New System.Drawing.Size(526, 399)
        Me.Main_Container.TabIndex = 0
        '
        'btnECInco
        '
        Me.btnECInco.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnECInco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnECInco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnECInco.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.EstadoCuenta
        Me.btnECInco.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnECInco.Location = New System.Drawing.Point(3, 3)
        Me.btnECInco.Name = "btnECInco"
        Me.btnECInco.Size = New System.Drawing.Size(115, 84)
        Me.btnECInco.TabIndex = 1
        Me.btnECInco.Text = "Estado de cuenta"
        Me.btnECInco.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnECInco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnECInco.UseVisualStyleBackColor = True
        '
        'btnPasajeInco
        '
        Me.btnPasajeInco.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPasajeInco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPasajeInco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasajeInco.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.Transfer
        Me.btnPasajeInco.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPasajeInco.Location = New System.Drawing.Point(124, 3)
        Me.btnPasajeInco.Name = "btnPasajeInco"
        Me.btnPasajeInco.Size = New System.Drawing.Size(115, 84)
        Me.btnPasajeInco.TabIndex = 2
        Me.btnPasajeInco.Text = "Pasaje de Cta a Inco"
        Me.btnPasajeInco.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPasajeInco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPasajeInco.UseVisualStyleBackColor = True
        '
        'btnBonifInco
        '
        Me.btnBonifInco.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBonifInco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBonifInco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBonifInco.Image = Global.Aguiñagalde.Aplicacion.My.Resources.Resources.warning
        Me.btnBonifInco.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBonifInco.Location = New System.Drawing.Point(245, 3)
        Me.btnBonifInco.Name = "btnBonifInco"
        Me.btnBonifInco.Size = New System.Drawing.Size(115, 84)
        Me.btnBonifInco.TabIndex = 3
        Me.btnBonifInco.Text = "Bonificacion"
        Me.btnBonifInco.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBonifInco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBonifInco.UseVisualStyleBackColor = True
        '
        'frmIncobrablesMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(532, 405)
        Me.Controls.Add(Me.Panel_Main)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmIncobrablesMenu"
        Me.Text = "frmIncobrablesMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Main.ResumeLayout(False)
        Me.Main_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Main As Windows.Forms.Panel
    Friend WithEvents Main_Container As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnECInco As Windows.Forms.Button
    Friend WithEvents btnPasajeInco As Windows.Forms.Button
    Friend WithEvents btnBonifInco As Windows.Forms.Button
End Class
