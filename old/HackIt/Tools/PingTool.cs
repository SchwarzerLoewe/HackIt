using HackIt.Core;
using HackIt.Tools.Dialogs;
using System;
using UILibrary;

namespace HackIt.Tools
{
    public class PingCommand : ITool
    {
        public string Name { get; set; } = "ping";
        public bool UseRegex { get; set; } = false;

        public string HelpText => "ping <ip>";

        public void HandleConsole(ShellControl shell, Command cmd)
        {
            
        }

        public bool ShowDialog()
        {
            var di = new PingDialog();
            if(di.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                return true;
            }

            return false;
        }
    }
}