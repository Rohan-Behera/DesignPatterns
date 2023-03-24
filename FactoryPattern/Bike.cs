using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Bike
    {
        public abstract void createEngine();
        public abstract void createChassis();

    }
}
