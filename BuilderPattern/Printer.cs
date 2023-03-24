using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    abstract class Printer
    {
        public abstract void printHeader();
        public abstract void printContent();

        public abstract void printFooter();


    }
}
