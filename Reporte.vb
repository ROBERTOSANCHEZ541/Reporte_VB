Imports System.Data.SqlTypes
Imports System.Runtime.Remoting
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class Reporte
    Private Sub PbExcel_Click(sender As Object, e As EventArgs) Handles PbExcel.Click
        If (CbTipo.Text = "") Then
            MsgBox("Seleccione un tipo")
        Else
            Dim m_Excel As Microsoft.Office.Interop.Excel.Application
            Dim aPath As String = My.Application.Info.DirectoryPath
            Dim ruta As String = "F:\source\Reporte_Xlsx\Resources\instr_ext.xlsx"
            m_Excel = New Microsoft.Office.Interop.Excel.Application
            m_Excel.Visible = False
            Dim objLibroExcel As Microsoft.Office.Interop.Excel.Workbook
            Dim objHojaExcel As Microsoft.Office.Interop.Excel.Worksheet
            objLibroExcel = m_Excel.Workbooks.Open(ruta, ReadOnly:=True)
            Dim objSQLconect As New System.Data.OleDb.OleDbConnection("Provider=SQLOLEdb; data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Capacitacion; integrated security=SSPI; persist security info=false; trusted connection= yes;")
            Query = "select Id_Instructor,Nombre,Tipo from Instructor WHERE Tipo='" + CbTipo.Text + "' And Id_Instructor In(Select Id_Instructor from Ctr_Cursos  WHERE  EstatuCurso In('A'))"
            Dim objSQLAdapter As New OleDb.OleDbDataAdapter(Query, objSQLconect)
            Dim objSQLDataSet As New DataSet("ExcelTest")
            objSQLAdapter.Fill(objSQLDataSet, "ReporteInstructor")
            'creamos una hoja en excel
            objHojaExcel = objLibroExcel.Worksheets(1)
            objHojaExcel.Cells(, "i") = ""
            i = 9
            objHojaExcel.Cells(6, 10).Value = DtpFecha.Text
            Dim objrow As DataRow
            If objSQLDataSet IsNot Nothing AndAlso objSQLDataSet.Tables.Count > 0 AndAlso objSQLDataSet.Tables(0).Rows.Count > 0 Then
                For Each objrow In objSQLDataSet.Tables(0).Rows
                    'asigna los valores de los  registros  a la celda
                    objHojaExcel.Cells(i, "I") = objrow.Item("Id_Instructor")
                    objHojaExcel.Cells(i, "J") = objrow.Item("Nombre")
                    objHojaExcel.Cells(i, "K") = objrow.Item("Tipo")
                    'AVANZAMOS UNA FILA
                    i += 1
                Next
                MsgBox("Reporte realizado correctamente")
                m_Excel.Visible = True
                objHojaExcel.Visible = Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetVisible
            Else
                Me.Focus()
                MsgBox("No contiene datos")
                Exit Sub
            End If
        End If
    End Sub
End Class