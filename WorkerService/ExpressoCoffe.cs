using System;

namespace Coffee
{
    public class ExpressoCoffe : ICoffee
    {
        public Guid Id { get; set; }
        
        private string MachineName = "Máquina de Café Expresso Manual Delonghi EC220 CD -110V";
        public void MakeCoffe()
        {
            this.Id = Guid.NewGuid();  
            Console.Write($"You have been made an Expresso Coffee id {this.Id} on Machine {MachineName}");
        }
    }
}