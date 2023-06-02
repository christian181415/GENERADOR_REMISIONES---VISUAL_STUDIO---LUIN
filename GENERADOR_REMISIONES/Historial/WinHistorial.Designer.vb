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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnGLU = New UIDC.UI_CustomButton()
        Me.BtnLFA = New UIDC.UI_CustomButton()
        Me.DTGHistorial = New System.Windows.Forms.DataGridView()
        Me.PCargaArchivo = New System.Windows.Forms.Panel()
        Me.BtnMostrarRemisiones = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PHistorial.SuspendLayout()
        CType(Me.DTGHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCargaArchivo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PHistorial
        '
        Me.PHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PHistorial.Controls.Add(Me.TableLayoutPanel1)
        Me.PHistorial.Controls.Add(Me.BtnGLU)
        Me.PHistorial.Controls.Add(Me.DTGHistorial)
        Me.PHistorial.Controls.Add(Me.PCargaArchivo)
        Me.PHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PHistorial.ForeColor = System.Drawing.Color.White
        Me.PHistorial.Location = New System.Drawing.Point(0, 0)
        Me.PHistorial.Name = "PHistorial"
        Me.PHistorial.Size = New System.Drawing.Size(477, 307)
        Me.PHistorial.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.ComboBox2.Location = New System.Drawing.Point(3, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(232, 24)
        Me.ComboBox2.TabIndex = 25
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(241, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox1.TabIndex = 24
        '
        'BtnGLU
        '
        Me.BtnGLU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGLU.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnGLU.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnGLU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGLU.ButtonImage = CType(resources.GetObject("BtnGLU.ButtonImage"), System.Drawing.Image)
        Me.BtnGLU.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnGLU.ButtonText = "Remisiones GLU"
        Me.BtnGLU.ClickBackColor = System.Drawing.Color.Red
        Me.BtnGLU.ClickTextColor = System.Drawing.Color.White
        Me.BtnGLU.CornerRadius = 5
        Me.BtnGLU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGLU.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnGLU.HoverBackgroundColor = System.Drawing.Color.Red
        Me.BtnGLU.HoverTextColor = System.Drawing.Color.White
        Me.BtnGLU.ImagePosition = UIDC.UI_CustomButton.imgPosition.Right
        Me.BtnGLU.Location = New System.Drawing.Point(3, 141)
        Me.BtnGLU.MaximumSize = New System.Drawing.Size(500, 31)
        Me.BtnGLU.Name = "BtnGLU"
        Me.BtnGLU.Size = New System.Drawing.Size(251, 31)
        Me.BtnGLU.TabIndex = 23
        Me.BtnGLU.Text = "UI_CustomButton1"
        Me.BtnGLU.TextColor = System.Drawing.Color.White
        Me.BtnGLU.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'BtnLFA
        '
        Me.BtnLFA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnLFA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnLFA.ButtonImage = CType(resources.GetObject("BtnLFA.ButtonImage"), System.Drawing.Image)
        Me.BtnLFA.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.BtnLFA.ButtonText = "Remisiones LFA"
        Me.BtnLFA.ClickBackColor = System.Drawing.Color.Red
        Me.BtnLFA.ClickTextColor = System.Drawing.Color.White
        Me.BtnLFA.CornerRadius = 5
        Me.BtnLFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLFA.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.BtnLFA.HoverBackgroundColor = System.Drawing.Color.Red
        Me.BtnLFA.HoverTextColor = System.Drawing.Color.White
        Me.BtnLFA.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.BtnLFA.Location = New System.Drawing.Point(3, 33)
        Me.BtnLFA.MaximumSize = New System.Drawing.Size(500, 31)
        Me.BtnLFA.Name = "BtnLFA"
        Me.BtnLFA.Size = New System.Drawing.Size(232, 31)
        Me.BtnLFA.TabIndex = 22
        Me.BtnLFA.Text = "UI_CustomButton1"
        Me.BtnLFA.TextColor = System.Drawing.Color.White
        Me.BtnLFA.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'DTGHistorial
        '
        Me.DTGHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTGHistorial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DTGHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
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
        Me.DTGHistorial.Location = New System.Drawing.Point(0, 69)
        Me.DTGHistorial.Name = "DTGHistorial"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGHistorial.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DTGHistorial.Size = New System.Drawing.Size(477, 200)
        Me.DTGHistorial.TabIndex = 6
        '
        'PCargaArchivo
        '
        Me.PCargaArchivo.Controls.Add(Me.BtnMostrarRemisiones)
        Me.PCargaArchivo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PCargaArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCargaArchivo.ForeColor = System.Drawing.Color.White
        Me.PCargaArchivo.Location = New System.Drawing.Point(0, 269)
        Me.PCargaArchivo.Name = "PCargaArchivo"
        Me.PCargaArchivo.Size = New System.Drawing.Size(477, 38)
        Me.PCargaArchivo.TabIndex = 5
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnLFA, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.67816!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.32184!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(477, 69)
        Me.TableLayoutPanel1.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        CType(Me.DTGHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCargaArchivo.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PHistorial As Panel
    Friend WithEvents PCargaArchivo As Panel
    Friend WithEvents BtnMostrarRemisiones As Button
    Friend WithEvents DTGHistorial As DataGridView
    Friend WithEvents BtnGLU As UIDC.UI_CustomButton
    Friend WithEvents BtnLFA As UIDC.UI_CustomButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
End Class
