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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PMenu = New System.Windows.Forms.Panel()
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
        Me.PTaskBar.Controls.Add(Me.Button3)
        Me.PTaskBar.Controls.Add(Me.PBoxLogo)
        Me.PTaskBar.Controls.Add(Me.Button2)
        Me.PTaskBar.Controls.Add(Me.Button1)
        resources.ApplyResources(Me.PTaskBar, "PTaskBar")
        Me.PTaskBar.ForeColor = System.Drawing.Color.White
        Me.PTaskBar.Name = "PTaskBar"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PBoxLogo
        '
        resources.ApplyResources(Me.PBoxLogo, "PBoxLogo")
        Me.PBoxLogo.Name = "PBoxLogo"
        Me.PBoxLogo.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PMenu
        '
        Me.PMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PMenu.Controls.Add(Me.PBotones)
        resources.ApplyResources(Me.PMenu, "PMenu")
        Me.PMenu.ForeColor = System.Drawing.Color.White
        Me.PMenu.Name = "PMenu"
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
        Me.Name = "FormPrincipal"
        Me.PTaskBar.ResumeLayout(False)
        CType(Me.PBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PMenu.ResumeLayout(False)
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
