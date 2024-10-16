namespace Day2_Sample.Models
{
    public class Servers
    {
        public static List<string> Instance;

        private Servers()
        {
        }

        public static List<string> GetIntance()
        {
            if (Instance == null) return Instance = new List<string>();
            return Instance;
        }
    }
}
