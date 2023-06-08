<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinHistorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinHistorial))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PHistorial = New System.Windows.Forms.Panel()
        Me.POpciones = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnLFA = New System.Windows.Forms.Button()
        Me.CmbYear = New System.Windows.Forms.ComboBox()
        Me.BtnGLU = New System.Windows.Forms.Button()
        Me.CmbMes = New System.Windows.Forms.ComboBox()
        Me.DTGHistorial = New System.Windows.Forms.DataGridView()
        Me.PMostrarHistorial = New System.Windows.Forms.Panel()
        Me.BtnMostrarRemisiones = New System.Windows.Forms.Button()
        Me.PHistorial.SuspendLayout()
        Me.POpciones.SuspendLayout()
        CType(Me.DTGHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PMostrarHistorial.SuspendLayout()
        Me.SuspendLayout()
        '
        'PHistorial
        '
        Me.PHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PHistorial.Controls.Add(Me.POpciones)
        Me.PHistorial.Controls.Add(Me.DTGHistorial)
        Me.PHistorial.Controls.Add(Me.PMostrarHistorial)
        Me.PHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PHistorial.ForeColor = System.Drawing.Color.White
        Me.PHistorial.Location = New System.Drawing.Point(0, 0)
        Me.PHistorial.Name = "PHistorial"
        Me.PHistorial.Size = New System.Drawing.Size(477, 307)
        Me.PHistorial.TabIndex = 6
        '
        'POpciones
        '
        Me.POpciones.ColumnCount = 2
        Me.POpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.POpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.POpciones.Controls.Add(Me.BtnLFA, 0, 0)
        Me.POpciones.Controls.Add(Me.CmbYear, 0, 1)
        Me.POpciones.Controls.Add(Me.BtnGLU, 1, 0)
        Me.POpciones.Controls.Add(Me.CmbMes, 1, 1)
        Me.POpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.POpciones.Location = New System.Drawing.Point(0, 0)
        Me.POpciones.Name = "POpciones"
        Me.POpciones.RowCount = 2
        Me.POpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.60606!))
        Me.POpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.39394!))
        Me.POpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.POpciones.Size = New System.Drawing.Size(477, 66)
        Me.POpciones.TabIndex = 26
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
        'DTGHistorial
        '
        Me.DTGHistorial.AllowUserToAddRows = False
        Me.DTGHistorial.AllowUserToDeleteRows = False
        Me.DTGHistorial.AllowUserToResizeColumns = False
        Me.DTGHistorial.AllowUserToResizeRows = False
        Me.DTGHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTGHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGHistorial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DTGHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DTGHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTGHistorial.DefaultCellStyle = DataGridViewCellStyle2
        Me.DTGHistorial.Location = New System.Drawing.Point(0, 72)
        Me.DTGHistorial.MultiSelect = False
        Me.DTGHistorial.Name = "DTGHistorial"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGHistorial.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DTGHistorial.RowHeadersVisible = False
        Me.DTGHistorial.Size = New System.Drawing.Size(477, 197)
        Me.DTGHistorial.TabIndex = 6
        '
        'PMostrarHistorial
        '
        Me.PMostrarHistorial.Controls.Add(Me.BtnMostrarRemisiones)
        Me.PMostrarHistorial.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PMostrarHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PMostrarHistorial.ForeColor = System.Drawing.Color.White
        Me.PMostrarHistorial.Location = New System.Drawing.Point(0, 269)
        Me.PMostrarHistorial.Name = "PMostrarHistorial"
        Me.PMostrarHistorial.Size = New System.Drawing.Size(477, 38)
        Me.PMostrarHistorial.TabIndex = 5
        '
        'BtnMostrarRemisiones
        '
        Me.BtnMostrarRemisiones.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnMostrarRemisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMostrarRemisiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMostrarRemisiones.FlatAppearance.BorderSize = 0
        Me.BtnMostrarRemisiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnMostrarRemisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrarRemisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrarRemisiones.ForeColor = System.Drawing.Color.White
        Me.BtnMostrarRemisiones.Location = New System.Drawing.Point(0, 0)
        Me.BtnMostrarRemisiones.Name = "BtnMostrarRemisiones"
        Me.BtnMostrarRemisiones.Size = New System.Drawing.Size(477, 38)
        Me.BtnMostrarRemisiones.TabIndex = 1
        Me.BtnMostrarRemisiones.Text = "MOSTRAR REMISIONES"
        Me.BtnMostrarRemisiones.UseVisualStyleBackColor = False
        '
        'WinHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 307)
        Me.Controls.Add(Me.PHistorial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WinHistorial"
        Me.Text = "WinHistorial"
        Me.PHistorial.ResumeLayout(False)
        Me.POpciones.ResumeLayout(False)
        CType(Me.DTGHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PMostrarHistorial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PHistorial As Panel
    Friend WithEvents PMostrarHistorial As Panel
    Friend WithEvents BtnMostrarRemisiones As Button
    Friend WithEvents DTGHistorial As DataGridView
    Friend WithEvents POpciones As TableLayoutPanel
    Friend WithEvents CmbMes As ComboBox
    Friend WithEvents CmbYear As ComboBox
    Friend WithEvents BtnGLU As Button
    Friend WithEvents BtnLFA As Button
End Class
