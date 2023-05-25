Public Class ClassConfig
#Region "VARIABLES | CLASSCONFIG | VARIABLES GLOBALES DEL SISTEMA"
    Dim valor As Boolean = False
    Dim moux As Integer
    Dim mouy As Integer
#End Region


#Region "CONFIGLOAD | CLASSCONFIG | CONFIGURACIONES PARA LA CARGA INCIAL DEL SISTEMA"
    Public Function LoadWindow(Win01 As Form, PInfo As Panel, Form As Form, Win02 As Form, Win03 As Form)
        'Win01.Size = New Size(477, 307)
        Win01.MdiParent = Form
        Win01.Show()
        Win01.Dock = DockStyle.Fill
        Win02.Hide()
        Win03.Hide()
        PInfo.Controls.Add(Win01)
    End Function
#End Region


#Region "BOTONES | CLASSCONFIG | FUNCIONES PARA LOS BOTONES DE LA BARRA TOP"
    Public Function ExitApp()
        If MsgBox("Deseas cerrar la aplicaión?", vbYesNo Or vbQuestion, "Exit | Corporativo LUIN") = vbYes Then
            End
        End If
    End Function
    Public Function MinimizeApp(Form As Form)
        Form.WindowState = FormWindowState.Minimized
    End Function
    Public Function MaximizeApp(Form As Form)
        If Form.WindowState = FormWindowState.Normal Then
            Form.WindowState = FormWindowState.Maximized
        ElseIf Form.WindowState = FormWindowState.Maximized Then
            Form.WindowState = FormWindowState.Normal
        End If
        WinRemisiones.Dock = DockStyle.Fill
    End Function
    Public Function ColorBTN(Imagen As String, PBox As PictureBox)
        Dim ImgColor As System.Drawing.Bitmap = Bitmap.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() + "\Assets\IMG\" & Imagen)
        PBox.BackgroundImage = ImgColor
    End Function
#End Region


#Region "PANEL | CLASSCONFIG | FUNCIONES PARA MOVER EL FORMULARIO Y SER RESPONSIVO"
    Public Function ResponsiveTaskBar(PTaskBar As Panel)
        If PTaskBar.Size.Width = 152 Then
            PTaskBar.Size = New Size(55, 0)
        ElseIf PTaskBar.Size.Width = 55 Then
            PTaskBar.Size = New Size(152, 0)
        End If
        WinRemisiones.Dock = DockStyle.Fill
    End Function
    Public Function MouseDown(Form As Form)
        valor = True
        moux = Cursor.Position.X - Form.Left
        mouy = Cursor.Position.Y - Form.Top
    End Function
    Public Function MouseMove(Form As Form)
        If valor = True Then
            Form.Top = Cursor.Position.Y - mouy
            Form.Left = Cursor.Position.X - moux
        End If
    End Function
    Public Function MouseUp()
        valor = False
    End Function
#End Region
End Class
