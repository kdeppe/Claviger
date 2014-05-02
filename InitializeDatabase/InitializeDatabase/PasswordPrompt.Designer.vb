<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordPrompt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordPrompt))
        Me.lblPassword1 = New System.Windows.Forms.Label()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.tbxPassword1 = New System.Windows.Forms.TextBox()
        Me.tbxPassword2 = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.tbxUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPassword1
        '
        Me.lblPassword1.AutoSize = True
        Me.lblPassword1.Location = New System.Drawing.Point(23, 46)
        Me.lblPassword1.Name = "lblPassword1"
        Me.lblPassword1.Size = New System.Drawing.Size(95, 13)
        Me.lblPassword1.TabIndex = 0
        Me.lblPassword1.Text = "Choose Password:"
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.Location = New System.Drawing.Point(23, 72)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(94, 13)
        Me.lblPassword2.TabIndex = 1
        Me.lblPassword2.Text = "Confirm Password:"
        '
        'tbxPassword1
        '
        Me.tbxPassword1.Location = New System.Drawing.Point(141, 43)
        Me.tbxPassword1.Name = "tbxPassword1"
        Me.tbxPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPassword1.Size = New System.Drawing.Size(132, 20)
        Me.tbxPassword1.TabIndex = 2
        '
        'tbxPassword2
        '
        Me.tbxPassword2.Location = New System.Drawing.Point(141, 69)
        Me.tbxPassword2.Name = "tbxPassword2"
        Me.tbxPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPassword2.Size = New System.Drawing.Size(132, 20)
        Me.tbxPassword2.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(114, 95)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 21)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(23, 20)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(97, 13)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Choose Username:"
        '
        'tbxUsername
        '
        Me.tbxUsername.Location = New System.Drawing.Point(141, 17)
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.Size = New System.Drawing.Size(131, 20)
        Me.tbxUsername.TabIndex = 6
        '
        'PasswordPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 127)
        Me.Controls.Add(Me.tbxUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.tbxPassword2)
        Me.Controls.Add(Me.tbxPassword1)
        Me.Controls.Add(Me.lblPassword2)
        Me.Controls.Add(Me.lblPassword1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PasswordPrompt"
        Me.Text = "Database Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPassword1 As System.Windows.Forms.Label
    Friend WithEvents lblPassword2 As System.Windows.Forms.Label
    Friend WithEvents tbxPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents tbxPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents tbxUsername As System.Windows.Forms.TextBox
End Class
