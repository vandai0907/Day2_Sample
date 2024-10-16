using Strategy.Interfaces;

namespace Strategy.Models
{
    internal class SubStrategy : IStrategy
    {
        public int Execute(int a, int b) => a - b;
    }
}
