Imports System.Configuration
Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO

Public Class ClassExportarExcel
    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
    Dim Fila As Integer

    Dim RutaAccess As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
    Dim ConexionDB As OleDbConnection = New OleDbConnection(RutaAccess)


    Public Function GenerarExcel(DTGSeriesDB As DataGridView, DtgExportarRemisiones As DataGridView, SaveFileExcel As SaveFileDialog, LTablaRemisiones As Label, CmbYear As ComboBox, CmbMes As ComboBox)
        If SaveFileExcel.ShowDialog = System.Windows.Forms.DialogResult.OK And LTablaRemisiones.Text <> String.Empty And CmbYear.Text <> String.Empty And CmbMes.Text <> String.Empty Then
            SaveFileExcel.Filter = "Archivos Excel(*.xlsx)|*xlsx"
            Dim RutaExcel = SaveFileExcel.FileName
            Try
                ConexionDB.Open()
                Dim Consulta = "SELECT Serie FROM " & LTablaRemisiones.Text &
                                " WHERE FORMAT(FechaArchivo, 'yyyy') = " & CmbYear.Text &
                                " AND FORMAT(FechaArchivo, 'M') = " & DateTime.ParseExact(CmbMes.Text, "MMMM", CultureInfo.CurrentCulture).Month &
                                " GROUP BY Serie;"
                Dim DataAdapter As New OleDbDataAdapter(Consulta, ConexionDB)
                Dim DT As New DataTable
                DataAdapter.Fill(DT)
                DTGSeriesDB.DataSource = Nothing
                DTGSeriesDB.Columns.Clear()
                DTGSeriesDB.DataSource = DT
            Catch ex As Exception
                MsgBox("Error al crear el archivo Excel." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CEE9GE26")
            End Try


            Try
                exLibro = exApp.Workbooks.Add()
                If LTablaRemisiones.Text = "LFA_REMS" Then
                    For FilaDB As Integer = 0 To DTGSeriesDB.Rows.Count - 1
                        Fila = FilaDB
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "APR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "APIZACO")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "CPR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "CHACHAPA")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "CLR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "CHOLULA")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "CVR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "CHULAVISTA")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "CRR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "CORDOBA")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "GRR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "GRAJALES")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "HPR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "HUAJUAPAN")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "HNR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "HUAHUCHINANGO")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "IZR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "IZUCAR")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "LPR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "LA PAZ")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "LRR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "LOS REMEDIOS")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "MYR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "MAYORAZGO")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "OAR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "OAXACA")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "SMR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "SAN MARTIN")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "STR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "SANTIAGO")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "TCR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "TECAMACHALCO")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "THR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "TEHUACAN I")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "THIIR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "TEHUACAN II")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "TPR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "TEPEACA")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "TZR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "TEZIUTLAN I")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "TZIIR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "TEZIUTLAN II")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "TXR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "TUXPAN")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "ZCR" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "ZACAPOAXTLA")
                        End If
                    Next
                ElseIf LTablaRemisiones.Text = "GLU_REMS" Then
                    For FilaDB As Integer = 0 To DTGSeriesDB.Rows.Count - 1
                        Fila = FilaDB
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "RCE" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "CENTRO")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "RCH" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "CHACHAPA")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "ROX" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "OAXACA")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "RPA" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "PATRIMONIO")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "RTH" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "TEHUACAN")
                        End If
                        If DTGSeriesDB.Rows(FilaDB).Cells(0).Value = "RVE" Then
                            ProcesarExcel(DTGSeriesDB, DtgExportarRemisiones, LTablaRemisiones, CmbYear, CmbMes, "VERACRUZ")
                        End If
                    Next
                End If
                MsgBox("Su archivo: " & Path.GetFileNameWithoutExtension(RutaExcel) & Chr(10) & "Fue generado correctamente.")
            Catch ex As Exception
                MsgBox("Error al crear el archivo Excel." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CEE9GE50")
            End Try
            ConexionDB.Close()
            exLibro.SaveAs(RutaExcel)
        End If
        exApp.Quit()
        exHoja = Nothing
        exLibro = Nothing
    End Function




    Public Function ProcesarExcel(DTGSeriesDB As DataGridView, DtgExportarRemisiones As DataGridView, LTablaRemisiones As Label, CmbYear As ComboBox, CmbMes As ComboBox, NomRemisiones As String)
        Try
            Dim Consulta = "SELECT Codigo, Producto, SUM(Unidad) AS Unidades, SUM(CostoTotal) AS Costo_Total FROM " & LTablaRemisiones.Text &
                        " WHERE Serie = '" & DTGSeriesDB.Rows(Fila).Cells(0).Value & "'" &
                        " AND FORMAT(FechaArchivo, 'yyyy') = " & CmbYear.Text &
                        " AND FORMAT(FechaArchivo, 'M') = " & DateTime.ParseExact(CmbMes.Text, "MMMM", CultureInfo.CurrentCulture).Month &
                        " GROUP BY Codigo, Producto"
            Dim DataAdapter As New OleDbDataAdapter(Consulta, ConexionDB)
            Dim DT As New DataTable
            DataAdapter.Fill(DT)
            DtgExportarRemisiones.DataSource = Nothing
            DtgExportarRemisiones.Columns.Clear()
            DtgExportarRemisiones.DataSource = DT
            DtgExportarRemisiones.Columns("Costo_Total").DefaultCellStyle.Format = "C2"

            exHoja = exLibro.Worksheets.Add()
            exHoja.Name = NomRemisiones

            Dim NCol As Integer = DtgExportarRemisiones.ColumnCount
            Dim NRow As Integer = DtgExportarRemisiones.RowCount


            For i As Integer = 1 To NCol
                exHoja.Cells.Item(4, i) = DtgExportarRemisiones.Columns(i - 1).Name.ToString()
            Next
            For FilaWin As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(FilaWin + 5, Col + 1) = DtgExportarRemisiones.Rows(FilaWin).Cells(Col).Value()
                    'exHoja.Columns.NumberFormat =
                Next
            Next


            With exHoja.Range("A1:D2")
                .Merge()
                .Value = "REMISIONES " & NomRemisiones & " - " & UCase(CmbMes.Text & " " & CmbYear.Text)
                .Font.Bold = True
                .Font.Size = 20
                .HorizontalAlignment = 3
            End With
            With exHoja.Range("A4:D4")
                .Font.Bold = True
                .AutoFilter(1,, VisibleDropDown:=True)
                .Interior.Color = Color.LightGray
                .HorizontalAlignment = 3
            End With
            exHoja.Range("B1").ColumnWidth = 50
            exHoja.Columns(4).NumberFormat = "$###,##0.00"
        Catch ex As Exception
            MsgBox("Error al crear el archivo Excel." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error | Corporativo LUIN | #CEE9GE82")
        End Try
    End Function
End Class
