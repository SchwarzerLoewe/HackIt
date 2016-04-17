using HackIt.Core;
using UILibrary;
using System.Collections.Generic;

namespace HackIt.Tools.Commands
{
    public class GroupCommand : ITool
    {
        public string Name => "*";

        public List<Command> Commands { get; set; } = new List<Command>();
        public string GroupName { get; set; }

        public async void HandleConsole(ShellControl shell, Command cmd)
        {
            if (cmd.Name == "group")
            {
                var mode = true;
                shell.Prompt = "> \t";

                while (mode)
                {
                    var cmds = await Shell.ReadLineAsync();
                    if (cmd.Args[0] == "end")
                    {
                        mode = false;
                        shell.Prompt = "> ";
                        break;
                    }
                    else
                    {
                        //GroupName = cmd.Args[1];
                    }

                    Commands.Add(Command.Parse(cmds));
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