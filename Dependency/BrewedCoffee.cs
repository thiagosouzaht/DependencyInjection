using System;
using System.Collections.Generic;

namespace Coffee
{
    public class BrewedCoffe : ICoffee
    {
        public Guid Id;
        public string Recipe { get; set; }
        public void MakeCoffe()
        {
            this.Id = Guid.NewGuid();
            Console.Write($"Brewed Coffee Id: {this.Id} has been made");
        }
    }
}