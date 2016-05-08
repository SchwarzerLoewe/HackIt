using Calculator.Windows;
using HackIt.UI;

namespace HackIt.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowManager.UpdateWindow(27, 15);
            WindowManager.UpdateWindow(27, 15);
            WindowManager.SetWindowTitle("Calculator");

            new MainWindow();
        }
    }
}