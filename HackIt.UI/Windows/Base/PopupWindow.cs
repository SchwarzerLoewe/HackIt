using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDraw.Windows.Base
{
    public class PopupWindow : Window
    {
        protected String Title;

        protected ConsoleColor TitleBarColor = ConsoleColor.DarkGray;
        protected ConsoleColor TitleColor = ConsoleColor.Black;

        public PopupWindow(String title, int postionX, int postionY, int width, int height, Window parentWindow)
            : base(postionX, postionY, width, height, parentWindow)
        {
            Title = title;
        }

        public override void ReDraw()
        {
            WindowManager.DrawColorBlock(TitleBarColor, PostionX, PostionY, PostionX + 1, PostionY + Width); //Title Bar
            WindowManager.WriteText(' ' + Title + ' ', PostionX, PostionY + 2, TitleColor, BackgroundColor);

            WindowManager.DrawColorBlock(BackgroundColor, PostionX + 1, PostionY, PostionX + Height, PostionY + Width); //Main Box
        }

    }
}
