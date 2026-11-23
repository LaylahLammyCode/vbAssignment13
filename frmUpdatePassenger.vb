Imports System.IO
Imports System.Data.SQLite
Public Class frmUpdatePassenger
    Private Sub frmUpdatePassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
    Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\..\flyme2themoon (4).db"))

        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strStateQuery As String = "SELECT intStateID, strState FROM TStates"
            Using command As New SQLiteCommand(strStateQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                cboState.DataSource = dataTable
                cboState.DisplayMember = "strState"
                cboState.ValueMember = "intStateID"
            End Using
            Dim strPassengerQuery As String = "SELECT intPassengerID, strFirstName || ' ' || strLastName AS strFullName FROM TPassengers"
            Using command As New SQLiteCommand(strPassengerQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                cboPassengers.DataSource = dataTable
                cboPassengers.DisplayMember = "strFullName"
                cboPassengers.ValueMember = "intPassengerID"
            End Using
        End Using
    End Sub

    Private Sub cboPassengers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPassengers.SelectedIndexChanged
        If TypeOf cboPassengers.SelectedValue Is DataRowView OrElse cboPassengers.SelectedValue Is Nothing Then
            Exit Sub
        End If

        Dim databasePath As String =
    Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\..\flyme2themoon (4).db"))

        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strSelectQuery As String = $"SELECT intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail FROM TPassengers WHERE intPassengerID = {cboPassengers.SelectedValue}"
            Using command As New SQLiteCommand(strSelectQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    reader.Read()
                    txtFirstName.Text = reader.GetString(1)
                    txtLastName.Text = reader.GetString(2)
                    txtaddress.Text = reader.GetString(3)
                    txtCity.Text = reader.GetString(4)
                    cboState.SelectedValue = reader.GetInt32(5)
                    txtZip.Text = reader.GetString(6)
                    txtPhone.Text = reader.GetString(7)
                    txtEmail.Text = reader.GetString(8)
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtaddress.Text = "" Or txtCity.Text = "" Or txtZip.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Or cboState.SelectedValue Is Nothing Then
            MessageBox.Show("All fields are required. Please check your inputs.")
            Exit Sub
        End If
        Dim intPassengerID As Integer
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
        intPassengerID = cboPassengers.SelectedValue

        Dim databasePath As String =
    Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\..\flyme2themoon (4).db"))

        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strUpdateQuery As String = $"UPDATE TPassengers SET strFirstName = '{strFirstName}', strLastName = '{strLastName}', strAddress = '{strAddress}', strCity = '{strCity}', intStateID = {intStateID}, strZip = '{strZip}', strPhoneNumber = '{strPhone}', strEmail = '{strEmail}' WHERE intPassengerID = {intPassengerID}"
            Using command As New SQLiteCommand(strUpdateQuery, conn)
                command.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("This is my message. Update was successful.")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
