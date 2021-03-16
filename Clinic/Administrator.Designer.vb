<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrator))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsertype = New System.Windows.Forms.Label()
        Me.txtUsertype = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.BtnFirstRecod = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLastRecord = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(12, 220)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(164, 42)
        Me.lblHeader.TabIndex = 63
        Me.lblHeader.Text = "Admin"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(12, 470)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(167, 50)
        Me.btnRefresh.TabIndex = 62
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(12, 311)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(167, 50)
        Me.btnAddUser.TabIndex = 61
        Me.btnAddUser.Text = "AddUser"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(12, 520)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(167, 50)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(12, 420)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(167, 50)
        Me.btnUpdate.TabIndex = 60
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(12, 367)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(167, 50)
        Me.btnDelete.TabIndex = 58
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(455, 165)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(160, 37)
        Me.txtUsername.TabIndex = 76
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(376, 179)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 17)
        Me.lblUsername.TabIndex = 75
        Me.lblUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(826, 115)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(160, 37)
        Me.txtPassword.TabIndex = 74
        '
        'lblUsertype
        '
        Me.lblUsertype.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsertype.Location = New System.Drawing.Point(720, 168)
        Me.lblUsertype.Name = "lblUsertype"
        Me.lblUsertype.Size = New System.Drawing.Size(81, 34)
        Me.lblUsertype.TabIndex = 73
        Me.lblUsertype.Text = "Usertype"
        Me.lblUsertype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsertype
        '
        Me.txtUsertype.Location = New System.Drawing.Point(826, 165)
        Me.txtUsertype.Multiline = True
        Me.txtUsertype.Name = "txtUsertype"
        Me.txtUsertype.Size = New System.Drawing.Size(160, 37)
        Me.txtUsertype.TabIndex = 72
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(720, 115)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(81, 34)
        Me.lblPassword.TabIndex = 71
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(455, 115)
        Me.txtUserId.Multiline = True
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(160, 37)
        Me.txtUserId.TabIndex = 70
        '
        'lblUserId
        '
        Me.lblUserId.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.Location = New System.Drawing.Point(379, 112)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(68, 34)
        Me.lblUserId.TabIndex = 69
        Me.lblUserId.Text = "UserID"
        Me.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirstRecod
        '
        Me.BtnFirstRecod.BackColor = System.Drawing.Color.White
        Me.BtnFirstRecod.Location = New System.Drawing.Point(862, 684)
        Me.BtnFirstRecod.Name = "BtnFirstRecod"
        Me.BtnFirstRecod.Size = New System.Drawing.Size(138, 43)
        Me.BtnFirstRecod.TabIndex = 68
        Me.BtnFirstRecod.Text = ">>"
        Me.BtnFirstRecod.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(722, 684)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(138, 43)
        Me.btnNext.TabIndex = 67
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(582, 684)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(138, 43)
        Me.btnPrevious.TabIndex = 66
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnLastRecord
        '
        Me.btnLastRecord.BackColor = System.Drawing.Color.White
        Me.btnLastRecord.Location = New System.Drawing.Point(442, 684)
        Me.btnLastRecord.Name = "btnLastRecord"
        Me.btnLastRecord.Size = New System.Drawing.Size(138, 43)
        Me.btnLastRecord.TabIndex = 65
        Me.btnLastRecord.Text = "<<"
        Me.btnLastRecord.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Location = New System.Drawing.Point(226, 243)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(895, 413)
        Me.DataGridView1.TabIndex = 64
        '
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 766)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblUsertype)
        Me.Controls.Add(Me.txtUsertype)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.BtnFirstRecod)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnLastRecord)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Administrator"
        Me.Text = "Administrator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUsertype As Label
    Friend WithEvents txtUsertype As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents lblUserId As Label
    Friend WithEvents BtnFirstRecod As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnLastRecord As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
