Imports System.Configuration
Imports System.Data.OleDb
Imports System.Globalization

Public Class WinHistorial
#Region "VARIABLES GLOBALES | WINHISTORIAL | VARIABLES DE ACCESO A LOS METODOS DE LA CLASE HISTORIAL"
    Dim NewHistorial As New ClassHistorial
#End Region


#Region "WINHISTORIAL LOAD | WINHISTORIAL | CONFIGURACION DE CARGA INICIAL DEL FORMULARIO"
    Private Sub WinHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewHistorial.ConfigLoad(CmbYear, CmbMes, BtnLFA)
        'NewHistorial.CargaMeses(CmbMes, CmbYear)
    End Sub
#End Region


#Region "BTN EMPRESAS | WINHISTORIAL | ACCIONES PARA LOS BOTONES DE LAS EMPRESAS GLU Y LFA"
    Private Sub BtnLFA_Click(sender As Object, e As EventArgs) Handles BtnLFA.Click
        NewHistorial.BtnEmpresas(BtnLFA, BtnGLU, "LFA_REMS")
    End Sub
    Private Sub BtnGLU_Click(sender As Object, e As EventArgs) Handles BtnGLU.Click
        NewHistorial.BtnEmpresas(BtnGLU, BtnLFA, "GLU_REMS")
    End Sub
#End Region



#Region "CMB MES | WINHISTORIAL | COMBO BOX QUE CARGA LOS MESES REGISTRADOS EN DB"
    Private Sub CmbMes_MouseClick(sender As Object, e As MouseEventArgs) Handles CmbMes.MouseClick
        NewHistorial.CargaMeses(CmbMes, CmbYear)
    End Sub
#End Region


#Region "BTN MOSTRAR REMISIONES | WINHISTORIAL | ACCIONES PARA MOSTRAR LAS REMISIONES DE TAL AÑO - MES"
    Private Sub BtnMostrarRemisiones_Click(sender As Object, e As EventArgs) Handles BtnMostrarRemisiones.Click
        NewHistorial.MostrarRemisiones(CmbMes, CmbYear, DTGHistorial)
    End Sub
#End Region
End Class