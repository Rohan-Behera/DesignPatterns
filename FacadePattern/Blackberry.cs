using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
     class Blackberry : MobileShop
    {
        public Blackberry()
        {
            modelNo();
            price();
            
        }
        public void modelNo()
        {
            Console.WriteLine("This is Blackberry bolt");
        }

        public void price()
        {
            Console.WriteLine("Price : Rs.25,000/-");
        }

        
    }
}
