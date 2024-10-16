using Strategy.Interfaces;

namespace Strategy.Models
{
    internal class SumStrategy : IStrategy
    {
        public int Execute(int a, int b) => a + b;
    }
}
