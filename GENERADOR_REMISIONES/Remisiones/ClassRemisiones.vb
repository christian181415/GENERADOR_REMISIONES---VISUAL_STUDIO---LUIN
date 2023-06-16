Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.OleDb

Public Class ClassRemisiones
#Region "VARIABLES | WINREMISIONES | VARIABLES GLOABLES"
    'VARIABLES PARA EL ACCESO A LA BASE DE DATOS
    Dim RutaArchivo, NombreArchivo As String
    Dim TablasAccessBRT, TablaRemisionesBRT As String
    Dim TablaAccess, TablaRemisiones As String

    'VARIABLES PARA EL ACCESO A EL ARCHIVO EXCEL
    Dim CadenaConexionExcel As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaArchivo + ";" & "Extended Properties='Excel 12.0 Xml;'"
    Dim RecorreFecha, InsertarContent, ProgresoProducto, Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo, Sucursal_ID As String
    Dim TotalFilasLFA, FilasLFA As Long
#End Region


#Region "WINREMISIONES LOAD | CLASSREMISIONES | CONFIGURACIONES PARA LA CARGA INCIAL DEL SISTEMA"
    Public Function LoadWindow(BWRemisiones As BackgroundWorker)
        Try
            BWRemisiones.WorkerReportsProgress = True
            BWRemisiones.WorkerSupportsCancellation = True
        Catch ex As Exception
            MsgBox("Error al cargar la ventana.", MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CR20WRL25")
        End Try
    End Function
#End Region


#Region "BTN EMPRESAS | CLASSREMISIONES | BOTONES QUE INDICAN A QUE TABLA SUBIR LA INFO EN DB"
    Public Function BtnEmpresas(BtnActive As Button, BtnDisable As Button, EmpresaBRT As String, Empresa As String)
        Try
            BtnActive.BackColor = Color.Red
            BtnDisable.BackColor = Color.FromArgb(138, 42, 43)
            TablasAccessBRT = EmpresaBRT & " (Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo)"
            TablaRemisionesBRT = EmpresaBRT
            TablaAccess = Empresa & " (Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo)"
            TablaRemisiones = Empresa
        Catch ex As Exception
            MsgBox("Error al cambiar el icono." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CR32BE39")
        End Try
    End Function
#End Region


#Region "BTNCARGAR | WINREMISIONES | BOTON QUE ABRE UN FILEDIALOG Y EJECUTA UN PROCESO ASINCORNO"
    Public Function BtnCargarRemisiones(OFDRemisiones As OpenFileDialog, TimeProcess As Timer, BWRemisiones As BackgroundWorker)
        Try
            OFDRemisiones.Title = "Seleccione el archivo Excel a cargar."
            OFDRemisiones.Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx"
            If TablasAccessBRT <> String.Empty Then
                If OFDRemisiones.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    RutaArchivo = OFDRemisiones.FileName
                    NombreArchivo = OFDRemisiones.SafeFileName

                    TimeProcess.Start()
                    BWRemisiones.RunWorkerAsync()
                End If
            Else
                TimeProcess.Stop()
                MsgBox("Selecciona una empresa para guardar las remisiones.", MsgBoxStyle.Exclamation, "Error | Corporativo LUIN | #CR46CR60")
            End If
        Catch ex As Exception
            TimeProcess.Stop()
            MsgBox("Error en la carga del archivo." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Coporativo LUIN | #CR45CR63")
        End Try
    End Function
    Public Function TimeProcess(BWRemisiones As BackgroundWorker, PBarDatos As ProgressBar, LDatos As Label, BtnCargar As Button, BtnLFA As Button, BtnGLU As Button)
        Try
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
        Catch ex As Exception
            MsgBox("Error en el tiempo de ejecución." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Coporativo LUIN | #CR67TP83")
        End Try
    End Function
#End Region


#Region "BACKGROUND WORKER | WINREMISIONES | CONTROL QUE EJECUTA UN PROCESO ASINCRONO"
    Public Function BWRems(BWRemisiones As BackgroundWorker)
        'TRY | ELIMINAR DATOS
        Try
            Dim CadenaConexionAccess As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
            Using ConexionDB As New System.Data.OleDb.OleDbConnection(CadenaConexionAccess)
                Dim ComandoElim_BRTLFA As OleDbCommand = ConexionDB.CreateCommand()
                Dim ComandoElim_BRTGLU As OleDbCommand = ConexionDB.CreateCommand()

                ConexionDB.Open()
                Dim EliminarLFA = "DELETE * FROM BRT_LFA_REMS"
                ComandoElim_BRTLFA.CommandText = EliminarLFA
                Dim DatosLFA As Integer = ComandoElim_BRTLFA.ExecuteNonQuery()

                Dim EliminarGLU = "DELETE * FROM BRT_GLU_REMS"
                ComandoElim_BRTGLU.CommandText = EliminarGLU
                Dim DatosGLU As Integer = ComandoElim_BRTGLU.ExecuteNonQuery()
                ConexionDB.Close()
            End Using
        Catch ex As Exception
            BWRemisiones.CancelAsync()
            MsgBox("Error al eliminar los registros anteriores." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Coporativo LUIN | #CR90BWR110")
        End Try

        'TRY | REGISTRAR DATOS
        Try
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

                                InsertarContent = String.Format("INSERT INTO {0} VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');", TablasAccessBRT, Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo)
                                ProgresoProducto = "Registro: " & Serie & " " & Producto
                                Comando.CommandText = InsertarContent
                                Comando.ExecuteNonQuery()
                            End If
                        Next
                    ElseIf RegistrosDB > 0 Then
                        If MsgBox("Ya existen remisiones con esa fecha: " & Mes & "/" & Ano & Chr(10) & "¿Desea volver a cargarlos?", vbYesNo Or vbQuestion, "Información | Corporativo LUIN") = vbYes Then
                            Dim ConsultaDelete As String = "DELETE * FROM " & TablaRemisiones &
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

                                    InsertarContent = String.Format("INSERT INTO {0} VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');", TablasAccessBRT, Serie, Folio, Codigo, Producto, Unidad, CostoTotal, FechaRegistro, FechaArchivo)
                                    ProgresoProducto = "Registro: " & Serie & " " & Producto
                                    Comando.CommandText = InsertarContent
                                    Comando.ExecuteNonQuery()
                                End If
                            Next
                        End If
                    End If
                    ConexionDB.Close()
                End Using
                ExWB.Close(True)
                ExApp.Quit()
            Catch ex As Exception
                BWRemisiones.CancelAsync()
                MsgBox("Error al leer el archivo." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Coporativo LUIN | #CR90BWR176")
                ExWB.Close(True)
                ExApp.Quit()
            End Try
        Catch ex As Exception
            BWRemisiones.CancelAsync()
            MsgBox("Error al iniciar el proceso." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Coporativo LUIN | #CR90BWR181")
        End Try


        'TRY | PROCESAR DATOS
        Try
            Dim CadenaConexionAccess As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
            Using ConexionDB As New System.Data.OleDb.OleDbConnection(CadenaConexionAccess)
                Dim ComandoSumarRems As OleDbCommand = ConexionDB.CreateCommand()

                ConexionDB.Open()
                Dim EliminarLFA = "INSERT INTO " & TablaAccess &
                                " SELECT Serie, Folio, Codigo, Producto, SUM(" & TablaRemisionesBRT & ".Unidad) AS Unidades, SUM(" & TablaRemisionesBRT & ".CostoTotal) AS Total, FechaRegistro, FechaArchivo" &
                                " FROM " & TablaRemisionesBRT & " GROUP BY Serie, Folio, Codigo, Producto, FechaRegistro, FechaArchivo;"
                ComandoSumarRems.CommandText = EliminarLFA
                Dim DatosLFA As Integer = ComandoSumarRems.ExecuteNonQuery()
                ConexionDB.Close()
            End Using
        Catch ex As Exception
            BWRemisiones.CancelAsync()
            MsgBox("Error al procesar la información." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Coporativo LUIN | #CR90BWR224")
        End Try
    End Function
    Public Function BWRemsProgress(PBarDatos As ProgressBar, LDatos As Label, e As System.ComponentModel.ProgressChangedEventArgs)
        Try
            PBarDatos.Maximum = TotalFilasLFA - 24
            PBarDatos.Value = e.ProgressPercentage
            LDatos.Text = ProgresoProducto
        Catch ex As Exception
            MsgBox("Error al aumentar el progreso." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CR184BWRP190")
        End Try
    End Function
#End Region
End Class
