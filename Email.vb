       Private Sub BtnEmail_Click(sender As Object, e As EventArgs) Handles BtnEmail.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("maharship81@gmail.com", "9408884695maha")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("maharship81@gmail.com")
            e_mail.To.Add(txtEmail.Text)
            e_mail.Subject = "Email Sending"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Hii, This Is Car Services Center"
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
