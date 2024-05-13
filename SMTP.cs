using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class SMTP
    {
        IMailConstructor mailConstructor;
        public SMTP(IMailConstructor mailConstructor)
        {
            this.mailConstructor = mailConstructor;
        }
        public void SendNoReplyMail()
        {
            Mail mail = mailConstructor.AddSubject("No Reply").AddContent("Hello World").Construct();

            Console.WriteLine("Sending email...");
            Console.WriteLine($"To: {mail.Recipient}");
            Console.WriteLine($"Subject: {mail.Subject}");
            Console.WriteLine($"Content: {mail.Content}");
            Console.WriteLine("Email sent successfully!");
        }
    }
    }
