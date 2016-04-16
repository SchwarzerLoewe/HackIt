using System;
using HackIt.Core;
using UILibrary;

namespace HackIt.Tools
{
    public class HelpCommand : ITool
    {
        public string Name => "help";

        public void HandleConsole(ShellControl shell, Command cmd)
        {
            Console.WriteLine("This is a help");
        }

        public bool ShowDialog() => false;
    }
}