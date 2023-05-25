<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinRemisiones
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
        Me.PCargaArchivo = New System.Windows.Forms.Panel()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.BtnMostrarRemisiones = New System.Windows.Forms.Button()
        Me.PRemisiones = New System.Windows.Forms.Panel()
        Me.PInstrucciones = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LInstrucciones = New System.Windows.Forms.Label()
        Me.BWRemisiones = New System.ComponentModel.BackgroundWorker()
        Me.OFDRemisiones = New System.Windows.Forms.OpenFileDialog()
        Me.PCargaArchivo.SuspendLayout()
        Me.PRemisiones.SuspendLayout()
        Me.PInstrucciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PCargaArchivo
        '
        Me.PCargaArchivo.Controls.Add(Me.BtnCargar)
        Me.PCargaArchivo.Controls.Add(Me.BtnMostrarRemisiones)
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
        Me.BtnCargar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCargar.FlatAppearance.BorderSize = 0
        Me.BtnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargar.ForeColor = System.Drawing.Color.White
        Me.BtnCargar.Location = New System.Drawing.Point(0, 0)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(192, 38)
        Me.BtnCargar.TabIndex = 1
        Me.BtnCargar.Text = "CARGAR ARCHIVO"
        Me.BtnCargar.UseVisualStyleBackColor = False
        '
        'BtnMostrarRemisiones
        '
        Me.BtnMostrarRemisiones.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnMostrarRemisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMostrarRemisiones.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMostrarRemisiones.FlatAppearance.BorderSize = 0
        Me.BtnMostrarRemisiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnMostrarRemisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrarRemisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrarRemisiones.ForeColor = System.Drawing.Color.White
        Me.BtnMostrarRemisiones.Location = New System.Drawing.Point(254, 0)
        Me.BtnMostrarRemisiones.Name = "BtnMostrarRemisiones"
        Me.BtnMostrarRemisiones.Size = New System.Drawing.Size(223, 38)
        Me.BtnMostrarRemisiones.TabIndex = 3
        Me.BtnMostrarRemisiones.Text = "MOSTRAR REMISIONES"
        Me.BtnMostrarRemisiones.UseVisualStyleBackColor = False
        '
        'PRemisiones
        '
        Me.PRemisiones.Controls.Add(Me.PInstrucciones)
        Me.PRemisiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PRemisiones.Location = New System.Drawing.Point(0, 0)
        Me.PRemisiones.Name = "PRemisiones"
        Me.PRemisiones.Size = New System.Drawing.Size(477, 269)
        Me.PRemisiones.TabIndex = 3
        '
        'PInstrucciones
        '
        Me.PInstrucciones.Controls.Add(Me.Label4)
        Me.PInstrucciones.Controls.Add(Me.Label3)
        Me.PInstrucciones.Controls.Add(Me.Label2)
        Me.PInstrucciones.Controls.Add(Me.Label1)
        Me.PInstrucciones.Controls.Add(Me.LInstrucciones)
        Me.PInstrucciones.Location = New System.Drawing.Point(17, 48)
        Me.PInstrucciones.Name = "PInstrucciones"
        Me.PInstrucciones.Size = New System.Drawing.Size(437, 166)
        Me.PInstrucciones.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(410, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "- Cargue el archivo"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "- Cargue el archivo"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "- Cargue el archivo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "- Cargue el archivo"
        '
        'LInstrucciones
        '
        Me.LInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LInstrucciones.Location = New System.Drawing.Point(13, 10)
        Me.LInstrucciones.Name = "LInstrucciones"
        Me.LInstrucciones.Size = New System.Drawing.Size(410, 38)
        Me.LInstrucciones.TabIndex = 13
        Me.LInstrucciones.Text = "Para un uso optimo del sistema generador de remisiones siga las siguientes instru" &
    "cciones."
        '
        'OFDRemisiones
        '
        Me.OFDRemisiones.FileName = "OpenFileDialog1"
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
        Me.Text = "WinRemisiones"
        Me.PCargaArchivo.ResumeLayout(False)
        Me.PRemisiones.ResumeLayout(False)
        Me.PInstrucciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PCargaArchivo As Panel
    Friend WithEvents PRemisiones As Panel
    Friend WithEvents BtnMostrarRemisiones As Button
    Friend WithEvents BtnCargar As Button
    Friend WithEvents PInstrucciones As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LInstrucciones As Label
    Friend WithEvents BWRemisiones As System.ComponentModel.BackgroundWorker
    Friend WithEvents OFDRemisiones As OpenFileDialog
End Class
