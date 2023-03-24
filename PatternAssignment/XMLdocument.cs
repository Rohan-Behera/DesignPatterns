using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAssignment
{
     class XMLdocument : Document
    {
        

        protected override void printBody()
        {
            Console.WriteLine("This is the body of the XML document");
        }

        protected override void printHeader()
        {
            Console.WriteLine("This is the Header of the XML DOcument");
        }

        protected override void printFooter()
        {
            Console.WriteLine("this is the Footer of the XML document");
        }

    }
}
