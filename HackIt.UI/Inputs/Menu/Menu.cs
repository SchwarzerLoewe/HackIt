using ConsoleDraw.Inputs.Base;
using ConsoleDraw.Windows.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDraw.Inputs
{
    public class Menu : Input
    {
        private String Text = "";
        private ConsoleColor TextColor = ConsoleColor.Black;
        private ConsoleColor BackgroudColor = ConsoleColor.Gray;
        private ConsoleColor SelectedTextColor = ConsoleColor.White;
        private ConsoleColor SelectedBackgroundColor = ConsoleColor.DarkGray;

        private bool Selected = false;
        public List<MenuItem> MenuItems = new List<MenuItem>();
        public MenuDropdown MenuDropdown;

        public Menu(String text, int x, int y, String iD, Window parentWindow) : base(x, y, 1, text.Count() + 2, parentWindow, iD)
        {
            Text = text;
            Xpostion = x;
            Ypostion = y;

            Selectable = true;
        }

        public override void Draw()
        {
            if (Selected)
                WindowManager.WriteText('['+Text+']', Xpostion, Ypostion, SelectedTextColor, SelectedBackgroundColor);
            else
                WindowManager.WriteText('[' + Text + ']', Xpostion, Ypostion, TextColor, BackgroudColor);
        }

        public override void Select()
        {
            if (!Selected)
            {
                Selected = true;
                Draw();

                new MenuDropdown(Xpostion + 1, Ypostion, MenuItems, ParentWindow);

            }
        }

        public override void Unselect()
        {
            if (Selected)
            {
                Selected = false;
                Draw();
            }
        }

        public override void Enter()
        {
            MenuDropdown = new MenuDropdown(Xpostion + 1, Ypostion, MenuItems, ParentWindow);
        }

        public override void CursorMoveLeft()
        {
            ParentWindow.MoveToLastItem();
        }
        public override void CursorMoveRight()
        {
            ParentWindow.MoveToNextItem();
        }

        public override void CursorMoveDown()
        {
            MenuDropdown = new MenuDropdown(Xpostion + 1, Ypostion, MenuItems, ParentWindow);
        }
    }
}
