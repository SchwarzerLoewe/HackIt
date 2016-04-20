using HackIt.Core;
using UILibrary;
using System.Collections.Generic;
using HackIt.Pages;
using System;
using System.Linq;

namespace HackIt.Tools.Commands
{
    public class GroupCommand : ITool
    {
        public string Name { get; set; } = "group";
        public string HelpText => "group <groupname>|end";

        public GroupCommand()
        {
            
        }

        public List<Command> Commands { get; set; } = new List<Command>();
        public string GroupName { get; set; }
        public bool UseRegex { get; set; } = true;

        public async void HandleConsole(ShellControl shell, Command cmd)
        {
            // group <name>
            if (cmd.Name == "group")
            {
                ConsolePage.GroupTool = this;

                var mode = true;
                shell.Prompt = "< ";
                if (cmd.Args[0] != "end")
                {
                    GroupName = cmd.Args[0];
                }

                ConsolePage.IsRecognizing = true;

                while (mode)
                {
                    if (cmd.Args[0] == "end")
                    {
                        if(ConsolePage.Commands.ContainsKey(GroupName))
                        {
                            Shell.WriteLine("Group already exists, sorry");
                            break;
                        }
                        mode = false;
                        shell.Prompt = "> ";
                        ConsolePage.IsRecognizing = false;

                        ConsolePage.Commands.Add(GroupName, Commands.ToArray().ToList());
                        var mp = ServiceLocator.Get<SavedGame>("SavedGame");
                        mp.Commands.Add(GroupName, Commands.ToArray().ToList());

                        Commands.Clear();
                        GroupName = "";

                        break;
                    }
                    else if (cmd.Args[0] == "delete")
                    {

                    }
                    else
                    {
                        var cmds = await Shell.ReadLineAsync();
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
                        foreach (var v in c.Value)
                        {
                            foreach (var tool in ConsolePage.Tools)
                            {
                                tool.HandleConsole(shell, v);
                            }
                        }
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