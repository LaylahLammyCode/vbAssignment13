<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPassenger
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtFirstName = New TextBox()
        txtZip = New TextBox()
        txtCity = New TextBox()
        txtaddress = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtLastName = New TextBox()
        cboState = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnSubmit = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(199, 37)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(192, 27)
        txtFirstName.TabIndex = 0
        ' 
        ' txtZip
        ' 
        txtZip.Location = New Point(199, 269)
        txtZip.Name = "txtZip"
        txtZip.Size = New Size(192, 27)
        txtZip.TabIndex = 1
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(199, 202)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(192, 27)
        txtCity.TabIndex = 2
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(199, 169)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(192, 27)
        txtaddress.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(199, 136)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(192, 27)
        txtEmail.TabIndex = 4
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(199, 103)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(192, 27)
        txtPhone.TabIndex = 5
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(199, 70)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(192, 27)
        txtLastName.TabIndex = 6
        ' 
        ' cboState
        ' 
        cboState.FormattingEnabled = True
        cboState.Location = New Point(199, 235)
        cboState.Name = "cboState"
        cboState.Size = New Size(192, 28)
        cboState.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 8
        Label1.Text = "First Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(63, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 9
        Label2.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(63, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 10
        Label3.Text = "Phone:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(63, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 20)
        Label4.TabIndex = 11
        Label4.Text = "E-Mail:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(63, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 12
        Label5.Text = "Address:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(63, 209)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 20)
        Label6.TabIndex = 13
        Label6.Text = "City:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(63, 243)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 14
        Label7.Text = "State:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(63, 276)
        Label8.Name = "Label8"
        Label8.Size = New Size(34, 20)
        Label8.TabIndex = 15
        Label8.Text = "Zip:"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(248, 330)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 16
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(694, 409)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 17
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmAddPassenger
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnSubmit)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cboState)
        Controls.Add(txtLastName)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtaddress)
        Controls.Add(txtCity)
        Controls.Add(txtZip)
        Controls.Add(txtFirstName)
        Name = "frmAddPassenger"
        Text = "frmAddPassenger"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cboState As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
End Class
