﻿Imports System.Configuration
Imports System.Data.OleDb

Public Class WinRemisiones
    'EL ARCHIVO DE REMISIONES BRUTO SE ENCUENTRA EN LA SIGUIENTE RUTA: \\192.168.16.16\Sistemas IT\22_GLU_DOCUMENTACION\23_REPORTES\22_REMISIONES\23_REMISIONES\23_GLU_REMS\Originales
#Region "VARIABLES | WINREMISIONES | VARIABLES GLOABLES"
    'VARIABLES PARA EL ACCESO A LA BASE DE DATOS
    Dim RutaArchivo, NombreArchivo As String
    Dim TablasAccess As String = String.Empty
    Dim TablaRemisiones As String

    'VARIABLES PARA EL ACCESO A EL ARCHIVO EXCEL
    Dim CadenaConexionExcel As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaArchivo + ";" & "Extended Properties='Excel 12.0 Xml;'"
    Dim RecorreFecha, InsertarContent, ProgresoProducto, Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo, Sucursal_ID As String
    Dim TotalFilasLFA, FilasLFA As Long
#End Region


#Region "LOAD REMISIONES | WINREMISIONES | CARGA INICIAL DEL FORMULARIO REMISIONES"
    Private Sub WinRemisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BWRemisiones.WorkerReportsProgress = True
        BWRemisiones.WorkerSupportsCancellation = True
    End Sub
#End Region


#Region "BTN EMPRESAS DB | WINREMISIONES | BOTONES QUE INDICAN A QUE TABLA SUBIR LA INFO EN DB"
    Private Sub BtnGLU_Click(sender As Object, e As EventArgs) Handles BtnGLU.Click
        BtnGLU.BackgroundColor = Color.Red
        BtnLFA.BackgroundColor = Color.FromArgb(138, 42, 43)
        TablasAccess = "GLU_REMS (Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo)"
        TablaRemisiones = "GLU_REMS"
    End Sub
    Private Sub BtnLFA_Click(sender As Object, e As EventArgs) Handles BtnLFA.Click
        BtnLFA.BackgroundColor = Color.Red
        BtnGLU.BackgroundColor = Color.FromArgb(138, 42, 43)
        TablasAccess = "LFA_REMS (Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo)"
        TablaRemisiones = "LFA_REMS"
    End Sub
#End Region


#Region "BTNCARGAR | WINREMISIONES | BOTON QUE ABRE UN FILEDIALOG Y EJECUTA UN PROCESO ASINCORNO"
    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        Try
            OFDRemisiones.Title = "Seleccione el archivo Excel a cargar."
            OFDRemisiones.Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx"
            If TablasAccess <> String.Empty Then
                If OFDRemisiones.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    RutaArchivo = OFDRemisiones.FileName
                    NombreArchivo = OFDRemisiones.SafeFileName

                    TimeProcess.Start()
                    BWRemisiones.RunWorkerAsync()
                End If
            Else
                TimeProcess.Stop()
                MsgBox("Error" & Chr(10) & "Selecciona una empresa para guardar las remisiones.", MsgBoxStyle.Exclamation, "Error | Corporativo LUIN | BWRemisiones")
            End If
        Catch ex As Exception
            TimeProcess.Stop()
            MsgBox("Error en la carga del archivo." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Coporativo LUIN | BtnCargar")
        End Try
    End Sub
#End Region
    Private Sub TimeProcess_Tick(sender As Object, e As EventArgs) Handles TimeProcess.Tick
        If BWRemisiones.IsBusy = True Then
            PBarDatos.Visible = True
            LDatos.Visible = True
            BtnCargar.Enabled = False
            BtnLFA.Enabled = False
            BtnGLU.Enabled = False
        Else
            PBarDatos.Visible = False
            LDatos.Visible = False
            BtnCargar.Enabled = True
            BtnLFA.Enabled = True
            BtnGLU.Enabled = True
        End If
    End Sub


#Region "BACKGROUND WORKER | WINREMISIONES | CONTROL QUE EJECUTA UN PROCESO ASINCRONO"
    Private Sub BWRemisiones_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWRemisiones.DoWork
        Dim CadenaConexionAccess As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
        Dim HojaExcel As Object
        Dim ExApp As Object
        Dim ExWB As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim RegistrosDB As String = String.Empty

        ExApp = New Microsoft.Office.Interop.Excel.Application()
        ExWB = ExApp.Workbooks.Open(RutaArchivo)
        HojaExcel = ExWB.Worksheets("Reporte de Compac")
        TotalFilasLFA = HojaExcel.UsedRange.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row
        Try
            Using ConexionDB As New System.Data.OleDb.OleDbConnection(CadenaConexionAccess)
                Dim Comando As OleDbCommand = ConexionDB.CreateCommand()
                Dim FechaExcelValidate As Date = HojaExcel.Cells(2, 11).value
                Dim Mes As String = FechaExcelValidate.Month
                Dim Ano As String = FechaExcelValidate.Year
                Dim ConsultaFecha As String = "SELECT Count(*) FROM " & TablaRemisiones &
                                        " WHERE FORMAT(FechaArchivo, 'M') = " & Mes &
                                        "AND FORMAT(FechaArchivo, 'yyyy') = " & Ano
                Dim ComandoConsultaFecha As OleDbCommand = New OleDbCommand(ConsultaFecha)
                ComandoConsultaFecha.Connection = ConexionDB
                ConexionDB.Open()
                Dim Reader As OleDbDataReader = ComandoConsultaFecha.ExecuteReader
                While Reader.Read
                    RegistrosDB = Reader.GetInt32(0)
                End While

                If RegistrosDB = 0 Then
                    For FilasLFA = 6 To TotalFilasLFA
                        RecorreFecha = HojaExcel.Cells(FilasLFA, 1).value
                        If IsDate(RecorreFecha) = True Then
                            BWRemisiones.ReportProgress(FilasLFA)
                            Serie = HojaExcel.Cells(FilasLFA, 3).value
                            Folio = HojaExcel.Cells(FilasLFA, 4).value
                            Codigo = HojaExcel.Cells(FilasLFA, 6).value
                            Producto = HojaExcel.Cells(FilasLFA, 7).value.ToString.Replace("'", "")
                            Unidad = HojaExcel.Cells(FilasLFA, 8).value.ToString.Replace("-", "")
                            CostoTotal = HojaExcel.Cells(FilasLFA, 10).value.ToString.Replace("-", "")
                            FechaRegistro = Date.Today()
                            FechaArchivo = HojaExcel.Cells(FilasLFA, 1).value

                            InsertarContent = String.Format("INSERT INTO {0} VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');", TablasAccess, Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo)
                            ProgresoProducto = "Registro: " & Serie & " " & Producto
                            Comando.CommandText = InsertarContent
                            Comando.ExecuteNonQuery()
                        End If
                    Next
                    MsgBox("¡Exito!" & Chr(10) & "Remisiones registradas con exito.", MsgBoxStyle.Information, "Exito | Corporativo LUIN | BWRemisiones")
                ElseIf RegistrosDB > 0 Then
                    If MsgBox("Ya existen remisiones con esa fecha: " & Mes & "/" & Ano & Chr(10) & "¿Desea volver a cargarlos?", vbYesNo Or vbQuestion, "Información | Corporativo LUIN | BWRemisiones") = vbYes Then
                        Dim ConsultaDelete As String = "DELETE * FROM LFA_REMS " &
                                                "WHERE FORMAT(FechaArchivo, 'M') = " & Mes &
                                                "AND FORMAT(FechaArchivo, 'yyyy') = " & Ano
                        Dim ComandoConsultaDelete As OleDbCommand = New OleDbCommand(ConsultaDelete)
                        ComandoConsultaDelete.Connection = ConexionDB
                        Dim ReaderDelete As OleDbDataReader = ComandoConsultaDelete.ExecuteReader

                        For FilasLFA = 6 To TotalFilasLFA
                            RecorreFecha = HojaExcel.Cells(FilasLFA, 1).value
                            If IsDate(RecorreFecha) = True Then
                                BWRemisiones.ReportProgress(FilasLFA)
                                Serie = HojaExcel.Cells(FilasLFA, 3).value
                                Folio = HojaExcel.Cells(FilasLFA, 4).value
                                Codigo = HojaExcel.Cells(FilasLFA, 6).value
                                Producto = HojaExcel.Cells(FilasLFA, 7).value.ToString.Replace("'", "")
                                Unidad = HojaExcel.Cells(FilasLFA, 8).value.ToString.Replace("-", "")
                                CostoTotal = HojaExcel.Cells(FilasLFA, 10).value.ToString.Replace("-", "")
                                FechaRegistro = Date.Today()
                                FechaArchivo = HojaExcel.Cells(FilasLFA, 1).value

                                InsertarContent = String.Format("INSERT INTO {0} VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');", TablasAccess, Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo)
                                ProgresoProducto = "Registro: " & Serie & " " & Producto
                                Comando.CommandText = InsertarContent
                                Comando.ExecuteNonQuery()
                            End If
                        Next
                        MsgBox("¡Exito!" & Chr(10) & "Remisiones registradas con exito.", MsgBoxStyle.Information, "Exito | Corporativo LUIN | BWRemisiones")
                    End If
                End If
                ConexionDB.Close()
            End Using
            ExWB.Close(True)
            ExApp.Quit()
        Catch ex As Exception
            MsgBox("Error al leer el archivo." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Coporativo LUIN | BWRemisiones")
            ExWB.Close(True)
            ExApp.Quit()
        End Try
    End Sub
    Private Sub BWRemisiones_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BWRemisiones.ProgressChanged
        Try
            PBarDatos.Maximum = TotalFilasLFA - 24
            PBarDatos.Value = e.ProgressPercentage
            LDatos.Text = ProgresoProducto
        Catch ex As Exception
            MsgBox("Error" & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Corporativo LUIN | BWRemisiones Progress")
        End Try
    End Sub
#End Region
End Class