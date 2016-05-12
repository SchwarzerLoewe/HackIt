using ConsoleDraw;
using ConsoleDraw.Windows.Base;
using HackIt.Console.Windows;

namespace HackIt.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowManager.UpdateWindow(100, 43);

            WindowManager.SetWindowTitle("HackIt");

            var lw = new LoginWindow(new FullWindow(0, 0, 100, 43, null) { BackgroundColor = System.ConsoleColor.Black });
            lw.Show();
        }
    }
}