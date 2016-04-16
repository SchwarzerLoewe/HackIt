using System.Net;

namespace HackIt.Core.Models
{
    public class Computer
    {
        public string Name { get; set; } = "Localhost";
        public IPAddress IP { get; set; }

        public FileSystem FileSystem { get; set; } = new FileSystem();
    }
}