Imports System.Data.OleDb

Public Class Staff_Nurse
    Dim con As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Dim index As Integer
    Dim Totalrecords As Integer
    Private Sub Staff_Nurse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        con.Open()
        sql = "Select * from PatientInfo"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "PatientInfo")
        DataGridView1.DataSource = ds.Tables("PatientInfo")
        index = -1
        Totalrecords = ds.Tables("PatientInfo").Rows.Count

        con.Close()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        If txtPatientID.Text = Nothing Then
            MessageBox.Show("Please fill up the details first !")
        Else
            con.Open()
            sql = "Insert into PatientInfo([PatientID],[PatientName],[PatientIDPassport],[PatientAddress],[PatientMobile],[PatientEmail],[PatientWeight],[PatientHeight],[PatientAllergy],[PatientBloodGrp])
        values('" & txtPatientID.Text & "','" & txtName.Text & "','" & TxtIDPass.Text & "','" & txtAddress.Text & "','" & txtMobile.Text & "','" & txtEmail.Text & "','" & txtWeight.Text & "','" & txtHeight.Text & "','" & txtAllergy.Text & "','" & txtBlood.Text & "')"

            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
            cmd.Parameters.Add(New OleDbParameter("PatientID", CType(txtPatientID.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientName", CType(txtName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientIDPassport", CType(TxtIDPass.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientAddress", CType(txtAddress.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientMobile", CType(txtMobile.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientEmail", CType(txtEmail.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientWeight", CType(txtWeight.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientHeight", CType(txtHeight.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientAllergy", CType(txtAllergy.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PatientBllod", CType(txtBlood.Text, String)))
            MessageBox.Show("Records Saved!")

            btnBilling.Enabled = False
            BtnUpdate.Enabled = False

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                txtPatientID.Clear()
                txtName.Clear()
                TxtIDPass.Clear()
                txtAddress.Clear()
                txtMobile.Clear()
                txtEmail.Clear()
                txtWeight.Clear()
                txtHeight.Clear()
                txtAllergy.Clear()
                txtBlood.Clear()



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
        sql = "Select * from PatientInfo order by PatientID "
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "PatientInfo")
        DataGridView1.DataSource = ds.Tables("PatientInfo")
        index = -1
        Totalrecords = ds.Tables("PatientInfo").Rows.Count
        con.Close()

        btnBilling.Enabled = True
        BtnUpdate.Enabled = True
    End Sub

    Private Sub btnLastRecord_Click(sender As Object, e As EventArgs) Handles btnLastRecord.Click
        index = 0
        NavigateRecords()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If index > 0 Then
            index = index - 1
            NavigateRecords()
        Else
            MessageBox.Show("Last Record")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < Totalrecords - 1 Then
            index = index + 1
            NavigateRecords()
        Else
            MessageBox.Show("First Record")
        End If
    End Sub

    Private Sub BtnFirstRecod_Click(sender As Object, e As EventArgs) Handles BtnFirstRecod.Click
        index = Totalrecords - 1
        NavigateRecords()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If txtPatientID.Text = Nothing Then
            MessageBox.Show("Please fill up the details first !")
        Else
            con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
            con.Open()
            sql = "Update PatientInfo set  [PatientName]= '" & txtName.Text & "', [PatientIDPassport]='" & TxtIDPass.Text & "',[PatientAddress]='" & txtAddress.Text & "',[PatientMobile]='" & txtMobile.Text & "',[PatientEmail]='" & txtEmail.Text & "',[PatientWeight]='" & txtWeight.Text & "',[PatientHeight]='" & txtHeight.Text & "',[PatientAllergy]='" & txtAllergy.Text & "',[PatientBloodGrp]='" & txtBlood.Text & "' where [PatientID]='" & txtPatientID.Text & "' "
            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
            MessageBox.Show("Records Updated!")
            btnRefresh.Enabled = True
            btnAddPatient.Enabled = False
            btnBilling.Enabled = False

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                txtPatientID.Clear()
                txtName.Clear()
                TxtIDPass.Clear()
                txtAddress.Clear()
                txtMobile.Clear()
                txtEmail.Clear()
                txtWeight.Clear()
                txtHeight.Clear()
                txtAllergy.Clear()
                txtBlood.Clear()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            btnAddPatient.Enabled = True
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAddPatient.Enabled = True
        btnBilling.Enabled = True
        txtAddress.Clear()

        txtAllergy.Clear()
        txtBlood.Clear()
        txtEmail.Clear()
        txtHeight.Clear()
        TxtIDPass.Clear()
        txtMobile.Clear()
        txtName.Clear()
        txtPatientID.Clear()
        txtWeight.Clear()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        FinalPayment.Show()
    End Sub
    Sub NavigateRecords()
        txtPatientID.Text = ds.Tables("PatientInfo").Rows(index).Item(0)
        txtName.Text = ds.Tables("PatientInfo").Rows(index).Item(1)
        TxtIDPass.Text = ds.Tables("PatientInfo").Rows(index).Item(2)
        txtAddress.Text = ds.Tables("PatientInfo").Rows(index).Item(3)
        txtMobile.Text = ds.Tables("PatientInfo").Rows(index).Item(4)
        txtEmail.Text = ds.Tables("PatientInfo").Rows(index).Item(5)
        txtWeight.Text = ds.Tables("PatientInfo").Rows(index).Item(6)
        txtHeight.Text = ds.Tables("PatientInfo").Rows(index).Item(7)
        txtAllergy.Text = ds.Tables("PatientInfo").Rows(index).Item(8)
        txtBlood.Text = ds.Tables("PatientInfo").Rows(index).Item(9)
    End Sub
End Class