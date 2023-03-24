using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Samsung : MobileShop
    {
        public Samsung()
        {
            modelNo();
            price();

        }
        public void modelNo()
        {
            Console.WriteLine("This is Samsung Galaxy S23 Ultra");
        }

        public void price()
        {
            Console.WriteLine("Price : Rs. 90,000/-");
        }
    }
}
