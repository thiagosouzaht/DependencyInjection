namespace Coffee
{
    public class Human
    {
        public ICoffee Coffee { get; set; }
        
        public Human(ICoffee coffee)
        {
            this.Coffee = coffee;
        }
        public void MakeCoffe()
        {
            this.Coffee.MakeCoffe();
        }
    }
}