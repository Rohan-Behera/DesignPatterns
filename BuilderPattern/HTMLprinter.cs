using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class HTMLprinter : Printer
    {
        string header;
        string content;
        string footer;

        public HTMLprinter(string header,string content,string footer)
        {
            this.header = header;
            this.content = content;
            this.footer = footer;
        }

        public override void printContent()
        {
            Console.WriteLine("Print content " + content);
        }

        public override void printFooter()
        {

            Console.WriteLine("printfooter " + footer);

        }

        public override void printHeader()
        {
            Console.WriteLine("printHeader " + header);
        }

        public void getTempHTMLPath()
        {
            Console.WriteLine("This is the temp HTML Path");
        }
    }
}
