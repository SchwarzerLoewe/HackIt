using HackIt.Core;
using System;
using System.Windows.Forms;
using TestApp;

namespace HackIt.Pages
{
    public partial class ConsolePage : UserControl
    {
        public ConsolePage()
        {
            InitializeComponent();

            Console.SetOut(new ShellWriter(shellControl1));
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
                Console.WriteLine(e.Command);
            }
        }
    }
}