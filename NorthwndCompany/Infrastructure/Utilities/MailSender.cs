using System.Net;
using System.Net.Mail;

namespace NorthwndCompany.Infrastructure.Utilities
{
    public static class MailSender
    {
        public static void Send(string to,string subject,string message)
        {
            MailMessage mailMessage = new MailMessage("northwndtraders2022@hotmail.com", to);
            mailMessage.Subject = subject;
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("northwndtraders2022@hotmail.com", "Nw1234?Abcd256");
            
            smtpClient.Send(mailMessage);
        }

        //public static void Send(List<string> tos, string subject, string message,List<Attachment> attachments)
        //{
        //    MailMessage mailMessage = new MailMessage();
        //    mailMessage.Subject = subject;
        //    mailMessage.Body = message;
        //    mailMessage.IsBodyHtml = true;
        //    mailMessage.From = new MailAddress("kimden@gmail.com");

        //    foreach (var item in tos)
        //        mailMessage.Bcc.Add(item);

        //    if (attachments != null && attachments.Count > 0)
        //    {
        //        foreach (var item in attachments)
        //            mailMessage.Attachments.Add(item);
        //    }
            

        //    SmtpClient smtpClient = new SmtpClient();
        //    smtpClient.Send(mailMessage);
        //}

        //public static void Send(List<string> tos, string subject, string message, List<string> files)
        //{
        //    MailMessage mailMessage = new MailMessage();
        //    mailMessage.Subject = subject;
        //    mailMessage.Body = message;
        //    mailMessage.IsBodyHtml = true;
        //    mailMessage.From = new MailAddress("kimden@gmail.com");

        //    foreach (var item in tos)
        //        mailMessage.Bcc.Add(item);

        //    if (files != null && files.Count > 0)
        //    {
        //        foreach (var file in files)
        //            mailMessage.Attachments.Add(new Attachment(file));
                    
        //    }


        //    SmtpClient smtpClient = new SmtpClient();
        //    smtpClient.Send(mailMessage);
        //}
    }
}
