using HackIt.Core;
using UILibrary;
using System.Collections.Generic;
using HackIt.Pages;

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
                shell.Prompt = "< ";
                //GroupName = cmd.Args[1];

                while (mode)
                {
                    var cmds = await Shell.ReadLineAsync();
                    if (cmd.ToString() == "group end")
                    {
                        mode = false;
                        shell.Prompt = "> ";

                        Commands.RemoveAt(Commands.Count - 1);

                        ConsolePage.Commands.Add("cmd", Commands);
                        Commands = new List<Command>();
                        GroupName = "";

                        break;
                    }
                    else
                    {
                        Commands.Add(Command.Parse(cmds));
                    }
                }
            }
            else
            {
                foreach (var c in ConsolePage.Commands)
                {
                    if(c.Key == cmd.Name)
                    {

                    }
                }
            }
        }

        public bool ShowDialog()
        {
            return false;
        }
    }
}