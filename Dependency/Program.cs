using System;
using Coffee;

namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            var brewedCoffe = new BrewedCoffe();
            var cappuccino = new Cappuccino();
            var Expresso = new ExpressoCoffe();
            
            var human = new Human(brewedCoffe);
        }
    }
}