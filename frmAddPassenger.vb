'autospacinf feels weird but looks professional keep it
Imports System.Data.SQLite

Public Class frmAddPassenger

    Private Sub frmAddPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
    System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath,
                     "..\..\..\..\flyme2themoon (4).db"))

        Dim connectionString As String =
    "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT intStateID, strState FROM TStates"
            Using command As New SQLiteCommand(strQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cboState.DataSource = dataTable
                cboState.DisplayMember = "strState"
                cboState.ValueMember = "intStateID"
            End Using
        End Using
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtaddress.Text = "" Or txtCity.Text = "" Or txtZip.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Or cboState.SelectedValue Is Nothing Then
            MessageBox.Show(" check inputs.")
            Exit Sub
        End If

        Dim intNextPrimaryKey As Integer
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim intStateID As String
        Dim strZip As String
        Dim strPhone As String
        Dim strEmail As String

        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strAddress = txtaddress.Text
        strCity = txtCity.Text
        intStateID = cboState.SelectedValue.ToString()
        strZip = txtZip.Text
        strPhone = txtPhone.Text
        strEmail = txtEmail.Text

        Dim databasePath As String =
    System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath,
                     "..\..\..\..\flyme2themoon (4).db"))

        Dim connectionString As String =
    "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()

            Dim strKeyQuery As String = "SELECT IFNULL(MAX(intPassengerID), 0) + 1 FROM TPassengers"
            Using command As New SQLiteCommand(strKeyQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    reader.Read()
                    intNextPrimaryKey = reader.GetInt32(0)
                End Using
            End Using

            Dim strInsertQuery As String =
            $"INSERT INTO TPassengers VALUES 
             ({intNextPrimaryKey}, '{strFirstName}', '{strLastName}', '{strAddress}', '{strCity}', {intStateID}, '{strZip}', '{strPhone}', '{strEmail}')"

            Using command As New SQLiteCommand(strInsertQuery, conn)
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Add was successful.")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
