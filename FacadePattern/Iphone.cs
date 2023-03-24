using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Iphone : MobileShop
    {

        public Iphone()
        {
            modelNo();
            price();

        }
        public void modelNo()
        {
            Console.WriteLine("This is Iphone 14 Pro Max");
        }

        public void price()
        {
            Console.WriteLine("Price : Rs.1,50,000/- ");
        }
    }
}
