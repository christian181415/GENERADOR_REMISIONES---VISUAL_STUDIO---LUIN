﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinRemisiones
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinRemisiones))
        Me.PCargaArchivo = New System.Windows.Forms.Panel()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.PRemisiones = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnGLU = New System.Windows.Forms.Button()
        Me.BtnLFA = New System.Windows.Forms.Button()
        Me.PBarDatos = New System.Windows.Forms.ProgressBar()
        Me.LDatos = New System.Windows.Forms.Label()
        Me.PInstrucciones = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LInstrucciones = New System.Windows.Forms.Label()
        Me.BWRemisiones = New System.ComponentModel.BackgroundWorker()
        Me.OFDRemisiones = New System.Windows.Forms.OpenFileDialog()
        Me.TimeProcess = New System.Windows.Forms.Timer(Me.components)
        Me.PCargaArchivo.SuspendLayout()
        Me.PRemisiones.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PInstrucciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PCargaArchivo
        '
        Me.PCargaArchivo.Controls.Add(Me.BtnCargar)
        Me.PCargaArchivo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PCargaArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCargaArchivo.ForeColor = System.Drawing.Color.White
        Me.PCargaArchivo.Location = New System.Drawing.Point(0, 269)
        Me.PCargaArchivo.Name = "PCargaArchivo"
        Me.PCargaArchivo.Size = New System.Drawing.Size(477, 38)
        Me.PCargaArchivo.TabIndex = 2
        '
        'BtnCargar
        '
        Me.BtnCargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCargar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCargar.FlatAppearance.BorderSize = 0
        Me.BtnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargar.ForeColor = System.Drawing.Color.White
        Me.BtnCargar.Location = New System.Drawing.Point(0, 0)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(477, 38)
        Me.BtnCargar.TabIndex = 1
        Me.BtnCargar.Text = "CARGAR ARCHIVO"
        Me.BtnCargar.UseVisualStyleBackColor = False
        '
        'PRemisiones
        '
        Me.PRemisiones.Controls.Add(Me.TableLayoutPanel1)
        Me.PRemisiones.Controls.Add(Me.PBarDatos)
        Me.PRemisiones.Controls.Add(Me.LDatos)
        Me.PRemisiones.Controls.Add(Me.PInstrucciones)
        Me.PRemisiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PRemisiones.Location = New System.Drawing.Point(0, 0)
        Me.PRemisiones.Name = "PRemisiones"
        Me.PRemisiones.Size = New System.Drawing.Size(477, 269)
        Me.PRemisiones.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnGLU, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnLFA, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 222)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(436, 40)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'BtnGLU
        '
        Me.BtnGLU.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnGLU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnGLU.FlatAppearance.BorderSize = 0
        Me.BtnGLU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnGLU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGLU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGLU.Image = CType(resources.GetObject("BtnGLU.Image"), System.Drawing.Image)
        Me.BtnGLU.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGLU.Location = New System.Drawing.Point(221, 3)
        Me.BtnGLU.Name = "BtnGLU"
        Me.BtnGLU.Size = New System.Drawing.Size(212, 34)
        Me.BtnGLU.TabIndex = 28
        Me.BtnGLU.Text = "Remisiones GLU"
        Me.BtnGLU.UseVisualStyleBackColor = False
        '
        'BtnLFA
        '
        Me.BtnLFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnLFA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLFA.FlatAppearance.BorderSize = 0
        Me.BtnLFA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnLFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLFA.Image = CType(resources.GetObject("BtnLFA.Image"), System.Drawing.Image)
        Me.BtnLFA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLFA.Location = New System.Drawing.Point(3, 3)
        Me.BtnLFA.Name = "BtnLFA"
        Me.BtnLFA.Size = New System.Drawing.Size(212, 34)
        Me.BtnLFA.TabIndex = 30
        Me.BtnLFA.Text = "Remisiones LFA"
        Me.BtnLFA.UseVisualStyleBackColor = False
        '
        'PBarDatos
        '
        Me.PBarDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PBarDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PBarDatos.Location = New System.Drawing.Point(19, 200)
        Me.PBarDatos.Margin = New System.Windows.Forms.Padding(0)
        Me.PBarDatos.Name = "PBarDatos"
        Me.PBarDatos.Size = New System.Drawing.Size(437, 10)
        Me.PBarDatos.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PBarDatos.TabIndex = 3
        Me.PBarDatos.Visible = False
        '
        'LDatos
        '
        Me.LDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LDatos.AutoSize = True
        Me.LDatos.Location = New System.Drawing.Point(19, 182)
        Me.LDatos.Name = "LDatos"
        Me.LDatos.Size = New System.Drawing.Size(49, 13)
        Me.LDatos.TabIndex = 2
        Me.LDatos.Text = "Registro:"
        Me.LDatos.Visible = False
        '
        'PInstrucciones
        '
        Me.PInstrucciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PInstrucciones.Controls.Add(Me.Label5)
        Me.PInstrucciones.Controls.Add(Me.Label4)
        Me.PInstrucciones.Controls.Add(Me.Label3)
        Me.PInstrucciones.Controls.Add(Me.Label2)
        Me.PInstrucciones.Controls.Add(Me.Label1)
        Me.PInstrucciones.Controls.Add(Me.LInstrucciones)
        Me.PInstrucciones.Location = New System.Drawing.Point(19, 13)
        Me.PInstrucciones.Name = "PInstrucciones"
        Me.PInstrucciones.Size = New System.Drawing.Size(437, 166)
        Me.PInstrucciones.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(397, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Remisiones LFA     Remisiones GLU"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(410, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "- Cargue el archivo excel con formato .xls"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "- Seleccione la empresa con la que se guarda la remisión."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "00/ENE./0000     00/FEB./0000     00/MAR./0000"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 35)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "- Modifique el archivo para que las fechas tengan un formato correcto."
        '
        'LInstrucciones
        '
        Me.LInstrucciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LInstrucciones.Location = New System.Drawing.Point(14, 13)
        Me.LInstrucciones.Name = "LInstrucciones"
        Me.LInstrucciones.Size = New System.Drawing.Size(410, 37)
        Me.LInstrucciones.TabIndex = 13
        Me.LInstrucciones.Text = "Para un uso optimo del sistema generador de remisiones siga las siguientes instru" &
    "cciones."
        '
        'BWRemisiones
        '
        '
        'OFDRemisiones
        '
        Me.OFDRemisiones.FileName = "OpenFileDialog1"
        '
        'TimeProcess
        '
        '
        'WinRemisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 307)
        Me.Controls.Add(Me.PRemisiones)
        Me.Controls.Add(Me.PCargaArchivo)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WinRemisiones"
        Me.ShowIcon = False
        Me.Text = "UI_TitleBanner1"
        Me.PCargaArchivo.ResumeLayout(False)
        Me.PRemisiones.ResumeLayout(False)
        Me.PRemisiones.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PInstrucciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PCargaArchivo As Panel
    Friend WithEvents PRemisiones As Panel
    Friend WithEvents BtnCargar As Button
    Friend WithEvents PInstrucciones As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LInstrucciones As Label
    Friend WithEvents BWRemisiones As System.ComponentModel.BackgroundWorker
    Friend WithEvents OFDRemisiones As OpenFileDialog
    Friend WithEvents LDatos As Label
    Friend WithEvents PBarDatos As ProgressBar
    Friend WithEvents TimeProcess As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnLFA As Button
    Friend WithEvents BtnGLU As Button
End Class
