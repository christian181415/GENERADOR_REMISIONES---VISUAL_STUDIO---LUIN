Public Class ClassConfig
#Region "VARIABLES | CLASSCONFIG | VARIABLES GLOBALES DEL SISTEMA"
    Dim valor As Boolean = False
    Dim moux As Integer
    Dim mouy As Integer
#End Region


#Region "CONFIGLOAD | CLASSCONFIG | CONFIGURACIONES PARA LA CARGA INCIAL DEL SISTEMA"
    Public Function LoadWindow(Win01 As Form, Btn01 As Button, PInfo As Panel, Form As Form, Win02 As Form, Win03 As Form, Btn02 As Button, Btn03 As Button, LNombrePanel As Label, Panel As String)
        Try
            Win01.MdiParent = Form
            Win01.Dock = DockStyle.Fill
            Win01.Show()
            Win02.Hide()
            Win03.Hide()

            Btn01.BackColor = Color.Red
            Btn02.BackColor = Color.FromArgb(20, 20, 20)
            Btn03.BackColor = Color.FromArgb(20, 20, 20)

            LNombrePanel.Text = Panel
            PInfo.Controls.Add(Win01)
        Catch ex As Exception
            MsgBox("Error al cargar la ventana.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CC10LW25")
        End Try
    End Function
#End Region


#Region "BOTONES | CLASSCONFIG | FUNCIONES PARA LOS BOTONES DE LA BARRA TOP"
    Public Function ExitApp()
        Try
            If MsgBox("Desea cerrar la aplicación?", vbYesNo Or vbQuestion, "Exit | Corporativo LUIN") = vbYes Then
                End
            End If
        Catch ex As Exception
            MsgBox("Error al cerrar el programa.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CC32EA38")
        End Try
    End Function
    Public Function MinimizeApp(Form As Form)
        Try
            Form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox("Error al minimizar el programa.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CC41MIA45")
        End Try
    End Function
    Public Function MaximizeApp(Form As Form)
        Try
            If Form.WindowState = FormWindowState.Normal Then
                Form.WindowState = FormWindowState.Maximized
            ElseIf Form.WindowState = FormWindowState.Maximized Then
                Form.WindowState = FormWindowState.Normal
            End If
            WinRemisiones.Dock = DockStyle.Fill
        Catch ex As Exception
            MsgBox("Error al maximizar el programa.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CC48MAA57")
        End Try
    End Function
    Public Function ColorBTN(Imagen As String, PBox As PictureBox)
        Try
            Dim ImgColor As System.Drawing.Bitmap = Bitmap.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() + "\Assets\IMG\" & Imagen)
            PBox.BackgroundImage = ImgColor
        Catch ex As Exception
            MsgBox("Error al cambiar imagen.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CC60CBT65")
        End Try
    End Function
#End Region


#Region "PANEL | CLASSCONFIG | FUNCIONES PARA MOVER EL FORMULARIO Y SER RESPONSIVO"
    Public Function ResponsiveTaskBar(PTaskBar As Panel)
        Try
            If PTaskBar.Size.Width = 152 Then
                PTaskBar.Size = New Size(55, 0)
            ElseIf PTaskBar.Size.Width = 55 Then
                PTaskBar.Size = New Size(152, 0)
            End If
            WinRemisiones.Dock = DockStyle.Fill
        Catch ex As Exception
            MsgBox("Error al redimencionar.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CC72RTB81")
        End Try
    End Function
    Public Function MouseDown(Form As Form)
        Try
            valor = True
            moux = Cursor.Position.X - Form.Left
            mouy = Cursor.Position.Y - Form.Top
        Catch ex As Exception
            MsgBox("Error al mover la ventana.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CC84MD90")
        End Try
    End Function
    Public Function MouseMove(Form As Form)
        Try
            If valor = True Then
                Form.Top = Cursor.Position.Y - mouy
                Form.Left = Cursor.Position.X - moux
            End If
        Catch ex As Exception
            MsgBox("Error al mover la ventana.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CC93MM100")
        End Try
    End Function
    Public Function MouseUp()
        Try
            valor = False
        Catch ex As Exception
            MsgBox("Error al mover la ventana.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CC103MU107")
        End Try
    End Function
#End Region
End Class
