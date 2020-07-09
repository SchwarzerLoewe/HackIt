using Avalonia.Controls;
using Avalonia.Threading;
using HackIt.Core.Models;
using System;

namespace HackIt.Core
{
    public class IPFinder
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        private Computer _host;
        private TextBlock _label;

        public IPFinder(Computer host, TextBlock ipLabel)
        {
            _host = host;
            _label = ipLabel;
        }

        public void StartFinding()
        {
            var rndm = new Random();
            var pos = 0;
            string first = "?", second = "?", third = "?", fourth = "?";

            _timer.Interval = TimeSpan.FromMilliseconds(250);

            _timer.Tick += (s, e) =>
                {
                    var ip = string.Format("{0}.{1}.{2}.{3}", first, second, third, fourth);
                    _label.Text = string.Format("Suche nach IP: {0}", ip.ToString());
                    var i = rndm.Next(0, 255);

                    if(i.ToString() == _host.IP.ToString().Split('.')[pos])
                    {
                        pos++;
                    }

                    //if (ip.ToString().Split('.')[pos] == _host.IP.ToString().Split('.')[pos])
                    {

                        if (pos == 0) first = i.ToString();
                        if (pos == 1) second = i.ToString();
                        if (pos == 2) third = i.ToString();
                        if (pos == 3) fourth = i.ToString();

                    }
                };

            _timer.Start();
        }
    }
}