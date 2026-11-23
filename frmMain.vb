Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
    System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath,
                     "..\..\..\..\flyme2themoon (4).db"))

        Dim connectionString As String =
    "Data Source=" & databasePath & ";Version=3;"
    End Sub

    Private Sub btnAddPassengerForm_Click(sender As Object, e As EventArgs) Handles btnAddPassengerForm.Click
        Dim frmAdd As New frmAddPassenger
        frmAdd.ShowDialog()
    End Sub

    Private Sub btnShowPassengerForm_Click(sender As Object, e As EventArgs) Handles btnShowPassengerForm.Click
        Dim frmShow As New frmShowPassenger
        frmShow.ShowDialog()
    End Sub

    Private Sub btnUpdatePassengerForm_Click(sender As Object, e As EventArgs) Handles btnUpdatePassengerForm.Click
        Dim frmUpdate As New frmUpdatePassenger
        frmUpdate.ShowDialog()
    End Sub
End Class


