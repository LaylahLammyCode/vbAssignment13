<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePassenger
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
        btnExit = New Button()
        btnSubmit = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cboState = New ComboBox()
        txtLastName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtaddress = New TextBox()
        txtCity = New TextBox()
        txtZip = New TextBox()
        txtFirstName = New TextBox()
        cboPassengers = New ComboBox()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(656, 409)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 35
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(212, 343)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 34
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(27, 289)
        Label8.Name = "Label8"
        Label8.Size = New Size(34, 20)
        Label8.TabIndex = 33
        Label8.Text = "Zip:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(27, 256)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 32
        Label7.Text = "State:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 20)
        Label6.TabIndex = 31
        Label6.Text = "City:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 30
        Label5.Text = "Address:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 20)
        Label4.TabIndex = 29
        Label4.Text = "E-Mail:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 28
        Label3.Text = "Phone:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 27
        Label2.Text = "Last Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 26
        Label1.Text = "First Name:"
        ' 
        ' cboState
        ' 
        cboState.FormattingEnabled = True
        cboState.Location = New Point(163, 248)
        cboState.Name = "cboState"
        cboState.Size = New Size(192, 28)
        cboState.TabIndex = 25
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(163, 83)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(192, 27)
        txtLastName.TabIndex = 24
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(163, 116)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(192, 27)
        txtPhone.TabIndex = 23
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(163, 149)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(192, 27)
        txtEmail.TabIndex = 22
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(163, 182)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(192, 27)
        txtaddress.TabIndex = 21
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(163, 215)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(192, 27)
        txtCity.TabIndex = 20
        ' 
        ' txtZip
        ' 
        txtZip.Location = New Point(163, 282)
        txtZip.Name = "txtZip"
        txtZip.Size = New Size(192, 27)
        txtZip.TabIndex = 19
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(163, 50)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(192, 27)
        txtFirstName.TabIndex = 18
        ' 
        ' cboPassengers
        ' 
        cboPassengers.FormattingEnabled = True
        cboPassengers.Location = New Point(188, 12)
        cboPassengers.Name = "cboPassengers"
        cboPassengers.Size = New Size(151, 28)
        cboPassengers.TabIndex = 36
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(28, 20)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 20)
        Label9.TabIndex = 37
        Label9.Text = "Passenger:"
        ' 
        ' frmUpdatePassenger
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label9)
        Controls.Add(cboPassengers)
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
        Name = "frmUpdatePassenger"
        Text = "frmUpdatePassenger"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents cboPassengers As ComboBox
    Friend WithEvents Label9 As Label
End Class
