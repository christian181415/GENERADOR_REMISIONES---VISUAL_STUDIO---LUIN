﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinOpciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinOpciones))
        Me.POpciones = New System.Windows.Forms.Panel()
        Me.PBotonesOpciones = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnLFA = New System.Windows.Forms.Button()
        Me.CmbYear = New System.Windows.Forms.ComboBox()
        Me.BtnGLU = New System.Windows.Forms.Button()
        Me.CmbMes = New System.Windows.Forms.ComboBox()
        Me.PInstrucciones = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LInstrucciones = New System.Windows.Forms.Label()
        Me.PCargaArchivo = New System.Windows.Forms.Panel()
        Me.DtgExDiferencias = New System.Windows.Forms.DataGridView()
        Me.BtnGenerarExcel = New System.Windows.Forms.Button()
        Me.SaveFileExcel = New System.Windows.Forms.SaveFileDialog()
        Me.POpciones.SuspendLayout()
        Me.PBotonesOpciones.SuspendLayout()
        Me.PInstrucciones.SuspendLayout()
        Me.PCargaArchivo.SuspendLayout()
        CType(Me.DtgExDiferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'POpciones
        '
        Me.POpciones.Controls.Add(Me.PBotonesOpciones)
        Me.POpciones.Controls.Add(Me.PInstrucciones)
        Me.POpciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.POpciones.Location = New System.Drawing.Point(0, 0)
        Me.POpciones.Name = "POpciones"
        Me.POpciones.Size = New System.Drawing.Size(477, 269)
        Me.POpciones.TabIndex = 5
        '
        'PBotonesOpciones
        '
        Me.PBotonesOpciones.ColumnCount = 2
        Me.PBotonesOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PBotonesOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PBotonesOpciones.Controls.Add(Me.BtnLFA, 0, 0)
        Me.PBotonesOpciones.Controls.Add(Me.CmbYear, 0, 1)
        Me.PBotonesOpciones.Controls.Add(Me.BtnGLU, 1, 0)
        Me.PBotonesOpciones.Controls.Add(Me.CmbMes, 1, 1)
        Me.PBotonesOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PBotonesOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PBotonesOpciones.Name = "PBotonesOpciones"
        Me.PBotonesOpciones.RowCount = 2
        Me.PBotonesOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.60606!))
        Me.PBotonesOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.39394!))
        Me.PBotonesOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PBotonesOpciones.Size = New System.Drawing.Size(477, 66)
        Me.PBotonesOpciones.TabIndex = 27
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
        Me.BtnLFA.Size = New System.Drawing.Size(232, 34)
        Me.BtnLFA.TabIndex = 29
        Me.BtnLFA.Text = "Remisiones LFA"
        Me.BtnLFA.UseVisualStyleBackColor = False
        '
        'CmbYear
        '
        Me.CmbYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.CmbYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbYear.ForeColor = System.Drawing.Color.White
        Me.CmbYear.FormattingEnabled = True
        Me.CmbYear.Location = New System.Drawing.Point(3, 43)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.Size = New System.Drawing.Size(232, 24)
        Me.CmbYear.TabIndex = 24
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
        Me.BtnGLU.Location = New System.Drawing.Point(241, 3)
        Me.BtnGLU.Name = "BtnGLU"
        Me.BtnGLU.Size = New System.Drawing.Size(233, 34)
        Me.BtnGLU.TabIndex = 27
        Me.BtnGLU.Text = "Remisiones GLU"
        Me.BtnGLU.UseVisualStyleBackColor = False
        '
        'CmbMes
        '
        Me.CmbMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.CmbMes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMes.ForeColor = System.Drawing.Color.White
        Me.CmbMes.FormattingEnabled = True
        Me.CmbMes.Location = New System.Drawing.Point(241, 43)
        Me.CmbMes.Name = "CmbMes"
        Me.CmbMes.Size = New System.Drawing.Size(233, 24)
        Me.CmbMes.TabIndex = 25
        '
        'PInstrucciones
        '
        Me.PInstrucciones.Controls.Add(Me.Label4)
        Me.PInstrucciones.Controls.Add(Me.Label3)
        Me.PInstrucciones.Controls.Add(Me.Label2)
        Me.PInstrucciones.Controls.Add(Me.Label1)
        Me.PInstrucciones.Controls.Add(Me.LInstrucciones)
        Me.PInstrucciones.Location = New System.Drawing.Point(19, 83)
        Me.PInstrucciones.Name = "PInstrucciones"
        Me.PInstrucciones.Size = New System.Drawing.Size(437, 166)
        Me.PInstrucciones.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(410, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "- Elegir el nombre y ruta del archivo."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "- Dar clic en el boton ""generar excel""."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "- Seleecione el año y mes a consultar."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "- Seleccione una empresa."
        '
        'LInstrucciones
        '
        Me.LInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LInstrucciones.Location = New System.Drawing.Point(13, 10)
        Me.LInstrucciones.Name = "LInstrucciones"
        Me.LInstrucciones.Size = New System.Drawing.Size(410, 54)
        Me.LInstrucciones.TabIndex = 13
        Me.LInstrucciones.Text = "Para generar un concentrado de remisiones, es necesario proporcionar una fecha do" &
    "nde se haya cargado una remisión."
        '
        'PCargaArchivo
        '
        Me.PCargaArchivo.Controls.Add(Me.DtgExDiferencias)
        Me.PCargaArchivo.Controls.Add(Me.BtnGenerarExcel)
        Me.PCargaArchivo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PCargaArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCargaArchivo.ForeColor = System.Drawing.Color.White
        Me.PCargaArchivo.Location = New System.Drawing.Point(0, 269)
        Me.PCargaArchivo.Name = "PCargaArchivo"
        Me.PCargaArchivo.Size = New System.Drawing.Size(477, 38)
        Me.PCargaArchivo.TabIndex = 4
        '
        'DtgExDiferencias
        '
        Me.DtgExDiferencias.AllowUserToAddRows = False
        Me.DtgExDiferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgExDiferencias.Location = New System.Drawing.Point(448, 10)
        Me.DtgExDiferencias.Name = "DtgExDiferencias"
        Me.DtgExDiferencias.Size = New System.Drawing.Size(17, 16)
        Me.DtgExDiferencias.TabIndex = 28
        Me.DtgExDiferencias.Visible = False
        '
        'BtnGenerarExcel
        '
        Me.BtnGenerarExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnGenerarExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGenerarExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnGenerarExcel.FlatAppearance.BorderSize = 0
        Me.BtnGenerarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnGenerarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGenerarExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarExcel.ForeColor = System.Drawing.Color.White
        Me.BtnGenerarExcel.Location = New System.Drawing.Point(0, 0)
        Me.BtnGenerarExcel.Name = "BtnGenerarExcel"
        Me.BtnGenerarExcel.Size = New System.Drawing.Size(477, 38)
        Me.BtnGenerarExcel.TabIndex = 1
        Me.BtnGenerarExcel.Text = "GENERAR EXCEL"
        Me.BtnGenerarExcel.UseVisualStyleBackColor = False
        '
        'SaveFileExcel
        '
        Me.SaveFileExcel.Filter = "Archivos Excel(*.xlsx; *.xls)|*xlsx;*slx"
        Me.SaveFileExcel.Title = "Seleccione la ruta del archivo."
        '
        'WinOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 307)
        Me.Controls.Add(Me.POpciones)
        Me.Controls.Add(Me.PCargaArchivo)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WinOpciones"
        Me.Text = "WinOpciones"
        Me.POpciones.ResumeLayout(False)
        Me.PBotonesOpciones.ResumeLayout(False)
        Me.PInstrucciones.ResumeLayout(False)
        Me.PCargaArchivo.ResumeLayout(False)
        CType(Me.DtgExDiferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents POpciones As Panel
    Friend WithEvents PCargaArchivo As Panel
    Friend WithEvents BtnGenerarExcel As Button
    Friend WithEvents PInstrucciones As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LInstrucciones As Label
    Friend WithEvents PBotonesOpciones As TableLayoutPanel
    Friend WithEvents BtnLFA As Button
    Friend WithEvents CmbYear As ComboBox
    Friend WithEvents BtnGLU As Button
    Friend WithEvents CmbMes As ComboBox
    Friend WithEvents SaveFileExcel As SaveFileDialog
    Friend WithEvents DtgExDiferencias As DataGridView
End Class
