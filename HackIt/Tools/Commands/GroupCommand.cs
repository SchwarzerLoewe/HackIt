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
                    if (cmd.ToString().Trim() == "group end")
                    {
                        mode = false;
                        shell.Prompt = "> ";
                        ConsolePage.IsRecognizing = false;

                        ConsolePage.Commands.Add(GroupName, Commands.ToArray().ToList());
                        //Name += "|" + GroupName;

                        Commands.Clear();
                        GroupName = "";

                        break;
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