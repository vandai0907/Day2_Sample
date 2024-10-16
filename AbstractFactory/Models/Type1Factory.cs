using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class Type1Factory : ICoffeeShop
    {
        public ICaffee GetCaffee() => new BlackCoffee();

        public IOtherDrink GetOtherDrink() => new Espresso();
    }
}
