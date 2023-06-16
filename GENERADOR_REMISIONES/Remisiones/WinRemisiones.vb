Imports System.Configuration
Imports System.Data.OleDb

Public Class WinRemisiones
    'EL ARCHIVO DE REMISIONES BRUTO SE ENCUENTRA EN LA SIGUIENTE RUTA: \\192.168.16.16\Sistemas IT\22_GLU_DOCUMENTACION\23_REPORTES\22_REMISIONES\23_REMISIONES\23_GLU_REMS\Originales
    Dim NewRemision As New ClassRemisiones


#Region "LOAD REMISIONES | WINREMISIONES | CARGA INICIAL DEL FORMULARIO REMISIONES"
    Private Sub WinRemisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewRemision.LoadWindow(BWRemisiones)
    End Sub
#End Region


#Region "BTN EMPRESAS DB | WINREMISIONES | BOTONES QUE INDICAN A QUE TABLA SUBIR LA INFO EN DB"
    Private Sub BtnGLU_Click(sender As Object, e As EventArgs) Handles BtnGLU.Click
        NewRemision.BtnEmpresas(BtnGLU, BtnLFA, "BRT_GLU_REMS", "GLU_REMS")
    End Sub
    Private Sub BtnLFA_Click(sender As Object, e As EventArgs) Handles BtnLFA.Click
        NewRemision.BtnEmpresas(BtnLFA, BtnGLU, "BRT_LFA_REMS", "LFA_REMS")
    End Sub
#End Region


#Region "BTNCARGAR | WINREMISIONES | BOTON QUE ABRE UN FILEDIALOG Y EJECUTA UN PROCESO ASINCORNO"
    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        NewRemision.BtnCargarRemisiones(OFDRemisiones, TimeProcess, BWRemisiones)
    End Sub
    Private Sub TimeProcess_Tick(sender As Object, e As EventArgs) Handles TimeProcess.Tick
        NewRemision.TimeProcess(BWRemisiones, PBarDatos, LDatos, BtnCargar, BtnLFA, BtnGLU)
    End Sub
#End Region




#Region "BACKGROUND WORKER | WINREMISIONES | CONTROL QUE EJECUTA UN PROCESO ASINCRONO"
    Private Sub BWRemisiones_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWRemisiones.DoWork
        NewRemision.BWRems(BWRemisiones)
    End Sub
    Private Sub BWRemisiones_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BWRemisiones.ProgressChanged
        NewRemision.BWRemsProgress(PBarDatos, LDatos, e)
    End Sub
#End Region
End Class