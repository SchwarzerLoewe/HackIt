using System;
using System.Threading;

namespace HackIt.UI
{
    public static class TitleProgress
    {
        private static bool _started = false;

        public static void Start()
        {
            var old = Console.Title;

            const int maxProgressBarLength = 10;
            const string progressBarElement = "█";

            var title = "";

            do
            {
                title += progressBarElement;

                if (title.Length > maxProgressBarLength)
                {
                    title = progressBarElement;
                }

                Console.Title = title;

                Thread.Sleep(100);
            } while (_started);
        }

        public static void Stop()
        {
            _started = false;
        }
    }
}