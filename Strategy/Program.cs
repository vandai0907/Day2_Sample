using Strategy.Models;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1;
            ContextStrategy context = new ContextStrategy(new SumStrategy());
            Console.WriteLine(context.OnExecute(a, b));
        }
    }
}
