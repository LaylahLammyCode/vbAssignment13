<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAddPassengerForm = New Button()
        btnShowPassengerForm = New Button()
        btnUpdatePassengerForm = New Button()
        SuspendLayout()
        ' 
        ' btnAddPassengerForm
        ' 
        btnAddPassengerForm.Location = New Point(47, 141)
        btnAddPassengerForm.Name = "btnAddPassengerForm"
        btnAddPassengerForm.Size = New Size(207, 46)
        btnAddPassengerForm.TabIndex = 1
        btnAddPassengerForm.Text = "Add Passenger"
        btnAddPassengerForm.UseVisualStyleBackColor = True
        ' 
        ' btnShowPassengerForm
        ' 
        btnShowPassengerForm.Location = New Point(47, 211)
        btnShowPassengerForm.Name = "btnShowPassengerForm"
        btnShowPassengerForm.Size = New Size(207, 46)
        btnShowPassengerForm.TabIndex = 2
        btnShowPassengerForm.Text = "Show Passenger"
        btnShowPassengerForm.UseVisualStyleBackColor = True
        ' 
        ' btnUpdatePassengerForm
        ' 
        btnUpdatePassengerForm.Location = New Point(47, 278)
        btnUpdatePassengerForm.Name = "btnUpdatePassengerForm"
        btnUpdatePassengerForm.Size = New Size(207, 46)
        btnUpdatePassengerForm.TabIndex = 3
        btnUpdatePassengerForm.Text = "Update Passenger"
        btnUpdatePassengerForm.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnUpdatePassengerForm)
        Controls.Add(btnShowPassengerForm)
        Controls.Add(btnAddPassengerForm)
        Name = "frmMain"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnAddPassengerForm As Button
    Friend WithEvents btnShowPassengerForm As Button
    Friend WithEvents btnUpdatePassengerForm As Button

End Class
