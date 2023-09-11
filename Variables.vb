Module Variables
    Public Query As String
    Public i As String
    Public conexion As New SqlClient.SqlConnection("data source=DESKTOP-6ECTDJR\SQLEXPRESS; initial catalog=Capacitacion; integrated security=SSPI; persist security info = false; trusted_connection= yes ; ")
    'nos permite ejecutar los comandos que tiene almacenados de sql
    Public cmd As SqlClient.SqlCommand
    'perimte leer los datos 
    Public sqlread As SqlClient.SqlDataReader
End Module
