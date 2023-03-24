using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAssignment
{
     class HTMLdocumnet : Document
    {
        protected override void printBody()
        {
            Console.WriteLine("This is the body of the HTML document");
        }

        protected override void printHeader()
        {
            Console.WriteLine("This is the Header of the HTML DOcument");
        }

        protected override void printFooter()
        {
            Console.WriteLine("this is the Footer of the HTML document");
        }
    }
}
