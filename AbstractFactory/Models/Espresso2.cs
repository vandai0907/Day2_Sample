using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class Espresso2 : IOtherDrink
    {
        public string GetDrink() => "I order Espresso type 2";
    }
}
