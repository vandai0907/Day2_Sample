using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class Espresso : IOtherDrink
    {
        public string GetDrink() => "I order Espresso";
    }
}
