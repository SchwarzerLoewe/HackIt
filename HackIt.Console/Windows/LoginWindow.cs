using ConsoleDraw.Inputs;
using ConsoleDraw.Windows.Base;
using System.Collections.Generic;

namespace HackIt.Console.Windows
{
    public class LoginWindow : PopupWindow
    {
        public LoginWindow(Window _backWindow) : base("Login", 10, (_backWindow.Width / 2) - 15, 25, 10, _backWindow)
        {
            var missionPackLabel = new Label("MissionPack", PostionX +2 , PostionY+2 , "mpLabel", this);
            BackgroundColor = System.ConsoleColor.Blue;

            var opts = new List<string>() { "test", "german" };
            var cb = new Dropdown(PostionX + 4, PostionY +4, opts, "cb", this);

            var btn = new Button(PostionX + 6, PostionY + 5, "OK", "okBtn", this);
            btn.Action += () =>
            {
                this.ExitWindow();
                _backWindow.ExitWindow();

                var mw = new MainWindow(cb.Text);
                mw.Show();
            };

            missionPackLabel.BackgroundColor = System.ConsoleColor.Blue;
            cb.BackgroundColor = System.ConsoleColor.Blue;

            Inputs.Add(missionPackLabel);
            Inputs.Add(cb);
            Inputs.Add(btn);

            ApplyButton = btn;

        }

        public LoginWindow(int postionX, int postionY, int width, int height, Window parentWindow) : base("", postionX, postionY, width, height, parentWindow)
        {
        }
    }
}