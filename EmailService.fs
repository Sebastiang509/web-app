namespace TodoWeatherApp.Services

open System.Net
open System.Net.Mail
open System.Threading.Tasks

module EmailService =
    let sendEmail (subject: string) (body: string) =
        task {
            let smtpClient = new SmtpClient("smtp.gmail.com", 587)
            smtpClient.Credentials <- NetworkCredential("your-email@gmail.com", "your-app-password")
            smtpClient.EnableSsl <- true

            let mailMessage = new MailMessage()
            mailMessage.From <- MailAddress("your-email@gmail.com")
            mailMessage.To.Add("your-email@gmail.com")
            mailMessage.Subject <- subject
            mailMessage.Body <- body

            do! smtpClient.SendMailAsync(mailMessage)
        }
