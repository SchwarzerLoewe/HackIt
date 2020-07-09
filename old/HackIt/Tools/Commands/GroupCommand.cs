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

        public List<Command> Commands { get; set; } = new List<Command>();
        public string GroupName { get; set; }
        public bool UseRegex { get; set; } = true;
        public List<string> Args { get; set; } = new List<string>();

        public async void HandleConsole(ShellControl shell, Command cmd)
        {
            var sg = ServiceLocator.Get<SavedGame>("SavedGame");
            if (cmd.Name == "group")
            {
                ConsolePage.GroupTool = this;

                if(cmd.Args[0] == "delete")
                {
                    sg.Commands.Remove(cmd.Args[1]);
                    return;
                }

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
                        if(sg.Commands.ContainsKey(GroupName))
                        {
                            Shell.WriteLine("Group already exists, sorry");
                            break;
                        }

                        mode = false;
                        shell.Prompt = "> ";
                        ConsolePage.IsRecognizing = false;

                        sg.Commands.Add(GroupName, Commands.ToArray().ToList());

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
                foreach (var c in sg.Commands)
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

        public bool ShowDialog() => false;
    }
}