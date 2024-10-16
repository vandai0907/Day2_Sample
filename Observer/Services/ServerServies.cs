using Day2_Sample.Interfaces;
using Day2_Sample.Models;

namespace Day2_Sample.Services
{
    public class ServerServies : IServerService
    {
        private List<string> _servers;

        public ServerServies()
        {
            _servers = Servers.GetIntance();
        }
        public bool AddServer(string servers)
        {
            if (servers.Split(':')[0] == "http" || servers.Split(':')[0] == "https")
            {
                if (!_servers.Any(s => s.ToString() == servers))
                {
                    _servers.Add(servers);
                    return true;
                }

            }
            return false;

        }

        public List<string> DownServers(string url)
        {
            return _servers.Where(s => s.Split(':')[0] == url).ToList();
        }
    }
}
