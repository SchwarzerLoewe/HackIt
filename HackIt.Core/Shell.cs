﻿using System.Drawing;
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

        public static void Write(object obj)
        {
            _shell.WriteText(obj.ToString());
        }

        public static void WriteLine(object obj)
        {
            _shell.WriteText(obj.ToString() + "\r");
        }

        public static Task<string> ReadLineAsync()
        {
            EventCommandEntered handler = null;
            string value = null;
            var tcs = new TaskCompletionSource<string>();
            string prompt = _shell.Prompt;

            _shell.Prompt = "";

            handler = new EventCommandEntered((s, e) =>
            {
                value = e.Command;
                tcs.SetResult(value);

                _shell.Prompt = prompt;
                _shell.CommandEntered -= handler;
            });

            _shell.CommandEntered += handler;

            return tcs.Task;
        }
    }
}