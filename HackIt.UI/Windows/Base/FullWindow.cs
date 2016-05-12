using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDraw.Windows.Base
{
    public class FullWindow : Window
    {
        

        public FullWindow(int postionX, int postionY, int width, int height, Window parentWindow)
            : base(postionX, postionY, width, height, parentWindow)
        {
            BackgroundColor = ConsoleColor.Gray;
        }

        public override void ReDraw()
        {
            WindowManager.DrawColorBlock(BackgroundColor, PostionX, PostionY, PostionX + Height, PostionY + Width); //Main Box
        }

    }
}
