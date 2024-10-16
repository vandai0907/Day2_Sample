using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class Type2Factory : ICoffeeShop
    {
        public ICaffee GetCaffee() => new BlackCoffee2();

        public IOtherDrink GetOtherDrink() => new Espresso2();
    }
}
