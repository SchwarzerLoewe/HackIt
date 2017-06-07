using HackIt.Core;
using HackIt.Tools.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HackIt.Tools.Dialogs;

namespace HackIt.Pages
{
    public partial class ConsolePage : UserControl, INavigatable
    {
        public static List<ITool> Tools { get; set; } = new List<ITool>();
        public static bool IsRecognizing { get; set; }
        public static ITool GroupTool { get; set; }

        public string Title => "Console";

        public ConsolePage()
        {
            InitializeComponent();

            Shell.Init(shellControl1);

            Tools.Add(new GroupCommand());
            Tools.Add(new SimpleCommands());

        }

        private void shellControl1_CommandEntered(object sender, UILibrary.CommandEnteredEventArgs e)
        {
            var sg = ServiceLocator.Get<SavedGame>("SavedGame");
            var cmd = Command.Parse(e.Command);
            bool found = false;

            if (IsRecognizing)
            {
                GroupTool.HandleConsole(shellControl1, cmd);
            }
            else
            {
                foreach (var x in sg.Commands.ToArray())
                {
                    if (x.Key == cmd.Name)
                    {
                        foreach (var cm in x.Value)
                        {
                            foreach (var t in Tools)
                            {
                                if (cm.Name == t.Name || t.Name == "*")
                                {
                                    t.HandleConsole(shellControl1, cm);
                                    found = true;
                                }
                            }
                        }
                    }
                }
                foreach (var t in Tools)
                {
                    if (t.UseRegex)
                    {
                        if (Regex.IsMatch(cmd.Name, t.Name))
                        {
                            t.HandleConsole(shellControl1, cmd);
                            found = true;
                        }
                        else if (t.Name.Contains("*"))
                        {
                            t.HandleConsole(shellControl1, cmd);
                            found = true;
                        }
                    }
                    else
                    {
                        if (cmd.Name == t.Name)
                        {
                            t.HandleConsole(shellControl1, cmd);
                            found = true;
                        }
                        else if (t.Name == "*")
                        {
                            t.HandleConsole(shellControl1, cmd);
                            found = true;
                        }
                    }
                }
            }

            if(!found)
            {
                Shell.WriteLine("Command not found. Please type 'help' for a List of Commands!");
            }
        }

        public void OnNavigate()
        {
            shellControl1.Focus();
        }

        private void downloadFileButton_Click(object sender, System.EventArgs e)
        {
            var dlg = new DownloadDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var dlg = new PingDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //
            }
        }
    }
}