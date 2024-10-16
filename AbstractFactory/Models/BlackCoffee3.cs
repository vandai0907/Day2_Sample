using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class BlackCoffee3 : ICaffee
    {
        public string GetDrink() => "I get black coffee type 3";
    }
}
