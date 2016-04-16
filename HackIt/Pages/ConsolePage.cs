using HackIt.Core;
using HackIt.Tools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestApp;

namespace HackIt.Pages
{
    public partial class ConsolePage : UserControl
    {
        public List<ITool> Tools { get; set; } = new List<ITool>();

        public ConsolePage()
        {
            InitializeComponent();

            Console.SetOut(new ShellWriter(shellControl1));

            Tools.Add(new HelpCommand());
        }

        private void shellControl1_CommandEntered(object sender, UILibrary.CommandEnteredEventArgs e)
        {
            if(e.Command == "save")
            {
                var sg = ServiceLocator.Get<SavedGame>("SavedGame");
                sg.Save();
                Console.WriteLine("Saved Successfull");
            }
            else
            {
                var cmd = Command.Parse(e.Command);

                foreach (var t in Tools)
                {
                    if(cmd.Name == t.Name)
                    {
                        t.HandleConsole(shellControl1, cmd);
                    }
                }
            }
        }
    }
}