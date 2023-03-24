using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
     class ReportPrinter
    {

        string header;
        string content;
        string footer;


        public ReportPrinter setHeader(string header)
        {
            this.header = header;
            return this;
        }

        public ReportPrinter setContent(string content)
        {
            this.content = content;
            return this;
        }

        public ReportPrinter setFooter(string footer) 
        {
            this.footer = footer;   
            return this;
        }


        public HTMLprinter HTMLbuild()
        {
            return new HTMLprinter(header,content,footer);
        }

        public RTFP RTFPbuild()
        {
            return new RTFP(header,content,footer);
        }

        public PDFprinter PDFbuild()
        {
            return new PDFprinter(header,content,footer);
        }

    }
}
