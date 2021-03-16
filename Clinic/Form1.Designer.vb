<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.ComboBoxLogin = New System.Windows.Forms.ComboBox()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsertype = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Header = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxLogin
        '
        Me.ComboBoxLogin.FormattingEnabled = True
        Me.ComboBoxLogin.Items.AddRange(New Object() {"Administrator", "Staff Nurse", "Doctor"})
        Me.ComboBoxLogin.Location = New System.Drawing.Point(70, 470)
        Me.ComboBoxLogin.Name = "ComboBoxLogin"
        Me.ComboBoxLogin.Size = New System.Drawing.Size(338, 24)
        Me.ComboBoxLogin.TabIndex = 14
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(70, 381)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.Size = New System.Drawing.Size(338, 22)
        Me.Txtpassword.TabIndex = 13
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(70, 302)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(338, 22)
        Me.txtUsername.TabIndex = 12
        '
        'lblUsertype
        '
        Me.lblUsertype.AutoSize = True
        Me.lblUsertype.BackColor = System.Drawing.Color.White
        Me.lblUsertype.Location = New System.Drawing.Point(67, 449)
        Me.lblUsertype.Name = "lblUsertype"
        Me.lblUsertype.Size = New System.Drawing.Size(65, 17)
        Me.lblUsertype.TabIndex = 11
        Me.lblUsertype.Text = "Usertype"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(67, 361)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(67, 281)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 17)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.Header)
        Me.Panel1.Location = New System.Drawing.Point(29, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 696)
        Me.Panel1.TabIndex = 15
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(141, 495)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(126, 32)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Header
        '
        Me.Header.Font = New System.Drawing.Font("Rockwell", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Header.Location = New System.Drawing.Point(46, 14)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(300, 125)
        Me.Header.TabIndex = 0
        Me.Header.Text = "Oceana Clinic"
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 811)
        Me.Controls.Add(Me.ComboBoxLogin)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsertype)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Administrator"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxLogin As ComboBox
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsertype As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents Header As Label
End Class
