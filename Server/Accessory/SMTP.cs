using System;
using System.Net;
using System.Net.Mail;

namespace Server.Accessory
{
    class SMTP
    {
        public static String Email = "testunproverialovich@gmail.com";
        public static String Password = "Ntcnbhjdfybt";


        public static void sendCodeToEmail(string confirmCode, String ToEmail, String msg, String title)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(
                Email, Password);

            MailMessage mailMessage = new MailMessage(Email, ToEmail);

            mailMessage.Body = msg;
            mailMessage.Subject = title;
            try
            {
                smtp.Send(mailMessage);
            }
            catch (Exception ex)
            {
                new Exception($"Send error: {ex.Message}");
            }
        }
    }
}
