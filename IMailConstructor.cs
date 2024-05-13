using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public interface IMailConstructor
    {
        IMailConstructor AddSubject(string subject);
        IMailConstructor AddContent(string content);
        Mail Construct();
    }
}
