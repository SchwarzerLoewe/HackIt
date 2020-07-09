using System.Collections.Generic;

namespace HackIt.Core
{
    public class CustomCommand
    {
        public string Name { get; set; }
        public List<Command> Commands { get; set; } = new List<Command>();
    }
}