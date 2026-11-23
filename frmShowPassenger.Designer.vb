<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowPassenger
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
        lstPassengers = New ListBox()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lstPassengers
        ' 
        lstPassengers.FormattingEnabled = True
        lstPassengers.Location = New Point(54, 52)
        lstPassengers.Name = "lstPassengers"
        lstPassengers.Size = New Size(613, 224)
        lstPassengers.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(668, 395)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 36
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmShowPassenger
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(lstPassengers)
        Name = "frmShowPassenger"
        Text = "frmShowPassenger"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstPassengers As ListBox
    Friend WithEvents btnExit As Button
End Class
