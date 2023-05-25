<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.POpciones = New System.Windows.Forms.Panel()
        Me.PCargaArchivo = New System.Windows.Forms.Panel()
        Me.BtnGenerarExcel = New System.Windows.Forms.Button()
        Me.DTPFechaRemision = New UIDC.UI_CustomDateTimePicker()
        Me.PInstrucciones = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LInstrucciones = New System.Windows.Forms.Label()
        Me.POpciones.SuspendLayout()
        Me.PCargaArchivo.SuspendLayout()
        Me.PInstrucciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'POpciones
        '
        Me.POpciones.Controls.Add(Me.PInstrucciones)
        Me.POpciones.Controls.Add(Me.DTPFechaRemision)
        Me.POpciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.POpciones.Location = New System.Drawing.Point(0, 0)
        Me.POpciones.Name = "POpciones"
        Me.POpciones.Size = New System.Drawing.Size(477, 269)
        Me.POpciones.TabIndex = 5
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
        Me.PCargaArchivo.TabIndex = 4
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
        'PInstrucciones
        '
        Me.PInstrucciones.Controls.Add(Me.Label4)
        Me.PInstrucciones.Controls.Add(Me.Label3)
        Me.PInstrucciones.Controls.Add(Me.Label2)
        Me.PInstrucciones.Controls.Add(Me.Label1)
        Me.PInstrucciones.Controls.Add(Me.LInstrucciones)
        Me.PInstrucciones.Location = New System.Drawing.Point(22, 68)
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
        Me.Label4.Text = "- Elegir el nombre del archivo."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "- Elegir la ruta donde se guardara el archivo."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "- Clic en el boton ""general excel""."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "- Seleccione una fecha valida"
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
        Me.PCargaArchivo.ResumeLayout(False)
        Me.PInstrucciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents POpciones As Panel
    Friend WithEvents PCargaArchivo As Panel
    Friend WithEvents BtnGenerarExcel As Button
    Friend WithEvents DTPFechaRemision As UIDC.UI_CustomDateTimePicker
    Friend WithEvents PInstrucciones As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LInstrucciones As Label
End Class
