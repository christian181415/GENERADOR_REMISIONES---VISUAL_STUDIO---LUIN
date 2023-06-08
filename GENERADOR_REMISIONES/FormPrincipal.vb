Public Class FormPrincipal
#Region "VARIABLES | CODIGO | VARIABLES GLOBALES DEL SISTEMA"
    Dim NewConfig As New ClassConfig
#End Region
#Region "LOAD | FORM | CONFIGURACION DE LA CARGA INICIAL DEL SISTEMA"
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewConfig.LoadWindow(WinRemisiones, BtnRemisiones, PInfo, Me, WinHistorial, WinOpciones, BtnHistorial, BtnOpciones, LNombrePanel, "Remisiones")
    End Sub
#End Region


#Region "BOTONES | PMENU | ACCIONES DE LOS BOTONES"
    Private Sub PBoxExit_Click(sender As Object, e As EventArgs) Handles PBoxExit.Click
        NewConfig.ExitApp()
    End Sub
    Private Sub PBoxMinimize_Click(sender As Object, e As EventArgs) Handles PBoxMinimize.Click
        NewConfig.MinimizeApp(Me)
    End Sub
    Private Sub PBoxMaximize_Click(sender As Object, e As EventArgs) Handles PBoxMaximize.Click
        NewConfig.MaximizeApp(Me)
    End Sub
    Private Sub PBoxLogo_Click(sender As Object, e As EventArgs) Handles PBoxLogo.Click
        NewConfig.ResponsiveTaskBar(PTaskBar)
    End Sub
#End Region


#Region "PANEL | PNAVEGACION | MOVER LA VENTANA"
    Private Sub PMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PMenu.MouseDown
        NewConfig.MouseDown(Me)
    End Sub
    Private Sub PMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PMenu.MouseMove
        NewConfig.MouseMove(Me)
    End Sub
    Private Sub PMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PMenu.MouseUp
        NewConfig.MouseUp()
    End Sub
#End Region


#Region "PANEL | PBOTONES | CAMBIAR DE COLOR LA IMAGEN"
    Private Sub PBoxExit_MouseHover(sender As Object, e As EventArgs) Handles PBoxExit.MouseHover
        NewConfig.ColorBTN("BtnExit-Active.png", PBoxExit)
    End Sub
    Private Sub PBoxExit_MouseLeave(sender As Object, e As EventArgs) Handles PBoxExit.MouseLeave
        NewConfig.ColorBTN("BtnExit-Disable.png", PBoxExit)
    End Sub
    Private Sub PBoxMaximize_MouseHover(sender As Object, e As EventArgs) Handles PBoxMaximize.MouseHover
        NewConfig.ColorBTN("BtnMaximize-Active.png", PBoxMaximize)
    End Sub
    Private Sub PBoxMaximize_MouseLeave(sender As Object, e As EventArgs) Handles PBoxMaximize.MouseLeave
        NewConfig.ColorBTN("BtnMaximize-Disable.png", PBoxMaximize)
    End Sub
    Private Sub PBoxMinimize_MouseHover(sender As Object, e As EventArgs) Handles PBoxMinimize.MouseHover
        NewConfig.ColorBTN("BtnHide-Active.png", PBoxMinimize)
    End Sub
    Private Sub PBoxMinimize_MouseLeave(sender As Object, e As EventArgs) Handles PBoxMinimize.MouseLeave
        NewConfig.ColorBTN("BtnHide-Disable.png", PBoxMinimize)
    End Sub
#End Region


#Region "BOTONES | PNAVEGACION | ACCIONES PARA MOSTRAR LAS VENTANAS DEL PNAVEGACION"
    Private Sub BtnRemisiones_Click(sender As Object, e As EventArgs) Handles BtnRemisiones.Click
        NewConfig.LoadWindow(WinRemisiones, BtnRemisiones, PInfo, Me, WinHistorial, WinOpciones, BtnHistorial, BtnOpciones, LNombrePanel, "Remisiones")
    End Sub
    Private Sub BtnHistorial_Click(sender As Object, e As EventArgs) Handles BtnHistorial.Click
        NewConfig.LoadWindow(WinHistorial, BtnHistorial, PInfo, Me, WinRemisiones, WinOpciones, BtnRemisiones, BtnOpciones, LNombrePanel, "Historial")
    End Sub
    Private Sub BtnOpciones_Click(sender As Object, e As EventArgs) Handles BtnOpciones.Click
        NewConfig.LoadWindow(WinOpciones, BtnOpciones, PInfo, Me, WinRemisiones, WinHistorial, BtnRemisiones, BtnHistorial, LNombrePanel, "Opciones")
    End Sub
#End Region
End Class
