using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAssignment
{
    abstract class Document
    {
        public void print()
        {
            printBody();
            printHeader();
            printFooter();
        }
        protected abstract void printBody();
        protected abstract void printHeader();
        protected abstract void printFooter();


    }
}
