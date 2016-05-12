using ConsoleDraw.Inputs;
using ConsoleDraw.Windows.Base;

namespace HackIt.Console.Windows
{
    public class MainWindow : FullWindow
    {
        public MainWindow(string mp) : base(0, 0, System.Console.WindowWidth, System.Console.WindowHeight, null)
        {
            this.BackgroundColor = System.ConsoleColor.Black;

            var lbl = new Label("MissionPack", 10, 10, "lbl", this);
            lbl.ForegroundColor = System.ConsoleColor.Red;

            lbl.SetText($"MissionPack {mp}");

            Inputs.Add(lbl);
        }
    }
}