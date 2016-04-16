using HackIt.Core.Models;
using System;
using System.Net;
using System.Windows.Forms;

namespace HackIt.Core
{
    public class IPFinder
    {
        private Timer _timer = new Timer();
        private Computer _host;
        private Label _label;

        public IPFinder(Computer host, Label ipLabel)
        {
            _host = host;
            _label = ipLabel;
        }

        public void StartFinding()
        {
            var rndm = new Random();
            var pos = 0;
            string first = "?", second = "?", third = "?", fourth = "?";

            _timer.Interval = 250;

            string tmp = "";

            _timer.Tick += (s, e) =>
                {
                    var ip = string.Format("{0}.{1}.{2}.{3}", first, second, third, fourth);
                    _label.Text = string.Format("Suche nach IP: {0}", ip.ToString());
                    var i = rndm.Next(0, 9);
                    int innerpos = 0; ;

                    tmp = i.ToString();

                    if(i == _host.IP.ToString().Split('.')[pos].ToCharArray()[innerpos])
                    {
                        innerpos++;
                        pos++;
                        tmp = "";

                        if (innerpos == 0) first = tmp;
                        if (innerpos == 1) second = tmp;
                        if (innerpos == 2) third = tmp;

                    }
                    if(tmp == _host.IP.ToString().Split('.')[pos])
                    {
                        pos++;
                        tmp = "";
                    }

                    //if (ip.ToString().Split('.')[pos] == _host.IP.ToString().Split('.')[pos])
                    {

                        if (pos == 0) first = tmp;
                        if (pos == 1) second = tmp;
                        if (pos == 2) third = tmp;
                        if (pos == 3) fourth = tmp;

                    }
                };

            _timer.Start();
        }
    }
}