using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class BlackCoffee : ICaffee
    {
        public string GetDrink() => "I order black coffee";
    }
}
