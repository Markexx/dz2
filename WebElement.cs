using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2___2._zadatak
{
    public class WebElement
    {
        string name;
        public WebElement(string name)
        {
            Console.WriteLine($"Found {name}");
            this.name = name;
        }
        public void Click()
        {
            Console.WriteLine($"Clicked {name}");
        }
    }
}
