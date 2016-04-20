using HackIt.Core;
using System;
using System.Windows.Forms;

namespace HackIt
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mps = new MissionPackSelector();
            if(mps.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}