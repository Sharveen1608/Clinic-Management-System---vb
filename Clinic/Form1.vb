Imports System.Data.OleDb
Imports System
Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        Dim cmd As New OleDbCommand("select * from Adminuser where Username=@TxtUsername.Text and PassnumNo=@TxtPassword.Text and Usertype=@comboboxLogin.Selectedindex", conn)
        cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = txtUsername.Text
        cmd.Parameters.Add("@PassNumNo", OleDbType.VarChar).Value = Txtpassword.Text
        cmd.Parameters.Add("@Usertype", OleDbType.VarChar).Value = ComboBoxLogin.SelectedItem
        Dim adapter1 As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        adapter1.Fill(table)

        If table.Rows.Count > 0 Then
            MessageBox.Show("Welcome " + table.Rows(0)(1))
            If ComboBoxLogin.SelectedIndex = 0 Then

                Administrator.Show()
                Me.Hide()
            ElseIf ComboBoxLogin.SelectedIndex = 1 Then
                Staff_Nurse.Show()
                Me.Hide()
            ElseIf ComboBoxLogin.SelectedIndex = 2 Then
                Doctor.Show()
                Me.Hide()
            End If

        Else
            MsgBox("Credit invalid! Please try again")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
