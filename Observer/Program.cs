using Observer.Interfaces;
using Observer.Models;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();
            while (true)
            {
                var input = Console.ReadLine();
                int.TryParse(input, out var value);
                subject.OnUpdate(value);
            }
        }
    }
}
