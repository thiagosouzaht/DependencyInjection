using System;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            var BrewedCoffe = new BrewedCoffe();
            var ExpressoCoffee = new ExpressoCoffe();
            var Cappuccino = new Cappuccino();
            
            var Human = new Human(ExpressoCoffee);
            IHosted
            Human.MakeCoffe();
        }
    }
}