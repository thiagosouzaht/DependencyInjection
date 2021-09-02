using System;

namespace Coffee
{
    public class Cappuccino : ICoffee
    {
        public Guid Id { get; set; }

        public string Recipe = @$"    400 g de leite em pó integral
                                        230 g de açúcar
                                        50 g de café solúvel
                                        5 colheres (sopa) de chocolate em pó
                                        1 colher (sopa) bicarbonato de sódio
                                        1 colher (chá) de canela em pó";
        public void MakeCoffe()
        {
            this.Id = Guid.NewGuid();
            Console.WriteLine($"You have been made a Cappuccino coffee Id {Id} with this recipe: {Recipe}");
        }
    }
}