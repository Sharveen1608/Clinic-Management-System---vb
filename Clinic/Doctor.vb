Imports System.Data.OleDb

Public Class Doctor
    Dim con As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Dim index As Integer
    Dim Totalrecords As Integer
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPatientID.Text = Nothing Then
            MessageBox.Show("Please enter details first!")
        Else

            con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")

            con.Open()
            sql = "Insert into Billing([PatientID],[PatientName],[Medication],[ExtraFees],[Treatment],[Quantity],[MedicationFee],[TreatmentFee] )values ('" & txtPatientID.Text & "', '" & txtPatientname.Text & "','" & txtMedication.Text & "', '" & txtExtraFee.Text & "', '" & cmbTreatment.Text & "', '" & TxtQuantity.Text & "','" & txtMedicinePrice.Text & "', '" & txtTreatmentPrice.Text & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
            cmd.Parameters.Add(New OleDbParameter("PatientID", CType(txtPatientID.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientName", CType(txtPatientname.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Medication", CType(txtMedication.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("ExtraFees", CType(txtExtraFee.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Treatment", CType(cmbTreatment.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Quantity", CType(TxtQuantity.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("MedicationFee", CType(txtMedicinePrice.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("TreatmentFee", CType(txtTreatmentPrice.Text, String)))
            MessageBox.Show("Records Saved!")
            'btnCancel.Enabled = True
            'btnDelete.Enabled = False
            'btnUpdate.Enabled = False
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                txtPatientID.Clear()
                txtPatientname.Clear()
                txtMedication.Clear()
                txtExtraFee.Clear()
                cmbTreatment.Items.Clear()
                TxtQuantity.Clear()
                txtMedicinePrice.Clear()
                txtTreatmentPrice.Clear()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            con.Close()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ds.Clear()
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        con.Open()
        sql = "Select * from Billing"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "Billing")
        DataGridView1.DataSource = ds.Tables("Billing")
        index = -1
        Totalrecords = ds.Tables("Billing").Rows.Count
        con.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        con.Open()
        sql = "Select PatientID,PatientName, PatientWeight, PatientAllergy, PatientBloodGrp from PatientInfo"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "PatientInfo")
        DataGridView1.DataSource = ds.Tables("PatientInfo")
        index = -1
        Totalrecords = ds.Tables("PatientInfo").Rows.Count

        con.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        con.Open()
        sql = "Select * from MedicationTreatmentList"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "MedicationTreatmentList")
        DataGridView2.DataSource = ds.Tables("MedicationTreatmentList")
        index = -1
        Totalrecords = ds.Tables("MedicationTreatmentList").Rows.Count

        con.Close()
    End Sub

    Private Sub Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        con.Open()
        sql = "Select PatientID,PatientName, PatientWeight, PatientAllergy, PatientBloodGrp from PatientInfo"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "PatientInfo")
        DataGridView1.DataSource = ds.Tables("PatientInfo")
        index = -1
        Totalrecords = ds.Tables("PatientInfo").Rows.Count

        con.Close()
    End Sub

    Private Sub btnAppoinment_Click(sender As Object, e As EventArgs) Handles btnAppoinment.Click
        Appointment.Show()
        Me.Hide()
    End Sub
End Class