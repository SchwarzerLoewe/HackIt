using HackIt.Core;
using System.Drawing;
using System.Windows.Forms;
using UILibrary;
using System;
using HackIt.Pages;

namespace HackIt.Tools.Commands
{
    public class SimpleCommands : ITool
    {
        public string HelpText => "";

        public string Name { get; set; } = "*";
        public bool UseRegex { get; set; } = false;

        public void HandleConsole(ShellControl shell, Command cmd)
        {
            switch (cmd.Name)
            {
                case "help":
                    Shell.WriteLine("Here some Helps:");
                    foreach (var c in ConsolePage.Tools)
                    {
                        Shell.WriteLine(c.HelpText);
                    }

                    break;
                case "save":
                    var sg = ServiceLocator.Get<SavedGame>("SavedGame");
                    sg.Save();

                    Shell.WriteLine("Successfully saved");

                    break;
                case "echo":
                    Shell.WriteLine(cmd.Args[0]);

                    break;
                case "cls":
                    Shell.Clear();

                    break;
                case "shutdown":
                    Application.Exit();

                    break;
                case "color":
                    var back = (Color)new ColorConverter().ConvertFromString(cmd.Args[0]);
                    var fore = (Color)new ColorConverter().ConvertFromString(cmd.Args[1]);

                    Shell.BackColor = back;
                    Shell.ForeColor = fore;

                    break;
            }
        }

        public bool ShowDialog() => false;
    }
}