using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Turnstile.Classes
{
    internal class MailSend
    {
        internal static async void MailSendPassword()
        {
            string[] mailInfo = new string[4];
            SQLDatabase.sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("EXEC PCD_MAIL", SQLDatabase.sqlConnection);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    mailInfo[0] = (string)rd[0];
                    mailInfo[1] = (string)rd[1];
                    mailInfo[2] = (string)rd[2];
                    mailInfo[3] = (string)rd[3];
                }
            }
            catch (Exception)
            {
                SQLDatabase.sqlConnection.Close();
                new FileLogger("MAİL ATMADI");
                return;
            }
            SQLDatabase.sqlConnection.Close();
            if (!File.Exists(Application.StartupPath + "\\filelog.txt"))
                return;
            Attachment at = new(Application.StartupPath + "\\filelog.txt");
            MailMessage mail = new();
            mail.From = new MailAddress(Encription.Desc(mailInfo[0]));
            mail.To.Add(new MailAddress("ghasab101@gmail.com"));
            mail.Subject = "Turnstile Simulation Error Log";
            mail.Attachments.Add(at);
            using (SmtpClient smtp = new())
            {
                smtp.Credentials = new NetworkCredential(Encription.Desc(mailInfo[0]), Encription.Desc(mailInfo[1]));
                smtp.Port = int.Parse(Encription.Desc(mailInfo[2]));
                smtp.Host = Encription.Desc(mailInfo[3]);
                try
                {
                    await smtp.SendMailAsync(mail);
                    at.Dispose();
                    mail.Dispose();
                    smtp.Dispose();
                }
                catch (Exception)
                {
                    new FileLogger("MAİL ATMADI !!");
                    at.Dispose();
                    mail.Dispose();
                    smtp.Dispose();
                }
            }
        }
    }
}