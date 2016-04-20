using HackIt;
using System;
using System.Windows.Forms;

namespace MissionBuilder
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mpd = new MissionPackSelector();
            if (mpd.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}