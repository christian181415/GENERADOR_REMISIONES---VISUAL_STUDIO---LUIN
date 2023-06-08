<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.PTaskBar = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnOpciones = New System.Windows.Forms.Button()
        Me.PBoxLogo = New System.Windows.Forms.PictureBox()
        Me.BtnHistorial = New System.Windows.Forms.Button()
        Me.BtnRemisiones = New System.Windows.Forms.Button()
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.LNombrePanel = New System.Windows.Forms.Label()
        Me.PBotones = New System.Windows.Forms.Panel()
        Me.PBoxMaximize = New System.Windows.Forms.PictureBox()
        Me.PBoxMinimize = New System.Windows.Forms.PictureBox()
        Me.PBoxExit = New System.Windows.Forms.PictureBox()
        Me.PInfo = New System.Windows.Forms.Panel()
        Me.PTaskBar.SuspendLayout()
        CType(Me.PBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PMenu.SuspendLayout()
        Me.PBotones.SuspendLayout()
        CType(Me.PBoxMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PTaskBar
        '
        Me.PTaskBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PTaskBar.Controls.Add(Me.Panel3)
        Me.PTaskBar.Controls.Add(Me.Panel2)
        Me.PTaskBar.Controls.Add(Me.Panel1)
        Me.PTaskBar.Controls.Add(Me.BtnOpciones)
        Me.PTaskBar.Controls.Add(Me.PBoxLogo)
        Me.PTaskBar.Controls.Add(Me.BtnHistorial)
        Me.PTaskBar.Controls.Add(Me.BtnRemisiones)
        resources.ApplyResources(Me.PTaskBar, "PTaskBar")
        Me.PTaskBar.ForeColor = System.Drawing.Color.White
        Me.PTaskBar.Name = "PTaskBar"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'BtnOpciones
        '
        Me.BtnOpciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOpciones.FlatAppearance.BorderSize = 0
        Me.BtnOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.BtnOpciones, "BtnOpciones")
        Me.BtnOpciones.Name = "BtnOpciones"
        Me.BtnOpciones.UseVisualStyleBackColor = True
        '
        'PBoxLogo
        '
        resources.ApplyResources(Me.PBoxLogo, "PBoxLogo")
        Me.PBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBoxLogo.Name = "PBoxLogo"
        Me.PBoxLogo.TabStop = False
        '
        'BtnHistorial
        '
        Me.BtnHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHistorial.FlatAppearance.BorderSize = 0
        Me.BtnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.BtnHistorial, "BtnHistorial")
        Me.BtnHistorial.Name = "BtnHistorial"
        Me.BtnHistorial.UseVisualStyleBackColor = True
        '
        'BtnRemisiones
        '
        Me.BtnRemisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemisiones.FlatAppearance.BorderSize = 0
        Me.BtnRemisiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.BtnRemisiones, "BtnRemisiones")
        Me.BtnRemisiones.Name = "BtnRemisiones"
        Me.BtnRemisiones.UseVisualStyleBackColor = True
        '
        'PMenu
        '
        Me.PMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PMenu.Controls.Add(Me.LNombrePanel)
        Me.PMenu.Controls.Add(Me.PBotones)
        resources.ApplyResources(Me.PMenu, "PMenu")
        Me.PMenu.ForeColor = System.Drawing.Color.White
        Me.PMenu.Name = "PMenu"
        '
        'LNombrePanel
        '
        resources.ApplyResources(Me.LNombrePanel, "LNombrePanel")
        Me.LNombrePanel.ForeColor = System.Drawing.Color.White
        Me.LNombrePanel.Name = "LNombrePanel"
        '
        'PBotones
        '
        Me.PBotones.Controls.Add(Me.PBoxMaximize)
        Me.PBotones.Controls.Add(Me.PBoxMinimize)
        Me.PBotones.Controls.Add(Me.PBoxExit)
        resources.ApplyResources(Me.PBotones, "PBotones")
        Me.PBotones.Name = "PBotones"
        '
        'PBoxMaximize
        '
        resources.ApplyResources(Me.PBoxMaximize, "PBoxMaximize")
        Me.PBoxMaximize.Cursor = System.Windows.Forms.Cursors.Default
        Me.PBoxMaximize.Name = "PBoxMaximize"
        Me.PBoxMaximize.TabStop = False
        '
        'PBoxMinimize
        '
        resources.ApplyResources(Me.PBoxMinimize, "PBoxMinimize")
        Me.PBoxMinimize.Name = "PBoxMinimize"
        Me.PBoxMinimize.TabStop = False
        '
        'PBoxExit
        '
        resources.ApplyResources(Me.PBoxExit, "PBoxExit")
        Me.PBoxExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.PBoxExit.Name = "PBoxExit"
        Me.PBoxExit.TabStop = False
        '
        'PInfo
        '
        Me.PInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        resources.ApplyResources(Me.PInfo, "PInfo")
        Me.PInfo.ForeColor = System.Drawing.Color.White
        Me.PInfo.Name = "PInfo"
        '
        'FormPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PInfo)
        Me.Controls.Add(Me.PMenu)
        Me.Controls.Add(Me.PTaskBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "FormPrincipal"
        Me.PTaskBar.ResumeLayout(False)
        CType(Me.PBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PMenu.ResumeLayout(False)
        Me.PMenu.PerformLayout()
        Me.PBotones.ResumeLayout(False)
        CType(Me.PBoxMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PTaskBar As Panel
    Friend WithEvents PMenu As Panel
    Friend WithEvents PInfo As Panel
    Friend WithEvents PBoxLogo As PictureBox
    Friend WithEvents PBotones As Panel
    Friend WithEvents PBoxMaximize As PictureBox
    Friend WithEvents PBoxMinimize As PictureBox
    Friend WithEvents PBoxExit As PictureBox
    Friend WithEvents BtnOpciones As Button
    Friend WithEvents BtnHistorial As Button
    Friend WithEvents BtnRemisiones As Button
    Friend WithEvents LNombrePanel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
