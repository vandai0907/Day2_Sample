using Strategy.Interfaces;

namespace Strategy.Models
{
    internal class ContextStrategy
    {
        private IStrategy _strategy;

        public ContextStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int OnExecute(int a, int b) => _strategy.Execute(a, b);
    }
}
