<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinHistorial
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PHistorial = New System.Windows.Forms.Panel()
        Me.DTPFechaRemision = New UIDC.UI_CustomDateTimePicker()
        Me.PCargaArchivo = New System.Windows.Forms.Panel()
        Me.BtnGenerarExcel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PHistorial.SuspendLayout()
        Me.PCargaArchivo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PHistorial
        '
        Me.PHistorial.Controls.Add(Me.DataGridView1)
        Me.PHistorial.Controls.Add(Me.PCargaArchivo)
        Me.PHistorial.Controls.Add(Me.DTPFechaRemision)
        Me.PHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PHistorial.ForeColor = System.Drawing.Color.White
        Me.PHistorial.Location = New System.Drawing.Point(0, 0)
        Me.PHistorial.Name = "PHistorial"
        Me.PHistorial.Size = New System.Drawing.Size(477, 307)
        Me.PHistorial.TabIndex = 6
        '
        'DTPFechaRemision
        '
        Me.DTPFechaRemision.BackColor = System.Drawing.Color.Transparent
        Me.DTPFechaRemision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DTPFechaRemision.CollapseColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DTPFechaRemision.CustomFormat = Nothing
        Me.DTPFechaRemision.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTPFechaRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DTPFechaRemision.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTPFechaRemision.HeightBase = 30
        Me.DTPFechaRemision.LineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DTPFechaRemision.LineSize = 9
        Me.DTPFechaRemision.Location = New System.Drawing.Point(0, 0)
        Me.DTPFechaRemision.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPFechaRemision.MinDate = New Date(2023, 5, 1, 0, 0, 0, 0)
        Me.DTPFechaRemision.Name = "DTPFechaRemision"
        Me.DTPFechaRemision.Radius = True
        Me.DTPFechaRemision.Size = New System.Drawing.Size(477, 26)
        Me.DTPFechaRemision.SolidColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DTPFechaRemision.TabIndex = 0
        Me.DTPFechaRemision.Text = "miércoles, 24 de mayo de 2023"
        Me.DTPFechaRemision.TextColor = System.Drawing.Color.White
        Me.DTPFechaRemision.Value = New Date(2023, 5, 24, 16, 29, 59, 263)
        '
        'PCargaArchivo
        '
        Me.PCargaArchivo.Controls.Add(Me.BtnGenerarExcel)
        Me.PCargaArchivo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PCargaArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCargaArchivo.ForeColor = System.Drawing.Color.White
        Me.PCargaArchivo.Location = New System.Drawing.Point(0, 269)
        Me.PCargaArchivo.Name = "PCargaArchivo"
        Me.PCargaArchivo.Size = New System.Drawing.Size(477, 38)
        Me.PCargaArchivo.TabIndex = 5
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
        Me.BtnGenerarExcel.Text = "MOSTRAR REMISIONES"
        Me.BtnGenerarExcel.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 26)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(477, 243)
        Me.DataGridView1.TabIndex = 6
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
        Me.PCargaArchivo.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PHistorial As Panel
    Friend WithEvents DTPFechaRemision As UIDC.UI_CustomDateTimePicker
    Friend WithEvents PCargaArchivo As Panel
    Friend WithEvents BtnGenerarExcel As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
