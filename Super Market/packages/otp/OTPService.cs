using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market.packages.otp
{
    public class OTPService
    {
        private string otp;

        public string GetOTP(){
            return this.otp;
        }

        public void SendOTP(string username, string email)
        {
            Random random = new Random();
            this.otp = random.Next(100000, 999999).ToString();

            string from = "fcaicu.assignments@gmail.com";
            string fromPassword = "qxugcqlkzhypfxdy";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(from, "Super Market Application");
            message.Subject = "Confirmation Email";

            string footer = $@"
                    <div style=""text-align: center; font-family: Arial, sans-serif; font-size: 12px; color: #888; margin-top: 40px;"">
                      <p> Developed with ❤️ by </p>
                      <p>
                        <a href=""https://www.linkedin.com/in/george-malak/"" target=""_blank"" style=""margin: 0 8px; color: #636e72;"">George Malak</a> |
                        <a href=""https://www.linkedin.com/in/mohammed-atef-b0a408299/"" target=""_blank"" style=""margin: 0 8px; color: #636e72;"">Mohammed Atef</a> |
                        <a href=""https://www.linkedin.com/in/mariambadr13/"" target=""_blank"" style=""margin: 0 8px; color: #636e72;"">Mariam Badr</a> |
                        <a href=""https://www.linkedin.com/in/john-ayman-aa30842b7/"" target=""_blank"" style=""margin: 0 8px; color: #636e72;"">John Ayman</a> |
                        <a href=""https://www.linkedin.com/in/marawan-mohamed-7244692a4/"" target=""_blank"" style=""margin: 0 8px; color: #636e72;"">Marwan Mohammed</a>
                      </p>
                      <p>© 2025 Super Market. All rights reserved.</p>
                    </div>";


            message.To.Add(new MailAddress(email));
            message.Body =
                $"<center style='font-size: 1.5rem;'>Thank you <strong>{username}</strong> for your interest in our personal budgeting application.</center>" +
                $"<center style='font-size: 1.25rem;'>Your OTP code is: <strong style='color: green;'><ins>{otp}</ins></strong> </center>" + footer;
            message.IsBodyHtml = true;
            message.Priority = MailPriority.High;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new System.Net.NetworkCredential(from, fromPassword),
                EnableSsl = true,
            };

            smtp.Send(message);
        }
    }
}
