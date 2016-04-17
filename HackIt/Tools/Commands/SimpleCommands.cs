using HackIt.Core;
using UILibrary;

namespace HackIt.Tools.Commands
{
    public class SimpleCommands : ITool
    {
        public string Name => "*";

        public void HandleConsole(ShellControl shell, Command cmd)
        {
            switch (cmd.Name)
            {
                case "help":
                    Shell.WriteLine("Here some Helps:");

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
            }
        }

        public bool ShowDialog() => false;
    }
}