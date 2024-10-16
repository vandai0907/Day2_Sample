using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Type 1\n2. Type 2\n3. Type 3");
                ICoffeeShop shop = null;
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        shop = new Type1Factory();
                        break;
                    case "2":
                        shop = new Type2Factory();
                        break;
                    case "3":
                        shop = new Type3Factory();
                        break;
                    default:
                        continue;
                }
                Machine machine = new Machine(shop);
                Console.WriteLine("1. Coffee\n2. Other Drink");
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine(machine.GetCaffee());
                }
                else if (option == "2")
                {
                    Console.WriteLine(machine.GetOtherDrink());
                }
            }
        }
    }
}
