using HackIt.Core;
using HackIt.Tools.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HackIt.Pages
{
    public partial class ConsolePage : UserControl, INavigatable
    {
        public static List<ITool> Tools { get; set; } = new List<ITool>();
        public static Dictionary<string, List<Command>> Commands = new Dictionary<string, List<Command>>();
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
            var cmd = Command.Parse(e.Command);
            if (IsRecognizing)
            {
                GroupTool.HandleConsole(shellControl1, cmd);
            }
            else
            {
                foreach (var x in Commands.ToArray())
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
                        }
                        else if (t.Name.Contains("*"))
                        {
                            t.HandleConsole(shellControl1, cmd);
                        }
                    }
                    else
                    {
                        if (cmd.Name == t.Name)
                        {
                            t.HandleConsole(shellControl1, cmd);
                        }
                        else if (t.Name == "*")
                        {
                            t.HandleConsole(shellControl1, cmd);
                        }
                    }
                }
            }
        }

        public void OnNavigate()
        {
            shellControl1.Focus();
        }
    }
}