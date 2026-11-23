Imports System.IO
Imports System.Data.SQLite
Public Class frmShowPassenger
    Private Sub frmShowPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
    Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\..\flyme2themoon (4).db"))

        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"

        lstPassengers.Items.Clear()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail FROM TPassengers"
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strLine As String = reader.GetInt32(0).ToString() & " - " & reader.GetString(1) & " " & reader.GetString(2) & " | " & reader.GetString(3) & ", " & reader.GetString(4) & " | " & reader.GetString(7) & " | " & reader.GetString(8)
                        lstPassengers.Items.Add(strLine)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class



