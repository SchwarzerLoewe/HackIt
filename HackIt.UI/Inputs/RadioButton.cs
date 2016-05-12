using ConsoleDraw.Inputs.Base;
using ConsoleDraw.Windows.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDraw.Inputs
{
    public class RadioButton : Input
    {
        public ConsoleColor BackgroundColor = ConsoleColor.Gray;
        private ConsoleColor TextColor = ConsoleColor.Black;

        private ConsoleColor SelectedBackgroundColor = ConsoleColor.DarkGray;
        private ConsoleColor SelectedTextColor = ConsoleColor.White;

        private bool Selected = false;
        public bool Checked = false;
        public String RadioGroup;

        public Action Action;

        public RadioButton(int x, int y, String iD, String radioGroup, Window parentWindow) : base(x, y, 1, 3, parentWindow, iD)
        {
            RadioGroup = radioGroup;
            BackgroundColor = parentWindow.BackgroundColor;
            Selectable = true;
        }

        public override void Select()
        {
            if (!Selected)
            {
                Selected = true;
                Draw();
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
            if (Checked) //Already checked, no need to change
                return;

            //Uncheck all other Radio Buttons in the group
            ParentWindow.Inputs.OfType<RadioButton>().Where(x => x.RadioGroup == RadioGroup).ToList().ForEach(x => x.Uncheck());

            Checked = true;

            Draw();

            Action?.Invoke();
        }

        public void Uncheck()
        {
            if (!Checked) //Already unchecked, no need to change
                return;

            Checked = false;
            Draw();
        }

        public override void Draw()
        {
            String Char = Checked ? "■" : " ";

            if(Selected)
                WindowManager.WriteText('[' + Char + ']', Xpostion, Ypostion, SelectedTextColor, SelectedBackgroundColor);
            else
                WindowManager.WriteText('[' + Char + ']', Xpostion, Ypostion, TextColor, BackgroundColor);  
        }

        public override void CursorMoveDown()
        {
            ParentWindow.MovetoNextItemDown(Xpostion + 1, Ypostion, Width);
        }

        public override void CursorMoveRight()
        {
            ParentWindow.MovetoNextItemRight(Xpostion - 1, Ypostion + Width, 3);

        }

        public override void CursorMoveLeft()
        {
            ParentWindow.MovetoNextItemLeft(Xpostion - 1, Ypostion, 3);
        }

        public override void CursorMoveUp()
        {
            ParentWindow.MovetoNextItemUp(Xpostion - 1, Ypostion, Width);
        }
    }
}
