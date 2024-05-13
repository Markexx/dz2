using dz2;

public class Program
{
    static void Main(string[] args)
    {
        IMailConstructor mailConstructor = new MailConstructor();

        Mail mail = mailConstructor
            .AddSubject("Test Subject")
            .AddContent("This is the content of the email.")
            .Construct();

        SMTP smtp = new SMTP(mailConstructor);
        smtp.SendNoReplyMail();
    }
}


