using Observer.Interfaces;

namespace Observer.Models
{
    internal class Subject : ISubject
    {
        private int Number = 0;
        public void OnUpdate(int number)
        {
            Console.WriteLine("Subject: Notifying observers...");
            if (Number > number)
            {
                Console.WriteLine("Lower");
            }
            else if (Number < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Equal");
            }
            Number = number;
        }
    }
}
