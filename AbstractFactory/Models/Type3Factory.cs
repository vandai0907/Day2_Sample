using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class Type3Factory : ICoffeeShop
    {
        public ICaffee GetCaffee() => new BlackCoffee3();

        public IOtherDrink GetOtherDrink() => null;
    }
}
