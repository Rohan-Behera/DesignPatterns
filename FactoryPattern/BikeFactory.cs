using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BikeFactory
    {

       public static Bike bikefactory(string type)
        {
            Bike obj = null;

            if(type.ToLower() == "yellow" ) 
            {
                obj = new Yellow();
            }else if(type.ToLower() == "blue")
            {
                obj = new Blue();

            }else if(type.ToLower() == "red")
            {
                obj = new Red();
            }
            else
            {
                obj = null;
            }

            return obj;
        }



    }
}
