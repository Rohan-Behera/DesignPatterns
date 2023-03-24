using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public  class Shopkeerper
    {
        private MobileShop iphone;
        private MobileShop samsung;
        private MobileShop blackerry;


       public Shopkeerper()
        {
            iphoneSale();
            samsungSale();
            blackerrySale();
        }

        public void iphoneSale()
        {
            iphone = new Iphone();
        }
        public void samsungSale()
        {
            samsung = new Samsung();
        }

        public void blackerrySale()
        {
            blackerry = new Blackberry();
        }
    }
}
