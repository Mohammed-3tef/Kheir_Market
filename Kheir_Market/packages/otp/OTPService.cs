using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Kheir_Market.packages.otp
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
            message.From = new MailAddress(from, "Kheir Market Application");
            message.Subject = "Confirmation Email";
            
            message.Body = $@"
                              <!DOCTYPE html>
                              <html>
                              <head>
                                <meta charset='UTF-8'>
                                <style>
                                  body {{
                                    font-family: 'Segoe UI', Arial, sans-serif;
                                    background-color: #f9f9f9;
                                    padding: 30px;
                                    color: #333;
                                  }}
                                
                                  .container {{
                                    max-width: 600px;
                                    margin: auto;
                                    background-color: #ffffff;
                                    padding: 30px;
                                    border-radius: 10px;
                                    box-shadow: 0 2px 8px rgba(0,0,0,0.1);
                                    text-align: center;
                                  }}
                                  h1 {{
                                    font-size: 30px;
                                    color: #2c3e50;
                                  }}
                                  h2 {{
                                    font-size: 20px;
                                    color: #27ae60;
                                  }}
                                  .otp {{
                                    font-size: 28px;
                                    font-weight: bold;
                                    color: #27ae60;
                                    margin: 20px 0;
                                  }}
                                  .footer {{
                                    font-size: 12px;
                                    color: #888;
                                    margin-top: 40px;
                                  }}
                                  #sentence1{{
                                      font-size: 18px;
                                   }}
                                  .footer a {{
                                    margin: 0 8px;
                                    color: #636e72;
                                    text-decoration: none;
                                    transition: all 0.3s;
                                  }}
                                  .footer a:hover {{
                                    text-decoration: underline;
                                    color: #00CCCC;
                                  }}
                                </style>
                              </head>
                              <body>
                                <div class='container'>
                                  <h1>Thank you, <strong>{username}</strong>!</h1>
                                  <p id = 'sentence1' >We appreciate your interest in our <strong>Kheir Market</strong> Application.</p>
                                  <h2>Your One-Time Password (OTP)</h2>
                                  <div class='otp'>{otp}</div>
                                  <p>Please use this code to complete your verification process.</p>

                                  <div class='footer'>
                                    <p>Developed with ❤️ by</p>
                                    <p>
                                      <a href='https://www.linkedin.com/in/george-malak/' target='_blank'>George Malak</a> |
                                      <a href='https://www.linkedin.com/in/mohammed-atef-b0a408299/' target='_blank'>Mohammed Atef</a> |
                                      <a href='https://www.linkedin.com/in/mariambadr13/' target='_blank'>Mariam Badr</a> |
                                      <a href='https://www.linkedin.com/in/john-ayman-aa30842b7/' target='_blank'>John Ayman</a> |
                                      <a href='https://www.linkedin.com/in/marawan-mohamed-7244692a4/' target='_blank'>Marwan Mohammed</a>
                                    </p>
                                    <p>© 2025 Kheir Market. All rights reserved.</p>
                                  </div>
                                </div>
                              </body>
                              </html>";
            message.To.Add(new MailAddress(email));
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
