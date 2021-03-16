Imports System.Data.OleDb

Public Class FinalPayment
    Dim con As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Dim index As Integer
    Dim Totalrecords As Integer
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim Totalcost As Integer
        Dim AmountPaid As Integer
        Dim Balance As Integer
        Dim Calculation As Integer


        Totalcost = txtTotalCost.Text
        AmountPaid = txtAmountPaid.Text


        Calculation = AmountPaid - Totalcost - 30

        txtBalance.Text = Val(Calculation)
    End Sub

    Private Sub FinalPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Clear()
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clinic.mdb")
        con.Open()
        sql = "SELECT Billing.PatientID, Billing.PatientName,Billing.MedicationFee, Billing.Quantity, Billing.TreatmentFee, Billing.ExtraFees, [Billing]![MedicationFee]*[Billing]![Quantity]+[Billing]![TreatmentFee]+[Billing]![ExtraFees] AS TotalValue FROM Billing;"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "Billing")
        DataGridView1.DataSource = ds.Tables("Billing")
        index = -1
        Totalrecords = ds.Tables("Billing").Rows.Count

        con.Close()
    End Sub
End Class