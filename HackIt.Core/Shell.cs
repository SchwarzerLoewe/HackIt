using System.Drawing;
using System.Threading.Tasks;
using UILibrary;

namespace HackIt.Core
{
    public static class Shell
    {
        public static Color ForeColor
        {
            get { return _shell.ShellTextForeColor; }
            set { _shell.ShellTextForeColor = value; }
        }

        public static Color BackColor
        {
            get { return _shell.ShellTextBackColor; }
            set { _shell.ShellTextBackColor = value; }
        }

        public static Font Font
        {
            get { return _shell.ShellTextFont; }
            set { _shell.ShellTextFont = value; }
        }

        private static ShellControl _shell;

        public static void Init(ShellControl shell)
        {
            _shell = shell;
        }

        public static void WriteLine(object obj)
        {
            _shell.WriteText(obj.ToString() + "\r\n");
        }

        public static Task<string> ReadLineAsync()
        {
            EventCommandEntered handler = null;
            string value = null;
            var tcs = new TaskCompletionSource<string>();

            handler = new EventCommandEntered((s, e) =>
            {
                value = e.Command;
                tcs.SetResult(value);

                _shell.CommandEntered -= handler;
            });

            _shell.CommandEntered += handler;

            return tcs.Task;
        }

        public static void Clear()
        {
            _shell.Clear();
        }
    }
}