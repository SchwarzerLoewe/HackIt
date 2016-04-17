using HackIt.Core;
using UILibrary;
using System.Collections.Generic;

namespace HackIt.Tools.Commands
{
    public class GroupCommand : ITool
    {
        public string Name => "*";

        public List<Command> Internals { get; set; } = new List<Command>();
        public string GroupName { get; set; }

        public Dictionary<string, List<Command>> Commands { get; set; }

        public async void HandleConsole(ShellControl shell, Command cmd)
        {
            if (cmd.Name == "group")
            {
                GroupName = cmd.Args[1];

                var mode = true;
                while (mode)
                {
                    var cmds = await Shell.ReadLineAsync();
                    if (cmd.Args[0] == "end")
                    {
                        Commands.Add(GroupName, Internals);

                        GroupName = "";
                        Internals = new List<Command>();

                        mode = false;
                        break;
                    }
                    else
                    {
                        Internals.Add(Command.Parse(cmds));
                    }
                }
            }
            else
            {
                
            }
        }

        public bool ShowDialog()
        {
            return false;
        }
    }
}