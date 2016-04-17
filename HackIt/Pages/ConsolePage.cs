using HackIt.Core;
using HackIt.Tools.Commands;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HackIt.Pages
{
    public partial class ConsolePage : UserControl, INavigatable
    {
        public List<ITool> Tools { get; set; } = new List<ITool>();

        public string Title => "Konsole";

        public ConsolePage()
        {
            InitializeComponent();

            Shell.Init(shellControl1);

            Tools.Add(new SimpleCommands());
            Tools.Add(new GroupCommand());
        }

        private void shellControl1_CommandEntered(object sender, UILibrary.CommandEnteredEventArgs e)
        {
            var cmd = Command.Parse(e.Command);

            foreach (var t in Tools)
            {
                if (cmd.Name == t.Name)
                {
                    t.HandleConsole(shellControl1, cmd);
                }
                else if(t.Name == "*")
                {
                    t.HandleConsole(shellControl1, cmd);
                }
            }
        }

        public void OnNavigate()
        {
            shellControl1.Focus();
        }
    }
}