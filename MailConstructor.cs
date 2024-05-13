using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    internal class MailConstructor : IMailConstructor
    {
        Mail mail;
        public MailConstructor()
        {
            mail = new Mail();
        }

        public IMailConstructor AddSubject(string subject)
        {
            mail.Subject = subject;
            return this;
        }

        public IMailConstructor AddContent(string content)
        {
            mail.Content = content;
            return this;
        }

        public IMailConstructor AddRecipient(string recipient)
        {
            mail.Recipient = recipient;
            return this;
        }

        public Mail Construct()
        {
            return mail;
        }
    }
}
