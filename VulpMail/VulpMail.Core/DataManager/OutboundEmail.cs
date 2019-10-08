using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulpMail.Core.DataManager
{
    class OutboundEmail
    {
        public async void ConstructAndSendMessage(MimeMessage message)
        {
            await Task.Factory.StartNew(SendMessage, message);
        }

        public MimeMessage ConstructMessage(string recipentEmail, string messageSubject, string messageBody)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Saint Sender", "saintsender2.0@gmail.com"));
            message.To.Add(new MailboxAddress("", recipentEmail));
            message.Subject = messageSubject;

            var builder = new BodyBuilder();
            builder.TextBody = messageBody;
            message.Body = builder.ToMessageBody();

            return message;
        }

        public void SendMessage(Object state)
        {
            var message = (MimeMessage)state;
            try
            {
                var client = new SmtpClient();

                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("saintsender2.0@gmail.com", "atssddvndnffxggx");
                client.Send(message);
                client.Disconnect(true);

                Console.WriteLine("Send Mail Success.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Send Mail Failed : " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
