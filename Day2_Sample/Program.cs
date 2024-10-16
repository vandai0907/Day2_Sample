using Day2_Sample.Interfaces;
using Day2_Sample.Services;

namespace Day2_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton

            IServerService service = new ServerServies();
            IServerService service1 = new ServerServies();
            while (true)
            {
                Console.WriteLine("1. Add\n" +
                                  "2. Down");
                var option = Console.ReadLine();
                if (option == "1")
                {
                    string server = Console.ReadLine();
                    if (service.AddServer(server))
                    {
                        Console.WriteLine("Success");
                    }
                    else
                    {

                    }
                }
                else if (option == "2")
                {
                    Console.WriteLine("1. http\n" +
                                      "2. https");
                    option = Console.ReadLine();
                    var lstServes = service.DownServers(option == "1" ? "http" : "https");
                    foreach (var lstServe in lstServes)
                    {
                        Console.WriteLine(lstServe);
                    }

                    var lstServes1 = service1.DownServers(option == "1" ? "http" : "https");
                    foreach (var lstServe in lstServes1)
                    {
                        Console.WriteLine(lstServe);
                    }
                }
            }
        }
    }
}
