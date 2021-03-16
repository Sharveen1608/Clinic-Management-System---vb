<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalPayment
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
        Me.lblfixed = New System.Windows.Forms.Label()
        Me.lblConsultancy = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblfixed
        '
        Me.lblfixed.AutoSize = True
        Me.lblfixed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfixed.Location = New System.Drawing.Point(288, 470)
        Me.lblfixed.Name = "lblfixed"
        Me.lblfixed.Size = New System.Drawing.Size(63, 20)
        Me.lblfixed.TabIndex = 19
        Me.lblfixed.Text = "RM 30"
        '
        'lblConsultancy
        '
        Me.lblConsultancy.Location = New System.Drawing.Point(153, 459)
        Me.lblConsultancy.Name = "lblConsultancy"
        Me.lblConsultancy.Size = New System.Drawing.Size(100, 38)
        Me.lblConsultancy.TabIndex = 18
        Me.lblConsultancy.Text = "Consulatancy Fee"
        Me.lblConsultancy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(279, 663)
        Me.txtBalance.Multiline = True
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(117, 35)
        Me.txtBalance.TabIndex = 17
        '
        'lblBalance
        '
        Me.lblBalance.Location = New System.Drawing.Point(153, 663)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(110, 33)
        Me.lblBalance.TabIndex = 16
        Me.lblBalance.Text = "Balance"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Location = New System.Drawing.Point(279, 583)
        Me.txtAmountPaid.Multiline = True
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(117, 35)
        Me.txtAmountPaid.TabIndex = 15
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.Location = New System.Drawing.Point(153, 583)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(110, 33)
        Me.lblAmountPaid.TabIndex = 14
        Me.lblAmountPaid.Text = "Amount Paid"
        Me.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(279, 518)
        Me.txtTotalCost.Multiline = True
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(117, 35)
        Me.txtTotalCost.TabIndex = 13
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Location = New System.Drawing.Point(153, 518)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(110, 33)
        Me.lblTotalCost.TabIndex = 12
        Me.lblTotalCost.Text = "TotalCost"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(695, 540)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(116, 88)
        Me.btnPay.TabIndex = 11
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1049, 263)
        Me.DataGridView1.TabIndex = 10
        '
        'FinalPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 838)
        Me.Controls.Add(Me.lblfixed)
        Me.Controls.Add(Me.lblConsultancy)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FinalPayment"
        Me.Text = "FinalPayment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblfixed As Label
    Friend WithEvents lblConsultancy As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
