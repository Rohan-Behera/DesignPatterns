namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bike bike = BikeFactory.bikefactory("yellow");

            bike.createEngine();
            bike.createChassis();
            
           
        }
    }
}