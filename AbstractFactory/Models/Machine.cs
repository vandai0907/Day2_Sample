using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class Machine
    {
        ICaffee caffee;
        IOtherDrink OtherDrink;

        public Machine(ICoffeeShop coffeeShop)
        {
            caffee = coffeeShop.GetCaffee();
            OtherDrink = coffeeShop.GetOtherDrink();
        }

        public string? GetCaffee() => caffee?.GetDrink();
        public string? GetOtherDrink() => OtherDrink?.GetDrink();
    }
}
