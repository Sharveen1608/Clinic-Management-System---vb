Imports System.Net.Mail
Public Class Appointment
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Doctor.Show()
        Me.Hide()

    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress("testtestmalaysia@gmail.com")
            EmailMessage.To.Add(txtTo.Text)
            EmailMessage.Subject = (txtSubject.Text)
            EmailMessage.Body = (txtMessage.Text & "With love, Oceana")
            Dim Smtp As New SmtpClient("smtp.gmail.com")
            Smtp.Port = 587
            Smtp.UseDefaultCredentials = False
            Smtp.EnableSsl = True
            Smtp.Credentials = New System.Net.NetworkCredential("testtestmalaysia@gmail.com", "Testtest16")
            Smtp.Send(EmailMessage)
            MessageBox.Show("Done, mail sent!")
            txtMessage.Clear()
            txtSubject.Clear()
            txtTo.Clear()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class