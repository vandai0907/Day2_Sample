using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class BlackCoffee2 : ICaffee
    {
        public string GetDrink() => "I order black coffee type 2";
    }
}
