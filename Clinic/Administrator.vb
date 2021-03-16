Imports System.Data.OleDb
Public Class Administrator
    Dim con As New OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Dim Index As Integer
    Dim totalrecords As Integer
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        If txtUserId.Text = Nothing And txtUsername.Text = Nothing And txtPassword.Text = Nothing And txtUsertype.Text = Nothing Then
            MessageBox.Show("Please fill up the details first!")
        Else
            con.Open()
            sql = "Insert into Adminuser([UserID],[Username],[PassnumNo],[Usertype] )values ('" & txtUserId.Text & "', '" & txtUsername.Text & "','" & txtPassword.Text & "', '" & txtUsertype.Text & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
            cmd.Parameters.Add(New OleDbParameter("UserID", CType(txtUserId.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Username", CType(txtUsername.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PassnumNo", CType(txtPassword.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Usertype", CType(txtUsertype.Text, String)))
            MessageBox.Show("Records Saved!")
            btnCancel.Enabled = True
            btnDelete.Enabled = False
            btnUpdate.Enabled = False
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                txtUserId.Clear()
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsertype.Clear()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            con.Close()


        End If
    End Sub
    Sub NavigateRecords()
        txtUserId.Text = ds.Tables("Adminuser").Rows(Index).Item(0)
        txtUsername.Text = ds.Tables("Adminuser").Rows(Index).Item(1)
        txtPassword.Text = ds.Tables("Adminuser").Rows(Index).Item(2)
        txtUsertype.Text = ds.Tables("Adminuser").Rows(Index).Item(3)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        con.Open()
        If txtUserId.Text = Nothing Then
            MessageBox.Show("Please fill up the details first!")
        Else
            sql = "Delete from Adminuser where UserID =   '" & txtUserId.Text & "' "
            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
            MessageBox.Show("Records Deleted!")
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                txtUserId.Clear()
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsertype.Clear()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            con.Close()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtUserId.Text = Nothing Then
            MessageBox.Show("Please fill up the details first!")
        Else
            con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
            con.Open()
            sql = "Update Adminuser set [Username] ='" & txtUsername.Text & "', [PassnumNo]= '" & txtPassword.Text & "', [Usertype]='" & txtUsertype.Text & "' where [UserID] = '" & txtUserId.Text & "' "
            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
            MessageBox.Show("Records Updated!")
            btnAddUser.Enabled = False
            btnDelete.Enabled = False
            btnCancel.Enabled = True

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                txtUserId.Clear()
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsertype.Clear()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ds.Clear()

        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        con.Open()
        sql = "Select * from Adminuser order by UserID "
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "Adminuser")
        DataGridView1.DataSource = ds.Tables("Adminuser")
        Index = -1
        totalrecords = ds.Tables("Adminuser").Rows.Count
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAddUser.Enabled = True
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnRefresh.Enabled = True
        txtUserId.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsertype.Clear()
    End Sub

    Private Sub btnLastRecord_Click(sender As Object, e As EventArgs) Handles btnLastRecord.Click
        Index = totalrecords - 1
        NavigateRecords()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If Index > 0 Then
            Index = Index - 1
            NavigateRecords()
        Else
            MessageBox.Show("Last Record")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If Index < totalrecords - 1 Then
            Index = Index + 1
            NavigateRecords()
        Else
            MessageBox.Show("First Record")
        End If
    End Sub

    Private Sub BtnFirstRecod_Click(sender As Object, e As EventArgs) Handles BtnFirstRecod.Click
        Index = 0
        NavigateRecords()
    End Sub

    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        con.Open()

        sql = "Select * from Adminuser"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "Adminuser")
        DataGridView1.DataSource = ds.Tables("Adminuser")
        Index = -1
        totalrecords = ds.Tables("Adminuser").Rows.Count
        con.Close()
    End Sub
End Class