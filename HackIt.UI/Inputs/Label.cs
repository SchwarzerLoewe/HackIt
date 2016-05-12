using ConsoleDraw.Inputs.Base;
using ConsoleDraw.Windows.Base;
using System;
using System.Linq;

namespace ConsoleDraw.Inputs
{
    public class Label : Input
    {
        private String Text = "";
        public ConsoleColor ForegroundColor = ConsoleColor.Black;
        public ConsoleColor BackgroundColor = ConsoleColor.Gray;

        public Label(String text, int x, int y, String iD, Window parentWindow) : base(x, y, 1, text.Count(), parentWindow, iD)
        {
            Text = text;
            BackgroundColor = parentWindow.BackgroundColor;
            Selectable = false;
        }

        public override void Draw()
        {
            WindowManager.WriteText(Text, Xpostion, Ypostion, ForegroundColor, BackgroundColor);
        }

        public void SetText(String text)
        {
            Text = text;
            Width = text.Count();
            Draw();
        }
       
    }
}
