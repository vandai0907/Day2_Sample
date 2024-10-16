namespace Day2_Sample.Interfaces
{
    internal interface IServerService
    {
        public bool AddServer(string servers);
        public List<string> DownServers(string url);
    }
}
