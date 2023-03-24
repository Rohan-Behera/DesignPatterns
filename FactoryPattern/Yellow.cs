using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Yellow : Bike
    {

        public override void createEngine()
        {
            Console.WriteLine("This is the Engine of the Yellow bike");
        }

        public override void createChassis()
        {
            Console.WriteLine("The chassis color is Yellow");
        }
    }
}
