<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAppoinment = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtMedicinePrice = New System.Windows.Forms.TextBox()
        Me.lblMedicinePrice = New System.Windows.Forms.Label()
        Me.lblTreatmentPrice = New System.Windows.Forms.Label()
        Me.txtTreatmentPrice = New System.Windows.Forms.TextBox()
        Me.cmbTreatment = New System.Windows.Forms.ComboBox()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtMedication = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatientname = New System.Windows.Forms.TextBox()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.lblTreatment = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.txtExtraFee = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.lblExtraFee = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(23, 578)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(167, 47)
        Me.btnBack.TabIndex = 87
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAppoinment
        '
        Me.btnAppoinment.BackColor = System.Drawing.Color.White
        Me.btnAppoinment.Location = New System.Drawing.Point(23, 529)
        Me.btnAppoinment.Name = "btnAppoinment"
        Me.btnAppoinment.Size = New System.Drawing.Size(167, 47)
        Me.btnAppoinment.TabIndex = 86
        Me.btnAppoinment.Text = "Appointment"
        Me.btnAppoinment.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(26, 298)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(160, 42)
        Me.lblHeader.TabIndex = 85
        Me.lblHeader.Text = "Doctor"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(23, 479)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(167, 47)
        Me.btnRefresh.TabIndex = 84
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(23, 429)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(167, 47)
        Me.btnUpdate.TabIndex = 83
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(42, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(273, 469)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(588, 268)
        Me.DataGridView1.TabIndex = 106
        '
        'txtMedicinePrice
        '
        Me.txtMedicinePrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtMedicinePrice.Location = New System.Drawing.Point(850, 322)
        Me.txtMedicinePrice.Name = "txtMedicinePrice"
        Me.txtMedicinePrice.Size = New System.Drawing.Size(254, 22)
        Me.txtMedicinePrice.TabIndex = 105
        '
        'lblMedicinePrice
        '
        Me.lblMedicinePrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicinePrice.Location = New System.Drawing.Point(745, 322)
        Me.lblMedicinePrice.Name = "lblMedicinePrice"
        Me.lblMedicinePrice.Size = New System.Drawing.Size(91, 42)
        Me.lblMedicinePrice.TabIndex = 104
        Me.lblMedicinePrice.Text = "Medicine Price (RM)"
        Me.lblMedicinePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTreatmentPrice
        '
        Me.lblTreatmentPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatmentPrice.Location = New System.Drawing.Point(231, 316)
        Me.lblTreatmentPrice.Name = "lblTreatmentPrice"
        Me.lblTreatmentPrice.Size = New System.Drawing.Size(98, 46)
        Me.lblTreatmentPrice.TabIndex = 103
        Me.lblTreatmentPrice.Text = "Treatment Price (RM)"
        Me.lblTreatmentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTreatmentPrice
        '
        Me.txtTreatmentPrice.Location = New System.Drawing.Point(348, 316)
        Me.txtTreatmentPrice.Name = "txtTreatmentPrice"
        Me.txtTreatmentPrice.Size = New System.Drawing.Size(159, 22)
        Me.txtTreatmentPrice.TabIndex = 102
        '
        'cmbTreatment
        '
        Me.cmbTreatment.FormattingEnabled = True
        Me.cmbTreatment.Items.AddRange(New Object() {"One Medicine Type(RM10)", "Lab Services(RM100)", "X-Ray(RM50)", "Comprehensive Health Check(RM120)", "Partial Health Check(RM75)"})
        Me.cmbTreatment.Location = New System.Drawing.Point(348, 270)
        Me.cmbTreatment.Name = "cmbTreatment"
        Me.cmbTreatment.Size = New System.Drawing.Size(159, 24)
        Me.cmbTreatment.TabIndex = 101
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(850, 274)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(254, 22)
        Me.TxtQuantity.TabIndex = 100
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(749, 277)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(70, 20)
        Me.lblQuantity.TabIndex = 99
        Me.lblQuantity.Text = "Quantity"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(946, 429)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(263, 33)
        Me.btnShow.TabIndex = 98
        Me.btnShow.Text = "Show Medication List"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'txtMedication
        '
        Me.txtMedication.Location = New System.Drawing.Point(850, 96)
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.Size = New System.Drawing.Size(254, 129)
        Me.txtMedication.TabIndex = 97
        Me.txtMedication.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Leelawadee", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(513, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 30)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "If there is any"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPatientname
        '
        Me.txtPatientname.Location = New System.Drawing.Point(348, 140)
        Me.txtPatientname.Multiline = True
        Me.txtPatientname.Name = "txtPatientname"
        Me.txtPatientname.Size = New System.Drawing.Size(159, 43)
        Me.txtPatientname.TabIndex = 91
        '
        'lblMedication
        '
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedication.Location = New System.Drawing.Point(749, 96)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(87, 20)
        Me.lblMedication.TabIndex = 95
        Me.lblMedication.Text = "Medication"
        '
        'lblPatientID
        '
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.Location = New System.Drawing.Point(254, 86)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(75, 20)
        Me.lblPatientID.TabIndex = 88
        Me.lblPatientID.Text = "PatientID"
        '
        'lblTreatment
        '
        Me.lblTreatment.AutoSize = True
        Me.lblTreatment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatment.Location = New System.Drawing.Point(254, 262)
        Me.lblTreatment.Name = "lblTreatment"
        Me.lblTreatment.Size = New System.Drawing.Size(82, 20)
        Me.lblTreatment.TabIndex = 94
        Me.lblTreatment.Text = "Treatment"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(254, 151)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(51, 20)
        Me.lblPatientName.TabIndex = 89
        Me.lblPatientName.Text = "Name"
        '
        'txtExtraFee
        '
        Me.txtExtraFee.Location = New System.Drawing.Point(348, 205)
        Me.txtExtraFee.Multiline = True
        Me.txtExtraFee.Name = "txtExtraFee"
        Me.txtExtraFee.Size = New System.Drawing.Size(159, 43)
        Me.txtExtraFee.TabIndex = 93
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(348, 75)
        Me.txtPatientID.Multiline = True
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(159, 43)
        Me.txtPatientID.TabIndex = 90
        '
        'lblExtraFee
        '
        Me.lblExtraFee.AutoSize = True
        Me.lblExtraFee.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraFee.Location = New System.Drawing.Point(254, 205)
        Me.lblExtraFee.Name = "lblExtraFee"
        Me.lblExtraFee.Size = New System.Drawing.Size(69, 20)
        Me.lblExtraFee.TabIndex = 92
        Me.lblExtraFee.Text = "ExtraFee"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(946, 469)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(263, 260)
        Me.DataGridView2.TabIndex = 107
        '
        'Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 827)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtMedicinePrice)
        Me.Controls.Add(Me.lblMedicinePrice)
        Me.Controls.Add(Me.lblTreatmentPrice)
        Me.Controls.Add(Me.txtTreatmentPrice)
        Me.Controls.Add(Me.cmbTreatment)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtMedication)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPatientname)
        Me.Controls.Add(Me.lblMedication)
        Me.Controls.Add(Me.lblPatientID)
        Me.Controls.Add(Me.lblTreatment)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.txtExtraFee)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.lblExtraFee)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAppoinment)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Doctor"
        Me.Text = "Doctor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnAppoinment As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtMedicinePrice As TextBox
    Friend WithEvents lblMedicinePrice As Label
    Friend WithEvents lblTreatmentPrice As Label
    Friend WithEvents txtTreatmentPrice As TextBox
    Friend WithEvents cmbTreatment As ComboBox
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents txtMedication As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatientname As TextBox
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents lblTreatment As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents txtExtraFee As TextBox
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents lblExtraFee As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
