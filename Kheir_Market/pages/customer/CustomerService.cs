using Kheir_Market.packages.display;
using Kheir_Market.packages.validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kheir_Market.pages.customer
{
    public partial class CustomerService : Form
    {
        private MainWindow mainWindow;
        public CustomerService(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            this.FormClosing += this.mainWindow.formClosing;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            CustomerMenuPage customerMenuPage = new CustomerMenuPage(this.mainWindow);
            customerMenuPage.Show();
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
        }

        void sendResponseEmail(string email, string name)
        {
            // Send the response email to the user
            string from = "fcaicu.assignments@gmail.com";
            string fromPassword = "qxugcqlkzhypfxdy";

            MailMessage responseMessage = new MailMessage();
            responseMessage.From = new MailAddress(from, "Kheir Market Application");
            responseMessage.Subject = "Confirmation Email";

            // make the body of the email
            responseMessage.Body = $@"
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
                        p {{
                            font-size: 16px;
                        }}
                        .footer {{
                            text-align: center;
                            margin: auto;
                            font-size: 12px;
                            color: #888;
                            margin-top: 40px;
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
                        <h1>Thank You for Contacting Us!</h1>
                        <p>Dear {name},</p>
                        <p>We have received your message and will get back to you shortly.</p>
                        <p>Best regards,<br/>Kheir Market Application Team</p>
                    </div>

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
                </body>
                </html>";

            responseMessage.To.Add(new MailAddress(email));
            responseMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(from, fromPassword),
                EnableSsl = true
            };
            smtpClient.Send(responseMessage);
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
            // Validate the input before sending the message
            if (!Validator.IsValidName(this.nameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid name (at least 3 characters, letters and spaces only).");
                return;
            }

            if (!Validator.IsValidEmail(this.emailInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid email.");
                return;
            }

            if (string.IsNullOrWhiteSpace(this.messageInput.Text) || this.messageInput.Text.Length < 10)
            {
                MessageDisplay.ShowError("Please enter a message with at least 10 characters.");
                return;
            }

            string name = Uri.EscapeDataString(this.nameInput.Text);
            string email = Uri.EscapeDataString(this.emailInput.Text);
            string subject = Uri.EscapeDataString(this.subjectInput.Text);
            string message = Uri.EscapeDataString(this.messageInput.Text);

            string lrm = Uri.EscapeDataString("\u200E");  // Result: %E2%80%8E

            // Compose email content
            string body = lrm +
                "🔹 Name    : " + name + "%0A" +
                "🔹 Email   : " + email + "%0A" +
                "🔹 Subject : " + subject + "%0A" +
                "🔹 Date    : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "%0A%0A" +

                "📝 Complaint:%0A" + message + "%0A%0A" +
                "Please look into this matter at your earliest convenience. I would appreciate your response or any required action.%0A" +
                "Thank you for your time and support.%0A%0A" +
                "Best regards,%0A" +
                name + "%0A"
            ;

            // Gmail compose URL
            string gmailUrl = $"https://mail.google.com/mail/?view=cm&fs=1&to=fcaicu.assignments@gmail.com&su={subject}&body={body}";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = gmailUrl,
                UseShellExecute = true
            });

            await Task.Delay(15000);

            sendResponseEmail(this.emailInput.Text, this.nameInput.Text);
        }
    }
}
